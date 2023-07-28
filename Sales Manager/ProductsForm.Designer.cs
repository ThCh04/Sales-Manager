namespace Sales_Manager
{
    partial class ProductsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductsForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.preUp = new System.Windows.Forms.NumericUpDown();
            this.uniCot = new System.Windows.Forms.NumericUpDown();
            this.catCB = new System.Windows.Forms.ComboBox();
            this.nomTF = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.preUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uniCot)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.preUp);
            this.groupBox1.Controls.Add(this.uniCot);
            this.groupBox1.Controls.Add(this.catCB);
            this.groupBox1.Controls.Add(this.nomTF);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(15, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(285, 259);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información del Producto:";
            // 
            // button3
            // 
            this.button3.Image = global::Sales_Manager.Properties.Resources.plus_46_16;
            this.button3.Location = new System.Drawing.Point(240, 90);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(39, 23);
            this.button3.TabIndex = 10;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // preUp
            // 
            this.preUp.Location = new System.Drawing.Point(77, 181);
            this.preUp.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.preUp.Name = "preUp";
            this.preUp.Size = new System.Drawing.Size(73, 23);
            this.preUp.TabIndex = 9;
            // 
            // uniCot
            // 
            this.uniCot.Location = new System.Drawing.Point(77, 134);
            this.uniCot.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.uniCot.Name = "uniCot";
            this.uniCot.Size = new System.Drawing.Size(73, 23);
            this.uniCot.TabIndex = 9;
            // 
            // catCB
            // 
            this.catCB.FormattingEnabled = true;
            this.catCB.Location = new System.Drawing.Point(77, 90);
            this.catCB.Name = "catCB";
            this.catCB.Size = new System.Drawing.Size(157, 23);
            this.catCB.TabIndex = 8;
            this.catCB.Text = "Seleccionar";
            // 
            // nomTF
            // 
            this.nomTF.ForeColor = System.Drawing.SystemColors.ControlText;
            this.nomTF.Location = new System.Drawing.Point(77, 43);
            this.nomTF.Name = "nomTF";
            this.nomTF.Size = new System.Drawing.Size(157, 23);
            this.nomTF.TabIndex = 6;
            this.nomTF.MouseClick += new System.Windows.Forms.MouseEventHandler(this.nomTF_MouseClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(6, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Precio:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(6, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Unidades:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(6, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Categoría:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(6, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(130, 298);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Añadir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(225, 298);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Descartar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(312, 333);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProductsForm";
            this.Text = "Nuevo Producto";
            this.Load += new System.EventHandler(this.ProductsForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.preUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uniCot)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private TextBox nomTF;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label1;
        private NumericUpDown uniCot;
        public ComboBox catCB;
        private Button button1;
        private Button button2;
        private Button button3;
        private FontDialog fontDialog1;
        private NumericUpDown preUp;
    }
}