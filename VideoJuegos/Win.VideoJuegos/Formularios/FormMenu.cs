using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Win.VideoJuegos.Formularios;

namespace Win.VideoJuegos
{
    public partial class FormMenuPrincipal : Form
    {
        public static string NombreUsuario;
        public FormMenuPrincipal()
        {
            InitializeComponent();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FormProducto();
            frm.MdiParent = this;
            frm.Show();
        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FormCategoria();
            frm.MdiParent = this;
            frm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var frm = new FormLogin();
            frm.ShowDialog(); 
        }

        private void consolasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FormConsolas();
            frm.MdiParent = this;
            frm.Show();
        }

        private void crearUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FormCrearUsuario();
            frm.ShowDialog(); 
        }

        private void resetearContraseñaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FormresetearContrasena();
            frm.ShowDialog(); 
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var pregunta = MessageBox.Show("¿Está seguro que desea salir?", "Cerrar Sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (pregunta == DialogResult.Yes)
            {
                for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
                {
                    if (Application.OpenForms[i].Name != "FormMenuPrincipal")
                    {
                        Application.OpenForms[i].Close();
                    }
                }
                var frm = new FormLogin();
                var resultado = frm.ShowDialog();
            }
            
        }


        private void rentarVideoJuegosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FormRenta();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
