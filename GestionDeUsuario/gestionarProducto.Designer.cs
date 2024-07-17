namespace GestionDeUsuario
{
    partial class gestionarProducto
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRefescarDatos = new FontAwesome.Sharp.IconButton();
            this.btnguardar = new FontAwesome.Sharp.IconButton();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.chkHabilitarFecha = new System.Windows.Forms.CheckBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.cbxIdProve = new System.Windows.Forms.ComboBox();
            this.cbxIdAdm = new System.Windows.Forms.ComboBox();
            this.cbxIdEncarg = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPrecioVenta = new System.Windows.Forms.TextBox();
            this.txtPrecioCompra = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.btnRegistoPedido = new FontAwesome.Sharp.IconButton();
            this.btnRegistroProvee = new FontAwesome.Sharp.IconButton();
            this.btnBusca = new FontAwesome.Sharp.IconButton();
            this.btnElimin = new FontAwesome.Sharp.IconButton();
            this.btnActulizar = new FontAwesome.Sharp.IconButton();
            this.txbBusPro = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridProductos = new System.Windows.Forms.DataGridView();
            this.encargadosTableAdapterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.encargadosTableAdapterBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(45)))), ((int)(((byte)(62)))));
            this.panel1.Controls.Add(this.btnRefescarDatos);
            this.panel1.Controls.Add(this.btnguardar);
            this.panel1.Controls.Add(this.txtStock);
            this.panel1.Controls.Add(this.txtNombreProducto);
            this.panel1.Controls.Add(this.chkHabilitarFecha);
            this.panel1.Controls.Add(this.dtpFecha);
            this.panel1.Controls.Add(this.cbxIdProve);
            this.panel1.Controls.Add(this.cbxIdAdm);
            this.panel1.Controls.Add(this.cbxIdEncarg);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtPrecioVenta);
            this.panel1.Controls.Add(this.txtPrecioCompra);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(9, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(495, 254);
            this.panel1.TabIndex = 1;
            // 
            // btnRefescarDatos
            // 
            this.btnRefescarDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefescarDatos.IconChar = FontAwesome.Sharp.IconChar.RotateBackward;
            this.btnRefescarDatos.IconColor = System.Drawing.Color.RoyalBlue;
            this.btnRefescarDatos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRefescarDatos.IconSize = 30;
            this.btnRefescarDatos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefescarDatos.Location = new System.Drawing.Point(337, 146);
            this.btnRefescarDatos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRefescarDatos.Name = "btnRefescarDatos";
            this.btnRefescarDatos.Size = new System.Drawing.Size(135, 32);
            this.btnRefescarDatos.TabIndex = 32;
            this.btnRefescarDatos.Text = "Refrescar Datos";
            this.btnRefescarDatos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefescarDatos.UseVisualStyleBackColor = true;
            this.btnRefescarDatos.Click += new System.EventHandler(this.btnRefescarDatos_Click);
            // 
            // btnguardar
            // 
            this.btnguardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardar.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.btnguardar.IconColor = System.Drawing.Color.RoyalBlue;
            this.btnguardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnguardar.IconSize = 30;
            this.btnguardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnguardar.Location = new System.Drawing.Point(337, 200);
            this.btnguardar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(135, 32);
            this.btnguardar.TabIndex = 31;
            this.btnguardar.Text = "Registrar";
            this.btnguardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // txtStock
            // 
            this.txtStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStock.Location = new System.Drawing.Point(166, 88);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(90, 24);
            this.txtStock.TabIndex = 27;
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreProducto.Location = new System.Drawing.Point(13, 34);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(190, 24);
            this.txtNombreProducto.TabIndex = 26;
            // 
            // chkHabilitarFecha
            // 
            this.chkHabilitarFecha.AutoSize = true;
            this.chkHabilitarFecha.ForeColor = System.Drawing.Color.White;
            this.chkHabilitarFecha.Location = new System.Drawing.Point(286, 72);
            this.chkHabilitarFecha.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkHabilitarFecha.Name = "chkHabilitarFecha";
            this.chkHabilitarFecha.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkHabilitarFecha.Size = new System.Drawing.Size(162, 17);
            this.chkHabilitarFecha.TabIndex = 5;
            this.chkHabilitarFecha.Text = "Tiene Fecha de Vencimiento";
            this.chkHabilitarFecha.UseVisualStyleBackColor = true;
            this.chkHabilitarFecha.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(286, 46);
            this.dtpFecha.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(159, 20);
            this.dtpFecha.TabIndex = 24;
            // 
            // cbxIdProve
            // 
            this.cbxIdProve.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxIdProve.FormattingEnabled = true;
            this.cbxIdProve.Location = new System.Drawing.Point(13, 86);
            this.cbxIdProve.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxIdProve.Name = "cbxIdProve";
            this.cbxIdProve.Size = new System.Drawing.Size(136, 25);
            this.cbxIdProve.TabIndex = 22;
            // 
            // cbxIdAdm
            // 
            this.cbxIdAdm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxIdAdm.FormattingEnabled = true;
            this.cbxIdAdm.Location = new System.Drawing.Point(14, 146);
            this.cbxIdAdm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxIdAdm.Name = "cbxIdAdm";
            this.cbxIdAdm.Size = new System.Drawing.Size(134, 25);
            this.cbxIdAdm.TabIndex = 21;
            // 
            // cbxIdEncarg
            // 
            this.cbxIdEncarg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxIdEncarg.FormattingEnabled = true;
            this.cbxIdEncarg.Location = new System.Drawing.Point(14, 204);
            this.cbxIdEncarg.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxIdEncarg.Name = "cbxIdEncarg";
            this.cbxIdEncarg.Size = new System.Drawing.Size(134, 25);
            this.cbxIdEncarg.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(284, 23);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "Fecha de Vencimiento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(163, 184);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "Precio de Venta";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(12, 11);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "Nombre de Producto";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(163, 127);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "Precio de Compra";
            // 
            // txtPrecioVenta
            // 
            this.txtPrecioVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioVenta.Location = new System.Drawing.Point(166, 204);
            this.txtPrecioVenta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPrecioVenta.Name = "txtPrecioVenta";
            this.txtPrecioVenta.Size = new System.Drawing.Size(138, 24);
            this.txtPrecioVenta.TabIndex = 14;
            // 
            // txtPrecioCompra
            // 
            this.txtPrecioCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioCompra.Location = new System.Drawing.Point(166, 146);
            this.txtPrecioCompra.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPrecioCompra.Name = "txtPrecioCompra";
            this.txtPrecioCompra.Size = new System.Drawing.Size(138, 24);
            this.txtPrecioCompra.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(10, 184);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "ID Encargado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(10, 127);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "ID Administrador";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(163, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Stock";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 67);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "ID Proveedor";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(45)))), ((int)(((byte)(62)))));
            this.panel2.Controls.Add(this.iconButton1);
            this.panel2.Controls.Add(this.btnRegistoPedido);
            this.panel2.Controls.Add(this.btnRegistroProvee);
            this.panel2.Controls.Add(this.btnBusca);
            this.panel2.Controls.Add(this.btnElimin);
            this.panel2.Controls.Add(this.btnActulizar);
            this.panel2.Controls.Add(this.txbBusPro);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Location = new System.Drawing.Point(508, 10);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(272, 254);
            this.panel2.TabIndex = 2;
            // 
            // iconButton1
            // 
            this.iconButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.ListAlt;
            this.iconButton1.IconColor = System.Drawing.Color.RoyalBlue;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 30;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(12, 110);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(241, 32);
            this.iconButton1.TabIndex = 37;
            this.iconButton1.Text = "Listar Productos Vencidos";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // btnRegistoPedido
            // 
            this.btnRegistoPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistoPedido.IconChar = FontAwesome.Sharp.IconChar.TruckFast;
            this.btnRegistoPedido.IconColor = System.Drawing.Color.RoyalBlue;
            this.btnRegistoPedido.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRegistoPedido.IconSize = 30;
            this.btnRegistoPedido.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistoPedido.Location = new System.Drawing.Point(74, 199);
            this.btnRegistoPedido.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRegistoPedido.Name = "btnRegistoPedido";
            this.btnRegistoPedido.Size = new System.Drawing.Size(179, 32);
            this.btnRegistoPedido.TabIndex = 36;
            this.btnRegistoPedido.Text = "Registro Pedido";
            this.btnRegistoPedido.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegistoPedido.UseVisualStyleBackColor = true;
            this.btnRegistoPedido.Click += new System.EventHandler(this.btnRegistoPedido_Click);
            // 
            // btnRegistroProvee
            // 
            this.btnRegistroProvee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistroProvee.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.btnRegistroProvee.IconColor = System.Drawing.Color.RoyalBlue;
            this.btnRegistroProvee.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRegistroProvee.IconSize = 30;
            this.btnRegistroProvee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistroProvee.Location = new System.Drawing.Point(74, 153);
            this.btnRegistroProvee.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRegistroProvee.Name = "btnRegistroProvee";
            this.btnRegistroProvee.Size = new System.Drawing.Size(179, 32);
            this.btnRegistroProvee.TabIndex = 35;
            this.btnRegistroProvee.Text = "Registro Proveedor";
            this.btnRegistroProvee.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegistroProvee.UseVisualStyleBackColor = true;
            this.btnRegistroProvee.Click += new System.EventHandler(this.btnRegistroProvee_Click);
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
            this.btnBusca.Location = new System.Drawing.Point(214, 23);
            this.btnBusca.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBusca.Name = "btnBusca";
            this.btnBusca.Size = new System.Drawing.Size(39, 31);
            this.btnBusca.TabIndex = 34;
            this.btnBusca.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBusca.UseVisualStyleBackColor = false;
            this.btnBusca.Click += new System.EventHandler(this.btnBusca_Click);
            // 
            // btnElimin
            // 
            this.btnElimin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnElimin.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnElimin.IconColor = System.Drawing.Color.RoyalBlue;
            this.btnElimin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnElimin.IconSize = 30;
            this.btnElimin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnElimin.Location = new System.Drawing.Point(12, 65);
            this.btnElimin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnElimin.Name = "btnElimin";
            this.btnElimin.Size = new System.Drawing.Size(112, 32);
            this.btnElimin.TabIndex = 33;
            this.btnElimin.Text = "Eliminar";
            this.btnElimin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnElimin.UseVisualStyleBackColor = true;
            this.btnElimin.Click += new System.EventHandler(this.btnElimin_Click);
            // 
            // btnActulizar
            // 
            this.btnActulizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActulizar.IconChar = FontAwesome.Sharp.IconChar.Rotate;
            this.btnActulizar.IconColor = System.Drawing.Color.RoyalBlue;
            this.btnActulizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnActulizar.IconSize = 30;
            this.btnActulizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActulizar.Location = new System.Drawing.Point(144, 66);
            this.btnActulizar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnActulizar.Name = "btnActulizar";
            this.btnActulizar.Size = new System.Drawing.Size(112, 32);
            this.btnActulizar.TabIndex = 32;
            this.btnActulizar.Text = "Actulizar";
            this.btnActulizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnActulizar.UseVisualStyleBackColor = true;
            this.btnActulizar.Click += new System.EventHandler(this.btnActulizar_Click);
            // 
            // txbBusPro
            // 
            this.txbBusPro.Location = new System.Drawing.Point(12, 30);
            this.txbBusPro.Name = "txbBusPro";
            this.txbBusPro.Size = new System.Drawing.Size(162, 20);
            this.txbBusPro.TabIndex = 30;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(10, 10);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "Nombre de Producto";
            // 
            // dataGridProductos
            // 
            this.dataGridProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProductos.Location = new System.Drawing.Point(9, 279);
            this.dataGridProductos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridProductos.Name = "dataGridProductos";
            this.dataGridProductos.RowHeadersWidth = 51;
            this.dataGridProductos.RowTemplate.Height = 24;
            this.dataGridProductos.Size = new System.Drawing.Size(771, 179);
            this.dataGridProductos.TabIndex = 2;
            // 
            // encargadosTableAdapterBindingSource
            // 
            this.encargadosTableAdapterBindingSource.DataSource = typeof(GestionDeUsuario.db_libreriaDataSetTableAdapters.encargadosTableAdapter);
            // 
            // gestionarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(32)))), ((int)(((byte)(57)))));
            this.ClientSize = new System.Drawing.Size(788, 467);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridProductos);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "gestionarProducto";
            this.Text = "gestionarProducto";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.encargadosTableAdapterBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.BindingSource encargadosTableAdapterBindingSource;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.ComboBox cbxIdProve;
        private System.Windows.Forms.ComboBox cbxIdAdm;
        private System.Windows.Forms.ComboBox cbxIdEncarg;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPrecioVenta;
        private System.Windows.Forms.TextBox txtPrecioCompra;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridProductos;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.CheckBox chkHabilitarFecha;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.TextBox txbBusPro;
        private System.Windows.Forms.Label label9;
        private FontAwesome.Sharp.IconButton btnguardar;
        private FontAwesome.Sharp.IconButton btnActulizar;
        private FontAwesome.Sharp.IconButton btnBusca;
        private FontAwesome.Sharp.IconButton btnElimin;
        private FontAwesome.Sharp.IconButton btnRegistroProvee;
        private FontAwesome.Sharp.IconButton btnRegistoPedido;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton btnRefescarDatos;
    }
}