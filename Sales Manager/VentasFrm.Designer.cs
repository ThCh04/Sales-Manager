namespace Sales_Manager
{
    partial class VentasFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentasFrm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.anCarBt = new System.Windows.Forms.Button();
            this.svTB = new System.Windows.Forms.TextBox();
            this.desUP = new System.Windows.Forms.NumericUpDown();
            this.canUp = new System.Windows.Forms.NumericUpDown();
            this.svenBT = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.carGVi = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Código = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.ventGV = new System.Windows.Forms.DataGridView();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.dayTB = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.desUP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.canUp)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carGVi)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ventGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dayTB);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(226, 628);
            this.panel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(11, 338);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(208, 219);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Opciones Carrito:";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(46, 130);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(114, 23);
            this.button5.TabIndex = 0;
            this.button5.Text = "Facturar";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(46, 81);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(114, 23);
            this.button4.TabIndex = 0;
            this.button4.Text = "Vaciar Carrito";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(46, 31);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(114, 23);
            this.button3.TabIndex = 0;
            this.button3.Text = "Remover Selec.";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.anCarBt);
            this.groupBox1.Controls.Add(this.svTB);
            this.groupBox1.Controls.Add(this.desUP);
            this.groupBox1.Controls.Add(this.canUp);
            this.groupBox1.Controls.Add(this.svenBT);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(11, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(208, 275);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones Venta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(6, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Buscar Producto:";
            // 
            // anCarBt
            // 
            this.anCarBt.Location = new System.Drawing.Point(37, 214);
            this.anCarBt.Name = "anCarBt";
            this.anCarBt.Size = new System.Drawing.Size(133, 23);
            this.anCarBt.TabIndex = 5;
            this.anCarBt.Text = "Añadir al Carrito";
            this.anCarBt.UseVisualStyleBackColor = true;
            this.anCarBt.Click += new System.EventHandler(this.button2_Click);
            // 
            // svTB
            // 
            this.svTB.Location = new System.Drawing.Point(6, 74);
            this.svTB.Name = "svTB";
            this.svTB.Size = new System.Drawing.Size(137, 23);
            this.svTB.TabIndex = 0;
            this.svTB.TextChanged += new System.EventHandler(this.svTB_TextChanged);
            this.svTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.svTB_KeyDown);
            // 
            // desUP
            // 
            this.desUP.Location = new System.Drawing.Point(88, 166);
            this.desUP.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.desUP.Name = "desUP";
            this.desUP.Size = new System.Drawing.Size(63, 23);
            this.desUP.TabIndex = 4;
            // 
            // canUp
            // 
            this.canUp.Location = new System.Drawing.Point(88, 130);
            this.canUp.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.canUp.Name = "canUp";
            this.canUp.Size = new System.Drawing.Size(63, 23);
            this.canUp.TabIndex = 4;
            // 
            // svenBT
            // 
            this.svenBT.Image = global::Sales_Manager.Properties.Resources.search_663_16;
            this.svenBT.Location = new System.Drawing.Point(149, 74);
            this.svenBT.Name = "svenBT";
            this.svenBT.Size = new System.Drawing.Size(31, 24);
            this.svenBT.TabIndex = 1;
            this.svenBT.UseVisualStyleBackColor = true;
            this.svenBT.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(157, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 18);
            this.label6.TabIndex = 3;
            this.label6.Text = "%";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(6, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 18);
            this.label5.TabIndex = 3;
            this.label5.Text = "Descuento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(7, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cantidad:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.carGVi);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(226, 323);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(637, 305);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Carrito de Compras:";
            // 
            // carGVi
            // 
            this.carGVi.AllowUserToAddRows = false;
            this.carGVi.AllowUserToDeleteRows = false;
            this.carGVi.AllowUserToResizeColumns = false;
            this.carGVi.AllowUserToResizeRows = false;
            this.carGVi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.carGVi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.carGVi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.Código,
            this.Precio,
            this.Cantidad,
            this.Total});
            this.carGVi.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.carGVi.Location = new System.Drawing.Point(0, 44);
            this.carGVi.Name = "carGVi";
            this.carGVi.ReadOnly = true;
            this.carGVi.RowTemplate.Height = 25;
            this.carGVi.Size = new System.Drawing.Size(637, 261);
            this.carGVi.TabIndex = 0;
            this.carGVi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.carGV_CellClick);
            this.carGVi.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.carGV_RowsAdded);
            this.carGVi.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.carGV_RowsRemoved);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Producto";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // Código
            // 
            this.Código.HeaderText = "Código";
            this.Código.Name = "Código";
            this.Código.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.ventGV);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(226, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(637, 334);
            this.panel3.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(3, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Productos:";
            // 
            // ventGV
            // 
            this.ventGV.AllowUserToAddRows = false;
            this.ventGV.AllowUserToDeleteRows = false;
            this.ventGV.AllowUserToResizeColumns = false;
            this.ventGV.AllowUserToResizeRows = false;
            this.ventGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ventGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ventGV.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ventGV.Location = new System.Drawing.Point(0, 30);
            this.ventGV.Name = "ventGV";
            this.ventGV.RowTemplate.Height = 25;
            this.ventGV.Size = new System.Drawing.Size(637, 304);
            this.ventGV.TabIndex = 0;
            this.ventGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ventGV_CellClick);
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            this.Producto.Width = 149;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Producto";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(15, 567);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 18);
            this.label7.TabIndex = 8;
            this.label7.Text = "Ventas Diarias: ";
            // 
            // dayTB
            // 
            this.dayTB.Location = new System.Drawing.Point(17, 592);
            this.dayTB.Name = "dayTB";
            this.dayTB.ReadOnly = true;
            this.dayTB.Size = new System.Drawing.Size(186, 23);
            this.dayTB.TabIndex = 9;
            // 
            // VentasFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(863, 628);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VentasFrm";
            this.Text = "Nueva Venta";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.desUP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.canUp)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carGVi)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ventGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Panel panel3;
        private Label label2;
        private DataGridView ventGV;
        private GroupBox groupBox2;
        private Button button5;
        private Button button4;
        private Button button3;
        private GroupBox groupBox1;
        private Label label3;
        private Button anCarBt;
        private TextBox svTB;
        private NumericUpDown canUp;
        private Button svenBT;
        private Label label4;
        public DataGridView carGV;
        private DataGridViewTextBoxColumn Producto;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn Código;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Total;
        public DataGridView carGVi;
        private NumericUpDown desUP;
        private Label label6;
        private Label label5;
        private TextBox dayTB;
        private Label label7;
    }
}