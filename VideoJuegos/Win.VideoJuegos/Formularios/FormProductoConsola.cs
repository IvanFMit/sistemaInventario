using DAL.VideoJuegos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win.VideoJuegos.Formularios
{
    public partial class FormProductoConsola : Form
    {
        VideoJuegosBL _ef;
        public FormProductoConsola()
        {
            InitializeComponent();
            _ef = new VideoJuegosBL();
        }
        

        private void FormProductoConsola_Load(object sender, EventArgs e)
        {
            consolaBindingSource.DataSource = _ef.ObtenerConsolas();
            productoBindingSource.DataSource = _ef.ObtenerProductos();
            productoConsolaBindingSource.DataSource = _ef.ObtenerTodosProductosConsolas();
        }

        private void productoConsolaDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
        }

        private void productoConsolaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                var listaPC = new List<ProductoConsola>();

                foreach (DataGridViewRow row in productoConsolaDataGridView.Rows)
                {
                    if (row.Cells[0].Value != null && row.Cells[1].Value != null)
                    {
                        listaPC.Add(new ProductoConsola()
                        {
                            Id = int.Parse(row.Cells[0].Value.ToString()),
                            CodigoProducto = int.Parse(row.Cells[1].Value.ToString()),
                            CodigoConsola = int.Parse(row.Cells[2].Value.ToString()),
                            Existencia = int.Parse(row.Cells[3].Value.ToString()),
                            Disponibilidad = int.Parse(row.Cells[4].Value.ToString())
                        });
                    }
                }

                _ef.GuardarProductoConsola(listaPC);

                MessageBox.Show("Relaciones guardadas!", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.productoConsolaBindingSource.DataSource = _ef.ObtenerTodosProductosConsolas();
            }
            catch (Exception ex)
            { MessageBox.Show("Ha ocurrido un error: " + string.Format("Mensaje: {0} StatckTrace: {1}", ex.Message, ex.StackTrace), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
