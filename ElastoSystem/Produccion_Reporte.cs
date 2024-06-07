using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElastoSystem
{
    public partial class Produccion_Reporte : Form
    {
        public Produccion_Reporte()
        {
            InitializeComponent();
        }
        private void MandarALlamarNombre()
        {
            MySqlConnection mySqlConnection = new MySqlConnection(connectionString);
            mySqlConnection.Open();
            String id = txbNoTrabajador.Text;
            string nombre = ""; string app = ""; string apm = "";
            MySqlDataReader reader = null;
            string sql = "SELECT Nombre, Apellido_Paterno, Apellido_Materno FROM elastosystem_rh WHERE ID ='" + id + "' ";
            try
            {
                HashSet<string> unicos = new HashSet<string>();
                MySqlCommand comando = new MySqlCommand(sql, mySqlConnection);
                reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        nombre = reader.GetString(0);
                        app = reader.GetString(1);
                        apm = reader.GetString(2);
                        lblNombreTrabajador.Text = nombre + " " + app + " " + apm;

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
            finally
            {
                mySqlConnection.Close();
            }
        }

        private void CargarProductos()
        {
            MySqlConnection mySqlConnection = new MySqlConnection(connectionString2);
            mySqlConnection.Open();
            MySqlDataReader reader = null;
            string sql = "SELECT CONCAT (Clave, ' --- ', Nombre) AS Producto FROM productos";
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                mySqlConnection.Close();
            }
        }
        private void MandarALlamarFamilia()
        {
            txbFamilia.Clear();
            MySqlConnection mySqlConnection = new MySqlConnection(connectionString2);
            mySqlConnection.Open();
            string familia = "";
            MySqlDataReader reader = null;
            string sql = "SELECT Familia FROM productos WHERE Clave ='" + txbClave.Text + "' ";
            try
            {
                MySqlCommand comando = new MySqlCommand(sql, mySqlConnection);
                reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        familia = reader.GetString(0);
                        txbFamilia.Text = familia;

                    }
                }
                else
                {
                }
            }
            catch (Exception ex)
            {
                if (string.IsNullOrEmpty(txbFamilia.Text))
                {
                    MessageBox.Show("EL PRODUCTO NO TIENE FAMILIA NI PROCESO");
                }
                else
                {
                    MessageBox.Show(ex.Message);
                }
            }
            finally
            {
                mySqlConnection.Close();
            }
        }
        private void MandarALlamarProcesos()
        {
            MySqlConnection mySqlConnection = new MySqlConnection(connectionString2);
            mySqlConnection.Open();
            MySqlDataReader reader = null;
            string sql = "SELECT CONCAT (NUM_OP, ' --- ', DESCRIPCION) AS Operacion FROM sub_proceso WHERE FAMILIA = '" + txbFamilia.Text + "' ";
            try
            {
                MySqlCommand comando = new MySqlCommand(sql, mySqlConnection);
                reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        cbOperacion.Items.Add(reader["Operacion"].ToString());
                    }
                    cbOperacion.Sorted = true;

                }
                else
                {
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                mySqlConnection.Close();
            }
        }
        private void Tab()
        {
            txbNoTrabajador.TabIndex = 0;
            cbProducto.TabIndex = 1;
            cbOperacion.TabIndex = 2;
            txbCantidad.TabIndex = 3;
            cbUnidad.TabIndex = 4;
            dtpTiempoInicio.TabIndex = 5;
            dtpTiempoFinal.TabIndex = 6;
            btnRegistrar.TabIndex = 7;
        }
        private void CargarFecha()
        {
            DateTime fechaActual = DateTime.Now;
            TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
            string fechaLarga = fechaActual.ToString("dddd, dd 'de' MMMM 'del' yyyy", CultureInfo.CurrentCulture);
            fechaLarga = textInfo.ToTitleCase(fechaLarga);
            lblfecha.Text = fechaLarga;
        }
        private void Folio()
        {
            MySqlConnection mySqlConnection = new MySqlConnection(connectionString);
            mySqlConnection.Open();
            MySqlDataReader reader = null;
            string sql = "SELECT Folio FROM elastosystem_produccion_reportedeproduccion";

            try
            {
                int ultimoFolio = 0;
                MySqlCommand comando = new MySqlCommand(sql, mySqlConnection);
                reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string folioString = reader["Folio"].ToString();
                        if (int.TryParse(folioString, out int folio))
                        {
                            ultimoFolio = folio;
                        }
                        else
                        {

                        }
                    }
                    ultimoFolio = ultimoFolio + 1;
                    lblFolio.Text = ultimoFolio.ToString();
                }
                else
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                mySqlConnection.Close();
            }
        }
        private void Registrar()
        {
            if (lblNombreTrabajador.Text == "Nombre Trabajador" || cbProducto.SelectedIndex == -1 || cbOperacion.SelectedIndex == -1 || string.IsNullOrEmpty(txbCantidad.Text) || cbUnidad.SelectedIndex == -1)
            {
                MessageBox.Show("Debes de llenar todos los campos");
            }
            else
            {
                DateTime fechainicio = DateTime.Now;
                string fechai = fechainicio.ToString("yyyy-MM-dd");

                DateTime horaInicio = dtpTiempoInicio.Value;
                string horai = horaInicio.ToString("HH:mm");
                DateTime horaFin = dtpTiempoFinal.Value;
                string horaf = horaFin.ToString("HH:mm");
                TimeSpan diferencia = horaFin.Subtract(horaInicio);
                double minutosDiferencia = diferencia.TotalMinutes;
                int minutosEnteros = (int)minutosDiferencia;

                MySqlConnection conn = new MySqlConnection(connectionString);
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                try
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "INSERT INTO elastosystem_produccion_reportedeproduccion (Folio, Fecha, No_Trabajador, Nombre, Producto, Operacion, Cantidad, Unidad, HoraInicio, HoraFinal, Minutos) VALUES ('" + lblFolio.Text + "', '" + fechai + "', '" + txbNoTrabajador.Text + "', '" + lblNombreTrabajador.Text + "', '" + cbProducto.Text + "', '" + cbOperacion.Text + "', '" + txbCantidad.Text + "', '" + cbUnidad.Text + "', '" + horai + "', '" + horaf + "', '" + minutosEnteros + "');";
                    cmd.ExecuteNonQuery();
                    txbNoTrabajador.Clear(); lblNombreTrabajador.Text = "Nombre Trabajador";
                    cbProducto.Text = string.Empty; cbOperacion.Text = string.Empty; txbCantidad.Clear(); cbUnidad.Text = string.Empty; cbHora.Text = string.Empty; cbDecimal.Text = string.Empty;
                    cbOperacion.Items.Clear(); cbOperacion.Items.Clear();
                    MessageBox.Show("Registro: " + lblFolio.Text + " registrado con exito");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conn.Close();
                }
                Folio();
                MandarALlamarBD();
            }
            txbNoTrabajador.Focus();
            Tab();
        }
        private void MandarALlamarBD()
        {
            try
            {
                string tabla = "SELECT Folio, Nombre, Producto, Operacion, Cantidad, Unidad, HoraInicio, HoraFinal FROM elastosystem_produccion_reportedeproduccion";
                MySqlDataAdapter mySqlAdapter = new MySqlDataAdapter(tabla, connectionString);
                DataTable dt = new DataTable();
                mySqlAdapter.Fill(dt);
                dgvReporte.DataSource = dt;
                dt.DefaultView.Sort = "Folio DESC";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        string connectionString = "server=10.120.1.3 ; username=root; password=; database=elastosystem";
        string connectionString2 = "server=10.120.1.3 ; username=root ; password= ; database=elastotec";


        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbDecimal.Text = "0";
        }

        private void Produccion_Reporte_Load(object sender, EventArgs e)
        {
            CargarProductos();
            CargarFecha();
            Folio();
            Tab();
            MandarALlamarBD();

            dtpTiempoInicio.Format = DateTimePickerFormat.Custom;
            dtpTiempoInicio.CustomFormat = "HH:mm";
            dtpTiempoFinal.Format = DateTimePickerFormat.Custom;
            dtpTiempoFinal.CustomFormat = "HH:mm";
            dtpTiempoFinal.Value = dtpTiempoFinal.Value.AddHours(1);

        }

        private void txbNoTrabajador_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                // Obtener el texto actual del TextBox
                string texto = txbNoTrabajador.Text;

                // Verificar si el texto contiene un salto de línea
                if (texto.Contains(Environment.NewLine))
                {
                    // Eliminar el salto de línea
                    texto = texto.Replace(Environment.NewLine, "");

                    // Asignar el texto modificado de nuevo al TextBox
                    txbNoTrabajador.Text = texto;
                }

                // Consumir el evento para evitar que el Enter genere un salto de línea adicional
                e.Handled = true;
            }

            MandarALlamarNombre();
        }

        private void cbProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbOperacion.Items.Clear();
            string selectedValue = cbProducto.SelectedItem.ToString();
            int index = selectedValue.IndexOf(" --- ");
            if (index != -1)
            {
                string clave = selectedValue.Substring(0, index);
                txbClave.Text = clave;
            }

            MandarALlamarFamilia();
            MandarALlamarProcesos();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Registrar();
        }

        private void cbOperacion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
