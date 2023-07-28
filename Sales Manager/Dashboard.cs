using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sales_Manager
{
    public partial class Dashboard : Form
    {
        public List<FormExchange> listdash = new List<FormExchange>();
        public Dashboard()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cerrarSessionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 log = new Form1();
            log.ShowDialog();
        }

        private void añadirProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductsForm products = new ProductsForm();
            products.MdiParent = this;
            products.Show();
            
            
        }

        private void nuevaVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VentasFrm venta = new VentasFrm();
            venta.MdiParent = this;
            venta.Show();
        }

        private void administrarInventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InventarioFrm inventario= new InventarioFrm();
            inventario.MdiParent = this;
            inventario.Show();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            Admin();
        }

        private void administrarCategoríasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CatManager cat= new CatManager();
            cat.MdiParent = this;
            cat.Show();
        }

        private void historialDeVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HistoryFrm his= new HistoryFrm();
            his.MdiParent= this;
            his.Show();
        }

        private void infoDelDesarrolladorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Desarrollado con <3 por ThCh! :)");
        }

        private void desactivarControlTotalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hisTS.Enabled = false;
            invTS.Enabled = false;
            addTS.Enabled = false;
            consultarVentasPorDíaToolStripMenuItem.Enabled= false;
            catsTS.Enabled = false;
        }

        private void activarControlTotalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pinFRM2 adminFrm = new pinFRM2();
            this.Hide();
            adminFrm.ShowDialog();
       
        }

        private void Admin()
        {
            foreach (var exc in listdash)
            {
                if (exc.adminconf=="v")
                {
                    hisTS.Enabled = true;
                    invTS.Enabled = true;
                    addTS.Enabled = true;
                    catsTS.Enabled = true;
                    consultarVentasPorDíaToolStripMenuItem.Enabled = true;
                }
                else
                {
                    hisTS.Enabled = false;
                    invTS.Enabled = false;
                    addTS.Enabled = false;
                    catsTS.Enabled = false;
                    consultarVentasPorDíaToolStripMenuItem.Enabled = false;
                }
                
            }
        }

        private void consultarVentasPorDíaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DailyFrm dailyFrm = new DailyFrm();
            dailyFrm.MdiParent= this;
            dailyFrm.Show();
        }
    }
}
