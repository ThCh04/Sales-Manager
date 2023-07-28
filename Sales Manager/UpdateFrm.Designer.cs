namespace Sales_Manager
{
    partial class UpdateFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateFrm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.uuniCot = new System.Windows.Forms.NumericUpDown();
            this.ucatCB = new System.Windows.Forms.ComboBox();
            this.unomTF = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.upDV = new System.Windows.Forms.DataGridView();
            this.pridown = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uuniCot)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upDV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pridown)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.pridown);
            this.groupBox1.Controls.Add(this.uuniCot);
            this.groupBox1.Controls.Add(this.ucatCB);
            this.groupBox1.Controls.Add(this.unomTF);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(15, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(500, 158);
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
            // uuniCot
            // 
            this.uuniCot.Location = new System.Drawing.Point(374, 44);
            this.uuniCot.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.uuniCot.Name = "uuniCot";
            this.uuniCot.Size = new System.Drawing.Size(73, 23);
            this.uuniCot.TabIndex = 9;
            // 
            // ucatCB
            // 
            this.ucatCB.FormattingEnabled = true;
            this.ucatCB.Location = new System.Drawing.Point(77, 90);
            this.ucatCB.Name = "ucatCB";
            this.ucatCB.Size = new System.Drawing.Size(157, 23);
            this.ucatCB.TabIndex = 8;
            this.ucatCB.Text = "Seleccionar";
            // 
            // unomTF
            // 
            this.unomTF.ForeColor = System.Drawing.SystemColors.ControlText;
            this.unomTF.Location = new System.Drawing.Point(68, 45);
            this.unomTF.Name = "unomTF";
            this.unomTF.Size = new System.Drawing.Size(157, 23);
            this.unomTF.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(298, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Precio:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(298, 45);
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
            this.button1.Location = new System.Drawing.Point(521, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Actualizar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(521, 99);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Descartar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.upDV);
            this.panel1.Location = new System.Drawing.Point(15, 219);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(598, 193);
            this.panel1.TabIndex = 2;
            // 
            // upDV
            // 
            this.upDV.AllowUserToAddRows = false;
            this.upDV.AllowUserToDeleteRows = false;
            this.upDV.AllowUserToResizeColumns = false;
            this.upDV.AllowUserToResizeRows = false;
            this.upDV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.upDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.upDV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.upDV.Location = new System.Drawing.Point(0, 0);
            this.upDV.Name = "upDV";
            this.upDV.RowTemplate.Height = 25;
            this.upDV.Size = new System.Drawing.Size(598, 193);
            this.upDV.TabIndex = 0;
            this.upDV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.upDV_CellClick);
            // 
            // pridown
            // 
            this.pridown.Location = new System.Drawing.Point(374, 92);
            this.pridown.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.pridown.Name = "pridown";
            this.pridown.Size = new System.Drawing.Size(73, 23);
            this.pridown.TabIndex = 9;
            // 
            // UpdateFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(627, 441);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UpdateFrm";
            this.Text = "Actualizar Producto";
            this.Load += new System.EventHandler(this.UpdateFrm_Load);
            this.Shown += new System.EventHandler(this.UpdateFrm_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uuniCot)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.upDV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pridown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        public TextBox unomTF;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label1;
        public NumericUpDown uuniCot;
        public ComboBox ucatCB;
        private Button button1;
        private Button button2;
        private Button button3;
        private FontDialog fontDialog1;
        private Panel panel1;
        private DataGridView upDV;
        public NumericUpDown pridown;
    }

        
    }
