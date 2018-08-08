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

// https://msdn.microsoft.com/en-us/library/jj682076(v=vs.113).aspx

namespace Win.VideoJuegos
{
    public partial class FormCategoria : Form
    {
        VideoJuegosBL _ef;

        public FormCategoria()
        {
            InitializeComponent();
        }

        private void FormCategoria_Load(object sender, EventArgs e)
        {
            _ef = new VideoJuegosBL();
            this.categoriaBindingSource.DataSource = _ef.ObtenerCategorias();        
        }

        private void categoriaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            var listaCategorias = new List<Categoria>();

            foreach (DataGridViewRow row in categoriaDataGridView.Rows)
            {
                if (row.Cells[0].Value != null && row.Cells[1].Value != null)
                {
                    listaCategorias.Add(new Categoria()
                    {
                        Id = int.Parse(row.Cells[0].Value.ToString()),
                        Descripcion = row.Cells[1].Value.ToString()
                    });
                }
            }

            _ef.GuardarCategorias(listaCategorias);

            MessageBox.Show("Categorias guardadas!", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.categoriaBindingSource.DataSource = _ef.ObtenerCategorias();
        }

        private void categoriaDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
        }
    }
}
