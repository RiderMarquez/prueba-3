namespace GestionDeUsuario
{
    partial class registroPedido
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
            this.btnguardar = new FontAwesome.Sharp.IconButton();
            this.txtTotalPedido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbBusPro = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBusca = new FontAwesome.Sharp.IconButton();
            this.cbxIdProveedor = new System.Windows.Forms.ComboBox();
            this.cbxIdProducto = new System.Windows.Forms.ComboBox();
            this.dtpFechaPedido = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btnguardar
            // 
            this.btnguardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardar.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.btnguardar.IconColor = System.Drawing.Color.RoyalBlue;
            this.btnguardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnguardar.IconSize = 30;
            this.btnguardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnguardar.Location = new System.Drawing.Point(16, 264);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(286, 40);
            this.btnguardar.TabIndex = 47;
            this.btnguardar.Text = "Registrar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // txtTotalPedido
            // 
            this.txtTotalPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPedido.Location = new System.Drawing.Point(275, 202);
            this.txtTotalPedido.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotalPedido.Name = "txtTotalPedido";
            this.txtTotalPedido.Size = new System.Drawing.Size(252, 28);
            this.txtTotalPedido.TabIndex = 46;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(274, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 45;
            this.label2.Text = "Total Pedido";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(274, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 43;
            this.label1.Text = "Id Produto";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(12, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 20);
            this.label7.TabIndex = 41;
            this.label7.Text = "Fecha Pedido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 20);
            this.label3.TabIndex = 48;
            this.label3.Text = "Id Proveedor";
            // 
            // txbBusPro
            // 
            this.txbBusPro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbBusPro.Location = new System.Drawing.Point(13, 38);
            this.txbBusPro.Margin = new System.Windows.Forms.Padding(4);
            this.txbBusPro.Name = "txbBusPro";
            this.txbBusPro.Size = new System.Drawing.Size(252, 28);
            this.txbBusPro.TabIndex = 51;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 20);
            this.label4.TabIndex = 50;
            this.label4.Text = "Nombre Produto";
            // 
            // btnBusca
            // 
            this.btnBusca.BackColor = System.Drawing.Color.Transparent;
            this.btnBusca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBusca.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnBusca.IconColor = System.Drawing.Color.RoyalBlue;
            this.btnBusca.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBusca.IconSize = 30;
            this.btnBusca.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBusca.Location = new System.Drawing.Point(278, 28);
            this.btnBusca.Name = "btnBusca";
            this.btnBusca.Size = new System.Drawing.Size(52, 38);
            this.btnBusca.TabIndex = 52;
            this.btnBusca.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBusca.UseVisualStyleBackColor = false;
            this.btnBusca.Click += new System.EventHandler(this.btnBusca_Click);
            // 
            // cbxIdProveedor
            // 
            this.cbxIdProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxIdProveedor.FormattingEnabled = true;
            this.cbxIdProveedor.Location = new System.Drawing.Point(16, 122);
            this.cbxIdProveedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxIdProveedor.Name = "cbxIdProveedor";
            this.cbxIdProveedor.Size = new System.Drawing.Size(180, 30);
            this.cbxIdProveedor.TabIndex = 54;
            // 
            // cbxIdProducto
            // 
            this.cbxIdProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxIdProducto.FormattingEnabled = true;
            this.cbxIdProducto.Location = new System.Drawing.Point(278, 122);
            this.cbxIdProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxIdProducto.Name = "cbxIdProducto";
            this.cbxIdProducto.Size = new System.Drawing.Size(178, 30);
            this.cbxIdProducto.TabIndex = 53;
            // 
            // dtpFechaPedido
            // 
            this.dtpFechaPedido.Location = new System.Drawing.Point(16, 205);
            this.dtpFechaPedido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpFechaPedido.Name = "dtpFechaPedido";
            this.dtpFechaPedido.Size = new System.Drawing.Size(211, 22);
            this.dtpFechaPedido.TabIndex = 55;
            // 
            // registroPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(555, 364);
            this.Controls.Add(this.dtpFechaPedido);
            this.Controls.Add(this.cbxIdProveedor);
            this.Controls.Add(this.cbxIdProducto);
            this.Controls.Add(this.btnBusca);
            this.Controls.Add(this.txbBusPro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.txtTotalPedido);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Name = "registroPedido";
            this.Text = "registroPedido";
            this.Load += new System.EventHandler(this.registroPedido_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnguardar;
        private System.Windows.Forms.TextBox txtTotalPedido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbBusPro;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconButton btnBusca;
        private System.Windows.Forms.ComboBox cbxIdProveedor;
        private System.Windows.Forms.ComboBox cbxIdProducto;
        private System.Windows.Forms.DateTimePicker dtpFechaPedido;
    }
}