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
    public partial class FrmFiltroSocios : Form
    {
        private readonly Fachada cFachada;
        private readonly Vista.Logger.ILogger cLogger;
        public bool esBaja = true;

        public FrmFiltroSocios(Fachada pFachada, Logger.ILogger pLogger)
        {
            cFachada = pFachada;
            cLogger = pLogger;
            InitializeComponent();
        }

        private void FrmFiltroSocios_Load(object sender, EventArgs e)
        {
            if (esBaja)
            {
                btnEditarBaja.Text = "Dar de Baja";
            }
            else
            {
                btnEditarBaja.Text = "Modificar";
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

        private void btnBuscarSocios_Click(object sender, EventArgs e)
        {
            List<Socio> mListaResultadoBusqueda = new List<Socio>();
            if (tbNroSocio.Text != "")
            {
                int nroSocio = Convert.ToInt32(tbNroSocio.Text);
                mListaResultadoBusqueda = cFachada.getAllSocios().Where(x => x.NroSocio == nroSocio).ToList();
            }
            if (tbDni.Text != "")
            {
                int dni = Convert.ToInt32(tbDni.Text);
                if (mListaResultadoBusqueda.Count() == 0)
                {
                    mListaResultadoBusqueda = cFachada.getAllSocios().Where(x => x.Dni == dni).ToList();
                }
                else
                {
                    mListaResultadoBusqueda = mListaResultadoBusqueda.Where(x => x.Dni == dni).ToList();
                }
            }
            if(tbApellido.Text != "")
            {
                if (mListaResultadoBusqueda.Count() == 0)
                {
                    mListaResultadoBusqueda = cFachada.getAllSocios()
                        .Where(x => x.Apellido.ToLower().Contains(tbApellido.Text.ToLower())).ToList();
                }
                else
                {
                    mListaResultadoBusqueda = mListaResultadoBusqueda
                        .Where(x => x.Apellido.ToLower().Contains(tbApellido.Text.ToLower())).ToList();
                }
            }
            if(tbNombre.Text != "")
            {
                if (mListaResultadoBusqueda.Count() == 0)
                {
                    mListaResultadoBusqueda = cFachada.getAllSocios()
                        .Where(x => x.Nombre.ToLower().Contains(tbNombre.Text.ToLower())).ToList();
                }
                else
                {
                    mListaResultadoBusqueda = mListaResultadoBusqueda
                        .Where(x => x.Nombre.ToLower().Contains(tbNombre.Text.ToLower())).ToList();
                }
            }
            if(mListaResultadoBusqueda.Count() == 0)
            {
                mListaResultadoBusqueda = cFachada.getAllSocios();
            }
            dgvResultadoSocios.DataSource = mListaResultadoBusqueda.Where(x => cFachada.esSocioActivo(x) == true)
                                                .ToList().OrderBy(y => y.NroSocio).ToList();
        }

        private void btnLimpiarFiltros_Click(object sender, EventArgs e)
        {
            tbNroSocio.Clear();
            tbDni.Clear();
            tbNombre.Clear();
            tbApellido.Clear();
            dgvResultadoSocios.DataSource = new List<Socio>();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditarBaja_Click(object sender, EventArgs e)
        {
            int idSocio = Convert.ToInt32(dgvResultadoSocios.CurrentRow.Cells[0].Value);
            Socio socio = cFachada.findById(idSocio);
            if (esBaja)
            { 
                FrmBajaSocio frmBajaSocio = CompositionRoot.Resolve<FrmBajaSocio>();
                frmBajaSocio.cSocio = socio;
                frmBajaSocio.ShowDialog();
                btnBuscarSocios_Click(new object(), new EventArgs());
            } else
            {

            }
        }
    }
}
