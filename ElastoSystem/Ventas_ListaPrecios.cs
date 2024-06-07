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
    public partial class Ventas_ListaPrecios : Form
    {
        public Ventas_ListaPrecios()
        {
            InitializeComponent();
        }
        private void MandarALlamarProductos()
        {
            string tabla = "SELECT CLAVE, NOMBRE, PRECIO_A, LIMITE_A, PRECIO_AA, LIMITE_AA, PRECIO_AAA, LIMITE_AAA FROM productos";
            MySqlDataAdapter mySqlAdapter = new MySqlDataAdapter(tabla, connectionStringelastotec);
            DataTable dt = new DataTable();
            mySqlAdapter.Fill(dt);
            dgvProductos.DataSource = dt;
            dt.DefaultView.Sort = "CLAVE ASC";
            
        }
        private void Buscador()
        {
            try
            {
                string valorBusqueda = txbBuscador.Text;
                string consulta = "SELECT  CLAVE, NOMBRE, PRECIO_A, LIMITE_A, PRECIO_AA, LIMITE_AA, PRECIO_AAA, LIMITE_AAA FROM productos WHERE CLAVE LIKE @ValorBusqueda OR NOMBRE LIKE @ValorBusqueda";

                MySqlDataAdapter adaptador = new MySqlDataAdapter(consulta, connectionStringelastotec);

                adaptador.SelectCommand.Parameters.AddWithValue("@ValorBusqueda", "%" + valorBusqueda + "%");

                DataSet datos = new DataSet();

                adaptador.Fill(datos, "Resultados");

                dgvProductos.DataSource = datos.Tables["Resultados"];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar datos: " + ex.Message);
            }
        }
        private void BotonesHabilitadosEInhabilitadosDGV()
        {
            btnAgregar.Visible = false;
            btnNuevo.Visible = true;
            btnEliminar.Visible = true;
            btnActualizar.Visible = true;

            btnEliminar.Enabled = true;
            btnActualizar.Enabled = true;
            btnNuevo.Enabled = true;
        }
        private void LimpiarDatos()
        {
            txbClave.Focus();
            txbClave.Clear();
            txbProducto.Clear();
            txbPrecioA.Clear();
            txbLimiteA.Clear();
            txbPrecioAA.Clear();
            txbLimiteAA.Clear();
            txbPrecioAAA.Clear();
            txbLimiteAAA.Clear();
        }
        private void ActualizarDatos()
        {
            try
            {
                MySqlConnection mySqlConnection = new MySqlConnection(connectionStringelastotec);
                mySqlConnection.Open();
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = mySqlConnection;
                if (string.IsNullOrWhiteSpace(txbClave.Text) || string.IsNullOrWhiteSpace(txbProducto.Text) || string.IsNullOrWhiteSpace(txbPrecioA.Text) || string.IsNullOrEmpty(txbLimiteA.Text))
                {
                    MessageBox.Show("Favor de Ingresar todos los datos necesarios");
                }
                else
                {
                    comando.CommandText = "UPDATE productos SET NOMBRE = '" + txbProducto.Text + "', PRECIO_A = '" + txbPrecioA.Text + "', LIMITE_A = '" + txbLimiteA.Text + "', PRECIO_AA = '" + txbPrecioAA.Text + "', LIMITE_AA = '" + txbLimiteAA.Text + "', PRECIO_AAA = '" + txbPrecioAAA.Text + "' , LIMITE_AAA = '" + txbLimiteAAA.Text + "' WHERE CLAVE = '" + txbClave.Text + "'";
                    comando.ExecuteNonQuery();
                    mySqlConnection.Close();
                    MessageBox.Show("Producto " + txbClave.Text + " actaualizado");
                    LimpiarDatos();
                    MandarALlamarProductos();
                    btnNuevo.PerformClick();
                }
            }
            catch
            {
                MessageBox.Show("Error al actualizar datos");
            }
        }
        private void EliminarProducto()
        {
            try
            {
                MySqlConnection mySqlConnection = new MySqlConnection(connectionStringelastotec);
                mySqlConnection.Open();
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = mySqlConnection;
                comando.CommandText = "DELETE FROM productos WHERE CLAVE = '" + txbClave.Text + "'";
                comando.ExecuteNonQuery();
                mySqlConnection.Close();
                MessageBox.Show("Producto " + txbClave.Text + " eliminado");
                LimpiarDatos();
                MandarALlamarProductos();
            }
            catch
            {
                MessageBox.Show("Error al eliminar cliente");
            }
        }
        private void AgregarProducto()
        {
            try
            {
                MySqlConnection mySqlConnection = new MySqlConnection(connectionStringelastotec);
                mySqlConnection.Open();
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = mySqlConnection;
                if (string.IsNullOrWhiteSpace(txbClave.Text) || string.IsNullOrWhiteSpace(txbProducto.Text) || string.IsNullOrWhiteSpace(txbPrecioA.Text) || string.IsNullOrEmpty(txbLimiteA.Text))
                {
                    MessageBox.Show("Favor de Ingresar todos los datos");
                }
                else
                {
                    comando.CommandText = "INSERT INTO productos (CLAVE, NOMBRE, PRECIO_A, LIMITE_A, PRECIO_AA, LIMITE_AA, PRECIO_AAA, LIMITE_AAA) VALUES('" + txbClave.Text + "','" + txbProducto.Text + "','" + txbPrecioA.Text + "','" + txbLimiteA.Text + "' , '" + txbPrecioAA.Text + "', '" + txbLimiteAA.Text + "', '" + txbPrecioAAA.Text + "', '" + txbLimiteAAA.Text + "');";
                    comando.ExecuteNonQuery();
                    mySqlConnection.Close();
                    MessageBox.Show("Producto " + txbClave.Text + " registrado");
                    LimpiarDatos();
                    MandarALlamarProductos();
                }
            }
            catch
            {
                MessageBox.Show("Error al registrar datos");
            }
        }
        private void Nuevo()
        {
            txbClave.Enabled = true;
            btnEliminar.Visible = false;
            btnActualizar.Visible = false;
            btnNuevo.Visible = false;
            btnAgregar.Visible = true;
            LimpiarDatos();
        }
        private void Tabuladores()
        {
            txbClave.Focus();
            txbClave.TabIndex = 0;
            txbProducto.TabIndex = 1;
            txbPrecioA.TabIndex = 2;
            txbLimiteA.TabIndex = 3;
            txbPrecioAA.TabIndex = 4;
            txbLimiteAA.TabIndex = 5;
            txbPrecioAAA.TabIndex = 6;
            txbLimiteAAA.TabIndex = 7;
        }


        string connectionStringelastotec = "server=10.120.1.3 ; username=root; password=; database=elastotec";

        private void Ventas_ListaPrecios_Load(object sender, EventArgs e)
        {
            MandarALlamarProductos();
            Tabuladores();

        }

        private void txbBuscador_TextChanged(object sender, EventArgs e)
        {
            Buscador();
        }

        private void txbBuscador_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Buscador();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Buscador();
        }

        private void dgvProductos_DoubleClick(object sender, EventArgs e)
        {
            txbClave.Enabled = false;
            DataGridView dgv = (DataGridView)sender;

            if (dgv.SelectedCells.Count > 0)
            {
                int rowIndex = dgv.SelectedCells[0].RowIndex;

                string clave = dgv.Rows[rowIndex].Cells[0].Value.ToString();
                txbClave.Text = clave;

                string producto = dgv.Rows[rowIndex].Cells[1].Value.ToString();
                txbProducto.Text = producto;

                string precioa = dgv.Rows[rowIndex].Cells[2].Value.ToString();
                txbPrecioA.Text = precioa;

                string limitea = dgv.Rows[rowIndex].Cells[3].Value.ToString();
                txbLimiteA.Text = limitea;

                string precioaa = dgv.Rows[rowIndex].Cells[4].Value.ToString();
                txbPrecioAA.Text = precioaa;

                string limiteaa = dgv.Rows[rowIndex].Cells[5].Value.ToString();
                txbLimiteAA.Text = limiteaa;

                string precioaaa = dgv.Rows[rowIndex].Cells[6].Value.ToString();
                txbPrecioAAA.Text = precioaaa;

                string limiteaaa = dgv.Rows[rowIndex].Cells[7].Value.ToString();
                txbLimiteAAA.Text = limiteaaa;

                BotonesHabilitadosEInhabilitadosDGV();

            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarDatos();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ActualizarDatos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarProducto();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarProducto();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Nuevo();
        }
    }
}
