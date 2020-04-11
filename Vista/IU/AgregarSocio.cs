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

        private void tbNroSocio_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tbDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tbApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }

        private void tbNombre_KeyPress(object sender, KeyPressEventArgs e)
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
                Socio socioAnterior = cFachada.findByNroSocio(nroSocio);
                if(socioAnterior != null)
                {
                    string strMensaje = string.Format("El número de Socio: {1} ya se encuentra registrado para:{0}Nombre: {2}{0}DNI: {3}{0}{0}¿Desea asignarlo a: {4}?", 
                        Environment.NewLine, socioAnterior.NroSocio, string.Concat(socioAnterior.Nombre," ", socioAnterior.Apellido), socioAnterior.Dni.ToString(), string.Concat(tbNombre.Text," ", tbApellido.Text));

                    DialogResult dialogResult = MessageBox.Show(strMensaje,
                      "Número de Socio Existente", MessageBoxButtons.YesNo);
                    switch (dialogResult)
                    {
                        case DialogResult.Yes:
                            socioAnterior.Apellido = tbApellido.Text;
                            socioAnterior.Nombre = tbNombre.Text;
                            socioAnterior.Dni = pDNI; ;
                            socioAnterior.Domicilio = tbDomicilio.Text;
                            socioAnterior.Nacionalidad = cbNacionalidad.Text;
                            cFachada.updateSocio(socioAnterior);
                            MessageBox.Show("El socio se guardó correctamente", "Socio Guardado", MessageBoxButtons.OK);
                            this.Clean();
                            break;
                        case DialogResult.No:
                            break;
                    }
                } else
                {
                    Socio socio = new Socio();
                    socio.NroSocio = nroSocio;
                    socio.Apellido = tbApellido.Text;
                    socio.Nombre = tbNombre.Text;
                    socio.Dni = pDNI; ;
                    socio.Domicilio = tbDomicilio.Text;
                    socio.Nacionalidad = cbNacionalidad.Text;
                    socio.FechaIngreso = dtFechaIngreso.Value.Date;
                    cFachada.addSocio(socio);
                    MessageBox.Show("El socio se guardó correctamente");
                    this.Clean();
                }
            }
            catch (Exception mExcepcion)
            {
                MessageBox.Show(mExcepcion.Message);
                cLogger.Debug(mExcepcion.Message);
            }
        }

        public void Clean()
        {
            tbNroSocio.Text = cFachada.getNextNroSocio().ToString();
            tbApellido.Text = "";
            tbNombre.Text = "";
            tbDni.Text = "";
            cbNacionalidad.SelectedIndex = 0;
            tbDomicilio.Text = "";
            dtFechaIngreso.Value = DateTime.Today;
        }
    }
}
