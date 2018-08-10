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
        List<ProductosRenta> listaProductosRenta;
        BindingSource source;

        public FormRenta()
        {
            InitializeComponent();

            _ef = new VideoJuegosBL();
            this.tipoRentaBindingSource.DataSource = _ef.ObtenerTipoRenta();

            listaProductosRenta = new List<ProductosRenta>();
            source = new BindingSource();
            source.DataSource = listaProductosRenta;
            ProductoDataGridView.DataSource = source;
        }

        private void FormRenta_Load(object sender, EventArgs e)
        {
            nuevo();
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

        private bool ValidarDatos()
        {
            int productoId;
            int.TryParse(textBox1.Tag.ToString(), out productoId);
            if (productoId == 0)
            {
                MessageBox.Show("Seleccione el producto");
                return false;
            }
            int tipoRentaId;
            int.TryParse(comboBox1.SelectedValue.ToString(), out tipoRentaId);
            if (tipoRentaId == 0)
            {
                MessageBox.Show("Seleccione el tipo de renta");
                return false;
            }
            int clienteId;
            int.TryParse(textBox5.Tag.ToString(), out clienteId);
            if (clienteId == 0)
            {
                MessageBox.Show("Seleccione el cliente");
                return false;
            }
            return true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (ValidarDatos() == false) return;

            var productoId = int.Parse(textBox1.Tag.ToString());
            var productoYaFueAgregado = listaProductosRenta.FirstOrDefault((productoRenta) => productoRenta.Id == productoId);

            if (productoYaFueAgregado == null)
            {
                var nuevoProductoRenta = new ProductosRenta()
                {
                    Id = productoId,
                    ProductoDescripcion = textBox1.Text,
                    ConsolaDescripcion = textBox2.Text,
                    Fecha = dateTimePicker1.Value,
                    TipoRentaId = int.Parse(comboBox1.SelectedValue.ToString()),
                    TipoRentaDescripcion = comboBox1.Text,
                    Precio = decimal.Parse(textBox3.Text),
                    ClienteId = int.Parse(textBox5.Tag.ToString()),
                    ClienteNombre = textBox5.Text,
                    TipoMovimiento = comboBox2.Text
                };

                listaProductosRenta.Add(nuevoProductoRenta);
                source.ResetBindings(false);

                textBox1.Tag = "";
                textBox1.Clear();
                textBox2.Clear();
            }
            else
            {
                MessageBox.Show("El producto ya fue agregado");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (ProductoDataGridView.CurrentRow != null)
            {
                var fila = ProductoDataGridView.Rows[ProductoDataGridView.CurrentRow.Index];
                var productoId = int.Parse(fila.Cells[0].Value.ToString());
                var producto = listaProductosRenta.FirstOrDefault((productoRenta) => productoRenta.Id == productoId);

                if (producto != null)
                {
                    listaProductosRenta.Remove(producto);
                    source.ResetBindings(false);
                }
            }
        }

        private void nuevo()
        {
            textBox1.Tag = "";
            textBox1.Clear();
            textBox2.Clear();
            textBox4.Clear();
            textBox5.Tag = "";
            textBox5.Clear();
            listaProductosRenta.Clear();
            source.ResetBindings(false);
            comboBox2.SelectedIndex = 0;
            dateTimePicker1.Value = DateTime.Today.Date;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            nuevo();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listaProductosRenta.Count() > 0)
            {
                if (_ef.GuardarRenta(listaProductosRenta))
                {
                    MessageBox.Show("Los datos fueron guardados");
                    nuevo();
                }
                else
                {
                    MessageBox.Show("Ocurrio un error, contacte al administrador");
                }
            }
            else
            {
                MessageBox.Show("Ingrese productos para rentar");
            }
        }

    }
}
