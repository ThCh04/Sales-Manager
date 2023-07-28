namespace Sales_Manager
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.permisoDeAdministradorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.activarControlTotalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desactivarControlTotalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.venderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaVentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hisTS = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarVentasPorDíaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.invTS = new System.Windows.Forms.ToolStripMenuItem();
            this.addTS = new System.Windows.Forms.ToolStripMenuItem();
            this.catsTS = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoDelDesarrolladorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSessionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.MistyRose;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.permisoDeAdministradorToolStripMenuItem,
            this.venderToolStripMenuItem,
            this.productosToolStripMenuItem,
            this.acercaDeToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // permisoDeAdministradorToolStripMenuItem
            // 
            this.permisoDeAdministradorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.activarControlTotalToolStripMenuItem,
            this.desactivarControlTotalToolStripMenuItem});
            this.permisoDeAdministradorToolStripMenuItem.Name = "permisoDeAdministradorToolStripMenuItem";
            this.permisoDeAdministradorToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.permisoDeAdministradorToolStripMenuItem.Text = "Administrador";
            // 
            // activarControlTotalToolStripMenuItem
            // 
            this.activarControlTotalToolStripMenuItem.Name = "activarControlTotalToolStripMenuItem";
            this.activarControlTotalToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.activarControlTotalToolStripMenuItem.Text = "Activar Control Total";
            this.activarControlTotalToolStripMenuItem.Click += new System.EventHandler(this.activarControlTotalToolStripMenuItem_Click);
            // 
            // desactivarControlTotalToolStripMenuItem
            // 
            this.desactivarControlTotalToolStripMenuItem.Name = "desactivarControlTotalToolStripMenuItem";
            this.desactivarControlTotalToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.desactivarControlTotalToolStripMenuItem.Text = "Desactivar Control Total";
            this.desactivarControlTotalToolStripMenuItem.Click += new System.EventHandler(this.desactivarControlTotalToolStripMenuItem_Click);
            // 
            // venderToolStripMenuItem
            // 
            this.venderToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevaVentaToolStripMenuItem,
            this.hisTS,
            this.consultarVentasPorDíaToolStripMenuItem});
            this.venderToolStripMenuItem.Name = "venderToolStripMenuItem";
            this.venderToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.venderToolStripMenuItem.Text = "Vender";
            // 
            // nuevaVentaToolStripMenuItem
            // 
            this.nuevaVentaToolStripMenuItem.Name = "nuevaVentaToolStripMenuItem";
            this.nuevaVentaToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.nuevaVentaToolStripMenuItem.Text = "Nueva Venta";
            this.nuevaVentaToolStripMenuItem.Click += new System.EventHandler(this.nuevaVentaToolStripMenuItem_Click);
            // 
            // hisTS
            // 
            this.hisTS.Enabled = false;
            this.hisTS.Name = "hisTS";
            this.hisTS.Size = new System.Drawing.Size(203, 22);
            this.hisTS.Text = "Historial de Ventas";
            this.hisTS.Click += new System.EventHandler(this.historialDeVentasToolStripMenuItem_Click);
            // 
            // consultarVentasPorDíaToolStripMenuItem
            // 
            this.consultarVentasPorDíaToolStripMenuItem.Enabled = false;
            this.consultarVentasPorDíaToolStripMenuItem.Name = "consultarVentasPorDíaToolStripMenuItem";
            this.consultarVentasPorDíaToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.consultarVentasPorDíaToolStripMenuItem.Text = "Consultar Ventas por Día";
            this.consultarVentasPorDíaToolStripMenuItem.Click += new System.EventHandler(this.consultarVentasPorDíaToolStripMenuItem_Click);
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.invTS,
            this.addTS,
            this.catsTS});
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.productosToolStripMenuItem.Text = "Productos";
            // 
            // invTS
            // 
            this.invTS.Enabled = false;
            this.invTS.Name = "invTS";
            this.invTS.Size = new System.Drawing.Size(195, 22);
            this.invTS.Text = "Ver Inventario ";
            this.invTS.Click += new System.EventHandler(this.administrarInventarioToolStripMenuItem_Click);
            // 
            // addTS
            // 
            this.addTS.Enabled = false;
            this.addTS.Name = "addTS";
            this.addTS.Size = new System.Drawing.Size(195, 22);
            this.addTS.Text = "Añadir Producto";
            this.addTS.Click += new System.EventHandler(this.añadirProductoToolStripMenuItem_Click);
            // 
            // catsTS
            // 
            this.catsTS.Enabled = false;
            this.catsTS.Name = "catsTS";
            this.catsTS.Size = new System.Drawing.Size(195, 22);
            this.catsTS.Text = "Administrar Categorías";
            this.catsTS.Click += new System.EventHandler(this.administrarCategoríasToolStripMenuItem_Click);
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoDelDesarrolladorToolStripMenuItem});
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            // 
            // infoDelDesarrolladorToolStripMenuItem
            // 
            this.infoDelDesarrolladorToolStripMenuItem.Name = "infoDelDesarrolladorToolStripMenuItem";
            this.infoDelDesarrolladorToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.infoDelDesarrolladorToolStripMenuItem.Text = "Info. del Desarrollador";
            this.infoDelDesarrolladorToolStripMenuItem.Click += new System.EventHandler(this.infoDelDesarrolladorToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarSessionToolStripMenuItem,
            this.salirToolStripMenuItem1});
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.salirToolStripMenuItem.Text = "Sesión";
            // 
            // cerrarSessionToolStripMenuItem
            // 
            this.cerrarSessionToolStripMenuItem.Name = "cerrarSessionToolStripMenuItem";
            this.cerrarSessionToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.cerrarSessionToolStripMenuItem.Text = "Cerrar Sesión";
            this.cerrarSessionToolStripMenuItem.Click += new System.EventHandler(this.cerrarSessionToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem1
            // 
            this.salirToolStripMenuItem1.Name = "salirToolStripMenuItem1";
            this.salirToolStripMenuItem1.Size = new System.Drawing.Size(143, 22);
            this.salirToolStripMenuItem1.Text = "Salir";
            this.salirToolStripMenuItem1.Click += new System.EventHandler(this.salirToolStripMenuItem1_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(800, 629);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem venderToolStripMenuItem;
        private ToolStripMenuItem productosToolStripMenuItem;
        private ToolStripMenuItem acercaDeToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem nuevaVentaToolStripMenuItem;
        private ToolStripMenuItem invTS;
        private ToolStripMenuItem infoDelDesarrolladorToolStripMenuItem;
        private ToolStripMenuItem cerrarSessionToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem1;
        private ToolStripMenuItem addTS;
        private ToolStripMenuItem catsTS;
        private ToolStripMenuItem hisTS;
        private ToolStripMenuItem permisoDeAdministradorToolStripMenuItem;
        private ToolStripMenuItem activarControlTotalToolStripMenuItem;
        private ToolStripMenuItem desactivarControlTotalToolStripMenuItem;
        private ToolStripMenuItem consultarVentasPorDíaToolStripMenuItem;
    }
}