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
    public partial class ProductsForm : Form
    {
        String nombre, categoria;
        int codigo, unidades;
        decimal prio;
        decimal ver=0, precio=0;



        private void nomTF_MouseClick(object sender, MouseEventArgs e)
        {
            nomTF.SelectAll();
            nomTF.Focus();
            nomTF.ForeColor = Color.Black;
        }





        private void button3_Click(object sender, EventArgs e)
        {
            AddCat cat = new AddCat();
            this.Hide();
            cat.ShowDialog();
            this.Show();
            ProductsForm_Load(sender, e);

        }

        private void ProductsForm_Load(object sender, EventArgs e)
        {
            BDop db = new BDop();
            db.CatFill(catCB);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public ProductsForm()
        {
            InitializeComponent();
        }





        private void button1_Click(object sender, EventArgs e)
        {
            String no = nomTF.Text.ToLower().Trim();

            if (no == "")
            {
                MessageBox.Show("DEBE ESPECIFICAR UN NOMBRE PARA EL PRODUCTO");
            }
            else
            {

                nombre = no;
            }


            if (catCB.SelectedIndex == -1)
            {
                MessageBox.Show("DEBE SELECCIONAR UNA CATEGORIA");
            }
            else
            {

                categoria = catCB.Text.ToLower().Trim();
            }


            ver =uniCot.Value;

            if (ver == 0)
            {
                MessageBox.Show("DEBE ESPECIFICAR UNA CANTIDAD DE UNIDADES PARA EL PRODUCTO");
            }
            else
            {
                unidades =Convert.ToInt32(ver);
            }
            precio = preUp.Value;

            if (precio <= 0)
            {
                MessageBox.Show("DEBE ESPECIFICAR UN PRECIO MAYOR A 0 PARA EL PRODUCTO");
            }
            else
            {
                prio = precio;
            }

            

            BDop bd = new BDop();
            bd.addProducts(nombre, categoria, unidades, prio);

        }
    }
}
