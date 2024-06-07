using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElastoSystem
{
    public partial class ConsumiblesAlmacen : Form
    {
        public ConsumiblesAlmacen()
        {
            InitializeComponent();
        }

        private void EliminarConsumiblesPorSurtir()
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            try
            {
                cmd.CommandText = "DELETE FROM elastosystem_almacenconsumiblesporsurtir";
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        private void PorSurtir()
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            try
            {
                cmd.CommandText = "INSERT INTO elastosystem_almacenconsumiblesporsurtir (id_producto, producto, existencias, stock_minimo) SELECT id_producto, producto, existencias, stock_minimo FROM elastosystem_almacen WHERE stock_minimo >= existencias";
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        private void MandarALlamarConsumibles()
        {
            string cons = "SELECT * FROM elastosystem_almacen";
            MySqlDataAdapter mySqlAdapter = new MySqlDataAdapter(cons, connectionString);
            DataTable dta = new DataTable();
            mySqlAdapter.Fill(dta);
            dgvGeneral.DataSource = dta;
        }
        private void ConsumiblesAlmacen_Load(object sender, EventArgs e)
        {
            MandarALlamarConsumibles();
            EliminarConsumiblesPorSurtir();
            PorSurtir();
            string tabla = "SELECT * FROM elastosystem_almacenconsumiblesporsurtir";
            MySqlDataAdapter mySqlAdapter = new MySqlDataAdapter(tabla, connectionString);
            DataTable dt = new DataTable();
            mySqlAdapter.Fill(dt);
            dgv.DataSource = dt;
        }
        string connectionString = "server=10.120.1.3 ; username=root; password=; database=elastosystem";

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
