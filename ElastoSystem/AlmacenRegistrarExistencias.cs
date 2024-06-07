using DocumentFormat.OpenXml.Office.Word;
using DocumentFormat.OpenXml.Wordprocessing;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Cmp;
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
    public partial class AlmacenRegistrarExistencias : Form
    {
        public AlmacenRegistrarExistencias()
        {
            InitializeComponent();
            OrdenTab();

        }

        private void MandarALlamarAlmacen()
        {
            string tabla = "SELECT ID_Producto, Producto, Descripcion, Existencias, Unidad FROM elastosystem_almacen";
            MySqlDataAdapter mySqlAdapter = new MySqlDataAdapter(tabla, connectionString);
            DataTable dt = new DataTable();
            mySqlAdapter.Fill(dt);
            dgv.DataSource = dt;
            this.BeginInvoke(new Action(() =>
            {
                txbID.Focus();
            }));
        }

        string connectionString = "server=10.120.1.3 ; username=root; password=; database=elastosystem";

        private void OrdenTab()
        {
            txbID.TabIndex = 0;
            button1.TabIndex = 1;
            txbProducto.TabIndex = 2;
            txbExistencias.TabIndex = 3;
            txbAdd.TabIndex = 4;
            txbNotas.TabIndex = 5;
            txbclave.TabIndex = 6;
            button2.TabIndex = 7;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection mySqlConnection = new MySqlConnection(connectionString);
            mySqlConnection.Open();
            String codigo = txbID.Text;
            MySqlDataReader reader = null;
            string sql = "SELECT Producto, Existencias FROM elastosystem_almacen WHERE ID_Producto LIKE '" + codigo + "' ";
            try
            {
                MySqlCommand comando = new MySqlCommand(sql, mySqlConnection);
                reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        txbProducto.Text = reader.GetString(0);
                        txbExistencias.Text = reader.GetString(1);
                    }
                }
                else
                {
                    MessageBox.Show("Numero de Producto invalido");
                }
            }
            catch
            {
                MessageBox.Show("Error al encontrar datos");
            }
            mySqlConnection.Close();
            txbAdd.Focus();
        }


        private void AlmacenRegistrarExistencias_Load(object sender, EventArgs e)
        {
            MandarALlamarAlmacen();
        }

        private void txbID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                button1_Click(button1_Click, EventArgs.Empty);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txbID.Text) & !string.IsNullOrEmpty(txbProducto.Text) & !string.IsNullOrEmpty(txbExistencias.Text) & !string.IsNullOrEmpty(txbAdd.Text) & !string.IsNullOrEmpty(txbNotas.Text) & !string.IsNullOrEmpty(txbclave.Text))
            {
                string query = "SELECT * FROM elastosystem_login WHERE No_Trabajador='" + txbclave.Text + "'";
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                commandDatabase.CommandTimeout = 60;
                MySqlDataReader reader;

                try
                {
                    databaseConnection.Open();
                    reader = commandDatabase.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            string rol = reader["Roles"].ToString();

                            if (rol == "root")
                            {
                                labelprueba.Text = "exito";
                            }
                            else if (rol == "calidad")
                            {
                                labelprueba.Text = "exito";
                            }
                            else
                            {
                                MessageBox.Show("No tienes permisos para ingresar datos");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("CLAVE INCORRECTA");
                    }
                    databaseConnection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                try
                {
                    MySqlConnection conn = new MySqlConnection(connectionString);
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand();
                    if (labelprueba.Text == "exito")
                    {
                        int existencias = int.Parse(txbExistencias.Text);
                        int valoragregado = int.Parse(txbAdd.Text);

                        if (valoragregado > 0)
                        {
                            int total = existencias + valoragregado;
                            string usuariopc = Environment.UserName;
                            DateTime saveNow = DateTime.Now;
                            string fecha = saveNow.ToShortDateString();
                            string hora = saveNow.ToLongTimeString();
                            cmd.Connection = conn;
                            cmd.CommandText = "INSERT INTO elastosystem_almacenregistrosexistencias (Usuario, ID_Producto, Producto, Operacion, EDOP, Fecha, Hora, OC, Autorizo) VALUES( '" + usuariopc + "' , '" + txbID.Text + "', '" + txbProducto.Text + "' , '" + txbAdd.Text + "' , '" + total + "' , '" + fecha + "' , '" + hora + "', '" + txbNotas.Text + "' , '" + txbclave.Text + "');";
                            cmd.ExecuteNonQuery();
                            cmd.CommandText = "UPDATE elastosystem_almacen SET Existencias = '" + total + "' WHERE ID_Producto = '" + txbID.Text + "'";
                            cmd.ExecuteNonQuery();
                            txbProducto.Clear(); txbExistencias.Clear(); txbAdd.Clear(); txbNotas.Clear(); txbclave.Clear(); txbID.Clear();
                            MessageBox.Show("PRODUCTO REGISTRADO CON EXITO");
                        }
                        else
                        {
                            int total = existencias + valoragregado;
                            string usuariopc = Environment.UserName;
                            DateTime saveNow = DateTime.Now;
                            string fecha = saveNow.ToShortDateString();
                            string hora = saveNow.ToLongTimeString();
                            cmd.Connection = conn;
                            cmd.CommandText = "INSERT INTO elastosystem_almacenregistrosexistencias (Usuario, ID_Producto, Producto, Operacion, EDOP, Fecha, Hora, OC, Autorizo) VALUES( '" + usuariopc + "' , '" + txbID.Text + "', '" + txbProducto.Text + "' , '" + txbAdd.Text + "', '" + total + "' , '" + fecha + "' , '" + hora + "', '" + txbNotas.Text + "' , '" + txbclave.Text + "');";
                            cmd.ExecuteNonQuery();
                            cmd.CommandText = "UPDATE elastosystem_almacen SET Existencias = '" + total + "' WHERE ID_Producto = '" + txbID.Text + "'";
                            cmd.ExecuteNonQuery();
                            txbProducto.Clear(); txbExistencias.Clear(); txbAdd.Clear(); txbNotas.Clear(); txbclave.Clear(); txbID.Clear();
                            MessageBox.Show("PRODUCTO REGISTRADO CON EXITO");
                        }

                    }
                    else
                    {

                    }
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);
                }

                labelprueba.Text = "error";
            }
            else
            {
                MessageBox.Show("DEBES DE LLENAR TODOS LOS CAMPOS");
            }

            MandarALlamarAlmacen();

        }

        private void txbclave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                button2_Click(button2_Click, EventArgs.Empty);
            }
        }

        private void dgv_DoubleClick(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;

            if (dgv.SelectedCells.Count > 0)
            {
                int rowIndex = dgv.SelectedCells[0].RowIndex;

                string id = dgv.Rows[rowIndex].Cells[0].Value.ToString();
                txbID.Text = id;

                string producto = dgv.Rows[rowIndex].Cells[1].Value.ToString();
                txbProducto.Text = producto;

                string existencias = dgv.Rows[rowIndex].Cells[3].Value.ToString();
                txbExistencias.Text = existencias;

                txbAdd.Focus();

            }
        }
    }
}
