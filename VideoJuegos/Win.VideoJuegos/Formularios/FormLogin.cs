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
using Win.VideoJuegos.Formularios;

namespace Win.VideoJuegos
{
    public partial class FormLogin : Form
    {
        VideoJuegosBL _ef;

        public FormLogin()
        {
            InitializeComponent();
            _ef = new VideoJuegosBL();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var usuario = textBox1.Text;
            var contrasena = textBox2.Text;
            var loginExitoso = _ef.Login(usuario, contrasena);

            if (loginExitoso)
            {
                FormMenuPrincipal.NombreUsuario = usuario;
                var verificarUsuario = _ef.debecambiarContrasena(usuario);
                if (verificarUsuario)
                {
                    var frm = new FormCambioContrasena();
                    frm.usuario = usuario;
                    frm.ShowDialog();
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrecta");
            }
        }
    }
}
