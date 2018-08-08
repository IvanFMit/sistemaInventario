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
    public partial class FormCrearUsuario : Form
    {
        VideoJuegosBL _ef;
        public FormCrearUsuario()
        {
            InitializeComponent();
            _ef = new VideoJuegosBL();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Tuple<bool, string> resultado;
            if (textBox1.Text == "" && textBox2.Text == "" && textBox3.Text == "")
            {
                MessageBox.Show("Todos los campos son requeridos \nLlena correctamente los campos vacíos: ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var llamado = _ef.CrearUsuario(textBox1.Text.TrimEnd(), textBox2.Text.TrimEnd(), textBox3.Text.TrimEnd());
                resultado = new Tuple<bool, string>(llamado.Item1, llamado.Item2);
                if (resultado.Item1 == true)
                {
                    MessageBox.Show("Se Creo El Usuario Exitosamente \nLa Contraseña Es: " + resultado.Item2, "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Ocurrio Un Error: " + resultado.Item2, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Close();
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
