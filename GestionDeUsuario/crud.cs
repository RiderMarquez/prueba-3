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
    public partial class crud : Form
    {
        private SqlConnection conexion;
        public crud()
        {

            InitializeComponent();
            // Inicializar la conexión en el constructor del formulario
            conexion = new SqlConnection("Data Source=(local)\\SQLEXPRESS;Initial Catalog=db_libreria;Integrated Security=True;");
            // Suscribir el evento Load del formulario al método crud_Load
            this.Load += new EventHandler(crud_Load);
            textBox2.TextChanged += new EventHandler(textBox2_TextChanged);

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
            txtId.Text = "";
            txtNombre.Text = "";
            txtCelular.Text = "";
            txtDireccion.Text = "";
            txtCi.Text = "";
        }
        private void CargarListaVendedores()
        {
            try
            {
                // Se crea un nuevo objeto DataTable para almacenar los datos de los vendedores
                DataTable dtVendedores = new DataTable();

                // Se crea un nuevo SqlDataAdapter para ejecutar la consulta SQL y llenar el DataTable con los resultados
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM encargados", conexion);

                // Se utiliza el método Fill del SqlDataAdapter para llenar el DataTable con los datos obtenidos de la consulta
                adapter.Fill(dtVendedores);

                // Se establece el origen de datos del control DataGridView como el DataTable lleno con los datos de los vendedores
                dataGridView1.DataSource = dtVendedores;
            }
            catch (Exception ex)
            {
                // Si ocurre un error durante la carga de los datos, se captura la excepción y se muestra un mensaje de error al usuario
                MessageBox.Show("Error al cargar la lista de vendedores: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                string query = "INSERT INTO encargados(id_encargados, nombre, num_cel, direccion, carnet) " +
                               "VALUES (@id, @nombre, @numCel, @direccion, @carnet)";
                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@id", txtId.Text);
                cmd.Parameters.AddWithValue("@nombre", txtNombre.Text);
                cmd.Parameters.AddWithValue("@numCel", txtCelular.Text);
                cmd.Parameters.AddWithValue("@direccion", txtDireccion.Text);
                cmd.Parameters.AddWithValue("@carnet", txtCi.Text);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Registro insertado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCamposRegistro();
                CargarListaVendedores();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar el vendedor: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM encargados WHERE nombre LIKE @nombre", conexion);
                    // Se agrega un parámetro llamado @nombre a la consulta SQL, que será reemplazado por el valor de nombreBusqueda
                    // El símbolo '%' al inicio y al final de nombreBusqueda indica que se buscarán coincidencias parciales en el nombre
                    adapter.SelectCommand.Parameters.AddWithValue("@nombre", "%" + nombreBusqueda + "%");
                    // Se ejecuta la consulta SQL y se llenan los datos obtenidos en el DataTable dtResultado
                    adapter.Fill(dtResultado);
                    // Se establece el origen de datos del control dataGridView1 como el DataTable dtResultado
                    // Esto mostrará los resultados de la búsqueda en el control DataGridView
                    dataGridView1.DataSource = dtResultado;
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void mODIFICARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // Verificar si se ha seleccionado una fila en el DataGridView
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    // Obtener el ID del vendedor seleccionado
                    string id = dataGridView1.SelectedRows[0].Cells["id_encargados"].Value.ToString();

                    // Mostrar un mensaje de confirmación para la modificación
                    DialogResult result = MessageBox.Show("¿Estás seguro de modificar este vendedor?", "Confirmar modificación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    // Verificar si se confirma la modificación
                    if (result == DialogResult.Yes)
                    {
                        // Obtener los datos del vendedor seleccionado del DataGridView
                        string nombre = dataGridView1.SelectedRows[0].Cells["nombre"].Value.ToString();
                        string numCel = dataGridView1.SelectedRows[0].Cells["num_cel"].Value.ToString();
                        string direccion = dataGridView1.SelectedRows[0].Cells["direccion"].Value.ToString();
                        string carnet = dataGridView1.SelectedRows[0].Cells["carnet"].Value.ToString();

                        // Si se ha escrito algo en los TextBox, usar esos valores en lugar de los del vendedor seleccionado
                        if (!string.IsNullOrEmpty(txtNombre.Text))
                        {
                            nombre = txtNombre.Text;
                        }
                        if (!string.IsNullOrEmpty(txtCelular.Text))
                        {
                            numCel = txtCelular.Text;
                        }
                        if (!string.IsNullOrEmpty(txtDireccion.Text))
                        {
                            direccion = txtDireccion.Text;
                        }
                        if (!string.IsNullOrEmpty(txtCi.Text))
                        {
                            carnet = txtCi.Text;
                        }

                        // Ejecutar la modificación
                        string query = "UPDATE encargados SET nombre = @nombre, num_cel = @numCel, direccion = @direccion, carnet = @carnet WHERE id_encargados = @id";
                        SqlCommand cmd = new SqlCommand(query, conexion);
                        cmd.Parameters.AddWithValue("@nombre", nombre);
                        cmd.Parameters.AddWithValue("@numCel", numCel);
                        cmd.Parameters.AddWithValue("@direccion", direccion);
                        cmd.Parameters.AddWithValue("@carnet", carnet);
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();

                        // Actualizar la lista de vendedores después de la modificación
                        CargarListaVendedores();

                        MessageBox.Show("Vendedor modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Limpiar los campos después de la modificación (si es necesario)
                        LimpiarCamposRegistro();
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un vendedor para modificar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);//mensaje de error si no seleccionamos el vendedor en el listar 
                }
            }
             catch (Exception ex)
            {
                 MessageBox.Show("Error al modificar el vendedor: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);//mensaje de error si no se modifica el vendedor 
            }

        }

        private void eLIMINARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // Verificar si se ha seleccionado una fila en el DataGridView
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    // Obtener el ID del vendedor seleccionado
                    string id = dataGridView1.SelectedRows[0].Cells["id_encargados"].Value.ToString();

                    // Mostrar un mensaje de confirmación para la eliminación
                    DialogResult result = MessageBox.Show("¿Estás seguro de eliminar este vendedor?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    // Verificar si se confirma la eliminación
                    if (result == DialogResult.Yes)
                    {
                        // Crear la consulta SQL para eliminar al vendedor
                        string query = "DELETE FROM encargados WHERE id_encargados = @id";
                        SqlCommand cmd = new SqlCommand(query, conexion);
                        cmd.Parameters.AddWithValue("@id", id);

                        // Ejecutar la consulta
                        cmd.ExecuteNonQuery();

                        // Actualizar la lista de vendedores después de la eliminación
                        CargarListaVendedores();

                        MessageBox.Show("Vendedor eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Limpiar los campos después de la eliminación (si es necesario)
                        LimpiarCamposRegistro();
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un vendedor para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el vendedor: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void nUEVOToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
