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
    public partial class AddCat : Form
    {
        public AddCat()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BDop bDop = new BDop();
            bDop.AddCat(ncatTB.Text, dcatTB.Text);
            this.Close();
        }
    }
}
