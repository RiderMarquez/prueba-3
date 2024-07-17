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
    public partial class registroPedido : Form
    {
        private string connectionString = "Data Source=(local)\\SQLEXPRESS;Initial Catalog=db_libreria;Integrated Security=True;";

        public registroPedido()
        {
            InitializeComponent();
            this.Load += new EventHandler(registroPedido_Load);
        }


        private void registroPedido_Load(object sender, EventArgs e)
        {
            LlenarComboBoxes();
        }
        private void LlenarComboBoxes()

        {

 
            LlenarComboBox("SELECT id_proveedor FROM proveedores", cbxIdProveedor);
            LlenarComboBox("SELECT id_producto FROM productos", cbxIdProducto);
        }


        private void LlenarComboBox(string query, ComboBox comboBox)

        {
            comboBox.Items.Clear();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        comboBox.Items.Add(reader[0].ToString());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al llenar el ComboBox: " + ex.Message);
                }
            }
        }

        private void btnBusca_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM productos WHERE nombre_producto=@nombre_producto";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@nombre_producto", txbBusPro.Text);

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        

                        cbxIdProveedor.SelectedItem = reader["id_proveedor"].ToString();
                        cbxIdProducto.SelectedItem = reader["id_producto"].ToString();
                        

                        
                    }
                    else
                    {
                        MessageBox.Show("No se encontró el producto.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al leer el producto: " + ex.Message);
                }
            }
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO pedido (fecha_pedido, total_pedido, id_producto, id_proveedor) " +
                                   "VALUES (@fecha_pedido, @total_pedido, @id_producto, @id_proveedor)";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@fecha_pedido", dtpFechaPedido.Value);
                    cmd.Parameters.AddWithValue("@total_pedido", decimal.Parse(txtTotalPedido.Text));
                    cmd.Parameters.AddWithValue("@id_producto", (cbxIdProducto.SelectedItem as dynamic));
                    cmd.Parameters.AddWithValue("@id_proveedor", (cbxIdProveedor.SelectedItem as dynamic));

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Pedido registrado exitosamente.");
                        LimpiarCampos();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo registrar el pedido.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al registrar el pedido: " + ex.Message);
                }
            }
        }
        private void LimpiarCampos()
        {
            dtpFechaPedido.Value = DateTime.Now;
            txtTotalPedido.Clear();
            cbxIdProducto.SelectedIndex = -1;
            cbxIdProveedor.SelectedIndex = -1;
        }
    }
}
