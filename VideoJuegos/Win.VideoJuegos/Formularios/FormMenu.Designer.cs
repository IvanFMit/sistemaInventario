namespace Win.VideoJuegos
{
    partial class FormMenuPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenuPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consolasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosPorConsolaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rentarVideoJuegosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.invToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administraciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetearContraseñaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteProductoXConsolaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeRentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesDeDevolucionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajusteDeInventariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeSalidasXAjusteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeEntradasXAjusteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Salmon;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.rentaToolStripMenuItem,
            this.administraciónToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.cerrarSesiónToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productosToolStripMenuItem,
            this.categoriaToolStripMenuItem,
            this.consolasToolStripMenuItem,
            this.productosPorConsolaToolStripMenuItem,
            this.ajusteDeInventariosToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.archivoToolStripMenuItem.Text = "Inventarios";
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.productosToolStripMenuItem.Text = "Productos";
            this.productosToolStripMenuItem.Click += new System.EventHandler(this.productosToolStripMenuItem_Click);
            // 
            // categoriaToolStripMenuItem
            // 
            this.categoriaToolStripMenuItem.Name = "categoriaToolStripMenuItem";
            this.categoriaToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.categoriaToolStripMenuItem.Text = "Categoria";
            this.categoriaToolStripMenuItem.Click += new System.EventHandler(this.categoriaToolStripMenuItem_Click);
            // 
            // consolasToolStripMenuItem
            // 
            this.consolasToolStripMenuItem.Name = "consolasToolStripMenuItem";
            this.consolasToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.consolasToolStripMenuItem.Text = "Consolas";
            this.consolasToolStripMenuItem.Click += new System.EventHandler(this.consolasToolStripMenuItem_Click);
            // 
            // productosPorConsolaToolStripMenuItem
            // 
            this.productosPorConsolaToolStripMenuItem.Name = "productosPorConsolaToolStripMenuItem";
            this.productosPorConsolaToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.productosPorConsolaToolStripMenuItem.Text = "Productos por Consola";
            this.productosPorConsolaToolStripMenuItem.Click += new System.EventHandler(this.productosPorConsolaToolStripMenuItem_Click);
            // 
            // rentaToolStripMenuItem
            // 
            this.rentaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rentarVideoJuegosToolStripMenuItem,
            this.invToolStripMenuItem});
            this.rentaToolStripMenuItem.Name = "rentaToolStripMenuItem";
            this.rentaToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.rentaToolStripMenuItem.Text = "Renta";
            // 
            // rentarVideoJuegosToolStripMenuItem
            // 
            this.rentarVideoJuegosToolStripMenuItem.Name = "rentarVideoJuegosToolStripMenuItem";
            this.rentarVideoJuegosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.rentarVideoJuegosToolStripMenuItem.Text = "Rentar Video Juegos";
            this.rentarVideoJuegosToolStripMenuItem.Click += new System.EventHandler(this.rentarVideoJuegosToolStripMenuItem_Click);
            // 
            // invToolStripMenuItem
            // 
            this.invToolStripMenuItem.Name = "invToolStripMenuItem";
            this.invToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.invToolStripMenuItem.Text = "Clientes";
            this.invToolStripMenuItem.Click += new System.EventHandler(this.invToolStripMenuItem_Click);
            // 
            // administraciónToolStripMenuItem
            // 
            this.administraciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuariosToolStripMenuItem});
            this.administraciónToolStripMenuItem.Name = "administraciónToolStripMenuItem";
            this.administraciónToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.administraciónToolStripMenuItem.Text = "Administración";
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearUsuarioToolStripMenuItem,
            this.resetearContraseñaToolStripMenuItem});
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            // 
            // crearUsuarioToolStripMenuItem
            // 
            this.crearUsuarioToolStripMenuItem.Name = "crearUsuarioToolStripMenuItem";
            this.crearUsuarioToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.crearUsuarioToolStripMenuItem.Text = "Crear Usuario";
            this.crearUsuarioToolStripMenuItem.Click += new System.EventHandler(this.crearUsuarioToolStripMenuItem_Click);
            // 
            // resetearContraseñaToolStripMenuItem
            // 
            this.resetearContraseñaToolStripMenuItem.Name = "resetearContraseñaToolStripMenuItem";
            this.resetearContraseñaToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.resetearContraseñaToolStripMenuItem.Text = "Resetear Contraseña";
            this.resetearContraseñaToolStripMenuItem.Click += new System.EventHandler(this.resetearContraseñaToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reporteDeClientesToolStripMenuItem,
            this.reporteProductoXConsolaToolStripMenuItem,
            this.reporteDeRentasToolStripMenuItem,
            this.reportesDeDevolucionesToolStripMenuItem,
            this.reporteDeSalidasXAjusteToolStripMenuItem,
            this.reporteDeEntradasXAjusteToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // reporteDeClientesToolStripMenuItem
            // 
            this.reporteDeClientesToolStripMenuItem.Name = "reporteDeClientesToolStripMenuItem";
            this.reporteDeClientesToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.reporteDeClientesToolStripMenuItem.Text = "Reporte de Clientes";
            this.reporteDeClientesToolStripMenuItem.Click += new System.EventHandler(this.reporteDeClientesToolStripMenuItem_Click);
            // 
            // reporteProductoXConsolaToolStripMenuItem
            // 
            this.reporteProductoXConsolaToolStripMenuItem.Name = "reporteProductoXConsolaToolStripMenuItem";
            this.reporteProductoXConsolaToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.reporteProductoXConsolaToolStripMenuItem.Text = "Reporte Producto x Consola";
            this.reporteProductoXConsolaToolStripMenuItem.Click += new System.EventHandler(this.reporteProductoXConsolaToolStripMenuItem_Click);
            // 
            // reporteDeRentasToolStripMenuItem
            // 
            this.reporteDeRentasToolStripMenuItem.Name = "reporteDeRentasToolStripMenuItem";
            this.reporteDeRentasToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.reporteDeRentasToolStripMenuItem.Text = "Reporte de Rentas";
            this.reporteDeRentasToolStripMenuItem.Click += new System.EventHandler(this.reporteDeRentasToolStripMenuItem_Click);
            // 
            // reportesDeDevolucionesToolStripMenuItem
            // 
            this.reportesDeDevolucionesToolStripMenuItem.Name = "reportesDeDevolucionesToolStripMenuItem";
            this.reportesDeDevolucionesToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.reportesDeDevolucionesToolStripMenuItem.Text = "Reportes de Devoluciones";
            this.reportesDeDevolucionesToolStripMenuItem.Click += new System.EventHandler(this.reportesDeDevolucionesToolStripMenuItem_Click);
            // 
            // cerrarSesiónToolStripMenuItem
            // 
            this.cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
            this.cerrarSesiónToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.cerrarSesiónToolStripMenuItem.Text = "Cerrar Sesión";
            this.cerrarSesiónToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesiónToolStripMenuItem_Click);
            // 
            // ajusteDeInventariosToolStripMenuItem
            // 
            this.ajusteDeInventariosToolStripMenuItem.Name = "ajusteDeInventariosToolStripMenuItem";
            this.ajusteDeInventariosToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.ajusteDeInventariosToolStripMenuItem.Text = "Ajuste de Inventarios";
            this.ajusteDeInventariosToolStripMenuItem.Click += new System.EventHandler(this.ajusteDeInventariosToolStripMenuItem_Click);
            // 
            // reporteDeSalidasXAjusteToolStripMenuItem
            // 
            this.reporteDeSalidasXAjusteToolStripMenuItem.Name = "reporteDeSalidasXAjusteToolStripMenuItem";
            this.reporteDeSalidasXAjusteToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.reporteDeSalidasXAjusteToolStripMenuItem.Text = "Reporte de Salidas x Ajuste";
            this.reporteDeSalidasXAjusteToolStripMenuItem.Click += new System.EventHandler(this.reporteDeSalidasXAjusteToolStripMenuItem_Click);
            // 
            // reporteDeEntradasXAjusteToolStripMenuItem
            // 
            this.reporteDeEntradasXAjusteToolStripMenuItem.Name = "reporteDeEntradasXAjusteToolStripMenuItem";
            this.reporteDeEntradasXAjusteToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.reporteDeEntradasXAjusteToolStripMenuItem.Text = "Reporte de Entradas x Ajuste";
            this.reporteDeEntradasXAjusteToolStripMenuItem.Click += new System.EventHandler(this.reporteDeEntradasXAjusteToolStripMenuItem_Click);
            // 
            // FormMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Win.VideoJuegos.Properties.Resources.fondoMenu;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 504);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMenuPrincipal";
            this.Text = "Renta de Video Juegos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consolasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rentarVideoJuegosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administraciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetearContraseñaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDeClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteProductoXConsolaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDeRentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesDeDevolucionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosPorConsolaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem invToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajusteDeInventariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDeSalidasXAjusteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDeEntradasXAjusteToolStripMenuItem;
    }
}

