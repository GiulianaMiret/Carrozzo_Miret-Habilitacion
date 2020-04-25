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
    public partial class FrmGestionPagos : Form
    {
        private readonly Fachada.Fachada cFachada;
        private readonly Vista.Logger.ILogger cLogger;

        public FrmGestionPagos(Fachada.Fachada pFachada, Logger.ILogger pLogger)
        {
            cFachada = pFachada;
            cLogger = pLogger;
            InitializeComponent();
        }

        private void FrmGestionPagos_Load(object sender, EventArgs e)
        {
            btnBuscarPagos_Click(new object(), new EventArgs());
        }

        private void numericFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnBuscarSocios_Click(object sender, EventArgs e)
        {
            IEnumerable<Socio> listaSocios = new List<Socio>();
            if (tbNroSocio.Text != "")
            {
                int nroSocio = Convert.ToInt32(tbNroSocio.Text);
                listaSocios = cFachada.findByNroSocio(nroSocio).Where(x => cFachada.esSocioActivo(x)).ToList();
            }
            if (tbDni.Text != "")
            {
                int dni = Convert.ToInt32(tbDni.Text);
                if (listaSocios.Count() > 0)
                {
                    listaSocios = listaSocios.Where(x => x.Persona.Dni == dni).Where(y => cFachada.esSocioActivo(y)).ToList();
                } else
                {
                    listaSocios = cFachada.getAllSocios().Where(x => x.Persona.Dni == dni).Where(y => cFachada.esSocioActivo(y)).ToList();
                }
            }
            if(listaSocios.Count() <= 0 && tbNroSocio.Text == "" && tbDni.Text == "")
            {
                listaSocios = cFachada.getAllSocios().Where(x => cFachada.esSocioActivo(x)).ToList();
            }

            this.loadDataGridViewPagos(listaSocios.OrderBy(x => x.NroSocio));

        }

        public void loadDataGridViewPagos(IEnumerable<Socio> pListaSocios)
        {
            List<DataGridViewObject> dgvObjectList = new List<DataGridViewObject>();
            foreach (Socio bSocio in pListaSocios)
            {
                DataGridViewObject dgvObject = new DataGridViewObject();
                dgvObject.NroSocio = bSocio.NroSocio;
                dgvObject.DNI = bSocio.Persona.Dni;
                dgvObject.Nombre = string.Concat(bSocio.Persona.Nombre, " ", bSocio.Persona.Apellido);
                dgvObject.CuotasAdeudadas = cFachada.getCantidadCuotasAdeudadas(bSocio);
                Pago ultimoPago = cFachada.ultimaCuotaPaga(bSocio.Id); 
                if (ultimoPago == null)
                {
                    dgvObject.UltimaCuotaPaga = "No hay pagos registrados";
                } else
                {
                    dgvObject.UltimaCuotaPaga = string.Concat(ultimoPago.MesCuota.ToString(), "/", ultimoPago.Anio.ToString());
                }
                
                dgvObjectList.Add(dgvObject);
            }

            lblCantidadSocios.Text = pListaSocios.Count().ToString();
            lblCantidadSocios.Visible = true;
            lblCantidadText.Visible = true;

            dgvResultadoSocios.DataSource = dgvObjectList;
        }

        private void btnLimpiarFiltros_Click(object sender, EventArgs e)
        {
            dgvResultadoSocios.DataSource = new List<DataGridViewObject>();
            lblCantidadSocios.Text = "-";
            tbNroSocio.Text = "";
            tbDni.Text = "";
            dtFechaDesde.Value = DateTime.Now;
            lblCantidadSocios.Visible = false;
            lblCantidadText.Visible = false;
        }

        private void btnSociosDeudores_Click(object sender, EventArgs e)
        {
            IEnumerable<Socio> listaSocios = cFachada.getAllSocios().Where(x => cFachada.esSocioActivo(x)).ToList();
            listaSocios = cFachada.findDeudores(listaSocios);
            this.loadDataGridViewPagos(listaSocios.OrderBy(x => x.NroSocio));
        }

        private void btnSociosAldia_Click(object sender, EventArgs e)
        {
            IEnumerable<Socio> listaSocios = cFachada.getAllSocios().Where(x => cFachada.esSocioActivo(x)).ToList();
            listaSocios = cFachada.findSociosAlDia(listaSocios);
            this.loadDataGridViewPagos(listaSocios.OrderBy(x => x.NroSocio));
        }

        private void btnBuscarPagos_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
            lblCantidadSocios.Visible = false;
            lblCantidadText.Visible = false;
            btnBuscarPagos.BackColor = Color.Gray;
            btnAgregarPagos.BackColor = Color.FromArgb(128, 128, 255);
        }

        private void btnAgregarPagos_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
            btnBuscarPagos.BackColor = Color.FromArgb(128, 128, 255);
            btnAgregarPagos.BackColor = Color.Gray;
        }












        private class DataGridViewObject
        {
            public int NroSocio { get; set; }
            public int DNI { get; set; }
            public String Nombre { get; set; }
            public int CuotasAdeudadas { get; set; }
            public string UltimaCuotaPaga { get; set; }
        }
    }
}
