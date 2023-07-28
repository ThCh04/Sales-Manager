namespace Sales_Manager
{
    partial class updateFactFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(updateFactFrm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.ufactDV = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.facUP = new System.Windows.Forms.NumericUpDown();
            this.fafeTF = new System.Windows.Forms.TextBox();
            this.cliTF = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ufactDV)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.facUP)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ufactDV);
            this.panel1.Location = new System.Drawing.Point(12, 187);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 193);
            this.panel1.TabIndex = 6;
            // 
            // ufactDV
            // 
            this.ufactDV.AllowUserToAddRows = false;
            this.ufactDV.AllowUserToDeleteRows = false;
            this.ufactDV.AllowUserToOrderColumns = true;
            this.ufactDV.AllowUserToResizeColumns = false;
            this.ufactDV.AllowUserToResizeRows = false;
            this.ufactDV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ufactDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ufactDV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ufactDV.Location = new System.Drawing.Point(0, 0);
            this.ufactDV.Name = "ufactDV";
            this.ufactDV.RowTemplate.Height = 25;
            this.ufactDV.Size = new System.Drawing.Size(500, 193);
            this.ufactDV.TabIndex = 0;
            this.ufactDV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(310, 398);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Descartar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(418, 398);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Actualizar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.facUP);
            this.groupBox1.Controls.Add(this.fafeTF);
            this.groupBox1.Controls.Add(this.cliTF);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(500, 158);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información del Producto:";
            // 
            // facUP
            // 
            this.facUP.Location = new System.Drawing.Point(307, 49);
            this.facUP.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.facUP.Name = "facUP";
            this.facUP.Size = new System.Drawing.Size(71, 23);
            this.facUP.TabIndex = 8;
            // 
            // fafeTF
            // 
            this.fafeTF.ForeColor = System.Drawing.SystemColors.ControlText;
            this.fafeTF.Location = new System.Drawing.Point(68, 95);
            this.fafeTF.Name = "fafeTF";
            this.fafeTF.Size = new System.Drawing.Size(157, 23);
            this.fafeTF.TabIndex = 7;
            // 
            // cliTF
            // 
            this.cliTF.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cliTF.Location = new System.Drawing.Point(68, 45);
            this.cliTF.Name = "cliTF";
            this.cliTF.Size = new System.Drawing.Size(157, 23);
            this.cliTF.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(262, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Total:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(6, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(6, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cliente:";
            // 
            // updateFactFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(525, 431);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "updateFactFrm";
            this.Text = "Actualizar Factura";
            this.Load += new System.EventHandler(this.updateFactFrm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ufactDV)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.facUP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private DataGridView ufactDV;
        private Button button2;
        private Button button1;
        private GroupBox groupBox1;
        private NumericUpDown facUP;
        public TextBox fafeTF;
        public TextBox cliTF;
        private Label label5;
        private Label label4;
        private Label label1;
    }
}