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


namespace Win.VideoJuegos
{
    public partial class FormProducto : Form
    {
        VideoJuegosBL _ef;

        public FormProducto()
        {
            InitializeComponent();
        }

        private void FormProducto_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex= 0;
            _ef = new VideoJuegosBL();
            this.productoBindingSource.DataSource = _ef.ObtenerProductos();
            this.categoriaBindingSource.DataSource = _ef.ObtenerCategorias();        
        }

        private void productoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                var listaProductos = new List<Producto>();

                foreach (DataGridViewRow row in productoDataGridView.Rows)
                {
                    if (row.Cells[0].Value != null && row.Cells[1].Value != null)
                    {
                        listaProductos.Add(new Producto()
                        {
                            Id = int.Parse(row.Cells[0].Value.ToString()),
                            Descripcion = row.Cells[1].Value.ToString(),
                            Estado = row.Cells[2].Value.ToString(),
                            Existencia = int.Parse(row.Cells[3].Value.ToString()),
                            CodigoCategoria = int.Parse(row.Cells[4].Value.ToString())
                        });
                    }
                }

                _ef.GuardarProductos(listaProductos);

                MessageBox.Show("Productos guardados!", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.productoBindingSource.DataSource = _ef.ObtenerProductos();
                this.categoriaBindingSource.DataSource = _ef.ObtenerCategorias();
            }
            catch (Exception err)
            { MessageBox.Show("Ha ocurrido un error: " + err.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); }


        }

        private void productoDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                _ef = new VideoJuegosBL();
                this.productoBindingSource.DataSource = _ef.ObtenerProductosFiltrados(comboBox1.Text);
            }
            catch (Exception err)
            { MessageBox.Show("Ha ocurrido un error: " + err.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
