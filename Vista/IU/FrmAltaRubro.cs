using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista.IU
{
    public partial class FrmAltaRubro : Form
    {
        private readonly Fachada.Fachada cFachada;
        private readonly Vista.Logger.ILogger cLogger;

        public FrmAltaRubro(Fachada.Fachada pFachada, Logger.ILogger pLogger)
        {
            cFachada = pFachada;
            cLogger = pLogger;
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDescripcion.Text != "")
                {
                    cFachada.addRubro(new Core.Models.Rubro { Descripcion = txtDescripcion.Text,Activo = chkActivo.Checked });
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void FrmAltaRubro_Load(object sender, EventArgs e)
        {
            chkActivo.Checked = true;            
        }
    }
}
