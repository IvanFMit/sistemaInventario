using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL.VideoJuegos;

namespace Win.VideoJuegos.Formularios
{
    public partial class FormBuscarCliente : Form
    {
  public FormRenta formRenta { get; set; }
        VideoJuegosBL _ef;

        public FormBuscarCliente()
        {
            InitializeComponent();
            _ef = new VideoJuegosBL();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var buscar = textBox1.Text;
            var resultado = _ef.ObtenerClientes(buscar);
            var listaResultado = new List<ResultadoCliente>();

            foreach (var item in resultado)
            {
                listaResultado.Add(new ResultadoCliente()
                {
                    Id = item.Id,
                    Nombre = item.Nombre,
                    Telefono = item.Telefono,
                });
            }

            dataGridView1.DataSource = listaResultado;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                var fila = dataGridView1.Rows[dataGridView1.CurrentRow.Index];

                formRenta.ClienteId = int.Parse(fila.Cells[0].Value.ToString());
                formRenta.ClienteNombre = fila.Cells[1].Value.ToString();
                formRenta.ClienteTelefono = fila.Cells[2].Value.ToString();

                this.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    
}
    

    public class ResultadoCliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
    }
    }