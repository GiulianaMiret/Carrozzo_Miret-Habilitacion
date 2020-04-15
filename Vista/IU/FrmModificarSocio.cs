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
    public partial class FrmModificarSocio : Form
    {
        private readonly Fachada.Fachada cFachada;
        private readonly Vista.Logger.ILogger cLogger;
        public Socio cSocio;

        public FrmModificarSocio(Fachada.Fachada pFachada, Logger.ILogger pLogger)
        {
            cFachada = pFachada;
            cLogger = pLogger;
            InitializeComponent();
        }

        private void FrmModificarSocio_Load(object sender, EventArgs e)
        {
            tbNroSocio.Text = cSocio.NroSocio.ToString();
            tbDni.Text = cSocio.Persona.Dni.ToString();
            tbApellido.Text = cSocio.Persona.Apellido;
            tbNombre.Text = cSocio.Persona.Nombre;
            tbDomicilio.Text = cSocio.Persona.Domicilio;
            cbNacionalidad.Text = cSocio.Persona.Nacionalidad;
            if (cFachada.esSocioActivo(cSocio))
            {
                lblModificarSocioTitulo.Text = "Modificar Socio";
                dtFechaIngreso.Value = cSocio.FechaIngreso;
            } else
            {
                lblModificarSocioTitulo.Text = "Activar Socio";
                dtFechaIngreso.Value = DateTime.Today;
                tbDni.Enabled = false;
            }
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
                if (tbDni.Text == "")
                {
                    throw new Exception("Falta ingresar el DNI del Socio");
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

                if (cFachada.esSocioActivo(cSocio)) //Se nodifica
                {
                    int pDNI = Convert.ToInt32(tbDni.Text);
                    if (pDNI != cSocio.Persona.Dni)
                    {
                        Socio socio = cFachada.findSocioActivoByDni(pDNI);
                        if (socio != null)
                        {
                            throw new Exception("El número de documento pertenece al socio activo nro: " + socio.NroSocio.ToString());
                        }
                    }
                    DialogResult dialogResult = MessageBox.Show("El socio será modificado. ¿Desea continuar?",
                    "¿Modificar Socio?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    switch (dialogResult)
                    {
                        case DialogResult.Yes:
                            Persona persona = cFachada.findPersonaByDni(pDNI);
                            persona.Dni = pDNI;
                            persona.Apellido = tbApellido.Text;
                            persona.Nombre = tbNombre.Text;
                            persona.Domicilio = tbDomicilio.Text;
                            persona.Nacionalidad = cbNacionalidad.Text;
                            cFachada.updatePersona(persona);
                            MessageBox.Show("El socio se modificó exitosamente! Nro. de Socio: " + cSocio.NroSocio.ToString(),
                                "Socio modificado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                            break;
                        case DialogResult.No:
                            break;
                    }
                } else //Se reactiva
                {
                    DialogResult dialogResult = MessageBox.Show("El socio volverá a estar ACTIVO. ¿Desea continuar?",
                    "¿Activar Socio?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    switch (dialogResult)
                    {
                        case DialogResult.Yes:
                            Persona persona = cFachada.findPersonaByDni(cSocio.Persona.Dni);
                            persona.Apellido = tbApellido.Text;
                            persona.Nombre = tbNombre.Text;
                            persona.Domicilio = tbDomicilio.Text;
                            persona.Nacionalidad = cbNacionalidad.Text;
                            cSocio.Persona = persona;
                            cFachada.activarSocio(cSocio);
                            MessageBox.Show("El socio se activó nuevamente! Nro. de Socio: " + cSocio.NroSocio.ToString(),
                                "Socio ACTIVO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                            break;
                        case DialogResult.No:
                            break;
                    }
                }



                
                
            } catch(Exception mExcepcion)
            {
                MessageBox.Show(mExcepcion.Message, "Atención",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cLogger.Debug(mExcepcion.Message);
            }
        }
    }
}
