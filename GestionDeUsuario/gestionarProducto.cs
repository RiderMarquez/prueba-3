using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GestionDeUsuario
{
    public partial class gestionarProducto : Form
    {
        private string connectionString = "Data Source=(local)\\SQLEXPRESS;Initial Catalog=db_libreria;Integrated Security=True;";

        public gestionarProducto()
        {
            InitializeComponent();
           // ProbarConexion();
            this.Load += new EventHandler(gestionarProducto_Load);
            chkHabilitarFecha.CheckedChanged += checkBox1_CheckedChanged;
            dtpFecha.Enabled = false;
        }

        private void gestionarProducto_Load(object sender, EventArgs e)
        {
            LlenarComboBoxes();
            CargarDatos();
        }

        private void LlenarComboBoxes()

        {
            
            LlenarComboBox("SELECT id_encargado FROM encargados", cbxIdEncarg);
            LlenarComboBox("SELECT id_proveedor FROM proveedores", cbxIdProve);
            LlenarComboBox("SELECT id_admin FROM administradores", cbxIdAdm);
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
        private void RbHabilitarFecha_CheckedChanged(object sender, EventArgs e)
        {
       //     dtpFecha.Enabled = RbHabilitarFecha.Checked;
        }


        // CRUD
        // Funcion para Ingresar datos

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnActualizar_Click_1(object sender, EventArgs e)
        {
            
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
        }

        private void CargarDatos()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT id_producto, id_proveedor, id_admin, id_encargado, nombre_producto, precio_compra, precio_venta, fecha_vencimiento , stock FROM productos";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridProductos.DataSource = dt;

                    // Asignar nombres a las columnas
                    dataGridProductos.Columns["id_producto"].HeaderText = "ID Producto";
                    dataGridProductos.Columns["id_proveedor"].HeaderText = "ID Proveedor";
                    dataGridProductos.Columns["id_admin"].HeaderText = "ID Admin";
                    dataGridProductos.Columns["id_encargado"].HeaderText = "ID Encargado";
                    dataGridProductos.Columns["nombre_producto"].HeaderText = "Nombre Producto";
                    dataGridProductos.Columns["precio_compra"].HeaderText = "Precio Compra";
                    dataGridProductos.Columns["precio_venta"].HeaderText = "Precio Venta";
                    dataGridProductos.Columns["fecha_vencimiento"].HeaderText = "Fecha Vencimiento";
                    dataGridProductos.Columns["stock"].HeaderText = "Stock";

                    // Formato de fecha para manejar valores nulos
                    dataGridProductos.Columns["fecha_vencimiento"].DefaultCellStyle.NullValue = "Sin Fecha";
                    dataGridProductos.Columns["fecha_vencimiento"].DefaultCellStyle.Format = "d"; // Formato de fecha corta
                    
                    LimpiarCampos();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los datos: " + ex.Message);
                }
            }
        }

        private bool ValidarEntrada()
        {
            if (string.IsNullOrEmpty(txtNombreProducto.Text) ||
        cbxIdProve.SelectedItem == null ||
        cbxIdAdm.SelectedItem == null ||
        cbxIdEncarg.SelectedItem == null ||
        string.IsNullOrEmpty(txtPrecioCompra.Text) ||
        string.IsNullOrEmpty(txtPrecioVenta.Text) ||
        string.IsNullOrEmpty(txtStock.Text))
            {
                MessageBox.Show("Por favor, completa todos los campos.");
                return false;
            }

            return true;
        }

        
        private void LimpiarCampos()
        {
            txtStock.Clear();
            cbxIdProve.SelectedIndex = -1;
            cbxIdAdm.SelectedIndex = -1;
            cbxIdEncarg.SelectedIndex = -1;
            txtNombreProducto.Clear();
            txtPrecioCompra.Clear();
            txtPrecioVenta.Clear();
            dtpFecha.Value = DateTime.Now;
            dtpFecha.Enabled = false;
            chkHabilitarFecha.Checked = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnCargarDatos_Click_1(object sender, EventArgs e)
        {
            CargarDatos();

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            dtpFecha.Enabled = chkHabilitarFecha.Checked;
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
                        txtNombreProducto.Text = reader["nombre_producto"].ToString();

                        cbxIdProve.SelectedItem = reader["id_proveedor"].ToString();
                        cbxIdAdm.SelectedItem = reader["id_admin"].ToString();
                        cbxIdEncarg.SelectedItem = reader["id_encargado"].ToString();
                        txtPrecioCompra.Text = reader["precio_compra"].ToString();
                        txtPrecioVenta.Text = reader["precio_venta"].ToString();
                        txtStock.Text = reader["stock"].ToString();

                        if (reader["fecha_vencimiento"] != DBNull.Value)
                        {
                            dtpFecha.Value = DateTime.Parse(reader["fecha_vencimiento"].ToString());
                            chkHabilitarFecha.Checked = true;
                        }
                        else
                        {
                            dtpFecha.Value = DateTime.Now;
                            chkHabilitarFecha.Checked = false;
                        }
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

        private void btnElimin_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "DELETE FROM productos WHERE nombre_producto=@nombre_producto";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@nombre_producto", txtNombreProducto.Text);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Producto eliminado exitosamente.");
                        CargarDatos();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar el producto.");
                    }
                    LimpiarCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el producto: " + ex.Message);
                }
            }
        }

        private void btnActulizar_Click(object sender, EventArgs e)
        {
            if (!ValidarEntrada()) return;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE productos SET id_proveedor=@id_proveedor, id_admin=@id_admin, id_encargado=@id_encargado, " +
                                   "precio_compra=@precio_compra, precio_venta=@precio_venta, fecha_vencimiento=@fecha_vencimiento, stock=@stock " +
                                   "WHERE nombre_producto=@nombre_producto";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id_proveedor", int.Parse(cbxIdProve.SelectedItem?.ToString() ?? "0"));
                    cmd.Parameters.AddWithValue("@id_admin", int.Parse(cbxIdAdm.SelectedItem?.ToString() ?? "0"));
                    cmd.Parameters.AddWithValue("@id_encargado", int.Parse(cbxIdEncarg.SelectedItem?.ToString() ?? "0"));
                    cmd.Parameters.AddWithValue("@nombre_producto", txtNombreProducto.Text);
                    cmd.Parameters.AddWithValue("@precio_compra", decimal.Parse(txtPrecioCompra.Text));
                    cmd.Parameters.AddWithValue("@precio_venta", decimal.Parse(txtPrecioVenta.Text));
                    cmd.Parameters.AddWithValue("@stock", int.Parse(txtStock.Text));

                    if (chkHabilitarFecha.Checked)
                    {
                        cmd.Parameters.AddWithValue("@fecha_vencimiento", dtpFecha.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@fecha_vencimiento", DBNull.Value);
                    }

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Producto actualizado exitosamente.");
                        CargarDatos();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo actualizar el producto.");
                    }
                    LimpiarCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar el producto: " + ex.Message);
                }
            }
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (!ValidarEntrada()) return;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO productos (id_proveedor, id_admin, id_encargado, nombre_producto, precio_compra, precio_venta, fecha_vencimiento, stock) " +
                                   "VALUES (@id_proveedor, @id_admin, @id_encargado, @nombre_producto, @precio_compra, @precio_venta, @fecha_vencimiento, @stock)";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id_proveedor", int.Parse(cbxIdProve.SelectedItem?.ToString() ?? "0"));
                    cmd.Parameters.AddWithValue("@id_admin", int.Parse(cbxIdAdm.SelectedItem?.ToString() ?? "0"));
                    cmd.Parameters.AddWithValue("@id_encargado", int.Parse(cbxIdEncarg.SelectedItem?.ToString() ?? "0"));
                    cmd.Parameters.AddWithValue("@nombre_producto", txtNombreProducto.Text);
                    cmd.Parameters.AddWithValue("@precio_compra", decimal.Parse(txtPrecioCompra.Text));
                    cmd.Parameters.AddWithValue("@precio_venta", decimal.Parse(txtPrecioVenta.Text));
                    cmd.Parameters.AddWithValue("@stock", int.Parse(txtStock.Text));

                    if (chkHabilitarFecha.Checked)
                    {
                        cmd.Parameters.AddWithValue("@fecha_vencimiento", dtpFecha.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@fecha_vencimiento", DBNull.Value);
                    }

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Producto agregado exitosamente.");
                        CargarDatos();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo agregar el producto.");
                    }
                    LimpiarCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al agregar el producto: " + ex.Message);
                }
            }
        }

        private void btnRegistoPedido_Click(object sender, EventArgs e)
        {
            using (registroPedido frmRegistroPedido = new registroPedido())
            {
                frmRegistroPedido.ShowDialog();
            }

        }

        private void btnRegistroProvee_Click(object sender, EventArgs e)
        {
            using (registroProveedor frmRegistroProveedor = new registroProveedor())
            {
                frmRegistroProveedor.ShowDialog();
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM productos WHERE fecha_vencimiento < @fecha_actual";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@fecha_actual", DateTime.Now);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridProductos.DataSource = dt;

                    // Asignar nombres a las columnas
                    dataGridProductos.Columns["id_producto"].HeaderText = "ID Producto";
                    dataGridProductos.Columns["id_proveedor"].HeaderText = "ID Proveedor";
                    dataGridProductos.Columns["id_admin"].HeaderText = "ID Admin";
                    dataGridProductos.Columns["id_encargado"].HeaderText = "ID Encargado";
                    dataGridProductos.Columns["nombre_producto"].HeaderText = "Nombre Producto";
                    dataGridProductos.Columns["precio_compra"].HeaderText = "Precio Compra";
                    dataGridProductos.Columns["precio_venta"].HeaderText = "Precio Venta";
                    dataGridProductos.Columns["fecha_vencimiento"].HeaderText = "Fecha Vencimiento";
                    dataGridProductos.Columns["stock"].HeaderText = "Stock";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al listar productos vencidos: " + ex.Message);
                }
            }
        }

        private void btnRefescarDatos_Click(object sender, EventArgs e)
        {
            LlenarComboBoxes();
            CargarDatos();

        }
    }
}
