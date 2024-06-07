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
    public partial class Compras_RequisicionesEnviadas : Form
    {
        public Compras_RequisicionesEnviadas()
        {
            InitializeComponent();
        }
        private void CargarUsuarios()
        {
            MySqlConnection mySqlConnection = new MySqlConnection(connectionStringelastotec);
            mySqlConnection.Open();
            MySqlDataReader reader = null;
            string sql = "SELECT APATERNO, AMATERNO, NOMBRE FROM empleados WHERE PERMISO = 2";
            try
            {
                MySqlCommand comando = new MySqlCommand(sql, mySqlConnection);
                reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        // Obtener los valores de apaterno, amaterno y nombre
                        string apaterno = reader["APATERNO"].ToString();
                        string amaterno = reader["AMATERNO"].ToString();
                        string nombre = reader["NOMBRE"].ToString();
                        

                        // Combinar los valores en un solo string
                        string nombreCompleto = $"{nombre} {apaterno} {amaterno}";

                        // Agregar el nombre completo al ComboBox si no está duplicado
                        if (!cbUsuarios.Items.Contains(nombreCompleto))
                        {
                            cbUsuarios.Items.Add(nombreCompleto);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                // Cerrar la conexión
                mySqlConnection.Close();
            }

            // Ordenar los elementos del ComboBox
            cbUsuarios.Sorted = true;
            /*
            MySqlConnection mySqlConnection = new MySqlConnection(connectionString);
            mySqlConnection.Open();
            MySqlDataReader reader = null;
            string sql = "SELECT Usuario FROM elastosystem_login";
            try
            {
                HashSet<string> unicos = new HashSet<string>();
                MySqlCommand comando = new MySqlCommand(sql, mySqlConnection);
                reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        cbUsuarios.Items.Add(reader["Usuario"].ToString());
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
            cbUsuarios.Sorted = true;
            */
        }
        private void CargarRequisicionesPendientes()
        {
            try
            {
                string tabla = "SELECT ID_REQ, SOLICITANTE, DEPARTAMENTO, DIA, MES, ANO, NOTAS, USO FROM reqversion2";
                MySqlDataAdapter mySqlAdapter = new MySqlDataAdapter(tabla, connectionStringelastotec);
                DataTable dt = new DataTable();
                mySqlAdapter.Fill(dt);
                dt.Columns["ID_REQ"].ColumnName = "Folio";
                dgvRequisicions.DataSource = dt;
                dt.DefaultView.Sort = "Folio DESC";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            /*
            try
            {
                string tabla = "SELECT ID, Usuario, Fecha, Notas, TipoUso FROM elastosystem_compras_requisicion WHERE Estatus = 'PENDIENTE'";
                MySqlDataAdapter mySqlAdapter = new MySqlDataAdapter(tabla, connectionString);
                DataTable dt = new DataTable();
                mySqlAdapter.Fill(dt);
                dt.Columns["ID"].ColumnName = "Folio";
                dt.Columns["Usuario"].ColumnName = "Solicitante";
                dt.Columns["TipoUso"].ColumnName = "Tipo de Uso";
                dgvRequisicions.DataSource = dt;
                dt.DefaultView.Sort = "Folio DESC";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            */
        }
        private void MandarALlamarPartidas()
        {
            try
            {
                string tabla = "SELECT DESCRIPCION_P, CANTIDAD_P, UNIDAD_P, PROVEEDOR_P, STATUS_P FROM req_partidas WHERE IDFOLIO = '" + lblFolio.Text + "'";
                MySqlDataAdapter mySqlAdapter = new MySqlDataAdapter(tabla, connectionStringelastotec);
                DataTable dt = new DataTable();
                mySqlAdapter.Fill(dt);
                dt.Columns["DESCRIPCION_P"].ColumnName = "DESCRIPCION";
                dt.Columns["CANTIDAD_P"].ColumnName = "CANTIDAD";
                dt.Columns["UNIDAD_P"].ColumnName = "UNIDAD";
                dt.Columns["PROVEEDOR_P"].ColumnName = "PROVEEDOR";
                dt.Columns["STATUS_P"].ColumnName = "ESTATUS";
                dgvPartidas.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            /*
            try
            {
                string tabla = "SELECT Descripcion, Cantidad, Unidad, Precio, Proveedor, Estatus FROM elastosystem_compras_requisicion_desglosada WHERE ID = '" + lblFolio.Text + "'";
                MySqlDataAdapter mySqlAdapter = new MySqlDataAdapter(tabla, connectionString);
                DataTable dt = new DataTable();
                mySqlAdapter.Fill(dt);
                dgvPartidas.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            */
        }
        private void MandarALlamarPorUsuario()
        {
            dgvRequisicions.DataSource = null;
            dgvPartidas.DataSource = null;
            try
            {
                string tabla = "SELECT ID_REQ, SOLICITANTE, DEPARTAMENTO, DIA, MES, ANO, NOTAS, USO FROM reqversion2 WHERE SOLICITANTE = '" + cbUsuarios.Text + "'";
                MySqlDataAdapter mySqlAdapter = new MySqlDataAdapter(tabla, connectionStringelastotec);
                DataTable dt = new DataTable();
                mySqlAdapter.Fill(dt);
                dt.Columns["ID_REQ"].ColumnName = "Folio";
                dgvRequisicions.DataSource = dt;
                dt.DefaultView.Sort = "Folio DESC";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            /*
            dgvRequisicions.DataSource = null;
            dgvPartidas.DataSource = null;
            try
            {
                string tabla = "SELECT ID, Usuario, Fecha, Notas, TipoUso FROM elastosystem_compras_requisicion WHERE Estatus = 'PENDIENTE' AND Usuario = '"+ cbUsuarios.Text +"'";
                MySqlDataAdapter mySqlAdapter = new MySqlDataAdapter(tabla, connectionString);
                DataTable dt = new DataTable();
                mySqlAdapter.Fill(dt);
                dt.Columns["ID"].ColumnName = "Folio";
                dt.Columns["Usuario"].ColumnName = "Solicitante";
                dt.Columns["TipoUso"].ColumnName = "Tipo de Uso";
                dgvRequisicions.DataSource = dt;
                dt.DefaultView.Sort = "Folio DESC";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            */
        }

        string connectionString = "server=10.120.1.3 ; username=root; password= ; database=elastosystem";
        string connectionStringelastotec = "server=10.120.1.3 ; username=root; password= ; database=elastotec";
        private void Compras_RequisicionesEnviadas_Load(object sender, EventArgs e)
        {
            CargarUsuarios();
            CargarRequisicionesPendientes();
        }

        private void dgvRequisicions_DoubleClick(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;

            if (dgv.SelectedCells.Count > 0)
            {
                int rowIndex = dgv.SelectedCells[0].RowIndex;

                string id = dgv.Rows[rowIndex].Cells[0].Value.ToString();
                lblFolio.Text = id;

                string nota = dgv.Rows[rowIndex].Cells[6].Value.ToString();
                txbNotas.Text = nota;

                string uso = dgv.Rows[rowIndex].Cells[7].Value.ToString();
                txbTipoUso.Text = uso;
            }
            MandarALlamarPartidas();
            /*
            DataGridView dgv = (DataGridView)sender;

            if (dgv.SelectedCells.Count > 0)
            {
                int rowIndex = dgv.SelectedCells[0].RowIndex;

                string id = dgv.Rows[rowIndex].Cells[0].Value.ToString();
                lblFolio.Text = id;

                string nota = dgv.Rows[rowIndex].Cells[3].Value.ToString();
                txbNotas.Text = nota;

                string uso = dgv.Rows[rowIndex].Cells[4].Value.ToString();
                txbTipoUso.Text = uso;
            }
            MandarALlamarPartidas();
            */
        }

        private void dgvPartidas_Click(object sender, EventArgs e)
        {

        }

        private void dgvRequisicions_Click(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;

            if (dgv.SelectedCells.Count > 0)
            {
                int rowIndex = dgv.SelectedCells[0].RowIndex;

                string id = dgv.Rows[rowIndex].Cells[0].Value.ToString();
                lblFolio.Text = id;

                string nota = dgv.Rows[rowIndex].Cells[6].Value.ToString();
                txbNotas.Text = nota;

                string uso = dgv.Rows[rowIndex].Cells[7].Value.ToString();
                txbTipoUso.Text = uso;
            }
            MandarALlamarPartidas();
            /*
            DataGridView dgv = (DataGridView)sender;

            if (dgv.SelectedCells.Count > 0)
            {
                int rowIndex = dgv.SelectedCells[0].RowIndex;

                string id = dgv.Rows[rowIndex].Cells[0].Value.ToString();
                lblFolio.Text = id;

                string nota = dgv.Rows[rowIndex].Cells[3].Value.ToString();
                txbNotas.Text = nota;

                string uso = dgv.Rows[rowIndex].Cells[4].Value.ToString();
                txbTipoUso.Text = uso;
            }
            MandarALlamarPartidas();
            */
        }

        private void dgvRequisicions_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        private void cbUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbUsuarios.Text == "TODOS")
            {
                CargarRequisicionesPendientes();
            }
            else
            {
                MandarALlamarPorUsuario();
            }
            
        }
    }
}
