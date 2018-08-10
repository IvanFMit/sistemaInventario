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
    public partial class FormInv: Form
    {

        public int ProductoId { get; set; }
        public string ProductoDescripcion { get; set; }
        public string ConsolaDescripcion { get; set; }

        public int ClienteId { get; set; }
        public string ClienteNombre { get; set; }
        public string ClienteTelefono { get; set; }

        VideoJuegosBL _ef;
        List<ProductosRenta> listaProductosRenta2;
        BindingSource source;

        public FormInv()
        {
            InitializeComponent();

            _ef = new VideoJuegosBL();
            this.tipoRentaBindingSource.DataSource = _ef.ObtenerTipoRenta();

            listaProductosRenta2 = new List<ProductosRenta>();
            source = new BindingSource();
            source.DataSource = listaProductosRenta2;
            ProductoDataGridView.DataSource = source;
        }

        private void FormRenta_Load(object sender, EventArgs e)
        {
            nuevo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var frm = new FormBuscarJuego2();
            frm.formRenta = this;
            frm.ShowDialog();

            textBox1.Tag = ProductoId;
            textBox1.Text = ProductoDescripcion;
            textBox2.Text = ConsolaDescripcion;
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
            
            
            return true;
        }

     

        private void button6_Click(object sender, EventArgs e)
        {
            if (ProductoDataGridView.CurrentRow != null)
            {
                var fila = ProductoDataGridView.Rows[ProductoDataGridView.CurrentRow.Index];
                var productoId = int.Parse(fila.Cells[0].Value.ToString());
                var producto = listaProductosRenta2.FirstOrDefault((productoRenta) => productoRenta.Id == productoId);

                if (producto != null)
                {
                    listaProductosRenta2.Remove(producto);
                    source.ResetBindings(false);
                }
            }
        }

        private void nuevo()
        {
            textBox1.Tag = "";
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            listaProductosRenta2.Clear();
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
            if (listaProductosRenta2.Count() > 0)
            {
                if (_ef.GuardarInv(listaProductosRenta2))
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ValidarDatos() == false) return;

            var productoId = int.Parse(textBox1.Tag.ToString());
            var productoYaFueAgregado = listaProductosRenta2.FirstOrDefault((productoRenta) => productoRenta.Id == productoId);

            if (productoYaFueAgregado == null)
            {
                var nuevoProductoRenta = new ProductosRenta()
                {
                    Id = productoId,
                    ProductoDescripcion = textBox1.Text,
                    ConsolaDescripcion = textBox2.Text,
                    Fecha = dateTimePicker1.Value,
                    TipoMovimiento = comboBox2.Text,
                    cantidad = int.Parse(textBox3.Text.ToString()),

             
                  
                    TipoRentaId = 1,
                    TipoRentaDescripcion = "3 Dias",
                    Precio = decimal.Parse("60.00"),
                    ClienteId = 2,
                    ClienteNombre = "Juan Perez",
               
                };

                listaProductosRenta2.Add(nuevoProductoRenta);
                source.ResetBindings(false);

                textBox1.Tag = "";
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
            }
            else
            {
                MessageBox.Show("El producto ya fue agregado");
            }
        }
    }
}
