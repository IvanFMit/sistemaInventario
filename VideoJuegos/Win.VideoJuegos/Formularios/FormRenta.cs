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
    public partial class FormRenta : Form
    {

        public int ProductoId { get; set; }
        public string ProductoDescripcion { get; set; }
        public string ConsolaDescripcion { get; set; }

        public int ClienteId { get; set; }
        public string ClienteNombre { get; set; }
        public string ClienteTelefono { get; set; }

        VideoJuegosBL _ef;

        public FormRenta()
        {
            InitializeComponent();

            _ef = new VideoJuegosBL();
            this.tipoRentaBindingSource.DataSource = _ef.ObtenerTipoRenta();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var frm = new FormBuscarJuego();
            frm.formRenta = this;
            frm.ShowDialog();

            textBox1.Tag = ProductoId;
            textBox1.Text = ProductoDescripcion;
            textBox2.Text = ConsolaDescripcion;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var frm = new FormBuscarCliente();
            frm.formRenta = this;
            frm.ShowDialog();

            textBox5.Tag = ClienteId;
            textBox5.Text = ClienteNombre;
            textBox4.Text = ClienteTelefono;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

    }
}
