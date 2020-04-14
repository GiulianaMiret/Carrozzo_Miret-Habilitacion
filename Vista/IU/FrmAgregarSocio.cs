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
        private readonly Fachada.Fachada cFachada;
        private readonly Vista.Logger.ILogger cLogger;

        public FrmAgregarSocio(Fachada.Fachada pFachada, Logger.ILogger pLogger)
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
                socio.FechaIngreso = dtFechaIngreso.Value.Date;

                Persona persona = cFachada.findPersonaByDni(pDNI);
                if(persona != null)
                {
                    DialogResult dialogResult = MessageBox.Show("La persona ya está registrada, ¿Desea actualizar sus datos?",
                                            "PERSONA EXISTENTE",
                                                    MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    switch (dialogResult)
                    {
                        case DialogResult.Yes:
                            persona.Apellido = tbApellido.Text;
                            persona.Nombre = tbNombre.Text;
                            persona.Domicilio = tbDomicilio.Text;
                            persona.Nacionalidad = cbNacionalidad.Text;
                            break;
                        case DialogResult.No:
                            break;
                    }
                } else
                {
                    persona.Apellido = tbApellido.Text;
                    persona.Nombre = tbNombre.Text;
                    persona.Dni = pDNI;
                    persona.Domicilio = tbDomicilio.Text;
                    persona.Nacionalidad = cbNacionalidad.Text;
                    cFachada.addPersona(persona);
                }
                socio.Persona = persona;
                

                IEnumerable<Socio> sociosPorNumero = cFachada.findByNroSocio(nroSocio);
                if(sociosPorNumero.Count() > 0)
                {
                    string strMensaje;

                    Socio socioActivo = sociosPorNumero.Where(x => cFachada.esSocioActivo(x)).FirstOrDefault(); ;
                    if(socioActivo != null)
                    {
                        strMensaje = string.Format("El número de Socio: {1} pertenece a un Socio ACTIVO: {2}{0}{0}¿Desea dar de baja a este socio?",
                                Environment.NewLine, socioActivo.NroSocio, 
                                string.Concat(socioActivo.Persona.Nombre, " ", socioActivo.Persona.Apellido));

                        DialogResult dialogResult = MessageBox.Show(strMensaje,
                        "SOCIO ACTIVO", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                        switch (dialogResult)
                        {
                            case DialogResult.Yes:
                                FrmBajaSocio frmBajaSocio = CompositionRoot.Resolve<FrmBajaSocio>();
                                frmBajaSocio.cSocio = socioActivo;
                                frmBajaSocio.ShowDialog();
                                if (!cFachada.esSocioActivo(socioActivo))
                                {
                                    cFachada.addSocio(socio);
                                    strMensaje = string.Format("Se dió de baja a:{0} y se guardó a: {1} de manera exitosa",
                                        string.Concat(socioActivo.Persona.Nombre, " ", socioActivo.Persona.Apellido),
                                        string.Concat(persona.Nombre, " ", persona.Apellido));
                                    MessageBox.Show(strMensaje,
                                        "ALTA/BAJA EXITOSAS",
                                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Clear();
                                }
                                break;
                            case DialogResult.No:
                                break;
                        }
                    } else
                    {
                        Socio mSocio = cFachada.getLastSocioInactivoByNro(nroSocio);
                        strMensaje = string.Format("El número de Socio: {1} pertenecía a: {2}{0}{0}¿Desea reasignarlo?",
                           Environment.NewLine, mSocio.NroSocio, string.Concat(mSocio.Persona.Nombre, " ", mSocio.Persona.Apellido));

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
