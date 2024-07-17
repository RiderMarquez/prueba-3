using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionDeUsuario
{
    public partial class registroProveedor : Form
    {
        private string connectionString = "Data Source=(local)\\SQLEXPRESS;Initial Catalog=db_libreria;Integrated Security=True;";

        public registroProveedor()
        {
            InitializeComponent();
        }

        private void registroProveedor_Load(object sender, EventArgs e)
        {

        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO proveedores (nombre, telefono, direccion) VALUES (@nombre, @telefono, @direccion)";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@nombre", txtNombreProveedor.Text);
                    cmd.Parameters.AddWithValue("@telefono", txtTelefonoProveedor.Text);
                    cmd.Parameters.AddWithValue("@direccion", txtDireccionProveedor.Text);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Proveedor registrado exitosamente.");
                        LimpiarCamposProveedor();
                        
                    }
                    else
                    {
                        MessageBox.Show("No se pudo registrar el proveedor.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al registrar el proveedor: " + ex.Message);
                }
            }
        }

        private void LimpiarCamposProveedor()
        {
            txtNombreProveedor.Clear();
            txtTelefonoProveedor.Clear();
            txtDireccionProveedor.Clear();
        }
    }
}
