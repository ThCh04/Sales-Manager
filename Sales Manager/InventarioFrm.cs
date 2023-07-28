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
    
    public partial class InventarioFrm : Form 
    {
       
        dynamic search="";
        public String id,name,cat, price;
        public int uni;
        public InventarioFrm()
        {
            InitializeComponent();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            BDop bd = new BDop();
            bd.ShowProducts(invDV);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ProductsForm products= new ProductsForm();
            products.ShowDialog();
            toolStripButton5_Click(sender, e);

        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            search = searchTS.Text;
            BDop db = new BDop();
            db.SearchProducts(search, invDV);
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {

            BDop db = new BDop();
            if (String.IsNullOrEmpty(id))
            {
                MessageBox.Show("DEBE SELECCIONAR UN PRODUCTO PARA ELIMINARLO");
            }
            else
            {
                db.DeleteProducts(id, name);
            }
            
            toolStripButton5_Click(sender, e);
            id = null;
            invDV.ClearSelection();


        }

        private void searchTS_TextChanged(object sender, EventArgs e)
        {
            BDop bd = new BDop();
            bd.ShowProducts(invDV);
           
        }

        private void InventarioFrm_Load(object sender, EventArgs e)
        {

        }

        private void invDV_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int get = e.RowIndex;
            DataGridViewRow rows = invDV.Rows[get];
            name = rows.Cells[0].Value.ToString();
            id = rows.Cells[1].Value.ToString();
            cat = rows.Cells[2].Value.ToString();
            uni = int.Parse(rows.Cells[3].Value.ToString());
            price = rows.Cells[4].Value.ToString();
        }

        private void InventarioFrm_Shown(object sender, EventArgs e)
        {
            BDop bd = new BDop();
            bd.ShowProducts(invDV);
            rdcashLB.Text = bd.getTotal();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            UpdateFrm up = new UpdateFrm();
            up.ShowDialog();
            toolStripButton5_Click(sender, e);

        }

      
       


    }
}
