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
    public partial class FrmBajaSocio : Form
    {
        private readonly Fachada cFachada;
        private readonly Vista.Logger.ILogger cLogger;
        public Socio cSocio;

        public FrmBajaSocio(Fachada pFachada, Logger.ILogger pLogger)
        {
            cFachada = pFachada;
            cLogger = pLogger;
            InitializeComponent();
        }

        private void FrmBajaSocio_Load(object sender, EventArgs e)
        {
            dtFechaRenuncia.Value = DateTime.Today;
            lblNroSocioValor.Text = cSocio.NroSocio.ToString();
            lblDniValor.Text = cSocio.Persona.Dni.ToString();
            lblApellidoValor.Text = cSocio.Persona.Apellido;
            lblNombreValor.Text = cSocio.Persona.Nombre;
            lblDomicilioValor.Text = cSocio.Persona.Domicilio;
            lblNacionalidadValor.Text = cSocio.Persona.Nacionalidad;
            lblFechaIngresoValor.Text = string.Format("{0}/{1}/{2}", cSocio.FechaIngreso.Day, cSocio.FechaIngreso.Month, cSocio.FechaIngreso.Year);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtFechaRenuncia.Value.Date > DateTime.Today)
                {
                    throw new Exception("La fecha no es válida - La fecha de renuncia no puede ser futura");
                }
                if(tbMotivoRenuncia.Text == "")
                {
                    throw new Exception("Se debe ingresar el motivo de renuncia");
                }
                cSocio.MotivoRenuncia = tbMotivoRenuncia.Text;
                cSocio.FechaRenuncia = dtFechaRenuncia.Value.Date;
                cFachada.updateSocio(cSocio);
                this.Close();
            }
            catch(Exception mExcepcion)
            {
                MessageBox.Show(mExcepcion.Message, "Atención",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cLogger.Debug(mExcepcion.Message);
            }
        }
    }
}
