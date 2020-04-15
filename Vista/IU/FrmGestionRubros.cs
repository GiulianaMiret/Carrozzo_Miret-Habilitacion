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
    public partial class FrmGestionRubros : Form
    {
        private readonly Fachada cFachada;
        private readonly Vista.Logger.ILogger cLogger;

        public FrmGestionRubros(Fachada pFachada, Logger.ILogger pLogger)
        {
            cFachada = pFachada;
            cLogger = pLogger;
            InitializeComponent();
        }

        private void FrmGestionRubros_Load(object sender, EventArgs e)
        {
            dataGridRubros.DataSource = cFachada.getAllRubros();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Está seguro? el Rubro se eliminará permanentemente.",
                            "Eliminar Rubro", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                switch (dialogResult)
                {
                    case DialogResult.Yes:
                        cFachada.deleteRubro(new Core.Models.Rubro { Id = Convert.ToInt32(dataGridRubros.CurrentRow.Cells[0].Value) });
                        break;
                    case DialogResult.No:
                        break;
                }
            }
            catch (Exception bEx)
            {
                MessageBox.Show(bEx.Message);
            }            
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            var mFrmEditarRubro = CompositionRoot.Resolve<FrmEditarRubro>();
            mFrmEditarRubro.cRubroAEditar = new Core.Models.Rubro {
                                                                    Id = Convert.ToInt32(dataGridRubros.CurrentRow.Cells[0].Value),
                                                                    Descripcion = dataGridRubros.CurrentRow.Cells[1].Value.ToString(),
                                                                    Activo = Convert.ToBoolean(dataGridRubros.CurrentRow.Cells[2].Value)
                                                                  };
            mFrmEditarRubro.ShowDialog();
        }
    }
}
