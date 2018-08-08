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
    public partial class FormConsolas : Form
    {
        VideoJuegosBL _ef;

        public FormConsolas()
        {
            InitializeComponent();
            _ef = new VideoJuegosBL();
        }

        private void consolaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                var listaConsolas = new List<Consola>();

                foreach (DataGridViewRow row in consolaDataGridView.Rows)
                {
                    if (row.Cells[0].Value != null && row.Cells[1].Value != null)
                    {
                        listaConsolas.Add(new Consola()
                        {
                            Id = int.Parse(row.Cells[0].Value.ToString()),
                            Descripcion = row.Cells[1].Value.ToString()
                        });
                    }
                }

                _ef.GuardarConsolas(listaConsolas);

                MessageBox.Show("Consolas guardadas!", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.consolaBindingSource.DataSource = _ef.ObtenerConsolas();
            }
            catch (Exception err)
            { MessageBox.Show("Ha ocurrido un error: " + err.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void FormConsolas_Load(object sender, EventArgs e)
        {
            try
            {
                _ef = new VideoJuegosBL();
                this.consolaBindingSource.DataSource = _ef.ObtenerConsolas();
            }
            catch (Exception err)
            { MessageBox.Show("Ha ocurrido un error: " + err.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void consolaDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
        }

    }
}
