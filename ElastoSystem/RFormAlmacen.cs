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
    public partial class RFormAlmacen : Form
    {
        public RFormAlmacen()
        {
            InitializeComponent();
        }

        int datooriginal = 0;

        private void LlamarBaseDatosAlmacen()
        {
            string tabla = "SELECT * FROM elastosystem_almacen";
            MySqlDataAdapter mySqlAdapter = new MySqlDataAdapter(tabla, connectionString);
            DataTable dt = new DataTable();
            mySqlAdapter.Fill(dt);
            dgvbd.DataSource = dt;
            this.BeginInvoke(new Action(() =>
            {
                tbid.Focus();
            }));
        }

        string connectionString = "server=10.120.1.3 ; username=root; password=; database=elastosystem";
        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void RFormAlmacen_Load(object sender, EventArgs e)
        {
            LlamarBaseDatosAlmacen();
            OrdenTab();
        }
        private void OrdenTab()
        {
            tbid.TabIndex = 0;
            button2.TabIndex = 1;
            tbproducto.TabIndex = 2;
            tbdescripcion.TabIndex = 3;
            tbminimo.TabIndex = 4;
            cbunidad.TabIndex = 5;
            btnactualizar.TabIndex = 6;
        }

        private void btnregistrprod_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MySqlConnection mySqlConnection = new MySqlConnection(connectionString);
            mySqlConnection.Open();
            String codigo = tbid.Text;
            MySqlDataReader reader = null;
            string sql = "SELECT Producto, Descripcion, Stock_Minimo, Unidad FROM elastosystem_almacen WHERE ID_Producto LIKE '" + codigo + "' ";
            try
            {
                MySqlCommand comando = new MySqlCommand(sql, mySqlConnection);
                reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        tbproducto.Text = reader.GetString(0);
                        tbdescripcion.Text = reader.GetString(1);
                        tbminimo.Text = reader.GetString(2);
                        cbunidad.Text = reader.GetString(3);
                    }
                }
                else
                {
                    MessageBox.Show("Numero de Producto invalido");
                }
                LlamarBaseDatosAlmacen();
                datooriginal = int.Parse(tbminimo.Text);
            }
            catch
            {
                MessageBox.Show("Error al encontrar datos");
            }
            mySqlConnection.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string usuariopc = Environment.UserName;
            DateTime saveNow = DateTime.Now;
            string fecha = saveNow.ToShortDateString();
            string hora = saveNow.ToLongTimeString();

            if (string.IsNullOrWhiteSpace(tbid.Text) || string.IsNullOrWhiteSpace(tbproducto.Text) || string.IsNullOrWhiteSpace(tbdescripcion.Text) || string.IsNullOrWhiteSpace(tbminimo.Text) || cbunidad.SelectedIndex == -1)
            {
                MessageBox.Show("DEBEN DE ESTAR LLENOS TODOS LOS CAMPOS");
            }
            else
            {
                int datob = int.Parse(tbminimo.Text);
                if (datob < 0)
                {
                    MessageBox.Show("ERROR NO PUEDES COLOCAR NUMEROS NEGATIVOS");
                }
                else
                {
                    try
                    {
                        MySqlConnection mySqlConnection = new MySqlConnection(connectionString);
                        mySqlConnection.Open();
                        MySqlCommand comando = new MySqlCommand();
                        comando.Connection = mySqlConnection;
                        comando.CommandText = "UPDATE elastosystem_almacen SET Stock_Minimo = '" + tbminimo.Text + "' , Unidad = '" + cbunidad.Text + "' , Descripcion = '" + tbdescripcion.Text + "'  WHERE ID_Producto = '" + tbid.Text + "'";
                        comando.ExecuteNonQuery();
                        mySqlConnection.Close();
                        MessageBox.Show("Producto No. " + tbid.Text + " actualizado");
                        tbid.Clear(); tbproducto.Clear(); tbdescripcion.Clear(); tbminimo.Clear(); cbunidad.Text = string.Empty;
                        LlamarBaseDatosAlmacen();
                    }
                    catch
                    {
                        MessageBox.Show("Error al actualizar datos");
                    }

                }

            }
        }

        private void tbid_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                button2_Click(button2_Click, EventArgs.Empty);
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {


        }

        private void tbexistencias_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvbd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvbd_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvbd_SelectionChanged(object sender, EventArgs e)
        {

        }
    }
}
