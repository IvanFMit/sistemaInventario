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
    public partial class FormClientes : Form
    {
        VideoJuegosBL _ef;

        public FormClientes()
        {
            InitializeComponent();
            _ef = new VideoJuegosBL();
        }

        private void clienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            var listaClientes = new List<Cliente>();

            foreach (DataGridViewRow row in clienteDataGridView.Rows)
            {
                if (row.Cells[0].Value != null && row.Cells[1].Value != null)
                {
                    listaClientes.Add(new Cliente()
                    {
                        Id = int.Parse(row.Cells[0].Value.ToString()),
                        Nombre = row.Cells[1].Value.ToString(),
                        Telefono = row.Cells[2].Value.ToString()
                    });
                }
            }

            _ef.GuardarClientes(listaClientes);

            MessageBox.Show("Clientes guardados!", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Validate();
            this.clienteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.videoJuegosDatabaseDataSet);

        }

        private void FormClientes_Load(object sender, EventArgs e)
        {
            try
            {
                _ef = new VideoJuegosBL();
                this.clienteBindingSource.DataSource = _ef.ObtenerClientesLista();
            }
            catch (Exception err)
            { MessageBox.Show("Ha ocurrido un error: " + err.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }

        private void clienteDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
        }
    }
}
