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
    public partial class FormresetearContrasena : Form
    {

        VideoJuegosBL _ef;

        public FormresetearContrasena()
        {
            _ef = new VideoJuegosBL();
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var usuarioExiste = _ef.existeUsuario(textBoxUsuario.Text.TrimEnd());

            if (usuarioExiste)
            {
             var llamado =_ef.resetearContrasena(textBoxUsuario.Text.TrimEnd());

             var resultado = new Tuple<bool, string>(llamado.Item1, llamado.Item2);
             if (resultado.Item1 == true)
             {
                 MessageBox.Show("Contraseña reseteada correctamente \nLa Contaseña Es: " + resultado.Item2, "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 this.Close();
             }
             else
             {
                 MessageBox.Show("Ocurrio Un Error: " + resultado.Item2, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                 this.Close();
             }
              
              
            }
            else
            {
                MessageBox.Show("Usuario no existe");
            }
        }
    }
}
