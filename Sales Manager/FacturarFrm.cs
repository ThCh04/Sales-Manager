using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sales_Manager
{
    public partial class FacturarFrm : Form
    {
        public List<FormExchange> list = new List<FormExchange>();
       
        DateTime localDate = DateTime.Now;
        public String nclient, date, toy,idt,v;
       
        public FacturarFrm()
        {
           
            InitializeComponent();
            

        }

        private void FacturarFrm_Load(object sender, EventArgs e)
        {
            foreach (var exchange in list)
            {
                preFactDV.Rows.Add(exchange.producto,exchange.eid,exchange.precio,exchange.cantidad,exchange.total);
            }

            dateTB.Text = localDate.ToString("yyyy-MM-dd");
            double i=0;

            foreach (DataGridViewRow r in preFactDV.Rows)
            {
                i += double.Parse(r.Cells[4].Value.ToString());
            }
            totTB.Text = i.ToString();
            
        }

        private void FacturarFrm_Shown(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            VentasFrm ven = new VentasFrm();
            rollBack();
            
            this.Hide();
            ven.ShowDialog();
        }

        private void descBT_Click(object sender, EventArgs e)
        {
            rollBack();
            this.Close();
        }

        private void rollBack()
        {
            string i;
            int c;

            foreach (DataGridViewRow r in preFactDV.Rows)
            {
                i = r.Cells[1].Value.ToString();
                c = int.Parse(r.Cells[3].Value.ToString());

                BDop db = new BDop();
                db.rolldecreStock(i, c);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            printDocument1= new System.Drawing.Printing.PrintDocument();
            nclient = textBox1.Text;
            date = dateTB.Text;
            toy = totTB.Text;
            v = vendTB.Text;
            BDop db = new BDop();
            
            PrinterSettings ps = new PrinterSettings();
            printDocument1.PrinterSettings = ps;
            printDocument1.PrintPage += imprimir;
            if (String.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("DEBE INTRODUCIR EL NOMBRE DEL CLIENTE PARA FACTURAR");
            }
            else
            {

                db.rFactures(nclient, date,v, toy);
                idt=db.getFactId(nclient, date,v , toy);
                printDocument1.Print();
                this.Close();
            }
            
            
        }

        private void imprimir(object sender, PrintPageEventArgs e)
        {
            Font font = new Font("Arial", 8, FontStyle.Regular, GraphicsUnit.Point);
            Font fontb = new Font("Arial", 8, FontStyle.Bold, GraphicsUnit.Point);
            Font fontmain = new Font("Arial", 12, FontStyle.Bold, GraphicsUnit.Point);

            //e.Graphics.DrawString(preFactDV, font, Brushes.Black, new RectangleF(0, 10, 120, 20));
            String n, p, c, t;
            int y=20;
            int x = 20;
            
            e.Graphics.DrawString("Maa! Supply", fontmain, Brushes.Black,   new RectangleF(40, y +=20, 400, 20));   
            e.Graphics.DrawString("Calle Sagrario E. Diaz, Sto. Dgo. Este", font, Brushes.Black, new RectangleF(5, y += 20, 400, 20));
            e.Graphics.DrawString("829-273-3659", font, Brushes.Black, new RectangleF(50, y += 20, 400, 20));
            e.Graphics.DrawString("---------------------------------------", font, Brushes.Black, new RectangleF(0, y += 20, 400, 20));
            e.Graphics.DrawString($"ID DE FACTURA: {idt}                  ", fontb, Brushes.Black,  new RectangleF(0, y+=20, 400, 20));
            e.Graphics.DrawString($"Cliente:     {nclient}         ", fontb, Brushes.Black,   new RectangleF(0, y+=20, 400, 20));
            e.Graphics.DrawString($"Vendedor:     {v}         ", fontb, Brushes.Black, new RectangleF(0, y += 20, 400, 20));
            e.Graphics.DrawString($"FECHA:       {date}           ", fontb, Brushes.Black, new RectangleF(0, y += 20, 400, 20));
            e.Graphics.DrawString("---------------------------------------", font, Brushes.Black, new RectangleF(0, y += 20, 400, 20)); 
            e.Graphics.DrawString($"Precio |Cant. |Total", font, Brushes.Black, new RectangleF(0, y += 20, 400, 20));
            e.Graphics.DrawString($"Producto ", font, Brushes.Black, new RectangleF(0, y += 20, 400, 20));
            e.Graphics.DrawString("---------------------------------------", font, Brushes.Black, new RectangleF(0, y += 20, 400, 20));
            foreach (DataGridViewRow r in preFactDV.Rows)
            {
                RectangleF rectdv = new RectangleF(0, y += 20, 1000, 20);
                n = r.Cells[0].Value.ToString();
                p = r.Cells[2].Value.ToString();
                c = r.Cells[3].Value.ToString();
                t = r.Cells[4].Value.ToString();
                
                e.Graphics.DrawString($"{p}    {c}    {t}", font, Brushes.Black,rectdv );
                e.Graphics.DrawString($"{n}", font, Brushes.Black, new RectangleF(0, y += 20, 1000, 20));
            }
            e.Graphics.DrawString("---------------------------------------", font, Brushes.Black, new RectangleF(0, y += 20, 400, 20));
            e.Graphics.DrawString($"TOTAL A PAGAR: {toy}", fontb, Brushes.Black, new RectangleF(40, y += 20, 400, 20));
            e.Graphics.DrawString("", fontb, Brushes.Black, new RectangleF(0, y += 20, 400, 20));
            e.Graphics.DrawString("GRACIAS POR PREFERIRNOS", fontb, Brushes.Black,  new RectangleF(20, y+=20, 400, 20));

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
           
        }
    }
}
