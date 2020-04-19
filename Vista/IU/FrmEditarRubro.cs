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
    public partial class FrmEditarRubro : Form
    {
        private readonly Fachada cFachada;
        private readonly Vista.Logger.ILogger cLogger;
        public Rubro cRubroAEditar;

        public FrmEditarRubro(Fachada pFachada, Logger.ILogger pLogger)
        {
            cFachada = pFachada;
            cLogger = pLogger;
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            cFachada.updateRubro(cRubroAEditar);
        }

        private void FrmEditarRubro_Load(object sender, EventArgs e)
        {
            txtDescripcion.Text = cRubroAEditar.Descripcion;
        }
    }
}
