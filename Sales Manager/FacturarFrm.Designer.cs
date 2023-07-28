namespace Sales_Manager
{
    partial class FacturarFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FacturarFrm));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dateTB = new System.Windows.Forms.TextBox();
            this.totTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.preFactDV = new System.Windows.Forms.DataGridView();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.descBT = new System.Windows.Forms.Button();
            this.regBT = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.label4 = new System.Windows.Forms.Label();
            this.vendTB = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.preFactDV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(14, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cliente:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(107, 47);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(117, 23);
            this.textBox1.TabIndex = 1;
            // 
            // dateTB
            // 
            this.dateTB.Location = new System.Drawing.Point(107, 93);
            this.dateTB.Name = "dateTB";
            this.dateTB.ReadOnly = true;
            this.dateTB.Size = new System.Drawing.Size(117, 23);
            this.dateTB.TabIndex = 2;
            // 
            // totTB
            // 
            this.totTB.Location = new System.Drawing.Point(100, 177);
            this.totTB.Name = "totTB";
            this.totTB.ReadOnly = true;
            this.totTB.Size = new System.Drawing.Size(100, 23);
            this.totTB.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(14, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fecha:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(14, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Total:";
            // 
            // preFactDV
            // 
            this.preFactDV.AllowUserToAddRows = false;
            this.preFactDV.AllowUserToDeleteRows = false;
            this.preFactDV.AllowUserToResizeColumns = false;
            this.preFactDV.AllowUserToResizeRows = false;
            this.preFactDV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.preFactDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.preFactDV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Producto,
            this.ID,
            this.Precio,
            this.Cantidad,
            this.Total});
            this.preFactDV.Location = new System.Drawing.Point(238, 14);
            this.preFactDV.Name = "preFactDV";
            this.preFactDV.RowTemplate.Height = 25;
            this.preFactDV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.preFactDV.Size = new System.Drawing.Size(456, 415);
            this.preFactDV.TabIndex = 8;
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(26, 230);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 107);
            this.button1.TabIndex = 9;
            this.button1.Text = "Imprimir";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // descBT
            // 
            this.descBT.Location = new System.Drawing.Point(125, 364);
            this.descBT.Name = "descBT";
            this.descBT.Size = new System.Drawing.Size(75, 23);
            this.descBT.TabIndex = 10;
            this.descBT.Text = "Descartar";
            this.descBT.UseVisualStyleBackColor = true;
            this.descBT.Click += new System.EventHandler(this.descBT_Click);
            // 
            // regBT
            // 
            this.regBT.Location = new System.Drawing.Point(26, 364);
            this.regBT.Name = "regBT";
            this.regBT.Size = new System.Drawing.Size(75, 23);
            this.regBT.TabIndex = 11;
            this.regBT.Text = "Regresar";
            this.regBT.UseVisualStyleBackColor = true;
            this.regBT.Click += new System.EventHandler(this.button3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(14, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Vendedor/a:";
            // 
            // vendTB
            // 
            this.vendTB.Location = new System.Drawing.Point(107, 137);
            this.vendTB.Name = "vendTB";
            this.vendTB.Size = new System.Drawing.Size(100, 23);
            this.vendTB.TabIndex = 3;
            // 
            // FacturarFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(706, 441);
            this.Controls.Add(this.regBT);
            this.Controls.Add(this.descBT);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.preFactDV);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.vendTB);
            this.Controls.Add(this.totTB);
            this.Controls.Add(this.dateTB);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FacturarFrm";
            this.Text = "Facturar";
            this.Load += new System.EventHandler(this.FacturarFrm_Load);
            this.Shown += new System.EventHandler(this.FacturarFrm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.preFactDV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox dateTB;
        private TextBox totTB;
        private Label label2;
        private Label label3;
        private DataGridView preFactDV;
        private Button button1;
        private Button descBT;
        private Button regBT;
        private DataGridViewTextBoxColumn Producto;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Total;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private Label label4;
        private TextBox vendTB;
    }
}