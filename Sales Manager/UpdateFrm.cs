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
    public partial class UpdateFrm : Form
    {
        String id, name, cat;
        decimal price;
        int uni;

        public UpdateFrm()
        {
            InitializeComponent();
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BDop db=new BDop();
            name = unomTF.Text;
            cat = ucatCB.Text;
            uni = int.Parse(uuniCot.Value.ToString());
            price = pridown.Value;
            db.updateProds(id,name,cat,uni,price);
            UpdateFrm_Load(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddCat add = new AddCat();
            this.Hide();
            add.ShowDialog();
            this.Show();

        }

        private void UpdateFrm_Shown(object sender, EventArgs e)
        {
           
        }

        private void UpdateFrm_Load(object sender, EventArgs e)
        {
            BDop db = new BDop();
            db.CatFill(ucatCB);
            db.ShowProducts(upDV);
        }

        private void upDV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int get = e.RowIndex;
            DataGridViewRow rows = upDV.Rows[get];
            name = rows.Cells[0].Value.ToString();
            id = rows.Cells[1].Value.ToString();
            cat = rows.Cells[2].Value.ToString();
            uni = int.Parse(rows.Cells[3].Value.ToString());
            price =(decimal)rows.Cells[4].Value;

            
            unomTF.Text = name;
            uuniCot.Value = uni;
            pridown.Value = price;
        }
    }
}
