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
    public partial class HistoryFrm : Form
    {
        string id, fecha, name, total;
        dynamic search;
        public HistoryFrm()
        {
            InitializeComponent();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            BDop db = new BDop();
            if (String.IsNullOrEmpty(id))
            {
                MessageBox.Show("DEBE SELECCIONAR UNA FACTURA PARA ELIMINARLA");
            }
            else
            {
                db.delFacts(id);
            }

            db.showFac(hisDV);
            id = null;
            hisDV.ClearSelection();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            updateFactFrm pu = new updateFactFrm();
            pu.ShowDialog();
            BDop db = new BDop();
            db.showFac(hisDV);
        }

        private void searchTS_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                toolStripButton4_Click(sender, e);
            }
        }

        private void HistoryFrm_Load(object sender, EventArgs e)
        {
            BDop db = new BDop();
            db.showFac(hisDV);
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            search = searchTS.Text;
            BDop db = new BDop();
            db.searFacts(hisDV, search);
        }

        private void hisDV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int get = e.RowIndex;
            DataGridViewRow rows = hisDV.Rows[get];
            id = rows.Cells[0].Value.ToString();
            name = rows.Cells[1].Value.ToString();
            fecha = rows.Cells[2].Value.ToString();
            total = rows.Cells[3].Value.ToString();
            
        }
    }
}
