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
    public partial class Control_Almacen : Form
    {
        public Control_Almacen()
        {
            InitializeComponent();
        }

        string connectionString = "server=10.120.1.3 ; username=root; password=; database=elastosystem";
        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection mySqlConnection = new MySqlConnection(connectionString);
            mySqlConnection.Open();
            String codigo = tbnotrabajador.Text;
            MySqlDataReader reader = null;
            string sql = "SELECT Nombre, Apellido_Paterno FROM elastosystem_rh WHERE ID LIKE '" + codigo + "' ";
            try
            {
                MySqlCommand comando = new MySqlCommand(sql, mySqlConnection);
                reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        tbnombre.Text = reader.GetString(0);
                        tbapellido.Text = reader.GetString(1);
                    }
                }
                else
                {
                    MessageBox.Show("Numero de Trabajador invalido");
                }
            }
            catch
            {
                MessageBox.Show("Error al encontrar datos");
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MySqlConnection mySqlConnection = new MySqlConnection(connectionString);
            mySqlConnection.Open();
            String codigo = cbproducto.Text;
            MySqlDataReader reader = null;
            string sql = "SELECT ID_Producto FROM elastosystem_almacen WHERE Producto LIKE '" + codigo + "' ";
            try
            {
                MySqlCommand comandoa = new MySqlCommand(sql, mySqlConnection);
                reader = comandoa.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        tbidproducto.Text = reader.GetString(0);
                    }
                }
                else
                {
                    MessageBox.Show("Nombre de Producto invalido");
                }
            }
            catch
            {
                MessageBox.Show("Error al encontrar datos");
            }
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            MySqlConnection mySqlConnection = new MySqlConnection(connectionString);
            mySqlConnection.Open();



            String codigo = tbidproducto.Text;
            MySqlDataReader reader = null;
            string sql = "SELECT Existencias FROM elastosystem_almacen WHERE ID_Producto LIKE '" + codigo + "' ";
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

                    try
                    {
                        mySqlConnection.Open();
                        MySqlCommand comando = new MySqlCommand();
                        comando.Connection = mySqlConnection;
                        comando.CommandText = "UPDATE elastosystem_almacen SET Existencias = '" + total + "' WHERE ID_Producto = '" + tbidproducto.Text + "'";
                        comando.ExecuteNonQuery();
                        DateTime saveNow = DateTime.Now;
                        string fecha = saveNow.ToShortDateString();
                        string hora = saveNow.ToLongTimeString();
                        comando.CommandText = "INSERT INTO elastosystem_almacenregistro_salidas (No_Trabajador, Nombre, Producto, Cantidad, Fecha, Hora, Nota) VALUES( '" + tbnotrabajador.Text + "' , '" + tbnombre.Text + "' , '" + tbproducto.Text + "' , '" + tbcantidad.Text + "' , '" + fecha + "' , '" + hora + "' , '" + tbnota.Text + "');";
                        comando.ExecuteNonQuery();
                        mySqlConnection.Close();
                        MessageBox.Show("Requerimiento de Trabajador No. " + tbnotrabajador.Text + " surtido exitosamente");
                        comando.ExecuteNonQuery();

                        mySqlConnection.Close();
                    }
                    catch (Exception ee)
                    {
                        MessageBox.Show(ee.Message);
                    }

                }
                else
                {
                }
            }
            catch
            {
            }
            tbnotrabajador.Clear(); tbnombre.Clear(); tbapellido.Clear(); tbproducto.Clear(); tbidproducto.Clear(); tbcantidad.Clear(); tbnota.Clear();
            string tabla = "SELECT * FROM elastosystem_almacenregistro_salidas";
            MySqlDataAdapter mySqlAdapter = new MySqlDataAdapter(tabla, connectionString);
            DataTable dt = new DataTable();
            mySqlAdapter.Fill(dt);
            dgv.DataSource = dt;


        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Control_Almacen_Load(object sender, EventArgs e)
        {
            string tabla = "SELECT * FROM elastosystem_almacenregistro_salidas";
            MySqlDataAdapter mySqlAdapter = new MySqlDataAdapter(tabla, connectionString);
            DataTable dt = new DataTable();
            mySqlAdapter.Fill(dt);
            dgv.DataSource = dt;


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
                        cbproducto.Items.Add(reader["Producto"].ToString());
                    }
                }
                else
                {
                }
            }
            catch
            {
            }
            finally
            {
                mySqlConnection.Close();
            }
        }

        private void tbnotrabajador_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                MySqlConnection mySqlConnection = new MySqlConnection(connectionString);
                mySqlConnection.Open();
                String codigo = tbnotrabajador.Text;
                MySqlDataReader reader = null;
                string sql = "SELECT Nombre, Apellido_Paterno FROM elastosystem_rh WHERE ID LIKE '" + codigo + "' ";
                try
                {
                    MySqlCommand comando = new MySqlCommand(sql, mySqlConnection);
                    reader = comando.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            tbnombre.Text = reader.GetString(0);
                            tbapellido.Text = reader.GetString(1);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Numero de Trabajador invalido");
                    }
                }
                catch
                {
                    MessageBox.Show("Error al encontrar datos");
                }

                tbidproducto.Focus();
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
