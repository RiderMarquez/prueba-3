using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static GestionDeUsuario.Form1;

namespace GestionDeUsuario
{
    
    public partial class PanelDeContro : Form
    {
        private Form1.TipoUsuario tipoUsuario;
        public PanelDeContro(TipoUsuario tipoUsuario)
        {
            InitializeComponent();
            this.tipoUsuario = tipoUsuario;
            this.Load += vendedor_Load;
        }
        private void vendedor_Load(object sender, EventArgs e)
        {
            if (tipoUsuario == Form1.TipoUsuario.Vendedor)
            {
                btnAdmUsuarios.Enabled = false;
                //btnAdmVendedores.Enabled = false;
                btnReportes.Enabled = false;// Deshabilitar el botón para los vendedores
            }
            else if (tipoUsuario == Form1.TipoUsuario.Administrador)
            {
                btnReportes.Enabled = true; // Habilitar el botón solo para los administradores
            }
        }
        public void loadform(object From)
        {
            if(this.mainPanel.Controls.Count>0)
                this.mainPanel.Controls.RemoveAt(0);
            Form f = From as Form;
            f.TopLevel=false;
            f.Dock= DockStyle.Fill;
            this.mainPanel.Controls.Add(f);
            this.mainPanel.Tag = f;
            f.Show();
        }
        private void btnAdmUsuarios_Click(object sender, EventArgs e)
        {

        }

        private void btnGestionarProducto_Click(object sender, EventArgs e)
        {
            loadform(new gestionarProducto());
        }

        

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadform(new venderProducto());
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            loadform(new GestionReportes());
        }

        private void btnAdmUsuarios_Click_1(object sender, EventArgs e)
        {
            loadform(new crud());
        }
    }
}
