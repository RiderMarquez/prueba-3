namespace GestionDeUsuario
{
    partial class PanelDeContro
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnReportes = new System.Windows.Forms.Button();
            this.btnGestionarProducto = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAdmUsuarios = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1283, 49);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.btnSalir);
            this.panel2.Controls.Add(this.btnReportes);
            this.panel2.Controls.Add(this.btnGestionarProducto);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.btnAdmUsuarios);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 49);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(213, 605);
            this.panel2.TabIndex = 5;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(41, 438);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnReportes
            // 
            this.btnReportes.Location = new System.Drawing.Point(16, 91);
            this.btnReportes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(177, 28);
            this.btnReportes.TabIndex = 2;
            this.btnReportes.Text = "Reportes";
            this.btnReportes.UseVisualStyleBackColor = true;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // btnGestionarProducto
            // 
            this.btnGestionarProducto.Location = new System.Drawing.Point(16, 55);
            this.btnGestionarProducto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGestionarProducto.Name = "btnGestionarProducto";
            this.btnGestionarProducto.Size = new System.Drawing.Size(177, 28);
            this.btnGestionarProducto.TabIndex = 1;
            this.btnGestionarProducto.Text = "Gestionar Producto";
            this.btnGestionarProducto.UseVisualStyleBackColor = true;
            this.btnGestionarProducto.Click += new System.EventHandler(this.btnGestionarProducto_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 18);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "Vender Producto";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAdmUsuarios
            // 
            this.btnAdmUsuarios.Location = new System.Drawing.Point(16, 128);
            this.btnAdmUsuarios.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdmUsuarios.Name = "btnAdmUsuarios";
            this.btnAdmUsuarios.Size = new System.Drawing.Size(177, 28);
            this.btnAdmUsuarios.TabIndex = 3;
            this.btnAdmUsuarios.Text = "Administar de Usuario";
            this.btnAdmUsuarios.UseVisualStyleBackColor = true;
            this.btnAdmUsuarios.Click += new System.EventHandler(this.btnAdmUsuarios_Click_1);
            // 
            // mainPanel
            // 
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(213, 49);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1070, 605);
            this.mainPanel.TabIndex = 6;
            // 
            // PanelDeContro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 654);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PanelDeContro";
            this.Text = "PanelDeContro";
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Button btnGestionarProducto;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAdmUsuarios;
        private System.Windows.Forms.Button btnSalir;
    }
}