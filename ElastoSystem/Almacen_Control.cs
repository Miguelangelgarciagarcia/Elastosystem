using DocumentFormat.OpenXml.Vml;
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

namespace ElastoSystem
{
    public partial class Almacen_Control : Form
    {
        public Almacen_Control()
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
        private void MandarALlamarProducto()
        {
            MySqlConnection mySqlConnection = new MySqlConnection(connectionString);
            mySqlConnection.Open();
            String id = txbIDProducto.Text;
            string producto = ""; string unidad = "";
            MySqlDataReader reader = null;
            string sql = "SELECT Producto, Unidad FROM elastosystem_almacen WHERE ID_Producto ='" + id + "' ";
            try
            {
                HashSet<string> unicos = new HashSet<string>();
                MySqlCommand comando = new MySqlCommand(sql, mySqlConnection);
                reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        producto = reader.GetString(0);
                        unidad = reader.GetString(1);
                        lblNombreProducto.Text = producto;
                        lblUnidad.Text = unidad;
                    }
                    ExistenciasYEnvioTemporal();

                }
                else
                {
                    lblNombreProducto.Text = "VUELVE A INTENTARLO ID INCORRECTO";
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
        private void ExistenciasYEnvioTemporal()
        {
            MySqlConnection mySqlConnection = new MySqlConnection(connectionString);
            mySqlConnection.Open();
            String idProducto = txbIDProducto.Text;
            MySqlDataReader reader = null;
            string sql = "SELECT Existencias FROM elastosystem_almacen WHERE ID_Producto LIKE '" + idProducto + "' ";
            try
            {
                MySqlCommand comandoa = new MySqlCommand(sql, mySqlConnection);
                reader = comandoa.ExecuteReader();
                int cantidad = 1;
                string temp = null;
                int tempint;
                int total;
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        temp = reader.GetString(0);
                    }
                    tempint = Int32.Parse(temp);
                    total = tempint - cantidad;
                    mySqlConnection.Close();
                    if (total > -1)
                    {
                        try
                        {
                            mySqlConnection.Open();
                            MySqlCommand comando = new MySqlCommand();
                            comando.Connection = mySqlConnection;
                            comando.CommandText = "UPDATE elastosystem_almacen SET Existencias = '" + total + "' WHERE ID_Producto = '" + idProducto + "'";
                            comando.ExecuteNonQuery();
                            DateTime saveNow = DateTime.Now;
                            string fecha = saveNow.ToShortDateString();
                            string hora = saveNow.ToLongTimeString();
                            // Verificar si ya existe un registro con el mismo No_Trabajador y Producto
                            comando.CommandText = "SELECT COUNT(*) FROM elastosystem_almacenregistro_salidas_temp WHERE No_Trabajador = @NoTrabajador AND Producto = @Producto";
                            comando.Parameters.AddWithValue("@NoTrabajador", txbNoTrabajador.Text);
                            comando.Parameters.AddWithValue("@Producto", lblNombreProducto.Text);

                            int cantidadExistente = Convert.ToInt32(comando.ExecuteScalar());

                            if (cantidadExistente > 0)
                            {
                                // Ya existe un registro, actualizar la cantidad
                                comando.Parameters.Clear();
                                comando.CommandText = "UPDATE elastosystem_almacenregistro_salidas_temp SET Cantidad = Cantidad + 1 WHERE No_Trabajador = @NoTrabajador AND Producto = @Producto";
                                comando.Parameters.AddWithValue("@NoTrabajador", txbNoTrabajador.Text);
                                comando.Parameters.AddWithValue("@Producto", lblNombreProducto.Text);
                                comando.ExecuteNonQuery();
                            }
                            else
                            {
                                // No existe un registro, insertar un nuevo registro
                                comando.Parameters.Clear();
                                comando.CommandText = "INSERT INTO elastosystem_almacenregistro_salidas_temp (No_Trabajador, Nombre, Producto, Cantidad, Fecha, Hora, Unidad) VALUES (@NoTrabajador, @Nombre, @Producto, 1, @Fecha, @Hora, @Unidad)";
                                comando.Parameters.AddWithValue("@NoTrabajador", txbNoTrabajador.Text);
                                comando.Parameters.AddWithValue("@Nombre", lblNombreTrabajador.Text);
                                comando.Parameters.AddWithValue("@Producto", lblNombreProducto.Text);
                                comando.Parameters.AddWithValue("@Fecha", fecha);
                                comando.Parameters.AddWithValue("@Hora", hora);
                                comando.Parameters.AddWithValue("@Unidad", lblUnidad.Text);
                                comando.ExecuteNonQuery();
                            }
                            mySqlConnection.Close();

                            mySqlConnection.Close();
                        }
                        catch (Exception ee)
                        {
                            MessageBox.Show(ee.Message);
                        }
                        txbIDProducto.Clear(); lblNombreProducto.Text = "Nombre Producto"; lblUnidad.Text = "Unidad";
                    }
                    else
                    {
                        MessageBox.Show("No tienes suficiente stock de este producto");
                        txbIDProducto.Clear();
                        txbIDProducto.Focus();
                    }
                }
                else
                {
                }
            }
            catch
            {
            }
        }
        private void MandarALlamarBDTemporal()
        {
            string tabla = "SELECT Producto, Cantidad, Unidad FROM elastosystem_almacenregistro_salidas_temp";
            MySqlDataAdapter mySqlAdapter = new MySqlDataAdapter(tabla, connectionString);
            DataTable dt = new DataTable();
            mySqlAdapter.Fill(dt);
            dgvTemporal.DataSource = dt;
        }
        private void OrdenTabuladores()
        {
            txbNoTrabajador.TabIndex = 0;
            txbIDProducto.TabIndex = 1;
            txbNota.TabIndex = 2;
            btnAceptar.TabIndex = 3;
        }
        private void LimpiarYReinicar()
        {
            txbNoTrabajador.Clear(); 
            txbIDProducto.Clear();
            txbNota.Clear();
            dgvTemporal.DataSource= null;
            dgvTemporal.Rows.Clear();
            dgvTemporal.Columns.Clear();
            txbNoTrabajador.Focus();
            lblNombreTrabajador.Text = string.Empty;
            lblNombreProducto.Text = string.Empty;
            lblUnidad.Text = string.Empty;
        }
        private void LimpiarBDTemporal()
        {
            try
            {
                MySqlConnection mySqlConnection = new MySqlConnection(connectionString);
                mySqlConnection.Open();
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = mySqlConnection;
                comando.CommandText = "DELETE FROM elastosystem_almacenregistro_salidas_temp";
                comando.ExecuteNonQuery();
                mySqlConnection.Close();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
                MessageBox.Show("ERROR AL LIMPIAR BASE DE DATOS TEMPORAL");
                this.Hide();
            }
        }
        private void MandaALlamarBDSalidas()
        {
            string tabla = "SELECT * FROM elastosystem_almacenregistro_salidas";
            MySqlDataAdapter mySqlAdapter = new MySqlDataAdapter(tabla, connectionString);
            DataTable dt = new DataTable();
            mySqlAdapter.Fill(dt);
            dgvBD.DataSource = dt;
            dt.DefaultView.Sort = "Folio DESC";
        }

