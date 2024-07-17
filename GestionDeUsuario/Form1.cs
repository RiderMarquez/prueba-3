using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GestionDeUsuario
{
    public partial class Form1 : Form
    {
        private SqlConnection conexion;
        private bool sesionIniciada = false;
        private TipoUsuario tipoUsuario;
        public static string NombreUsuario { get; private set; }


        public enum TipoUsuario
        {
            Vendedor,
            Administrador
        }

        public Form1()
        {
            InitializeComponent();
            conexion = new SqlConnection("Data Source=(local)\\SQLEXPRESS;Initial Catalog=db_libreria;Integrated Security=True;");
            try
            {
                // Abrir la conexión al cargar el formulario
                conexion.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar con la base de datos: " + ex.Message, "Error",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (sesionIniciada)
            {
                MessageBox.Show("Ya ha iniciado sesión. Por favor, cierre sesión para volver a ingresar.",
               "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                string nombreUsuario = textBox1.Text;
                string contrasena = textBox2.Text;
                string query = "SELECT carnet FROM encargados WHERE nombre = @nombreUsuario";
                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    string carnetGuardado = reader["carnet"].ToString();
                    reader.Close();
                    if (contrasena == carnetGuardado)
                    {
                        // Inicio de sesión exitoso como vendedor
                        tipoUsuario = TipoUsuario.Vendedor;
                        MessageBox.Show("Inicio de sesión exitoso como vendedor.", "Éxito",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MostrarPanelDeContro(nombreUsuario);
                        LimpiarCamposLogin();
                        sesionIniciada = true;
                        this.Hide(); // Ocultar el formulario de inicio de sesión
                    }
                    else
                    {
                        MessageBox.Show("Contraseña incorrecta.", "Error", MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                    }
                }
                else
                {
                    reader.Close();
                    query = "SELECT num_cel FROM administradores WHERE nombre = @nombreUsuario";
                    cmd = new SqlCommand(query, conexion);
                    cmd.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);
                    reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        string celularGuardado = reader["num_cel"].ToString();
                        reader.Close();
                        if (contrasena == celularGuardado)
                        {
                            // Inicio de sesión exitoso como administrador
                            tipoUsuario = TipoUsuario.Administrador;
                            MessageBox.Show("Inicio de sesión exitoso como administrador.", "Éxito",
                           MessageBoxButtons.OK, MessageBoxIcon.Information);
                            MostrarPanelDeContro(nombreUsuario);
                            LimpiarCamposLogin();
                            sesionIniciada = true;
                            this.Hide(); // Ocultar el formulario de inicio de sesión
                        }
                        else
                        {
                            MessageBox.Show("Contraseña incorrecta.", "Error", MessageBoxButtons.OK,
                           MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Usuario no encontrado.", "Error", MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al iniciar sesión: " + ex.Message, "Error",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void MostrarPanelDeContro(string nombreVendedor)
        {
            PanelDeContro formularioVendedor = new PanelDeContro(tipoUsuario);
            formularioVendedor.ShowDialog();
            
            this.Hide();// Mostrar el formulario de inicio de sesión nuevamente al cerrar el formulario del vendedor
        }
        private void LimpiarCamposLogin()
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}