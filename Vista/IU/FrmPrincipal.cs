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

namespace Vista.IU
{
    public partial class FrmPrincipal : Form
    {
        private readonly Fachada cFachada;
        private readonly Vista.Logger.ILogger cLogger;

        public FrmPrincipal(Fachada pFachada, Logger.ILogger pLogger)
        {
            cFachada = pFachada;
            cLogger = pLogger;
            InitializeComponent();
        }

        private void btnSocios_Click(object sender, EventArgs e)
        {
            CompositionRoot.Resolve<FrmFiltroSocios>().ShowDialog();
            this.Close();
        }
    }
}
