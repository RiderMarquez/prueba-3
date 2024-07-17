using iTextSharp.text.pdf;
using iTextSharp.text;
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
using System.IO;

namespace GestionDeUsuario
{
    public partial class GestionReportes : Form
    {
        string connectionString = "Data Source=(local)\\SQLEXPRESS;Initial Catalog=db_libreria;Integrated Security=True;";
        public GestionReportes()
        {
            InitializeComponent();
            CargarFechasVencimientoEnComboBox();
            CargarProveedoresEnComboBox();
            CargarClientesEnComboBox();
            CargarProductosEnComboBox();
        }

        private void rbtRVP_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtRVP.Checked)
            {
                gbxRVP.Enabled = true;
                string query = @"
                    SELECT 
                        UPPER(REPLACE(cl.nombre, '_', ' ')) AS nombre_cliente,
                        UPPER(REPLACE(p.nombre_producto, '_', ' ')) AS nombre_producto,
                        c.total,
                        c.fecha
                    FROM 
                        compra c
                    INNER JOIN
                        clientes cl ON c.id_cliente = cl.id_cliente
                    INNER JOIN
                        productos p ON c.id_producto = p.id_producto
                ";
                CargarDatosEnDataGridView(query);
            }
            else
            {
                dataGridView1.DataSource = null;
                gbxRVP.Enabled = false;
            }
        }

        private void rbtHoy_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtHoy.Checked)
            {
                string query = "SELECT cl.nombre AS nombre_cliente, p.nombre_producto, c.total, c.fecha FROM compra c INNER JOIN clientes cl ON c.id_cliente = cl.id_cliente INNER JOIN productos p ON c.id_producto = p.id_producto WHERE CONVERT(DATE, c.fecha) = CONVERT(DATE, GETDATE()) ORDER BY c.fecha DESC;";
                CargarDatosEnDataGridView(query);
            }
        }

        private void rbtUS_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtUS.Checked)
            {
                string query = "SELECT \r\n cl.nombre AS nombre_cliente,\r\n    p.nombre_producto,\r\n    c.total,\r\n    c.fecha\r\nFROM \r\n    compra c\r\nINNER JOIN \r\n    clientes cl ON c.id_cliente = cl.id_cliente\r\nINNER JOIN \r\n    productos p ON c.id_producto = p.id_producto\r\nWHERE \r\n    c.fecha >= DATEADD(WEEK, -1, GETDATE())  -- Fecha hace una semana o más reciente\r\n    AND c.fecha <= GETDATE()                 -- Fecha hasta hoy\r\nORDER BY \r\n    c.fecha DESC;\r\n";
                CargarDatosEnDataGridView(query);
            }
        }

        private void rbtUM_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtUM.Checked)
            {
                string query = "SELECT \r\n  cl.nombre AS nombre_cliente,\r\n    p.nombre_producto,\r\n    c.total,\r\n    c.fecha\r\nFROM \r\n    compra c\r\nINNER JOIN \r\n    clientes cl ON c.id_cliente = cl.id_cliente\r\nINNER JOIN \r\n    productos p ON c.id_producto = p.id_producto\r\nWHERE \r\n    c.fecha >= DATEADD(MONTH, -1, GETDATE())  -- Fecha hace un mes o más reciente\r\n    AND c.fecha <= GETDATE()                 -- Fecha hasta hoy\r\nORDER BY \r\n    c.fecha DESC;\r\n";
                CargarDatosEnDataGridView(query);
            }
        }

        private void rbtRVPO_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtRVPO.Checked)
            {
                gbxRVPO.Enabled = true;
                string query = @"
                    SELECT 
                        UPPER(REPLACE(cl.nombre, '_', ' ')) AS nombre_cliente,
                        UPPER(REPLACE(p.nombre_producto, '_', ' ')) AS nombre_producto,
                        c.total,
                        c.fecha
                    FROM 
                        compra c
                    INNER JOIN
                        clientes cl ON c.id_cliente = cl.id_cliente
                    INNER JOIN
                        productos p ON c.id_producto = p.id_producto
                ";
                CargarDatosEnDataGridView(query);
            }
            else
            {
                gbxRVPO.Enabled = false;
            }
        }

        private void btnGenerarRVPO_Click(object sender, EventArgs e)
        {
            DateTime fechaInicio = dateTimePickerDesde.Value.Date;
            DateTime fechaFin = dateTimePickerHasta.Value.Date;
            StringBuilder consultaSql = new StringBuilder();
            consultaSql.Append(@"
                SELECT 
                    cl.carnet AS ci_cliente,
                    cl.nombre AS nombre_cliente,
                    p.nombre_producto,
                    c.total,
                    c.fecha
                FROM 
                    compra c
                INNER JOIN
                    clientes cl ON c.id_cliente = cl.id_cliente
                INNER JOIN
                    productos p ON c.id_producto = p.id_producto
                WHERE 
                    CONVERT(date, c.fecha) BETWEEN @fechaInicio AND @fechaFin
            ");
            List<SqlParameter> parametros = new List<SqlParameter>
             {
                 new SqlParameter("@fechaInicio", fechaInicio),
                 new SqlParameter("@fechaFin", fechaFin)
             };
            if (!string.IsNullOrWhiteSpace(cbCiCliente.Text))
            {
                consultaSql.Append(" AND cl.carnet = @ciCliente");
                parametros.Add(new SqlParameter("@ciCliente", cbCiCliente.Text));
            }
            if (!string.IsNullOrWhiteSpace(cbProducto.Text))
            {
                consultaSql.Append(" AND p.nombre_producto = @nombreProducto");
                parametros.Add(new SqlParameter("@nombreProducto", cbProducto.Text));
            }
            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();
                    using (SqlCommand comando = new SqlCommand(consultaSql.ToString(), conexion))
                    {
                        foreach (var parametro in parametros)
                        {
                            comando.Parameters.Add(parametro);
                        }
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(comando);
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);
                        dataGridView1.DataSource = dataTable;
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("Error SQL: " + sqlEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void rbtRPP_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtRPP.Checked)
            {
                gbxRPP.Enabled = true;
                string query = @"
                                SELECT                                   
                                    UPPER(REPLACE(p.nombre_producto, '_', ' ')) AS nombre_producto,
                                    p.precio_venta,
                                    p.fecha_vencimiento,
                                    p.stock,
                                    UPPER(REPLACE(pr.nombre, '_', ' ')) AS nombre_proveedor
                                FROM 
                                    productos p
                                INNER JOIN
                                    proveedores pr ON p.id_proveedor = pr.id_proveedor
                            ";
                CargarDatosEnDataGridView(query);
                CargarFechasVencimientoEnComboBox();
            }
            else
            {
                dataGridView1.DataSource = null;
                gbxRPP.Enabled = false;
            }
        }

        private void btnGenerarRPP_Click(object sender, EventArgs e)
        {
            StringBuilder consultaSql = new StringBuilder();
            consultaSql.Append(@"
                                SELECT 
                                    p.nombre_producto,
                                    p.precio_venta,
                                    p.fecha_vencimiento,
                                    p.stock,
                                    pr.nombre AS nombre_proveedor
                                FROM 
                                    productos p
                                INNER JOIN
                                    proveedores pr ON p.id_proveedor = pr.id_proveedor
                                WHERE 1=1
            ");
            List<SqlParameter> parametros = new List<SqlParameter>();
            if (!string.IsNullOrWhiteSpace(txtStock.Text))
            {
                int stock;
                if (int.TryParse(txtStock.Text, out stock))
                {
                    consultaSql.Append(" AND p.stock < @stock");
                    parametros.Add(new SqlParameter("@stock", stock));
                }
                else
                {
                    MessageBox.Show("Por favor, ingrese un valor numérico válido para el stock.");
                    return;
                }
            }
            if (!string.IsNullOrWhiteSpace(cbProveedor.Text))
            {
                consultaSql.Append(" AND pr.nombre LIKE '%' + @proveedor + '%'");
                parametros.Add(new SqlParameter("@proveedor", cbProveedor.Text));
            }
            if (!string.IsNullOrWhiteSpace(cbFV.Text))
            {
                DateTime fechaSeleccionada;
                if (DateTime.TryParse(cbFV.Text, out fechaSeleccionada))
                {
                    consultaSql.Append(" AND CONVERT(date, p.fecha_vencimiento) = @fechaSeleccionada");
                    parametros.Add(new SqlParameter("@fechaSeleccionada", fechaSeleccionada));
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione una fecha de vencimiento válida.");
                    return;
                }
            }

            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();
                    using (SqlCommand comando = new SqlCommand(consultaSql.ToString(), conexion))
                    {
                        foreach (var parametro in parametros)
                        {
                            comando.Parameters.Add(parametro);
                        }
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(comando);
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);
                        dataGridView1.DataSource = dataTable;
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("Error SQL: " + sqlEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnGPDF_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para generar el PDF.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "PDF (*.pdf)|*.pdf";
            saveDialog.FileName = ".pdf";

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                string nombreArchivo = Path.GetFileName(saveDialog.FileName);
                Document doc = new Document(PageSize.A4);

                try
                {
                    PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(saveDialog.FileName, FileMode.Create));
                    writer.PageEvent = new HeaderFooter();
                    doc.Open();
                    PdfPTable pdfTable = new PdfPTable(dataGridView1.ColumnCount);
                    pdfTable.DefaultCell.Padding = 3;
                    pdfTable.WidthPercentage = 100;
                    pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
                    foreach (DataGridViewColumn column in dataGridView1.Columns)
                    {
                        PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                        pdfTable.AddCell(cell);
                    }
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            pdfTable.AddCell(cell.Value?.ToString());
                        }
                    }
                    doc.Add(pdfTable);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al generar el PDF: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    doc.Close();
                }
                MessageBox.Show("PDF generado exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnLimpiarDGV_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
        }
        ///////////////////////////// METODOS 
        private void CargarFechasVencimientoEnComboBox()
        {
            string query = "SELECT DISTINCT fecha_vencimiento FROM productos ORDER BY fecha_vencimiento";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    cbFV.Items.Clear();
                    while (reader.Read())
                    {
                        cbFV.Items.Add(reader.GetDateTime(0).ToString("yyyy-MM-dd"));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        private void CargarProveedoresEnComboBox()
        {
            string query = "SELECT DISTINCT nombre FROM proveedores ORDER BY nombre";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    cbProveedor.Items.Clear();
                    while (reader.Read())
                    {
                        cbProveedor.Items.Add(reader.GetString(0));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar proveedores: " + ex.Message);
                }
            }
        }
        private void CargarClientesEnComboBox()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT DISTINCT carnet FROM clientes";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        cbCiCliente.Items.Add(reader["carnet"].ToString());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar clientes: " + ex.Message);
                }
            }
        }
        private void CargarProductosEnComboBox()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT DISTINCT nombre_producto FROM productos";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        cbProducto.Items.Add(reader["nombre_producto"].ToString());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar productos: " + ex.Message);
                }
            }
        }
        private void CargarDatosEnDataGridView(string query, List<SqlParameter> parametros = null)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                    if (parametros != null)
                    {
                        foreach (var parametro in parametros)
                        {
                            dataAdapter.SelectCommand.Parameters.Add(parametro);
                        }
                    }
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        public class HeaderFooter : PdfPageEventHelper
        {
            public override void OnEndPage(PdfWriter writer, Document doc)
            {
                try
                {
                    PdfPTable headerTable = new PdfPTable(1);
                    headerTable.TotalWidth = doc.PageSize.Width - doc.LeftMargin - doc.RightMargin;
                    headerTable.DefaultCell.Border = PdfPCell.NO_BORDER;
                    PdfPCell cell = new PdfPCell(new Phrase("LIBRERIA BOLIVIA MAR", FontFactory.GetFont(FontFactory.HELVETICA, 12, BaseColor.BLACK)));
                    cell.Padding = 5;
                    cell.Border = PdfPCell.NO_BORDER;
                    cell.HorizontalAlignment = Element.ALIGN_RIGHT;
                    cell.PaddingTop = doc.TopMargin + 20;
                    headerTable.AddCell(cell);
                    float headerHeight = headerTable.TotalHeight;
                    headerTable.WriteSelectedRows(0, -1, doc.LeftMargin, doc.PageSize.Height - doc.TopMargin + headerHeight + 10, writer.DirectContent);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al agregar encabezado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
