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

        private void reporteDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new CR_FR_Clientes();
            frm.MdiParent = this;
            frm.Show();
        }

        private void reporteProductoXConsolaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new CR_FR_ProductoC();
            frm.MdiParent = this;
            frm.Show();
        }

        private void reporteDeRentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new CR_FR_Renta();
            frm.MdiParent = this;
            frm.Show();
        }

        private void reportesDeDevolucionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new CR_FR_Devo();
            frm.MdiParent = this;
            frm.Show();
        }

     

        private void productosPorConsolaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FormProductoConsola();
            frm.MdiParent = this;
            frm.Show();
        }

        private void invToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FormClientes();
            frm.MdiParent = this;
            frm.Show();
        }

        private void ajusteDeInventariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FormInv();
            frm.MdiParent = this;
            frm.Show();
        }

        private void reporteDeSalidasXAjusteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new CR_FR_SAL();
            frm.MdiParent = this;
            frm.Show();
        }

        private void reporteDeEntradasXAjusteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new CR_FR_ENT();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
