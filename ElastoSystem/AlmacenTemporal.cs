using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ElastoSystem
{
    public partial class AlmacenTemporal : Form
    {

        public AlmacenTemporal()
        {
            InitializeComponent();

        }
        int contadorcantidad = 1;
        private void TextoDataGridView()
        {
            DataGridViewCellStyle estilo = new();
            estilo.Font = new Font("Montserrat", 12);
            estilo.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.DefaultCellStyle = estilo;
            dgv.ColumnHeadersDefaultCellStyle = estilo;
        }

        private void MandarALlamarNombre()
        {
            MySqlConnection mySqlConnection = new MySqlConnection(connectionString);
            mySqlConnection.Open();
            String id = tbnotrabajador.Text;
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
                        lbunidad.Text = unidad;

                    }
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

        private void MandarALlamarBDYOrdenar()
        {
            string tabla = "SELECT * FROM elastosystem_almacenregistro_salidas";
            MySqlDataAdapter mySqlAdapter = new MySqlDataAdapter(tabla, connectionString);
            DataTable dt = new DataTable();
            mySqlAdapter.Fill(dt);
            dgv.DataSource = dt;
            dt.DefaultView.Sort = "Folio DESC";
        }
        private void MandarALlamarApellidosPaterno()
        {
            cbnombre.Items.Clear(); tbnotrabajador.Clear();
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
                            cbap.Items.Add(apellidopat);
                            unicos.Add(apellidopat);
                        }
                    }
                    cbap.Sorted = true;

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
        private void MandarALlamarNombres()
        {
            tbnotrabajador.Clear(); cbnombre.Items.Clear();
            MySqlConnection mySqlConnection = new MySqlConnection(connectionString);
            mySqlConnection.Open();
            String codigo = cbap.Text;
            MySqlDataReader reader = null;
            string sql = "SELECT Nombre FROM elastosystem_rh WHERE Apellido_Paterno LIKE '" + codigo + "' ";
            try
            {
                HashSet<string> unicos = new HashSet<string>();
                MySqlCommand comando = new MySqlCommand(sql, mySqlConnection);
                reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        cbnombre.Items.Add(reader["Nombre"].ToString());

                    }
                    cbnombre.Sorted = true;
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
        private void MandarALlamarNoTrabajador()
        {
            MySqlConnection mySqlConnection = new MySqlConnection(connectionString);
            mySqlConnection.Open();
            String codigo = cbnombre.Text;
            String codigos = cbap.Text;
            MySqlDataReader reader = null;
            string sql = "SELECT ID FROM elastosystem_rh WHERE Nombre ='" + codigo + "' AND Apellido_Paterno ='" + codigos + "'  ";
            try
            {
                HashSet<string> unicos = new HashSet<string>();
                MySqlCommand comando = new MySqlCommand(sql, mySqlConnection);
                reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        tbnotrabajador.Text = reader.GetString(0);

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
                        cbproductos.Items.Add(reader["Producto"].ToString());
                    }
                    cbproductos.Sorted = true;

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
        private void OrdenTab()
        {
            tbnotrabajador.TabIndex = 0;
            tbnota.TabIndex = 1;

            /*cbap.TabIndex = 0;
            cbnombre.TabIndex = 1;
            cbproductos.TabIndex = 2;
            tbcantidad.TabIndex = 3;
            tbnota.TabIndex = 4;
            button3.TabIndex = 5;*/
        }
        private void MandarALlamarUnidad()
        {
            lbunidad.Text = ("Unidad");
            MySqlConnection mySqlConnection = new MySqlConnection(connectionString);
            mySqlConnection.Open();
            String codigo = cbproductos.Text;
            MySqlDataReader reader = null;
            string sql = "SELECT Unidad FROM elastosystem_almacen WHERE Producto LIKE '" + codigo + "' ";
            try
            {
                MySqlCommand comando = new MySqlCommand(sql, mySqlConnection);
                reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string uni = reader.GetString(0);
                        lbunidad.Text = uni;
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
        string connectionString = "server=10.120.1.3 ; username=root; password=; database=elastosystem";
        private void AlmacenTemporal_Load(object sender, EventArgs e)
        {
            TextoDataGridView();
            OrdenTab();
            MandarALlamarBDYOrdenar();
            MandarALlamarApellidosPaterno();
            MandarALlamarProductos();


        }


        private void cbap_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void cbap_SelectedIndexChanged(object sender, EventArgs e)
        {
            MandarALlamarNombres();
        }

        private void cbnombre_SelectedIndexChanged(object sender, EventArgs e)
        {
            MandarALlamarNoTrabajador();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            MandarALlamarUnidad();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbnotrabajador.Text) || string.IsNullOrEmpty(txbIDProducto.Text))
            {
                MessageBox.Show("DEBES DE LLENAR TODOS TUS CAMPOS");
                int cantidadtemp = int.Parse(txbCantidad.Text);
                if (cantidadtemp <= 0)
                {
                    MessageBox.Show("TU CANTIDAD NO PUEDE SER IGUAL O MENOR A 0");
                }
                else
                {
                    /*
                    MySqlConnection mySqlConnection = new MySqlConnection(connectionString);
                    mySqlConnection.Open();
                    String idprod = txbIDProducto.Text;
                    MySqlDataReader reader = null;
                    string sql = "SELECT Existencias FROM elastosystem_almacen WHERE ID_Producto LIKE '" + idprod + "' ";
                    */
                }
            }


        }
        private void button2_Click(object sender, EventArgs e)
        {
            MenuPrincipal frm2 = new();
            frm2.Show();
            this.Hide();
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {

        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox2.Visible = false;
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {

        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {

        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.Visible = true;
        }

        private void pictureBox4_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox4.Visible = false;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void paneltop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (cbap.SelectedIndex == -1 || cbnombre.SelectedIndex == -1 || string.IsNullOrWhiteSpace(tbnotrabajador.Text) || cbproductos.SelectedIndex == -1 || string.IsNullOrWhiteSpace(tbcantidad.Text))
            {
                MessageBox.Show("Debes de llenar todos los campos");
            }
            else
            {
                int cantidadtemp = int.Parse(tbcantidad.Text);
                if (cantidadtemp <= 0)
                {
                    MessageBox.Show("TU CANTIDAD NO PUEDE SER IGUAL O MENOR A 0");
                }
                else
                {
                    MySqlConnection mySqlConnection = new MySqlConnection(connectionString);
                    mySqlConnection.Open();
                    String codigo = cbproductos.Text;
                    MySqlDataReader reader = null;
                    string sql = "SELECT Existencias FROM elastosystem_almacen WHERE Producto LIKE '" + codigo + "' ";
                    try
                    {
                        MySqlCommand comandoa = new MySqlCommand(sql, mySqlConnection);
                        reader = comandoa.ExecuteReader();
                        int cantidad = Int32.Parse(tbcantidad.Text);
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
                                    comando.CommandText = "UPDATE elastosystem_almacen SET Existencias = '" + total + "' WHERE Producto = '" + cbproductos.Text + "'";
                                    comando.ExecuteNonQuery();
                                    DateTime saveNow = DateTime.Now;
                                    string fecha = saveNow.ToShortDateString();
                                    string hora = saveNow.ToLongTimeString();
                                    comando.CommandText = "INSERT INTO elastosystem_almacenregistro_salidas (No_Trabajador, Nombre, Producto, Cantidad, Fecha, Hora, Nota, Unidad) VALUES( '" + tbnotrabajador.Text + "' , '" + cbnombre.Text + "' , '" + cbproductos.Text + "' , '" + tbcantidad.Text + "' , '" + fecha + "' , '" + hora + "' , '" + tbnota.Text + "'  , '" + lbunidad.Text + "');";
                                    comando.ExecuteNonQuery();
                                    mySqlConnection.Close();
                                    MessageBox.Show("Requerimiento de Trabajador No. " + tbnotrabajador.Text + " agregado");
                                    comando.ExecuteNonQuery();
                                    mySqlConnection.Close();
                                }
                                catch (Exception ee)
                                {
                                    MessageBox.Show(ee.Message);
                                }
                                cbproductos.Text = String.Empty; tbcantidad.Clear(); tbnota.Clear();
                            }
                            else
                            {
                                MessageBox.Show("No tienes suficiente stock de este producto");
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
            }



        }

        private void tbnotrabajador_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }

        private void tbnotrabajador_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                // Obtener el texto actual del TextBox
                string texto = tbnotrabajador.Text;

                // Verificar si el texto contiene un salto de línea
                if (texto.Contains(Environment.NewLine))
                {
                    // Eliminar el salto de línea
                    texto = texto.Replace(Environment.NewLine, "");

                    // Asignar el texto modificado de nuevo al TextBox
                    tbnotrabajador.Text = texto;
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
                string texto = tbnotrabajador.Text;

                // Verificar si el texto contiene un salto de línea
                if (texto.Contains(Environment.NewLine))
                {
                    // Eliminar el salto de línea
                    texto = texto.Replace(Environment.NewLine, "");

                    // Asignar el texto modificado de nuevo al TextBox
                    tbnotrabajador.Text = texto;
                }

                // Cambiar el enfoque al siguiente control
                txbCantidad.Text = "1";
                // Mueve el cursor al final del texto en el TextBox
                txbCantidad.SelectionStart = txbCantidad.Text.Length;

                // Establece el foco en el TextBox
                txbCantidad.Focus();


                // Consumir el evento para evitar que el Enter genere un salto de línea adicional
                e.Handled = true;
            }

            MandarALlamarProducto();
        }

        private void txbCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {

                // Obtener el texto actual del TextBox
                string texto = txbCantidad.Text;

                // Verificar si el texto contiene un salto de línea
                if (texto.Contains(Environment.NewLine))
                {
                    // Eliminar el salto de línea
                    texto = texto.Replace(Environment.NewLine, "");

                    // Asignar el texto modificado de nuevo al TextBox
                    txbCantidad.Text = texto;
                }

                string ultimosCincoDigitos = ObtenerUltimosCincoDigitos(texto);
                ultimosCincoDigitos = ObtenerUltimosCincoDigitos(texto);

                if (ultimosCincoDigitos == txbIDProducto.Text)
                {
                    contadorcantidad = contadorcantidad + 1;
                    txbCantidad.Text = contadorcantidad.ToString();
                    txbCantidad.SelectionStart = txbCantidad.Text.Length;
                }
                else
                {
                    // Eliminar los últimos 5 dígitos y mostrar el resultado
                    txbCantidad.Text = ObtenerCadenaSinUltimosCincoDigitos(texto);

                    // Posicionar el cursor al final del texto
                    txbCantidad.SelectionStart = txbCantidad.Text.Length;
                }

                // Consumir el evento para evitar que el Enter genere un salto de línea adicional
                e.Handled = true;
            }
        }

        private string ObtenerCadenaSinUltimosCincoDigitos(string cadena)
        {
            if (cadena.Length >= 5)
            {
                return cadena.Substring(0, cadena.Length - 5);
            }
            else
            {
                return string.Empty;
            }
        }

        private string ObtenerUltimosCincoDigitos(string texto)
        {
            // Obtener los últimos 5 caracteres del texto
            int longitud = Math.Min(5, texto.Length);
            string ultimosCincoDigitos = texto.Substring(texto.Length - longitud);

            return ultimosCincoDigitos;
        }

        private void txbIDProducto_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}
