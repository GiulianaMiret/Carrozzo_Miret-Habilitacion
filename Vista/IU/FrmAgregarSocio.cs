using Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vista.Core.Models;

namespace Vista.IU
{
    public partial class FrmAgregarSocio : Form
    {
        private readonly Fachada cFachada;
        private readonly Vista.Logger.ILogger cLogger;

        public FrmAgregarSocio(Fachada pFachada, Logger.ILogger pLogger)
        {
            cFachada = pFachada;
            cLogger = pLogger;
            InitializeComponent();
        }

        private void FrmAgregarSocio_Load(object sender, EventArgs e)
        {
            cbNacionalidad.SelectedIndex = 0;
            tbNroSocio.Text = cFachada.getNextNroSocio().ToString();
            dtFechaIngreso.Value = DateTime.Today;
        }

        private void numericFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void letterFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                int nroSocio;
                if (tbNroSocio.Text == "")
                {
                    throw new Exception("Falta ingresar el Número de Socio");
                }
                else
                {
                    nroSocio = Convert.ToInt32(tbNroSocio.Text);
                }
                int pDNI;
                if (tbDni.Text == "")
                {
                    throw new Exception("Falta ingresar el DNI del Socio");
                } else
                {
                    pDNI = Convert.ToInt32(tbDni.Text);
                }
                if (tbApellido.Text == "")
                {
                    throw new Exception("Falta ingresar el Apellido del Socio");
                }
                if (tbNombre.Text == "")
                {
                    throw new Exception("Falta ingresar el Nombre del Socio");
                }
                if (tbDomicilio.Text == "")
                {
                    throw new Exception("Falta ingresar el Domicilio del Socio");
                }
                if (cbNacionalidad.Text == "")
                {
                    throw new Exception("Falta seleccionar la Nacionalidad del Socio");
                }
                if (dtFechaIngreso.Value.Date == null)
                {
                    throw new Exception("Falta completar la Fecha de Ingreso del Socio");
                }

                Socio socio = new Socio();
                socio.NroSocio = nroSocio;
                socio.Apellido = tbApellido.Text;
                socio.Nombre = tbNombre.Text;
                socio.Dni = pDNI; ;
                socio.Domicilio = tbDomicilio.Text;
                socio.Nacionalidad = cbNacionalidad.Text;
                socio.FechaIngreso = dtFechaIngreso.Value.Date;

                IEnumerable<Socio> sociosPorNumero = cFachada.findByNroSocio(nroSocio);
                if(sociosPorNumero.Count() > 0)
                {
                    int cantidadActivos = 0;

                    string strMensaje;

                    foreach (Socio bSocio in sociosPorNumero)
                    {
                        if (cFachada.esSocioActivo(bSocio))
                        {
                            strMensaje = string.Format("El número de Socio: {1} pertenece a un Socio ACTIVO: {2}{0}{0}¿Desea dar de baja a este socio?", 
                                Environment.NewLine, bSocio.NroSocio, string.Concat(bSocio.Nombre, " ", bSocio.Apellido));

                            DialogResult dialogResult = MessageBox.Show(strMensaje,
                            "SOCIO ACTIVO", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                            switch (dialogResult)
                            {
                                case DialogResult.Yes:
                                    FrmBajaSocio frmBajaSocio = CompositionRoot.Resolve<FrmBajaSocio>();
                                    frmBajaSocio.cSocio = bSocio;
                                    frmBajaSocio.ShowDialog();
                                    if (!cFachada.esSocioActivo(bSocio))
                                    {
                                        cFachada.addSocio(socio);
                                        strMensaje = string.Format("Se dió de baja a:{0} y se guardó a: {1} de manera exitosa",
                                            string.Concat(bSocio.Nombre, " ", bSocio.Apellido),
                                            string.Concat(socio.Nombre, " ", socio.Apellido));
                                        MessageBox.Show(strMensaje,
                                            "ALTA/BAJA EXITOSAS",
                                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        this.Clear();
                                    }
                                    break;
                                case DialogResult.No:
                                    break;
                            }
                            cantidadActivos++;
                            break;
                        }
                    }
                    if(cantidadActivos == 0)
                    {
                        Socio mSocio = cFachada.getLastSocioInactivoByNro(nroSocio);
                        strMensaje = string.Format("El número de Socio: {1} pertenecía a: {2}{0}{0}¿Desea reasignarlo?",
                           Environment.NewLine, mSocio.NroSocio, string.Concat(mSocio.Nombre, " ", mSocio.Apellido));

                        DialogResult dialogResult = MessageBox.Show(strMensaje,
                        "Número de Socio Existente", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                        switch (dialogResult)
                        {
                            case DialogResult.Yes:
                                cFachada.addSocio(socio);
                                MessageBox.Show("El socio se guardó correctamente", "ALTA EXITOSA", MessageBoxButtons.OK,
                                                        MessageBoxIcon.Information);
                                this.Clear();
                                break;
                            case DialogResult.No:
                                break;
                        }

                    }
                } else
                {
                    cFachada.addSocio(socio);
                    MessageBox.Show("El socio se guardó correctamente", "ALTA EXITOSA",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Clear();
                }
            }
            catch (Exception mExcepcion)
            {
                MessageBox.Show(mExcepcion.Message, "Atención",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cLogger.Debug(mExcepcion.Message);
            }
        }

        public void Clear()
        {
            tbNroSocio.Text = cFachada.getNextNroSocio().ToString();
            tbApellido.Clear();
            tbNombre.Clear();
            tbDni.Clear();
            cbNacionalidad.SelectedIndex = 0;
            tbDomicilio.Clear();
            dtFechaIngreso.Value = DateTime.Today;
        }
    }
}
