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
    public partial class CatManager : Form
    {
        String name, id, des;
        public CatManager()
        {
            InitializeComponent();
        }

        private void CatManager_Load(object sender, EventArgs e)
        {
            BDop db = new BDop();
            db.ShowCats(catsDV);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            BDop db = new BDop();

            if (String.IsNullOrEmpty(catnTB.Text) && String.IsNullOrEmpty(catdesTB.Text))
            {
                MessageBox.Show("DEBE ESPECIFICAR UN NOMBRE Y UNA DESCRIPCIÓN");
            }
            else if (String.IsNullOrEmpty(catdesTB.Text))
            {
                MessageBox.Show("DEBE ESPECIFICAR UNA DESCRIPCIÓN");
            } else if (String.IsNullOrEmpty(catnTB.Text))
            {
                MessageBox.Show("DEBE ESPECIFICAR UN NOMBRE");
            }
            else
            {
                db.updateCats(catnTB.Text, id, catdesTB.Text);
            }

            db.ShowCats(catsDV);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            AddCat addCat = new AddCat();
            addCat.ShowDialog();
            BDop db = new BDop();
            db.ShowCats(catsDV);

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            BDop db = new BDop();
           

            if (String.IsNullOrEmpty(id))
            {
                MessageBox.Show("DEBE SELECCIONAR UNA CATEGORÍA PARA ELIMINARLA");
            }
            else
            {
                db.deleteCats(name, id);
            }
        }

        private void catsDV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int get = e.RowIndex;
            DataGridViewRow rows = catsDV.Rows[get];
            name = rows.Cells[1].Value.ToString();
            id = rows.Cells[0].Value.ToString();
            des = rows.Cells[2].Value.ToString();

            catnTB.Text = name;
            catdesTB.Text = des;
        }
    }
}
