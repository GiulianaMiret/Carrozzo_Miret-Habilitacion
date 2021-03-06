﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vista.Fachada;


namespace Vista.IU
{
    public partial class FrmPrincipal : Form
    {
        private readonly Fachada.Fachada cFachada;
        private readonly Vista.Logger.ILogger cLogger;

        public FrmPrincipal(Fachada.Fachada pFachada, Logger.ILogger pLogger)
        {
            cFachada = pFachada;
            cLogger = pLogger;
            InitializeComponent();
        }

        private void btnSocios_Click(object sender, EventArgs e)
        {
            CompositionRoot.Resolve<FrmGestionSocios>().ShowDialog();
        }

        private void btnPagos_Click(object sender, EventArgs e)
        {
            CompositionRoot.Resolve<FrmGestionPagos>().ShowDialog();
        }

        private void btnRubros_Click(object sender, EventArgs e)
        {
            CompositionRoot.Resolve<FrmGestionRubros>().ShowDialog();
        }
    }
}
