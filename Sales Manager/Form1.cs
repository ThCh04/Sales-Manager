
namespace Sales_Manager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_MouseHover(object sender, EventArgs e)
        {
            label4.ForeColor = Color.Red;
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            label4.ForeColor = Color.Black;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String uname= uTX.Text.Trim();
            String pass=EncryptSha256.GetSHA256( passTX.Text.Trim());
            BDop op= new BDop();
            op.LogSQL(uname, pass);
            if(op.conf== true)
            {
                this.Hide();
                Dashboard das = new Dashboard();
                das.ShowDialog();
                this.Close();
            }
            


        }

        private void passTX_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
              button1_Click(sender, e);
            }
        }
    }
}