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
    public partial class FormCambioContrasena : Form
    {
        VideoJuegosBL _ef;
        public string usuario;
        
        public FormCambioContrasena()
        {
            _ef = new VideoJuegosBL();
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var nuevaContrasena1 = textBox1.Text;
            var nuevaContrasena2 = textBox2.Text;
            if (textBox1.Text.TrimEnd() != "")
            {
                if (nuevaContrasena1 == nuevaContrasena2)
                {
                    _ef.cambiarContrasena(this.usuario, nuevaContrasena1);
                    MessageBox.Show("Contraseña Actualizada", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Contraseña no son iguales, intente de nuevo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Contraseña vacía, intente de nuevo","Advertencia",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormCambioContrasena_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
