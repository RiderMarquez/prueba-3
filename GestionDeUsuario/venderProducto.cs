using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionDeUsuario
{
    public partial class venderProducto : Form
    {
        private string connectionString = "Data Source=(local)\\SQLEXPRESS;Initial Catalog=db_libreria;Integrated Security=True;";

        public venderProducto()
        {
            InitializeComponent();
            btnBuscar.Click += new EventHandler(btnBuscar_Click);
            cbNombre.SelectedIndexChanged += new EventHandler(cbNombre_SelectedIndexChanged);
            txtNitCarnet.TextChanged += new EventHandler(txtNitCarnet_TextChanged);
            sumarColumna();
            lblFecha2.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIdArticulo.Text))
            {
                MessageBox.Show("Por favor, complete el campo de búsqueda.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string input = txtIdArticulo.Text;
                    int idProducto;
                    string query;

                    // Determinar si la entrada es un ID (número) o un nombre (texto)
                    if (int.TryParse(input, out idProducto))
                    {
                        query = "SELECT id_producto, nombre_producto, precio_venta FROM productos WHERE id_producto = @input";
                    }
                    else
                    {
                        query = "SELECT id_producto, nombre_producto, precio_venta FROM productos WHERE nombre_producto LIKE '%' + @input + '%'";
                    }

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@input", input);

                    SqlDataReader reader = cmd.ExecuteReader();

                    cbNombre.Items.Clear();  // Limpiar el ComboBox antes de agregar nuevos ítems

                    while (reader.Read())
                    {
                        string nombreProducto = reader["nombre_producto"].ToString();
                        decimal precioVenta = (decimal)reader["precio_venta"];
                        int id = (int)reader["id_producto"];
                        cbNombre.Items.Add(new ComboBoxItem(id, nombreProducto, precioVenta));
                    }

                    if (cbNombre.Items.Count > 0)
                    {
                        cbNombre.SelectedIndex = 0;  // Seleccionar el primer ítem por defecto
                        MostrarPrecioSeleccionado();
                    }
                    else
                    {
                        MessageBox.Show("No se encontró el producto.");
                        txtPrecio.Clear();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al buscar el producto: " + ex.Message);
                }
            }
        }

        private void cbNombre_SelectedIndexChanged(object sender, EventArgs e)
        {
            MostrarPrecioSeleccionado();
        }

        private void txtNitCarnet_TextChanged(object sender, EventArgs e)
        {
            string carnet = txtNitCarnet.Text;

            if (string.IsNullOrWhiteSpace(carnet))
            {
                txtNombreCliente.Text = string.Empty;
                btnAñadir.Enabled = false;
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT nombre FROM clientes WHERE carnet = @carnet";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@carnet", carnet);

                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        txtNombreCliente.Text = result.ToString();
                        btnAñadir.Enabled = false;
                    }
                    else
                    {
                        txtNombreCliente.Text = string.Empty;
                        btnAñadir.Enabled = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al verificar el cliente: " + ex.Message);
                }
            }
        }

        private void MostrarPrecioSeleccionado()
        {
            if (cbNombre.SelectedItem != null)
            {
                ComboBoxItem selectedItem = (ComboBoxItem)cbNombre.SelectedItem;
                int idProducto = selectedItem.Id;

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        string query = "SELECT precio_venta FROM productos WHERE id_producto = @idProducto";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@idProducto", idProducto);
                        object result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            decimal precioVenta = (decimal)result;
                            txtPrecio.Text = precioVenta.ToString("F2");
                        }
                        else
                        {
                            MessageBox.Show("No se encontró el precio del producto.");
                            txtPrecio.Clear();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al obtener el precio del producto: " + ex.Message);
                    }
                }
            }
        }

        private void btnCargarLista_Click(object sender, EventArgs e)
        {
            // Verificar si se ha seleccionado un producto en el ComboBox
            if (cbNombre.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione un producto antes de cargarlo en la lista.");
                return;
            }

            // Obtener el producto seleccionado del ComboBox
            ComboBoxItem selectedItem = (ComboBoxItem)cbNombre.SelectedItem;
            int idProducto = selectedItem.Id;
            string nombreProducto = selectedItem.NombreProducto;
            decimal precioVenta = selectedItem.PrecioVenta;

            // Obtener la cantidad del producto del usuario
            if (!int.TryParse(txtCantidad.Text, out int cantidad) || cantidad <= 0)
            {
                MessageBox.Show("Por favor, ingrese una cantidad válida mayor que cero.");
                return;
            }

            // Verificar el stock disponible
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT stock FROM productos WHERE id_producto = @idProducto";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@idProducto", idProducto);

                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        int stockDisponible = (int)result;

                        if (cantidad > stockDisponible)
                        {
                            MessageBox.Show($"No hay suficiente stock. Cantidad disponible: {stockDisponible}.", "Stock insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se encontró el producto en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al verificar el stock del producto: " + ex.Message);
                    return;
                }
            }

            // Calcular el subtotal
            decimal subtotal = precioVenta * cantidad;

            // Agregar la fila con los datos al DataGridView
            dgvLista.Rows.Add(idProducto, nombreProducto, precioVenta, cantidad, subtotal);
            txtIdArticulo.Text = string.Empty;
            txtPrecio.Text = string.Empty;
            txtCantidad.Text = "1";
            cbNombre.SelectedIndex = -1; // Deseleccionar el ComboBox

            // Calcular y mostrar el total
            sumarColumna();
        }


        private void dgvLista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar si el evento fue desencadenado por hacer clic en una celda con el nombre "Eliminar"
            if (e.ColumnIndex >= 0 && dgvLista.Columns[e.ColumnIndex].Name == "Eliminar" && e.RowIndex >= 0)
            {
                // Mostrar un mensaje de confirmación para eliminar
                DialogResult result = MessageBox.Show("¿Estás seguro de que deseas eliminar esta fila?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Si el usuario hace clic en "Sí", proceder con la eliminación de la fila del DataGridView
                if (result == DialogResult.Yes)
                {
                    // Obtener la fila que se va a eliminar
                    DataGridViewRow row = dgvLista.Rows[e.RowIndex];

                    // Eliminar la fila del DataGridView
                    dgvLista.Rows.Remove(row);

                    // Recalcular y mostrar el total
                    sumarColumna();
                }
            }
        }

        private void sumarColumna()
        {
            decimal total = 0;

            foreach (DataGridViewRow row in dgvLista.Rows)
            {
                total += Convert.ToDecimal(row.Cells[4].Value);
            }
            lblCostoApagar.Text = total.ToString();
        }

        private void txtEfectivo_TextChanged(object sender, EventArgs e)
        {
            // Verificar si el valor ingresado en txtEfectivo es un número válido
            if (!decimal.TryParse(txtEfectivo.Text, out decimal efectivo))
            {
                // Si no es válido, mostrar un mensaje de error y limpiar el lblDevolucion
                MessageBox.Show("Por favor, ingrese un monto válido en efectivo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblDevolucion.Text = string.Empty;
                return;
            }

            // Calcular la devolución restando el efectivo del total a pagar
            decimal totalAPagar = decimal.Parse(lblCostoApagar.Text);
            decimal devolucion = efectivo - totalAPagar;

            // Mostrar la devolución en el lblDevolucion con formato de moneda
            lblDevolucion.Text = devolucion.ToString("N2");
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            // Verificar si txtNitCarnet está vacío
            if (string.IsNullOrEmpty(txtNitCarnet.Text))
            {
                MessageBox.Show("Por favor, ingrese el carnet del cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Verificar si el cliente ya existe en la base de datos
            bool clienteExiste = VerificarClienteExistente(txtNitCarnet.Text);

            if (!clienteExiste)
            {
                // Insertar un nuevo cliente en la base de datos
                InsertarNuevoCliente(txtNitCarnet.Text);
                // Mostrar un mensaje de éxito
                MessageBox.Show("Nuevo cliente añadido correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Mostrar un mensaje de error si el cliente ya existe
                MessageBox.Show("El cliente ya está registrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private bool VerificarClienteExistente(string carnet)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM clientes WHERE carnet = @carnet";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@carnet", carnet);
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al verificar la existencia del cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return true; // Devolver true en caso de error para evitar la inserción accidental
                }
            }
        }


        private void InsertarNuevoCliente(string carnet)
        {
            // Obtener el nombre del cliente desde txtNombreCliente
            string nombreCliente = txtNombreCliente.Text;

            // Conectar con la base de datos y ejecutar la consulta para insertar el nuevo cliente
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO clientes (nombre, carnet) VALUES (@nombre, @carnet)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@nombre", nombreCliente);
                    cmd.Parameters.AddWithValue("@carnet", carnet);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al añadir nuevo cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            // Verificar si el DataGridView está vacío
            if (dgvLista.Rows.Count == 0)
            {
                MessageBox.Show("La lista está vacía. No se puede proceder.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Detener la ejecución si el DataGridView está vacío
            }

            // Verificar si el TextBox txtEfectivo está vacío
            if (string.IsNullOrWhiteSpace(txtEfectivo.Text))
            {
                MessageBox.Show("El campo Efectivo está vacío. No se puede proceder.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Detener la ejecución si el campo Efectivo está vacío
            }

            // Verificar si el monto en txtEfectivo es un número válido y mayor o igual al lblCostoApagar
            if (!decimal.TryParse(txtEfectivo.Text, out decimal efectivo))
            {
                MessageBox.Show("El campo Efectivo debe ser un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Detener la ejecución si el valor en txtEfectivo no es un número válido
            }

            if (!decimal.TryParse(lblCostoApagar.Text, out decimal costoApagar))
            {
                MessageBox.Show("El valor en lblCostoApagar no es un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Detener la ejecución si el valor en lblCostoApagar no es un número válido
            }

            if (efectivo < costoApagar)
            {
                MessageBox.Show("El monto ingresado en Efectivo es insuficiente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Detener la ejecución si el monto en txtEfectivo es menor que lblCostoApagar
            }

            bool continuarSinCliente = false;
            int idCliente = -1; // Declarar idCliente fuera del bloque if

            // Verificar si el TextBox txtNitCarnet está vacío
            if (string.IsNullOrWhiteSpace(txtNitCarnet.Text))
            {
                // Mostrar un mensaje preguntando al usuario si desea continuar sin añadir puntos
                DialogResult result = MessageBox.Show("El campo NIT/Carnet está vacío. ¿Desea continuar?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.No)
                {
                    return; // Detener la ejecución si el usuario elige no continuar
                }
                else
                {
                    continuarSinCliente = true; // El usuario elige continuar sin cliente
                }
            }

            // Variables para nombre y carnet del cliente
            string nombreCliente = "S/N";
            string carnetCliente = "S/N";

            if (!continuarSinCliente)
            {
                // Obtener idCliente y otros datos del cliente desde la base de datos
                carnetCliente = txtNitCarnet.Text.Trim();
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string queryCliente = "SELECT id_cliente, nombre, carnet FROM clientes WHERE carnet = @carnet";
                    using (SqlCommand cmd = new SqlCommand(queryCliente, conn))
                    {
                        cmd.Parameters.AddWithValue("@carnet", carnetCliente);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                idCliente = reader.GetInt32(0);
                                nombreCliente = reader.GetString(1);
                                carnetCliente = reader.GetString(2);
                            }
                            else
                            {
                                MessageBox.Show("Cliente no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return; // Detener la ejecución si el cliente no se encuentra
                            }
                        }
                    }
                }
            }

            // Decrementar la cantidad de productos vendidos en la base de datos
            foreach (DataGridViewRow row in dgvLista.Rows)
            {
                int idProducto = (int)row.Cells[0].Value; // Suponiendo que el ID del producto está en la primera columna
                int cantidadVendida = (int)row.Cells["Column4"].Value; // Ajustar el nombre de la columna si es necesario

                // Actualizar la cantidad disponible del producto en la base de datos
                RestarCantidadProducto(idProducto, cantidadVendida);
            }

            // Generar la factura en la base de datos
            int idFactura;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlTransaction transaction = conn.BeginTransaction())
                {
                    try
                    {
                        // Insertar en la tabla factura
                        string queryFactura = "INSERT INTO factura (id_cliente, fecha_emision, total_factura) OUTPUT INSERTED.id_factura VALUES (@id_cliente, @fecha_emision, @total_factura)";
                        using (SqlCommand cmd = new SqlCommand(queryFactura, conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("@id_cliente", continuarSinCliente ? (object)DBNull.Value : idCliente);
                            cmd.Parameters.AddWithValue("@fecha_emision", DateTime.Now);
                            cmd.Parameters.AddWithValue("@total_factura", costoApagar);

                            idFactura = (int)cmd.ExecuteScalar();
                        }

                        // Insertar en la tabla detalle_factura
                        foreach (DataGridViewRow row in dgvLista.Rows)
                        {
                            int idProducto = (int)row.Cells[0].Value;
                            int cantidad = (int)row.Cells["Column4"].Value;
                            decimal precioUnitario = (decimal)row.Cells[2].Value;
                            decimal subtotal = cantidad * precioUnitario;

                            string queryDetalle = "INSERT INTO detalle_factura (id_factura, id_producto, cantidad, precio_unitario, subtotal) VALUES (@id_factura, @id_producto, @cantidad, @precio_unitario, @subtotal)";
                            using (SqlCommand cmd = new SqlCommand(queryDetalle, conn, transaction))
                            {
                                cmd.Parameters.AddWithValue("@id_factura", idFactura);
                                cmd.Parameters.AddWithValue("@id_producto", idProducto);
                                cmd.Parameters.AddWithValue("@cantidad", cantidad);
                                cmd.Parameters.AddWithValue("@precio_unitario", precioUnitario);
                                cmd.Parameters.AddWithValue("@subtotal", subtotal);

                                cmd.ExecuteNonQuery();
                            }
                        }

                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Error al realizar la venta: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }

            // Generar el archivo de factura
            try
            {
                // Obtener la ruta completa de la carpeta "Documentos" del usuario actual
                string documentosPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

                // Generar nombre único para el archivo de factura usando fecha y hora
                string timestamp = DateTime.Now.ToString("yyyyMMdd_HHmmss");
                string facturaFileName = $"Factura_{timestamp}.txt";

                // Ruta completa del archivo de la factura
                string filePath = Path.Combine(documentosPath, facturaFileName);

                // Generar el archivo de factura
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    writer.WriteLine("LIBRERÍA BOLIVIA MAR");
                    writer.WriteLine("**********************************");
                    writer.WriteLine("Dirc: xxxx");
                    writer.WriteLine("Tel:xxxx");
                    writer.WriteLine("Nit: xxxx");
                    writer.WriteLine("");
                    writer.WriteLine("Factura de Venta");
                    writer.WriteLine("No Fac: " + idFactura);
                    writer.WriteLine("Fecha: " + DateTime.Now.ToShortDateString() + " Hora: " + DateTime.Now.ToShortTimeString());
                    writer.WriteLine("Le Atendio: " + Form1.NombreUsuario); // Aquí se usa el nombre de usuario obtenido
                    writer.WriteLine("Cliente: " + nombreCliente); // Aquí se añade el nombre del cliente o "S/N"
                    writer.WriteLine("Carnet: " + carnetCliente); // Aquí se añade el carnet del cliente o "S/N"
                    writer.WriteLine("");
                    writer.WriteLine("----------------------------------");
                    writer.WriteLine("Artículo\tPrecio\tCantidad");

                    foreach (DataGridViewRow r in dgvLista.Rows)
                    {
                        string articulo = r.Cells[1].Value.ToString();
                        double precio = double.Parse(r.Cells[2].Value.ToString());
                        int cantidad = int.Parse(r.Cells["Column4"].Value.ToString());
                        double subtotal = double.Parse(r.Cells[4].Value.ToString());
                        writer.WriteLine($"{articulo}\t{precio:F2}\t{cantidad}");
                    }

                    writer.WriteLine("----------------------------------");
                    writer.WriteLine("Sub-Total: " + costoApagar.ToString("F2"));
                    writer.WriteLine("Total: " + costoApagar.ToString("F2"));
                    writer.WriteLine("");
                    writer.WriteLine("Efectivo Entregado: " + efectivo.ToString("F2"));
                    writer.WriteLine("Efectivo Devuelto: " + (efectivo - costoApagar).ToString("F2"));
                    writer.WriteLine("");
                    writer.WriteLine("**********************************");
                    writer.WriteLine("*     Gracias por preferirnos    *");
                    writer.WriteLine("**********************************");
                }

                MessageBox.Show("¡Venta realizada con éxito! Factura generada en 'Documentos\\" + facturaFileName + "'");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar la factura: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Llamar a la función para restablecer el formulario
            txtIdArticulo.Clear();
            cbNombre.SelectedIndex = -1; // Si es un ComboBox
            txtPrecio.Clear();
            txtCantidad.Text = "1";
            dgvLista.Rows.Clear();
            lblCostoApagar.Text = "0.00";
            txtEfectivo.Clear();
            lblDevolucion.Text = "0.00";
            txtNitCarnet.Clear();
            txtNombreCliente.Clear();
        }



        private void RestarCantidadProducto(int idProducto, int cantidadVendida)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Consulta para actualizar la cantidad disponible del producto
                    string query = "UPDATE productos SET stock = stock - @cantidadVendida WHERE id_producto = @idProducto";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@cantidadVendida", cantidadVendida);
                    cmd.Parameters.AddWithValue("@idProducto", idProducto);

                    // Ejecutar la consulta
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al restar la cantidad del producto en la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegistrarCliente_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario RegistroCliente
            RegistroCliente registroClienteForm = new RegistroCliente();

            // Mostrar el formulario RegistroCliente
            registroClienteForm.Show();
        }

    }

    public class ComboBoxItem
    {
        public int Id { get; }
        public string NombreProducto { get; }
        public decimal PrecioVenta { get; }

        public ComboBoxItem(int id, string nombreProducto, decimal precioVenta)
        {
            Id = id;
            NombreProducto = nombreProducto;
            PrecioVenta = precioVenta;
        }

        public override string ToString()
        {
            return NombreProducto;
        }
    }
}
