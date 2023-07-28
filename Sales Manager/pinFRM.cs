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
    public partial class pinFRM2 : Form
    {
        public pinFRM2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String uname = pinTB.Text.Trim();
            BDop op = new BDop();
            op.LogPIN(uname);
            Dashboard das = new Dashboard();

            if (op.confPIN == true)
            {
                FormExchange ex = new FormExchange();
                ex.adminconf = "v";
                MessageBox.Show("PERMISOS ACTUALIZADOS");
                das.listdash.Add(ex);
            }
            this.Hide();
            das.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
