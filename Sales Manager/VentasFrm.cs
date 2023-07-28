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
    public partial class VentasFrm : Form
    {
        dynamic input;
        string nom, id,dnom,did,fech;
        int can, uni, dcan,duni;
        decimal price,dprice;
        DataGridViewRow row=null, sen;
       
        public VentasFrm()
        {
            InitializeComponent();

            BDop db = new BDop();
            db.ShowProducts(ventGV);
            DateTime localDate = DateTime.Now;
            fech = localDate.ToString("yyyy-MM-dd");
            
            if (db.daySolds(fech) == "RD$NULL")
            {
                dayTB.Text = "RD$0";
            }

            dayTB.Text = db.daySolds(fech);

        }



        private void button1_Click(object sender, EventArgs e)
        {
            input = svTB.Text;
            BDop db = new BDop();
            db.SearchProducts(input, ventGV);
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (desUP.Value > 0)
            {
                decimal h= desUP.Value / 100;
                price = price-h;

            }

            can = Convert.ToInt32(canUp.Value);
            BDop db = new BDop();
            db.decreStock(id,can);
            db.ShowProducts(ventGV);
            if (can > 0 && can <= uni)
            {
                carGVi.Rows.Add(nom,id, price, can, can * price);
                

            } else if (can <= 0)
            {
                MessageBox.Show("CANTIDAD INVÁLIDA: DEBE ESPECIFICAR UNA CANTIDAD MAYOR QUE 0");

            } else if (can > uni && uni ==0 || uni == null && String.IsNullOrEmpty(nom))
            {
                MessageBox.Show("DEBE SELECCIONAR UN PRODUCTO ANTES DE AÑADIRLO AL CARRITO");

            }else if(can > uni)
            {
                MessageBox.Show("CANTIDAD INVÁLIDA: NO PUEDE VENDER MAS DE LO QUE TIENE EN INVENTARIO");
            }
            ventGV.ClearSelection();

        }

        private void svTB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }

      

        private void button5_Click(object sender, EventArgs e)
        {
            
            FacturarFrm fac = new FacturarFrm();
            foreach (DataGridViewRow r in carGVi.Rows)
            {
                FormExchange ex = new FormExchange();
                ex.producto= r.Cells[0].Value.ToString();
                ex.eid = r.Cells[1].Value.ToString();
                ex.precio = r.Cells[2].Value.ToString();
                ex.cantidad = r.Cells[3].Value.ToString();
                ex.total = r.Cells[4].Value.ToString();
                fac.list.Add(ex);
            }
            
            fac.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(row ==null)
            {
                MessageBox.Show("DEBE SELECCIONAR UN PRODUCTO PARA ELIMINARLO DEL CARRITO");
            }
            else
            {
                BDop bd = new BDop();
                carGVi.Rows.RemoveAt(row.Index);
                bd.rolldecreStock(did, duni);
                bd.ShowProducts(ventGV);
            }
            carGVi.ClearSelection();
        }

        private void carGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int get = e.RowIndex;
             row = carGVi.Rows[get];
            dnom = row.Cells[0].Value.ToString();
            did = row.Cells[1].Value.ToString();
            dprice = decimal.Parse(row.Cells[2].Value.ToString());
            duni = int.Parse(row.Cells[3].Value.ToString());
            

        }

        private void svTB_TextChanged(object sender, EventArgs e)
        {
            BDop db = new BDop();
            db.ShowProducts(ventGV);
        }

        private void carGV_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            
        }

        private void carGV_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string i;
            int c;

            foreach (DataGridViewRow r in carGVi.Rows)
            {
                i = r.Cells[1].Value.ToString();
                c = int.Parse(r.Cells[3].Value.ToString());

                BDop db = new BDop();
                db.rolldecreStock(i, c);
            } 

            BDop dbe = new BDop();
            dbe.ShowProducts(ventGV);   
            carGVi.Rows.Clear();
        }

        private void ventGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int get = e.RowIndex;
            DataGridViewRow rows = ventGV.Rows[get];
            nom = rows.Cells[0].Value.ToString();
            id = rows.Cells[1].Value.ToString();
            price = decimal.Parse(rows.Cells[4].Value.ToString());
            uni = int.Parse(rows.Cells[3].Value.ToString());
        }

       
    }

    

    
}
