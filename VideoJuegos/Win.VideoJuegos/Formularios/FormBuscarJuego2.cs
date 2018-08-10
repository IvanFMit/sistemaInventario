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
    public partial class FormBuscarJuego2 : Form
    {
        public FormInv formRenta { get; set; }
        VideoJuegosBL _ef;

        public FormBuscarJuego2()
        {
            InitializeComponent();

            _ef = new VideoJuegosBL();

            consolaBindingSource.DataSource = _ef.ObtenerConsolas();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int consolaId = 0;

            if (comboBox1.SelectedValue != null)
            {
                consolaId = int.Parse(comboBox1.SelectedValue.ToString());
            }

            var buscar = textBox1.Text;

            var resultado = _ef.ObtenerProductosConsolas(buscar, consolaId);

            var listaResultado = new List<Resultado>();

            foreach (var item in resultado)
            {
                listaResultado.Add(new Resultado()
                {
                    Id = item.Id,
                    Descripcion = item.Producto.Descripcion,
                    Consola = item.Consola.Descripcion,
                    Existencia = item.Existencia,
                    Disponibilidad = item.Disponibilidad
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

                formRenta.ProductoId = int.Parse(fila.Cells[0].Value.ToString());
                formRenta.ProductoDescripcion = fila.Cells[1].Value.ToString();
                formRenta.ConsolaDescripcion = fila.Cells[2].Value.ToString();

                this.Close();
            }
        }

        private void FormBuscarJuego_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = -1;
        }
      
    }

    public class Resultado2
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public string Consola { get; set; }
        public int Existencia { get; set; }
        public int Disponibilidad { get; set; }
    }

}
