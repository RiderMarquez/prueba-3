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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GestionDeUsuario
{
    public partial class RegistroCliente : Form
    {
        private SqlConnection conexion;
        public RegistroCliente()
        {
            InitializeComponent();
            // Inicializar la conexión en el constructor del formulario
            conexion = new SqlConnection("Data Source=(local)\\SQLEXPRESS;Initial Catalog=db_libreria;Integrated Security=True;");
            // Suscribir el evento Load del formulario al método crud_Load
            this.Load += new EventHandler(crud_Load);
            textBox2.TextChanged += new EventHandler(textBox2_TextChanged);
        }

        private void btnSalirCliente_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void crud_Load(object sender, EventArgs e)
        {
            try
            {
                // Abre la conexión al cargar el formulario
                conexion.Open();
                LimpiarCamposRegistro();//METODO PARA LIMPIAR LOS TEXBOX DE GRUPO DATOS 
                CargarListaVendedores();//ESTO METODO NOS AYUDA A CARGAR EN EL DATAGRIDVIEW LA LISTA VENDEDORES REGISTRADOS 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar con la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);//MENSAJE QUE NOS AVISARA SI HAY CONEXIÓN CON LA BASE DE DATOS 
            }
        }
        private void LimpiarCamposRegistro()
        {
            txtNombre.Text = "";
            txtCelular.Text = "";
            txtCi.Text = "";
            txtcorreo.Text = "";
        }
        private void CargarListaVendedores()
        {
            try
            {
                string query = "SELECT * FROM clientes";
                SqlDataAdapter da = new SqlDataAdapter(query, conexion);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView2.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la lista de clientes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                // Se obtiene el texto ingresado en el textBox2 y se eliminan los espacios en blanco al inicio y al final
                string nombreBusqueda = textBox2.Text.Trim();
                // Se verifica si el texto ingresado no está vacío ni nulo
                if (!string.IsNullOrEmpty(nombreBusqueda))
                {
                    // Se crea un nuevo objeto DataTable llamado dtResultado para almacenar los resultados de la consulta SQL
                    DataTable dtResultado = new DataTable();
                    // Se crea un nuevo SqlDataAdapter llamado adapter para ejecutar la consulta SQL
                    // La consulta selecciona todos los registros de la tabla encargados donde el nombre coincide parcialmente con el texto ingresado en textBox2
                    SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM clientes WHERE nombre LIKE @nombre", conexion);
                    // Se agrega un parámetro llamado @nombre a la consulta SQL, que será reemplazado por el valor de nombreBusqueda
                    // El símbolo '%' al inicio y al final de nombreBusqueda indica que se buscarán coincidencias parciales en el nombre
                    adapter.SelectCommand.Parameters.AddWithValue("@nombre", "%" + nombreBusqueda + "%");
                    // Se ejecuta la consulta SQL y se llenan los datos obtenidos en el DataTable dtResultado
                    adapter.Fill(dtResultado);
                    // Se establece el origen de datos del control dataGridView1 como el DataTable dtResultado
                    // Esto mostrará los resultados de la búsqueda en el control DataGridView
                    dataGridView2.DataSource = dtResultado;
                }
                else
                {
                    // Si el textBox2 está vacío, se carga la lista completa de vendedores llamando al método CargarListaVendedores
                    CargarListaVendedores();
                }
            }
            catch (Exception ex)
            {
                // Si ocurre una excepción durante la búsqueda de vendedores, se muestra un mensaje de error al usuario
                MessageBox.Show("Error al buscar vendedor: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void nUEVOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LimpiarCamposRegistro();
        }

        private void rEGISTRARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // Verificar si el campo nombre está vacío
                if (string.IsNullOrEmpty(txtNombre.Text))
                {
                    MessageBox.Show("Por favor, ingrese el nombre del encargado.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Salir del método sin ejecutar la inserción
                }

                // Si el campo nombre tiene contenido, continuar con la inserción
                string query = "INSERT INTO clientes(nombre, num_cel, carnet, correo_elec) " +
                               "VALUES (@nombre, @numCel, @carnet, @correo_elec)";
                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@nombre", txtNombre.Text);
                cmd.Parameters.AddWithValue("@numCel", txtCelular.Text);
                cmd.Parameters.AddWithValue("@carnet", txtCi.Text);
                cmd.Parameters.AddWithValue("@correo_elec", txtcorreo.Text);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Registro insertado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCamposRegistro();

                // Cargar la lista de clientes en el DataGridView
                CargarListaClientes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar el cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método para cargar la lista de clientes desde la base de datos al DataGridView
        void CargarListaClientes()
        {
            try
            {
                string query = "SELECT * FROM clientes";
                SqlDataAdapter da = new SqlDataAdapter(query, conexion);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView2.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la lista de clientes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void mODIFICARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // Verificar si se ha seleccionado una fila en el DataGridView
                if (dataGridView2.SelectedRows.Count > 0)
                {
                    // Obtener el ID del cliente seleccionado
                    int idCliente = Convert.ToInt32(dataGridView2.SelectedRows[0].Cells["id_cliente"].Value);

                    // Mostrar un mensaje de confirmación para la modificación
                    DialogResult result = MessageBox.Show("¿Estás seguro de modificar este cliente?", "Confirmar modificación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    // Verificar si se confirma la modificación
                    if (result == DialogResult.Yes)
                    {
                        // Obtener los nuevos valores de los TextBox (si se han modificado)
                        string nombre = txtNombre.Text;
                        string numCel = txtCelular.Text;
                        string carnet = txtCi.Text;
                        string correo = txtcorreo.Text;

                        // Ejecutar la modificación
                        string query = "UPDATE clientes SET nombre = @nombre, num_cel = @numCel, carnet = @carnet, correo_elec = @correo_elec WHERE id_cliente = @idCliente";
                        SqlCommand cmd = new SqlCommand(query, conexion);
                        cmd.Parameters.AddWithValue("@nombre", nombre);
                        cmd.Parameters.AddWithValue("@numCel", numCel);
                        cmd.Parameters.AddWithValue("@carnet", carnet);
                        cmd.Parameters.AddWithValue("@correo_elec", correo);
                        cmd.Parameters.AddWithValue("@idCliente", idCliente);
                        cmd.ExecuteNonQuery();

                        // Actualizar la lista de clientes después de la modificación
                        CargarListaClientes();

                        MessageBox.Show("Cliente modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Limpiar los campos después de la modificación
                        LimpiarCamposRegistro();
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un cliente para modificar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar el cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void eLIMINARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // Verificar si se ha seleccionado una fila en el DataGridView
                if (dataGridView2.SelectedRows.Count > 0)
                {
                    // Obtener el ID del cliente seleccionado
                    int idCliente = Convert.ToInt32(dataGridView2.SelectedRows[0].Cells["id_cliente"].Value);
                    string nombre = dataGridView2.SelectedRows[0].Cells["nombre"].Value.ToString();

                    // Mostrar un mensaje de confirmación para la eliminación
                    DialogResult result = MessageBox.Show("¿Estás seguro de eliminar al cliente '" + nombre + "'?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    // Verificar si se confirma la eliminación
                    if (result == DialogResult.Yes)
                    {
                        // Ejecutar la eliminación
                        string query = "DELETE FROM clientes WHERE id_cliente = @idCliente";
                        SqlCommand cmd = new SqlCommand(query, conexion);
                        cmd.Parameters.AddWithValue("@idCliente", idCliente);
                        cmd.ExecuteNonQuery();

                        // Actualizar la lista de clientes después de la eliminación
                        CargarListaClientes();

                        MessageBox.Show("Cliente eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Limpiar los campos después de la eliminación (si es necesario)
                        LimpiarCamposRegistro();
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un cliente para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RegistroCliente_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                // Se obtiene el texto ingresado en el txtBuscarCliente y se eliminan los espacios en blanco al inicio y al final
                string nombreBusqueda = textBox2.Text.Trim();

                // Se crea un nuevo objeto DataTable llamado dtResultado para almacenar los resultados de la consulta SQL
                DataTable dtResultado = new DataTable();

                // Se crea un nuevo SqlDataAdapter llamado adapter para ejecutar la consulta SQL
                // La consulta selecciona todos los registros de la tabla clientes donde el nombre coincide parcialmente con el texto ingresado en txtBuscarCliente
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM clientes WHERE nombre LIKE @nombre", conexion);

                // Se agrega un parámetro llamado @nombre a la consulta SQL, que será reemplazado por el valor de nombreBusqueda
                // El símbolo '%' al inicio y al final de nombreBusqueda indica que se buscarán coincidencias parciales en el nombre
                adapter.SelectCommand.Parameters.AddWithValue("@nombre", "%" + nombreBusqueda + "%");

                // Se ejecuta la consulta SQL y se llenan los datos obtenidos en el DataTable dtResultado
                adapter.Fill(dtResultado);

                // Se establece el origen de datos del control dataGridViewClientes como el DataTable dtResultado
                // Esto mostrará los resultados de la búsqueda en el control DataGridView
                dataGridView2.DataSource = dtResultado;
            }
            catch (Exception ex)
            {
                // Si ocurre una excepción durante la búsqueda de clientes, se muestra un mensaje de error al usuario
                MessageBox.Show("Error al buscar cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
