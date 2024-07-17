namespace GestionDeUsuario
{
    partial class GestionReportes
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbtRPP = new System.Windows.Forms.RadioButton();
            this.rbtRVPO = new System.Windows.Forms.RadioButton();
            this.rbtRVP = new System.Windows.Forms.RadioButton();
            this.gbxRPP = new System.Windows.Forms.GroupBox();
            this.cbProveedor = new System.Windows.Forms.ComboBox();
            this.cbFV = new System.Windows.Forms.ComboBox();
            this.btnGenerarRPP = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.gbxRVPO = new System.Windows.Forms.GroupBox();
            this.cbProducto = new System.Windows.Forms.ComboBox();
            this.cbCiCliente = new System.Windows.Forms.ComboBox();
            this.btnGenerarRVPO = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePickerHasta = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerDesde = new System.Windows.Forms.DateTimePicker();
            this.gbxRVP = new System.Windows.Forms.GroupBox();
            this.rbtUM = new System.Windows.Forms.RadioButton();
            this.rbtUS = new System.Windows.Forms.RadioButton();
            this.rbtHoy = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGPDF = new System.Windows.Forms.Button();
            this.btnLimpiarDGV = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2.SuspendLayout();
            this.gbxRPP.SuspendLayout();
            this.gbxRVPO.SuspendLayout();
            this.gbxRVP.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbtRPP);
            this.groupBox2.Controls.Add(this.rbtRVPO);
            this.groupBox2.Controls.Add(this.rbtRVP);
            this.groupBox2.Controls.Add(this.gbxRPP);
            this.groupBox2.Controls.Add(this.gbxRVPO);
            this.groupBox2.Controls.Add(this.gbxRVP);
            this.groupBox2.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(12, 14);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(497, 590);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "FILTROS";
            // 
            // rbtRPP
            // 
            this.rbtRPP.AutoSize = true;
            this.rbtRPP.Location = new System.Drawing.Point(374, 383);
            this.rbtRPP.Name = "rbtRPP";
            this.rbtRPP.Size = new System.Drawing.Size(71, 21);
            this.rbtRPP.TabIndex = 4;
            this.rbtRPP.TabStop = true;
            this.rbtRPP.Text = "ACTIVAR";
            this.rbtRPP.UseVisualStyleBackColor = true;
            this.rbtRPP.CheckedChanged += new System.EventHandler(this.rbtRPP_CheckedChanged);
            // 
            // rbtRVPO
            // 
            this.rbtRVPO.AutoSize = true;
            this.rbtRVPO.Location = new System.Drawing.Point(374, 199);
            this.rbtRVPO.Name = "rbtRVPO";
            this.rbtRVPO.Size = new System.Drawing.Size(71, 21);
            this.rbtRVPO.TabIndex = 3;
            this.rbtRVPO.TabStop = true;
            this.rbtRVPO.Text = "ACTIVAR";
            this.rbtRVPO.UseVisualStyleBackColor = true;
            this.rbtRVPO.CheckedChanged += new System.EventHandler(this.rbtRVPO_CheckedChanged);
            // 
            // rbtRVP
            // 
            this.rbtRVP.AutoSize = true;
            this.rbtRVP.Location = new System.Drawing.Point(376, 13);
            this.rbtRVP.Name = "rbtRVP";
            this.rbtRVP.Size = new System.Drawing.Size(71, 21);
            this.rbtRVP.TabIndex = 2;
            this.rbtRVP.TabStop = true;
            this.rbtRVP.Text = "ACTIVAR";
            this.rbtRVP.UseVisualStyleBackColor = true;
            this.rbtRVP.CheckedChanged += new System.EventHandler(this.rbtRVP_CheckedChanged);
            // 
            // gbxRPP
            // 
            this.gbxRPP.Controls.Add(this.cbProveedor);
            this.gbxRPP.Controls.Add(this.cbFV);
            this.gbxRPP.Controls.Add(this.btnGenerarRPP);
            this.gbxRPP.Controls.Add(this.label9);
            this.gbxRPP.Controls.Add(this.txtStock);
            this.gbxRPP.Controls.Add(this.label8);
            this.gbxRPP.Controls.Add(this.label6);
            this.gbxRPP.Controls.Add(this.label7);
            this.gbxRPP.Enabled = false;
            this.gbxRPP.ForeColor = System.Drawing.Color.White;
            this.gbxRPP.Location = new System.Drawing.Point(19, 402);
            this.gbxRPP.Name = "gbxRPP";
            this.gbxRPP.Size = new System.Drawing.Size(447, 165);
            this.gbxRPP.TabIndex = 1;
            this.gbxRPP.TabStop = false;
            this.gbxRPP.Text = "REPORTE PRODUCTOS PERSONALIZADO";
            // 
            // cbProveedor
            // 
            this.cbProveedor.FormattingEnabled = true;
            this.cbProveedor.Location = new System.Drawing.Point(106, 96);
            this.cbProveedor.Name = "cbProveedor";
            this.cbProveedor.Size = new System.Drawing.Size(121, 25);
            this.cbProveedor.TabIndex = 16;
            // 
            // cbFV
            // 
            this.cbFV.FormattingEnabled = true;
            this.cbFV.Location = new System.Drawing.Point(104, 37);
            this.cbFV.Name = "cbFV";
            this.cbFV.Size = new System.Drawing.Size(121, 25);
            this.cbFV.TabIndex = 15;
            // 
            // btnGenerarRPP
            // 
            this.btnGenerarRPP.ForeColor = System.Drawing.Color.Black;
            this.btnGenerarRPP.Location = new System.Drawing.Point(324, 95);
            this.btnGenerarRPP.Name = "btnGenerarRPP";
            this.btnGenerarRPP.Size = new System.Drawing.Size(102, 23);
            this.btnGenerarRPP.TabIndex = 13;
            this.btnGenerarRPP.Text = "GENERAR";
            this.btnGenerarRPP.UseVisualStyleBackColor = true;
            this.btnGenerarRPP.Click += new System.EventHandler(this.btnGenerarRPP_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 101);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 17);
            this.label9.TabIndex = 14;
            this.label9.Text = "PROVEEDOR";
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(310, 35);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(116, 23);
            this.txtStock.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 17);
            this.label8.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(253, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "STOCK";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "F. VENCIMIENTO";
            // 
            // gbxRVPO
            // 
            this.gbxRVPO.Controls.Add(this.cbProducto);
            this.gbxRVPO.Controls.Add(this.cbCiCliente);
            this.gbxRVPO.Controls.Add(this.btnGenerarRVPO);
            this.gbxRVPO.Controls.Add(this.label4);
            this.gbxRVPO.Controls.Add(this.label3);
            this.gbxRVPO.Controls.Add(this.dateTimePickerHasta);
            this.gbxRVPO.Controls.Add(this.label2);
            this.gbxRVPO.Controls.Add(this.label1);
            this.gbxRVPO.Controls.Add(this.dateTimePickerDesde);
            this.gbxRVPO.Enabled = false;
            this.gbxRVPO.ForeColor = System.Drawing.Color.White;
            this.gbxRVPO.Location = new System.Drawing.Point(19, 215);
            this.gbxRVPO.Name = "gbxRVPO";
            this.gbxRVPO.Size = new System.Drawing.Size(447, 165);
            this.gbxRVPO.TabIndex = 1;
            this.gbxRVPO.TabStop = false;
            this.gbxRVPO.Text = "REPORTE VENTA PERSONALIZADO";
            // 
            // cbProducto
            // 
            this.cbProducto.FormattingEnabled = true;
            this.cbProducto.Location = new System.Drawing.Point(106, 110);
            this.cbProducto.Name = "cbProducto";
            this.cbProducto.Size = new System.Drawing.Size(121, 25);
            this.cbProducto.TabIndex = 10;
            // 
            // cbCiCliente
            // 
            this.cbCiCliente.FormattingEnabled = true;
            this.cbCiCliente.Location = new System.Drawing.Point(104, 68);
            this.cbCiCliente.Name = "cbCiCliente";
            this.cbCiCliente.Size = new System.Drawing.Size(121, 25);
            this.cbCiCliente.TabIndex = 9;
            // 
            // btnGenerarRVPO
            // 
            this.btnGenerarRVPO.ForeColor = System.Drawing.Color.Black;
            this.btnGenerarRVPO.Location = new System.Drawing.Point(320, 112);
            this.btnGenerarRVPO.Name = "btnGenerarRVPO";
            this.btnGenerarRVPO.Size = new System.Drawing.Size(102, 23);
            this.btnGenerarRVPO.TabIndex = 3;
            this.btnGenerarRVPO.Text = "GENERAR";
            this.btnGenerarRVPO.UseVisualStyleBackColor = true;
            this.btnGenerarRVPO.Click += new System.EventHandler(this.btnGenerarRVPO_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "PRODUCTO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "CLIENTE CI";
            // 
            // dateTimePickerHasta
            // 
            this.dateTimePickerHasta.Location = new System.Drawing.Point(306, 28);
            this.dateTimePickerHasta.Name = "dateTimePickerHasta";
            this.dateTimePickerHasta.Size = new System.Drawing.Size(122, 23);
            this.dateTimePickerHasta.TabIndex = 6;
            this.dateTimePickerHasta.Value = new System.DateTime(2024, 6, 19, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(253, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "HASTA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "DESDE";
            // 
            // dateTimePickerDesde
            // 
            this.dateTimePickerDesde.Location = new System.Drawing.Point(103, 28);
            this.dateTimePickerDesde.Name = "dateTimePickerDesde";
            this.dateTimePickerDesde.Size = new System.Drawing.Size(121, 23);
            this.dateTimePickerDesde.TabIndex = 2;
            this.dateTimePickerDesde.Value = new System.DateTime(2024, 6, 19, 0, 0, 0, 0);
            // 
            // gbxRVP
            // 
            this.gbxRVP.Controls.Add(this.rbtUM);
            this.gbxRVP.Controls.Add(this.rbtUS);
            this.gbxRVP.Controls.Add(this.rbtHoy);
            this.gbxRVP.Enabled = false;
            this.gbxRVP.ForeColor = System.Drawing.Color.White;
            this.gbxRVP.Location = new System.Drawing.Point(19, 31);
            this.gbxRVP.Name = "gbxRVP";
            this.gbxRVP.Size = new System.Drawing.Size(447, 165);
            this.gbxRVP.TabIndex = 0;
            this.gbxRVP.TabStop = false;
            this.gbxRVP.Text = "REPORTE VENTA PREDEFINIDO";
            // 
            // rbtUM
            // 
            this.rbtUM.AutoSize = true;
            this.rbtUM.Location = new System.Drawing.Point(167, 104);
            this.rbtUM.Name = "rbtUM";
            this.rbtUM.Size = new System.Drawing.Size(86, 21);
            this.rbtUM.TabIndex = 3;
            this.rbtUM.TabStop = true;
            this.rbtUM.Text = "ULTIMO MES";
            this.rbtUM.UseVisualStyleBackColor = true;
            this.rbtUM.CheckedChanged += new System.EventHandler(this.rbtUM_CheckedChanged);
            // 
            // rbtUS
            // 
            this.rbtUS.AutoSize = true;
            this.rbtUS.Location = new System.Drawing.Point(167, 72);
            this.rbtUS.Name = "rbtUS";
            this.rbtUS.Size = new System.Drawing.Size(107, 21);
            this.rbtUS.TabIndex = 2;
            this.rbtUS.TabStop = true;
            this.rbtUS.Text = "ULTIMA SEMANA";
            this.rbtUS.UseVisualStyleBackColor = true;
            this.rbtUS.CheckedChanged += new System.EventHandler(this.rbtUS_CheckedChanged);
            // 
            // rbtHoy
            // 
            this.rbtHoy.AutoSize = true;
            this.rbtHoy.Location = new System.Drawing.Point(167, 41);
            this.rbtHoy.Name = "rbtHoy";
            this.rbtHoy.Size = new System.Drawing.Size(46, 21);
            this.rbtHoy.TabIndex = 1;
            this.rbtHoy.TabStop = true;
            this.rbtHoy.Text = "HOY";
            this.rbtHoy.UseVisualStyleBackColor = true;
            this.rbtHoy.CheckedChanged += new System.EventHandler(this.rbtHoy_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGPDF);
            this.groupBox1.Controls.Add(this.btnLimpiarDGV);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(536, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(529, 590);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "REPORTE";
            // 
            // btnGPDF
            // 
            this.btnGPDF.ForeColor = System.Drawing.Color.Black;
            this.btnGPDF.Location = new System.Drawing.Point(256, 529);
            this.btnGPDF.Name = "btnGPDF";
            this.btnGPDF.Size = new System.Drawing.Size(122, 38);
            this.btnGPDF.TabIndex = 3;
            this.btnGPDF.Text = "GENERAR PDF";
            this.btnGPDF.UseVisualStyleBackColor = true;
            this.btnGPDF.Click += new System.EventHandler(this.btnGPDF_Click);
            // 
            // btnLimpiarDGV
            // 
            this.btnLimpiarDGV.ForeColor = System.Drawing.Color.Black;
            this.btnLimpiarDGV.Location = new System.Drawing.Point(384, 529);
            this.btnLimpiarDGV.Name = "btnLimpiarDGV";
            this.btnLimpiarDGV.Size = new System.Drawing.Size(122, 38);
            this.btnLimpiarDGV.TabIndex = 2;
            this.btnLimpiarDGV.Text = "LIMPIAR";
            this.btnLimpiarDGV.UseVisualStyleBackColor = true;
            this.btnLimpiarDGV.Click += new System.EventHandler(this.btnLimpiarDGV_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.Gray;
            this.dataGridView1.Location = new System.Drawing.Point(24, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 5;
            this.dataGridView1.Size = new System.Drawing.Size(482, 493);
            this.dataGridView1.TabIndex = 0;
            // 
            // GestionReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(32)))), ((int)(((byte)(57)))));
            this.ClientSize = new System.Drawing.Size(1077, 618);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "GestionReportes";
            this.Text = "GestionReportes";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gbxRPP.ResumeLayout(false);
            this.gbxRPP.PerformLayout();
            this.gbxRVPO.ResumeLayout(false);
            this.gbxRVPO.PerformLayout();
            this.gbxRVP.ResumeLayout(false);
            this.gbxRVP.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbtRPP;
        private System.Windows.Forms.RadioButton rbtRVPO;
        private System.Windows.Forms.RadioButton rbtRVP;
        private System.Windows.Forms.GroupBox gbxRPP;
        private System.Windows.Forms.ComboBox cbProveedor;
        private System.Windows.Forms.ComboBox cbFV;
        private System.Windows.Forms.Button btnGenerarRPP;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox gbxRVPO;
        private System.Windows.Forms.ComboBox cbProducto;
        private System.Windows.Forms.ComboBox cbCiCliente;
        private System.Windows.Forms.Button btnGenerarRVPO;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePickerHasta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerDesde;
        private System.Windows.Forms.GroupBox gbxRVP;
        private System.Windows.Forms.RadioButton rbtUM;
        private System.Windows.Forms.RadioButton rbtUS;
        private System.Windows.Forms.RadioButton rbtHoy;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGPDF;
        private System.Windows.Forms.Button btnLimpiarDGV;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}