        string connectionString = "server=10.120.1.3 ; username=root; password=; database=elastosystem";

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

                // Cambiar el enfoque al siguiente control
                txbIDProducto.Focus();

                // Consumir el evento para evitar que el Enter genere un salto de línea adicional
                e.Handled = true;
            }

            MandarALlamarNombre();
        }
        private void txbIDProducto_KeyPress(object sender, KeyPressEventArgs e)
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

            MandarALlamarProducto();
            MandarALlamarBDTemporal();

        }

        private void pictureBox4_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox4.Visible = false;
        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox2.Visible = false;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.Visible = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
        }

        private void Almacen_Control_Load(object sender, EventArgs e)
        {
            MandaALlamarBDSalidas();
            OrdenTabuladores();
        }

        private void horayfecha_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection mySqlConnection = new MySqlConnection(connectionString);
                mySqlConnection.Open();
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = mySqlConnection;
                comando.CommandText = "INSERT INTO elastosystem_almacenregistro_salidas (No_Trabajador, Nombre, Producto, Cantidad, Fecha, Hora, Nota, Unidad) SELECT No_Trabajador, Nombre, Producto, Cantidad, Fecha, Hora, @Nota, Unidad FROM elastosystem_almacenregistro_salidas_temp;";
                comando.Parameters.AddWithValue("@Nota", txbNota.Text);
                comando.ExecuteNonQuery();
                mySqlConnection.Close();
                MessageBox.Show("Requerimiento de Trabajador No. " + txbNoTrabajador.Text + " surtido exitosamente");
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
                MessageBox.Show("ERROR AL SURTIR MATERIAL");
            }
            LimpiarBDTemporal();
            MandaALlamarBDSalidas();
            LimpiarYReinicar();
        }
    }
}
