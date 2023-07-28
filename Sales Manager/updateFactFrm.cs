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
    public partial class updateFactFrm : Form
    {
        string id, fecha, name, total;

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(id))
            {
                MessageBox.Show("DEBE SELECCIONAR UNA FACTURA PARA EDITARLA");
            }
            else
            {
                name = cliTF.Text;
                fecha = fafeTF.Text;
                total = facUP.Value.ToString();
                BDop db = new BDop();
                db.upFacts(name,fecha,total,id);
                db.showFac(ufactDV);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void updateFactFrm_Load(object sender, EventArgs e)
        {
            BDop dop = new BDop();
            dop.showFac(ufactDV);
        }

        public updateFactFrm()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int get = e.RowIndex;
            DataGridViewRow rows = ufactDV.Rows[get];
            id = rows.Cells[0].Value.ToString();
            name = rows.Cells[1].Value.ToString();
            fecha = rows.Cells[2].Value.ToString();
            total = rows.Cells[3].Value.ToString();

            cliTF.Text = name;
            facUP.Value= decimal.Parse(total);
            fafeTF.Text = fecha;
        }
    }
}
