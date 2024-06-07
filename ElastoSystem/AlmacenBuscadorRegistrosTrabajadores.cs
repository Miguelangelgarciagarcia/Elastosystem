using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.xml;
using System.IO;
using System.Drawing.Text;
using SpreadsheetLight;
using System.Net.Mail;
using System.Net;

namespace ElastoSystem
{
    public partial class AlmacenBuscadorRegistrosTrabajadores : Form
    {
        string connectionString = "server=10.120.1.3 ; username=root; password=; database=elastosystem";
        private DateTime fecha1;
        private DateTime fecha2;
        public AlmacenBuscadorRegistrosTrabajadores()
        {
            InitializeComponent();
        }
        private void MandarALlamarApellido()
        {
            cbNombre.Items.Clear(); txtbNoTrabajador.Clear();
            MySqlConnection mySqlConnection = new MySqlConnection(connectionString);
            mySqlConnection.Open();
            MySqlDataReader reader = null;
            string sql = "SELECT Apellido_Paterno FROM elastosystem_rh";
            try
            {
                HashSet<string> unicos = new HashSet<string>();
                MySqlCommand comando = new MySqlCommand(sql, mySqlConnection);
                reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string apellidopat = reader["Apellido_Paterno"].ToString();

                        if (!unicos.Contains(apellidopat))
                        {
                            cbApellidoPaterno.Items.Add(apellidopat);
                            unicos.Add(apellidopat);
                        }
                        else
                        {

                        }
                        cbApellidoPaterno.Sorted = true;


                    }

                }
                else
                {
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            mySqlConnection.Close();
        }
        private void MandarALlamarNombre()
        {
            txtbNoTrabajador.Clear(); cbNombre.Items.Clear();
            MySqlConnection mySqlConnection = new MySqlConnection(connectionString);
            mySqlConnection.Open();
            String Nombre = cbApellidoPaterno.Text;
            MySqlDataReader reader = null;
            string sql = "SELECT Nombre FROM elastosystem_rh WHERE Apellido_Paterno LIKE '" + Nombre + "' ";
            try
            {
                HashSet<string> unicos = new HashSet<string>();
                MySqlCommand comando = new MySqlCommand(sql, mySqlConnection);
                reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        cbNombre.Items.Add(reader["Nombre"].ToString());


                    }
                    cbNombre.Sorted = true;
                }
                else
                {
                }
            }
            catch
            {
            }
            mySqlConnection.Close();
        }
        private void MandarALlamarNoTrabajador()
        {
            MySqlConnection mySqlConnection = new MySqlConnection(connectionString);
            mySqlConnection.Open();
            String nombre = cbNombre.Text;
            String apellido_paterno = cbApellidoPaterno.Text;
            MySqlDataReader reader = null;
            string sql = "SELECT ID FROM elastosystem_rh WHERE Nombre ='" + nombre + "' AND Apellido_Paterno ='" + apellido_paterno + "'  ";
            try
            {
                MySqlCommand comando = new MySqlCommand(sql, mySqlConnection);
                reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        txtbNoTrabajador.Text = reader.GetString(0);

                    }

                }
                else
                {
                }
            }
            catch
            {
            }
            mySqlConnection.Close();
        }
        private void MandarALlamarProductos()
        {
            MySqlConnection mySqlConnection = new MySqlConnection(connectionString);
            mySqlConnection.Open();
            MySqlDataReader reader = null;
            string sql = "SELECT Producto FROM elastosystem_almacen";
            try
            {
                MySqlCommand comando = new MySqlCommand(sql, mySqlConnection);
                reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        cbProducto.Items.Add(reader["Producto"].ToString());
                    }
                    cbProducto.Sorted = true;

                }
                else
                {
                }
            }
            catch
            {
            }
            mySqlConnection.Close();
        }
        private void AlmacenBuscadorRegistrosTrabajadores_Load(object sender, EventArgs e)
        {
            MandarALlamarApellido();
            MandarALlamarProductos();
            Calendario1.Visible = false;
            Calendario2.Visible = false;
            pbCalendario1Cerrar.Visible = false;
            pbCalendario2Cerrar.Visible = false;
        }

        private void cbApellidoPaterno_SelectedIndexChanged(object sender, EventArgs e)
        {
            MandarALlamarNombre();
        }

        private void cbNombre_SelectedIndexChanged(object sender, EventArgs e)
        {
            MandarALlamarNoTrabajador();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Calendario2.Visible = false;
            Calendario1.Visible = true;
            pbCalendario1Cerrar.Visible = true;
        }

        private void Calendario1_DateChanged(object sender, DateRangeEventArgs e)
        {
            txtbFechaInicio.Text = Calendario1.SelectionStart.ToString("dd/MM/yyyy");
        }

        private void pbCalendario1Cerrar_Click(object sender, EventArgs e)
        {
            Calendario1.Visible = false;
            pbCalendario1Cerrar.Visible = false;
        }

        private void pbCalendario2_Click(object sender, EventArgs e)
        {
            Calendario1.Visible = false;
            Calendario2.Visible = true;
            pbCalendario2Cerrar.Visible = true;
        }

        private void pbCalendario2Cerrar_Click(object sender, EventArgs e)
        {
            Calendario2.Visible = false;
            pbCalendario2Cerrar.Visible = false;
        }

        private void Calendario2_DateChanged(object sender, DateRangeEventArgs e)
        {
            txtbFechaTermino.Text = Calendario2.SelectionStart.ToString("dd/MM/yyyy");
        }

        private void AlmacenBuscadorRegistrosTrabajadores_Click(object sender, EventArgs e)
        {
            Calendario1.Visible = false;
            Calendario2.Visible = false;
        }

        private void checkBox1_CheckStateChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            cbApellidoPaterno.Text = string.Empty;
            cbNombre.Text = string.Empty;
            txtbNoTrabajador.Text = string.Empty;
            cbApellidoPaterno.Enabled = !checkBox1.Checked;
            cbNombre.Enabled = !checkBox1.Checked;
            txtbNoTrabajador.Enabled = !checkBox1.Checked;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            cbProducto.Text = string.Empty;
            cbProducto.Enabled = !checkBox2.Checked;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            txtbFechaInicio.Text = string.Empty;
            txtbFechaTermino.Text = string.Empty;
            txtbFechaInicio.Enabled = !checkBox3.Checked;
            txtbFechaTermino.Enabled = !checkBox3.Checked;
            pbCalendario1.Enabled = !checkBox3.Checked;
            pbCalendario1Cerrar.Enabled = !checkBox3.Checked;
            pbCalendario2.Enabled = !checkBox3.Checked;
            pbCalendario2Cerrar.Enabled = !checkBox3.Checked;

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Calendario1.Visible = false;
            Calendario2.Visible = false;
            MySqlConnection mySqlConnection = new MySqlConnection(connectionString);
            mySqlConnection.Open();
            if (checkBox1.Checked & checkBox2.Checked & checkBox3.Checked)
            {
                string tabla = "SELECT * FROM elastosystem_almacenregistro_salidas";
                MySqlDataAdapter mySqlAdapter = new MySqlDataAdapter(tabla, connectionString);
                DataTable dt = new DataTable();
                mySqlAdapter.Fill(dt);
                dgv.DataSource = dt;
            }
            else if (!string.IsNullOrEmpty(txtbNoTrabajador.Text) & checkBox2.Checked & checkBox3.Checked)
            {
                String no_traba = txtbNoTrabajador.Text;
                string tabla = "SELECT * FROM elastosystem_almacenregistro_salidas WHERE No_Trabajador = '" + no_traba + "'";
                MySqlDataAdapter mySqlAdapter = new MySqlDataAdapter(tabla, connectionString);
                DataTable dt = new DataTable();
                mySqlAdapter.Fill(dt);
                dgv.DataSource = dt;
            }
            else if (cbProducto.SelectedIndex != -1 & !string.IsNullOrEmpty(txtbNoTrabajador.Text) & checkBox3.Checked)
            {
                String no_traba = txtbNoTrabajador.Text;
                string producto = cbProducto.Text;
                string tabla = "SELECT * FROM elastosystem_almacenregistro_salidas WHERE No_Trabajador = '" + no_traba + "'AND Producto = '" + producto + "'";
                MySqlDataAdapter mySqlAdapter = new MySqlDataAdapter(tabla, connectionString);
                DataTable dt = new DataTable();
                mySqlAdapter.Fill(dt);
                dgv.DataSource = dt;
            }
            else if (checkBox1.Checked & cbProducto.SelectedIndex != -1 & checkBox3.Checked)
            {
                string producto = cbProducto.Text;
                string tabla = "SELECT * FROM elastosystem_almacenregistro_salidas WHERE Producto = '" + producto + "'";
                MySqlDataAdapter mySqlAdapter = new MySqlDataAdapter(tabla, connectionString);
                DataTable dt = new DataTable();
                mySqlAdapter.Fill(dt);
                dgv.DataSource = dt;

            }
            else if (checkBox1.Checked & checkBox2.Checked & !string.IsNullOrEmpty(txtbFechaInicio.Text) & !string.IsNullOrEmpty(txtbFechaTermino.Text))
            {
                string fechaini = txtbFechaInicio.Text;
                string fechafin = txtbFechaTermino.Text;

                string tabla = "SELECT * FROM elastosystem_almacenregistro_salidas WHERE Fecha >= '" + fechaini + "' AND Fecha <= '" + fechafin + "'";
                MySqlDataAdapter mySqlAdapter = new MySqlDataAdapter(tabla, connectionString);
                DataTable dt = new DataTable();
                mySqlAdapter.Fill(dt);
                dgv.DataSource = dt;


            }
            else if (!string.IsNullOrEmpty(txtbNoTrabajador.Text) & checkBox2.Checked & !string.IsNullOrEmpty(txtbFechaInicio.Text) & !string.IsNullOrEmpty(txtbFechaTermino.Text))
            {
                string no_traba = txtbNoTrabajador.Text;
                string fechaini = txtbFechaInicio.Text;
                string fechafin = txtbFechaTermino.Text;
                string tabla = "SELECT * FROM elastosystem_almacenregistro_salidas WHERE Fecha >= '" + fechaini + "' AND Fecha <= '" + fechafin + "' AND No_Trabajador = '" + no_traba + "'";
                MySqlDataAdapter mySqlAdapter = new MySqlDataAdapter(tabla, connectionString);
                DataTable dt = new DataTable();
                mySqlAdapter.Fill(dt);
                dgv.DataSource = dt;
            }
            else if (checkBox1.Checked & cbProducto.SelectedIndex != -1 & !string.IsNullOrEmpty(txtbFechaInicio.Text) & !string.IsNullOrEmpty(txtbFechaTermino.Text))
            {
                string product = cbProducto.Text;
                string fechaini = txtbFechaInicio.Text;
                string fechafin = txtbFechaTermino.Text;
                string tabla = "SELECT * FROM elastosystem_almacenregistro_salidas WHERE Fecha >= '" + fechaini + "' AND Fecha <= '" + fechafin + "' AND Producto = '" + product + "'";
                MySqlDataAdapter mySqlAdapter = new MySqlDataAdapter(tabla, connectionString);
                DataTable dt = new DataTable();
                mySqlAdapter.Fill(dt);
                dgv.DataSource = dt;
            }
            else if (!string.IsNullOrEmpty(txtbNoTrabajador.Text) & cbProducto.SelectedIndex != -1 & !string.IsNullOrEmpty(txtbFechaInicio.Text) & !string.IsNullOrEmpty(txtbFechaTermino.Text))
            {
                string not = txtbNoTrabajador.Text;
                string product = cbProducto.Text;
                string fechaini = txtbFechaInicio.Text;
                string fechafin = txtbFechaTermino.Text;
                string tabla = "SELECT * FROM elastosystem_almacenregistro_salidas WHERE Fecha >= '" + fechaini + "' AND Fecha <= '" + fechafin + "' AND Producto = '" + product + "' AND No_Trabajador = '" + not + "'";
                MySqlDataAdapter mySqlAdapter = new MySqlDataAdapter(tabla, connectionString);
                DataTable dt = new DataTable();
                mySqlAdapter.Fill(dt);
                dgv.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Debes de seleccionar alguna opcion de los 3 campos requeridos");
                dgv.DataSource = null;
            }
            mySqlConnection.Close();

        }

        private void button2_Click(object sender, EventArgs e, PageSize PageSize, PageSize pageSize)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (dgv.Rows.Count > 0)
            {
                ExportarDataGridViewAExcel(dgv);
            }
            else
            {
                MessageBox.Show("No hay nada por exportar");
            }
        }
        private void ExportarDataGridViewAExcel(DataGridView dataGridView)
        {
            try
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Archivos de Excel (*.xlsx)|*.xlsx";
                    saveFileDialog.Title = "Guardar archivo de Excel";
                    saveFileDialog.FileName = ".xlsx";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string rutaArchivo = saveFileDialog.FileName;

                        SLDocument sl = new SLDocument();

                        // Obtener datos del DataGridView
                        DataTable dt = new DataTable();
                        for (int i = 0; i < dataGridView.Columns.Count; i++)
                        {
                            dt.Columns.Add(dataGridView.Columns[i].HeaderText);
                        }

                        foreach (DataGridViewRow dgvRow in dataGridView.Rows)
                        {
                            DataRow dataRow = dt.NewRow();
                            for (int j = 0; j < dataGridView.Columns.Count; j++)
                            {
                                dataRow[j] = dgvRow.Cells[j].Value;
                            }
                            dt.Rows.Add(dataRow);
                        }

                        // Agregar datos al documento de Excel
                        sl.ImportDataTable(1, 1, dt, true);

                        // Guardar el archivo Excel
                        sl.SaveAs(rutaArchivo);

                        MessageBox.Show("Exportación exitosa");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al exportar a Excel: " + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            /*if (dgv.Rows.Count > 0)
            {
                EnvioDeCorreos();
            }
            else
            {
                MessageBox.Show("No hay nada por enviar");
            }*/
        }
        /*private void EnvioDeCorreos()
        {
            SmtpClient smtpClient = new SmtpClient("smtp.ionos.mx");
            smtpClient.Port = 587;
            smtpClient.Credentials = new NetworkCredential("almacen@elastotecnica.com.mx", "El@sto2023:");
            smtpClient.EnableSsl = true;

            // Crear el mensaje de correo
            MailMessage mailMessage = new MailMessage();
            mailMessage.From = new MailAddress("compras@elastotecnica.com.mx");
            mailMessage.To.Add("miguel_tec_programador@outlook.com");
            mailMessage.To.Add("miguel.garcia@elastotecnica.com.mx");
            mailMessage.Subject = "REPORTE DE TRABAJADORES";
            StringBuilder cuerpoCorreo = new StringBuilder();
            cuerpoCorreo.AppendLine("TABLA DEL REPORTE:");
            cuerpoCorreo.AppendLine("FOLIO / NO_TRABAJADOR / NOMBRE / PRODUCTO / CANTIDAD / FECHA / HORA / NOTA / UNIDAD");

            foreach (DataGridViewRow fila in dgv.Rows)
            {
                foreach (DataGridViewCell celda in fila.Cells)
                {
                    string valorCelda = (celda.Value != null) ? celda.Value.ToString() : "";

                    cuerpoCorreo.Append(valorCelda);
                    cuerpoCorreo.Append("\t");
                }
                cuerpoCorreo.AppendLine();
            }

            mailMessage.Body = cuerpoCorreo.ToString();

            try
            {
                // Enviar el correo
                smtpClient.Send(mailMessage);
                MessageBox.Show("ENIVIADO CON EXITO");
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR" + ex.Message);
            }
        }*/
    }
}
