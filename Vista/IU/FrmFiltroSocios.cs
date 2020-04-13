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

        public FrmFiltroSocios(Fachada pFachada, Logger.ILogger pLogger)
        {
            cFachada = pFachada;
            cLogger = pLogger;
            InitializeComponent();
        }

        private void FrmFiltroSocios_Load(object sender, EventArgs e)
        {
            cbEstadoSocio.SelectedIndex = 0;
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
                    mListaResultadoBusqueda = cFachada.getAllSocios().Where(x => x.Persona.Dni == dni).ToList();
                }
                else
                {
                    mListaResultadoBusqueda = mListaResultadoBusqueda.Where(x => x.Persona.Dni == dni).ToList();
                }
            }
            if(tbApellido.Text != "")
            {
                if (mListaResultadoBusqueda.Count() == 0)
                {
                    mListaResultadoBusqueda = cFachada.getAllSocios()
                        .Where(x => x.Persona.Apellido.ToLower().Contains(tbApellido.Text.ToLower())).ToList();
                }
                else
                {
                    mListaResultadoBusqueda = mListaResultadoBusqueda
                        .Where(x => x.Persona.Apellido.ToLower().Contains(tbApellido.Text.ToLower())).ToList();
                }
            }
            if(tbNombre.Text != "")
            {
                if (mListaResultadoBusqueda.Count() == 0)
                {
                    mListaResultadoBusqueda = cFachada.getAllSocios()
                        .Where(x => x.Persona.Nombre.ToLower().Contains(tbNombre.Text.ToLower())).ToList();
                }
                else
                {
                    mListaResultadoBusqueda = mListaResultadoBusqueda
                        .Where(x => x.Persona.Nombre.ToLower().Contains(tbNombre.Text.ToLower())).ToList();
                }
            }
            if(mListaResultadoBusqueda.Count() == 0)
            {
                mListaResultadoBusqueda = cFachada.getAllSocios();
            }
            String estadoSocio = cbEstadoSocio.Text;
            switch (estadoSocio)
            {
                case "ACTIVOS":
                    mListaResultadoBusqueda = mListaResultadoBusqueda.Where(x => cFachada.esSocioActivo(x) == true).ToList();
                    break;
                case "DADOS DE BAJA":
                    mListaResultadoBusqueda = mListaResultadoBusqueda.Where(x => cFachada.esSocioActivo(x) == false).ToList();
                    break;
            }
            this.loadDataGridViewSocios(mListaResultadoBusqueda);
        }

        private void btnLimpiarFiltros_Click(object sender, EventArgs e)
        {
            tbNroSocio.Clear();
            tbDni.Clear();
            tbNombre.Clear();
            tbApellido.Clear();
            dgvResultadoSocios.DataSource = new List<DataGridViewObject>();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModificarSocio_Click(object sender, EventArgs e)
        {
            if (dgvResultadoSocios.CurrentRow != null)
            {
                int idSocio = Convert.ToInt32(dgvResultadoSocios.CurrentRow.Cells[0].Value);
                Socio socio = cFachada.findSocioById(idSocio);
                if (cFachada.esSocioActivo(socio))
                {
                    FrmModificarSocio frmModificarSocio = CompositionRoot.Resolve<FrmModificarSocio>();
                    frmModificarSocio.cSocio = socio;
                    frmModificarSocio.ShowDialog();
                    btnBuscarSocios_Click(new object(), new EventArgs());
                } else
                {
                    MessageBox.Show("No se puede modificar un socio que ya fue dado de baja",
                                        "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void btnBajaSocio_Click(object sender, EventArgs e)
        {
            if (dgvResultadoSocios.CurrentRow != null)
            {
                int idSocio = Convert.ToInt32(dgvResultadoSocios.CurrentRow.Cells[0].Value);
                Socio socio = cFachada.findSocioById(idSocio);
                if (cFachada.esSocioActivo(socio))
                {
                    FrmBajaSocio frmBajaSocio = CompositionRoot.Resolve<FrmBajaSocio>();
                    frmBajaSocio.cSocio = socio;
                    frmBajaSocio.ShowDialog();
                    btnBuscarSocios_Click(new object(), new EventArgs());
                } else
                {
                    MessageBox.Show("El socio ya fue dado de baja",
                                        "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void btnAgregarSocio_Click(object sender, EventArgs e)
        {
            CompositionRoot.Resolve<FrmAgregarSocio>().ShowDialog();
        }

        private void btnReactivar_Click(object sender, EventArgs e)
        {
            if (dgvResultadoSocios.CurrentRow != null)
            {
                int idSocio = Convert.ToInt32(dgvResultadoSocios.CurrentRow.Cells[0].Value);
                Socio socio = cFachada.findSocioById(idSocio);
                if (!cFachada.esSocioActivo(socio))
                {
                    List<Socio> listaAux = cFachada.getAllSocios().Where(x => x.Persona == socio.Persona 
                                                && cFachada.esSocioActivo(x) == true).ToList();
                    if(listaAux.Count() > 0)
                    {
                        MessageBox.Show("El socio con DNI: "+socio.Persona.Dni.ToString()+" ya está Activo",
                                        "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    } else
                    {
                        Socio socioActivo = cFachada.findByNroSocio(socio.NroSocio).Where(x => cFachada.esSocioActivo(x)).FirstOrDefault();
                        if(socioActivo != null)
                        {
                            String strMensaje = string.Format("El número de Socio: {1} está ACTIVO y pertenece a: {2}{0}{0}¿Desea asignarle otro número?",
                                Environment.NewLine, socioActivo.NroSocio,
                                string.Concat(socioActivo.Persona.Nombre, " ", socioActivo.Persona.Apellido));

                            DialogResult dialogResult = MessageBox.Show(strMensaje,
                            "Nro SOCIO NO DISPONIBLE", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                            switch (dialogResult)
                            {
                                case DialogResult.Yes:
                                    socio.NroSocio = cFachada.getNextNroSocio();
                                    FrmModificarSocio frmModificarSocio = CompositionRoot.Resolve<FrmModificarSocio>();
                                    frmModificarSocio.cSocio = socio;
                                    frmModificarSocio.ShowDialog();
                                    break;
                                case DialogResult.No:
                                    break;
                            }




                        } else
                        {
                            FrmModificarSocio frmModificarSocio = CompositionRoot.Resolve<FrmModificarSocio>();
                            frmModificarSocio.cSocio = socio;
                            frmModificarSocio.ShowDialog();
                            btnBuscarSocios_Click(new object(), new EventArgs());
                        }
                    }
                }
                else
                {
                    MessageBox.Show("El socio ya está Activo",
                                        "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        public void loadDataGridViewSocios(List<Socio> pSociosList)
        {
            List<DataGridViewObject> dgvObjectList = new List<DataGridViewObject>();
            foreach (Socio socio in pSociosList)
            {
                DataGridViewObject dgvObject = new DataGridViewObject();
                dgvObject.NroSocio = socio.NroSocio;
                dgvObject.DNI = socio.Persona.Dni;
                dgvObject.Nombre = socio.Persona.Nombre;
                dgvObject.Apellido = socio.Persona.Apellido;
                dgvObject.Domicilio = socio.Persona.Domicilio;
                dgvObject.FechaIngreso = socio.FechaIngreso;
                dgvObject.FechaRenuncia = socio.FechaRenuncia;
                dgvObject.MotivoRenuncia = socio.MotivoRenuncia;

                if (cFachada.esSocioActivo(socio))
                {
                    dgvObject.Estado = "Activo";
                } else
                {
                    dgvObject.Estado = "Inactivo";
                }
                dgvObjectList.Add(dgvObject);
            }

            switch (cbEstadoSocio.Text)
            {
                case "TODOS":
                    dgvResultadoSocios.Columns["Estado"].Visible = true;
                    dgvResultadoSocios.Columns["FechaRenuncia"].Visible = true;
                    dgvResultadoSocios.Columns["MotivoRenuncia"].Visible = true;
                    break;
                case "ACTIVOS":
                    dgvResultadoSocios.Columns["Estado"].Visible = false;
                    dgvResultadoSocios.Columns["FechaRenuncia"].Visible = false;
                    dgvResultadoSocios.Columns["MotivoRenuncia"].Visible = false;
                    break;
                case "DADOS DE BAJA":
                    dgvResultadoSocios.Columns["Estado"].Visible = false;
                    dgvResultadoSocios.Columns["FechaRenuncia"].Visible = true;
                    dgvResultadoSocios.Columns["MotivoRenuncia"].Visible = true;
                    break;
            }

            dgvResultadoSocios.DataSource = dgvObjectList.OrderBy(x => x.NroSocio).ToList();
        }








        private class DataGridViewObject
        {
            public int NroSocio { get; set; }
            public int DNI { get; set; }
            public String Nombre { get; set; }
            public String Apellido { get; set; }
            public String Domicilio { get; set; }
            public DateTime FechaIngreso { get; set; }
            public DateTime FechaRenuncia { get; set; }
            public String MotivoRenuncia { get; set; }
            public String Estado { get; set; }
        }
    }
}
