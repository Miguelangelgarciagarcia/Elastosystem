using DocumentFormat.OpenXml.Wordprocessing;
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
    public partial class Ventas_Clientes : Form
    {
        public Ventas_Clientes()
        {
            InitializeComponent();
        }
        private void OrdenTab()
        {
            txbEmpresa.TabIndex = 0;
            txbCliente.TabIndex = 1;
            txbTelefono.TabIndex = 2;
            txbCorreo.TabIndex = 3;
            txbRFC.TabIndex = 4;
            txbDireccion.TabIndex = 5;
            txbBanco.TabIndex = 6;
            txbNoCuenta.TabIndex = 7;
            txbClabe.TabIndex = 8;
        }
        private void IDIncrementable()
        {
            MySqlConnection mySqlConnection = new MySqlConnection(connectionStringelastotec);
            mySqlConnection.Open();
            MySqlDataReader reader = null;
            int idprod;
            string sql = "SELECT ID FROM clientes ORDER BY ID DESC LIMIT 1 ";
            try
            {
                MySqlCommand comando = new MySqlCommand(sql, mySqlConnection);
                reader = comando.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        idprod = Convert.ToInt32(reader["ID"]);
                        int idnuevo = idprod + 1;
                        lblID.Text = idnuevo.ToString();
                    }
                }
                else
                {

                }
                this.BeginInvoke(new Action(() =>
                {
                    txbEmpresa.Focus();
                }));

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            /*
            MySqlConnection mySqlConnection = new MySqlConnection(connectionString);
            mySqlConnection.Open();
            MySqlDataReader reader = null;
            int idprod;
            string sql = "SELECT ID FROM elastosystem_ventas_clientes ORDER BY ID DESC LIMIT 1 ";
            try
            {
                MySqlCommand comando = new MySqlCommand(sql, mySqlConnection);
                reader = comando.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        idprod = Convert.ToInt32(reader["ID"]);
                        int idnuevo = idprod + 1;
                        lblID.Text = idnuevo.ToString();
                    }
                }
                else
                {

                }
                this.BeginInvoke(new Action(() =>
                {
                    txbEmpresa.Focus();
                }));

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            */
        }
        private void MandarALlamarBDClientes()
        {
            string tabla = "SELECT * FROM clientes";
            MySqlDataAdapter mySqlAdapter = new MySqlDataAdapter(tabla, connectionStringelastotec);
            DataTable dt = new DataTable();
            mySqlAdapter.Fill(dt);
            dgvClientes.DataSource = dt;
            dt.DefaultView.Sort = "ID DESC";
            /*
            string tabla = "SELECT * FROM elastosystem_ventas_clientes";
            MySqlDataAdapter mySqlAdapter = new MySqlDataAdapter(tabla, connectionString);
            DataTable dt = new DataTable();
            mySqlAdapter.Fill(dt);
            dgvClientes.DataSource = dt;
            dt.DefaultView.Sort = "ID DESC";
            */
        }
        private void AgregarCliente()
        {
            try
            {
                MySqlConnection mySqlConnection = new MySqlConnection(connectionStringelastotec);
                mySqlConnection.Open();
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = mySqlConnection;
                if (string.IsNullOrWhiteSpace(txbEmpresa.Text) || string.IsNullOrWhiteSpace(txbCliente.Text) || string.IsNullOrWhiteSpace(txbTelefono.Text) || string.IsNullOrEmpty(txbCorreo.Text) || string.IsNullOrEmpty(txbRFC.Text))
                {
                    MessageBox.Show("Favor de Ingresar todos los datos");
                }
                else
                {
                    comando.CommandText = "INSERT INTO clientes (ID, NOMBRE, CONTACTO, TELEFONO, EMAIL, DIRECCION, RFC, BANCO, NOCUENTA, CLABE) VALUES('" + lblID.Text + "','" + txbEmpresa.Text + "','" + txbCliente.Text + "','" + txbTelefono.Text + "' , '" + txbCorreo.Text + "', '" + txbDireccion.Text + "', '" + txbRFC.Text + "', '" + txbBanco.Text + "', '" + txbNoCuenta.Text + "', '" + txbClabe.Text + "');";
                    comando.ExecuteNonQuery();
                    mySqlConnection.Close();
                    MessageBox.Show("Cliente No. " + lblID.Text + " registrado");
                    LimpiarDatosCliente();
                    IDIncrementable();
                    MandarALlamarBDClientes();
                }
            }
            catch
            {
                MessageBox.Show("Error al registrar datos");
            }
            /*
            try
            {
                MySqlConnection mySqlConnection = new MySqlConnection(connectionString);
                mySqlConnection.Open();
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = mySqlConnection;
                if (string.IsNullOrWhiteSpace(txbEmpresa.Text) || string.IsNullOrWhiteSpace(txbCliente.Text) || string.IsNullOrWhiteSpace(txbTelefono.Text) || string.IsNullOrEmpty(txbCliente.Text))
                {
                    MessageBox.Show("Favor de Ingresar todos los datos");
                }
                else
                {
                    comando.CommandText = "INSERT INTO elastosystem_ventas_clientes (ID, Empresa, Cliente, Telefono, Correo) VALUES('" + lblID.Text + "','" + txbEmpresa.Text + "','" + txbCliente.Text + "','" + txbTelefono.Text + "' , '" + txbCorreo.Text + "');";
                    comando.ExecuteNonQuery();
                    mySqlConnection.Close();
                    MessageBox.Show("Cliente No. " + lblID.Text + " registrado");
                    lblID.Text = string.Empty; txbEmpresa.Clear(); txbCliente.Clear(); txbTelefono.Clear(); txbCorreo.Text = string.Empty;
                    IDIncrementable();
                    MandarALlamarBDClientes();
                }
            }
            catch
            {
                MessageBox.Show("Error al registrar datos");
            }
            */
        }
        private void LimpiarDatosCliente()
        {
            txbEmpresa.Clear();
            txbCliente.Clear();
            txbTelefono.Clear();
            txbCorreo.Clear();
            txbRFC.Clear();
            txbDireccion.Clear();
            txbBanco.Clear();
            txbNoCuenta.Clear();
            txbClabe.Clear();
        }
        private void BotonesHabilitadosEInhabilitadosDGV()
        {
            btnAgregarCliente.Visible = false;
            btnNuevo.Visible = true;
            btnEliminar.Visible = true;
            btnActualizar.Visible = true;

            btnEliminar.Enabled = true;
            btnActualizar.Enabled = true;
            btnNuevo.Enabled = true;
        }
        private void BotonesHabilitadosEInhabilitadosNuevo()
        {
            btnNuevo.Visible = false;
            btnEliminar.Visible = false;
            btnActualizar.Visible = false;
            btnAgregarCliente.Visible = true;

        }
        private void EliminarRegistro()
        {
            try
            {
                MySqlConnection mySqlConnection = new MySqlConnection(connectionStringelastotec);
                mySqlConnection.Open();
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = mySqlConnection;
                comando.CommandText = "DELETE FROM clientes WHERE ID = '" + lblID.Text + "'";
                comando.ExecuteNonQuery();
                mySqlConnection.Close();
                MessageBox.Show("Cliente No. " + lblID.Text + " eliminado");
                LimpiarDatosCliente();
                MandarALlamarBDClientes();
            }
            catch
            {
                MessageBox.Show("Error al eliminar cliente");
            }
            /*
            try
            {
                MySqlConnection mySqlConnection = new MySqlConnection(connectionString);
                mySqlConnection.Open();
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = mySqlConnection;
                comando.CommandText = "DELETE FROM elastosystem_ventas_clientes WHERE ID = '" + lblID.Text + "'";
                comando.ExecuteNonQuery();
                mySqlConnection.Close();
                MessageBox.Show("Cliente No. " + lblID.Text + " eliminado");
                lblID.Text = string.Empty; txbEmpresa.Clear(); txbCliente.Clear(); txbTelefono.Clear(); txbCorreo.Text = string.Empty;
                MandarALlamarBDClientes();
            }
            catch
            {
                MessageBox.Show("Error al eliminar cliente");
            }
            */
        }
        private void ActualizarRegistro()
        {
            try
            {
                MySqlConnection mySqlConnection = new MySqlConnection(connectionStringelastotec);
                mySqlConnection.Open();
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = mySqlConnection;
                if (string.IsNullOrWhiteSpace(txbEmpresa.Text) || string.IsNullOrWhiteSpace(txbCliente.Text) || string.IsNullOrWhiteSpace(txbTelefono.Text) || string.IsNullOrEmpty(txbCorreo.Text))
                {
                    MessageBox.Show("Favor de Ingresar todos los datos");
                }
                else
                {
                    comando.CommandText = "UPDATE clientes SET NOMBRE = '" + txbEmpresa.Text + "', CONTACTO = '" + txbCliente.Text + "', TELEFONO = '" + txbTelefono.Text + "', EMAIL = '" + txbCorreo.Text + "', DIRECCION = '" + txbDireccion.Text + "', RFC = '" + txbRFC.Text + "' , BANCO = '" + txbBanco.Text + "', NOCUENTA = '" + txbNoCuenta.Text + "', CLABE = '" + txbClabe.Text + "' WHERE ID = '" + lblID.Text + "'";
                    comando.ExecuteNonQuery();
                    mySqlConnection.Close();
                    MessageBox.Show("Cliente No. " + lblID.Text + " actaualizado");
                    LimpiarDatosCliente();
                    MandarALlamarBDClientes();
                    btnNuevo.PerformClick();
                }
            }
            catch
            {
                MessageBox.Show("Error al actualizar datos");
            }
            /*
            try
            {
                MySqlConnection mySqlConnection = new MySqlConnection(connectionString);
                mySqlConnection.Open();
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = mySqlConnection;
                if (string.IsNullOrWhiteSpace(txbEmpresa.Text) || string.IsNullOrWhiteSpace(txbCliente.Text) || string.IsNullOrWhiteSpace(txbTelefono.Text) || string.IsNullOrEmpty(txbCliente.Text))
                {
                    MessageBox.Show("Favor de Ingresar todos los datos");
                }
                else
                {
                    comando.CommandText = "UPDATE elastosystem_ventas_clientes SET Empresa = '" + txbEmpresa.Text + "', Cliente = '" + txbCliente.Text + "', Telefono = '" + txbTelefono.Text + "', Correo = '" + txbCorreo.Text + "' WHERE ID = '" + lblID.Text + "'";
                    comando.ExecuteNonQuery();
                    mySqlConnection.Close();
                    MessageBox.Show("Cliente No. " + lblID.Text + " actaualizado");
                    lblID.Text = string.Empty; txbEmpresa.Clear(); txbCliente.Clear(); txbTelefono.Clear(); txbCorreo.Text = string.Empty;
                    MandarALlamarBDClientes();
                }
            }
            catch
            {
                MessageBox.Show("Error al actualizar datos");
            }
            */
        }
        private void Buscador()
        {
            try
            {
                string valorBusqueda = txbBuscador.Text;
                string consulta = "SELECT * FROM clientes WHERE CONTACTO LIKE @ValorBusqueda OR NOMBRE LIKE @ValorBusqueda";

                MySqlDataAdapter adaptador = new MySqlDataAdapter(consulta, connectionStringelastotec);

                adaptador.SelectCommand.Parameters.AddWithValue("@ValorBusqueda", "%" + valorBusqueda + "%");

                DataSet datos = new DataSet();

                adaptador.Fill(datos, "Resultados");

                dgvClientes.DataSource = datos.Tables["Resultados"];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar datos: " + ex.Message);
            }
            /*
            try
            {
                // Asegúrate de tener una conexión a la base de datos (connectionString)
                string valorBusqueda = txbBuscador.Text;
                string consulta = "SELECT * FROM elastosystem_ventas_clientes WHERE cliente LIKE @ValorBusqueda OR empresa LIKE @ValorBusqueda";

                // Crear un adaptador de datos
                MySqlDataAdapter adaptador = new MySqlDataAdapter(consulta, connectionString);

                // Configurar los parámetros del adaptador
                adaptador.SelectCommand.Parameters.AddWithValue("@ValorBusqueda", "%" + valorBusqueda + "%");

                // Crear un conjunto de datos para almacenar los resultados
                DataSet datos = new DataSet();

                // Rellenar el conjunto de datos con los resultados de la consulta
                adaptador.Fill(datos, "Resultados");

                // Asignar el conjunto de datos al DataGridView
                dgvClientes.DataSource = datos.Tables["Resultados"];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar datos: " + ex.Message);
            }
            */
        }

        string connectionString = "server=10.120.1.3 ; username=root; password=; database=elastosystem";
        string connectionStringelastotec = "server=10.120.1.3 ; username=root; password=; database=elastotec";

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void Ventas_Clientes_Load(object sender, EventArgs e)
        {
            MandarALlamarBDClientes();
            IDIncrementable();
            OrdenTab();
        }
        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            AgregarCliente();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            LimpiarDatosCliente();
        }
        private void dgvClientes_SelectionChanged(object sender, EventArgs e)
        {

        }
        private void dgvClientes_DoubleClick(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;

            if (dgv.SelectedCells.Count > 0)
            {
                int rowIndex = dgv.SelectedCells[0].RowIndex;

                string id = dgv.Rows[rowIndex].Cells[0].Value.ToString();
                lblID.Text = id;

                string empresa = dgv.Rows[rowIndex].Cells[1].Value.ToString();
                txbEmpresa.Text = empresa;

                string direccion = dgv.Rows[rowIndex].Cells[2].Value.ToString();
                txbDireccion.Text = direccion;

                string telefono = dgv.Rows[rowIndex].Cells[3].Value.ToString();
                txbTelefono.Text = telefono;

                string correo = dgv.Rows[rowIndex].Cells[4].Value.ToString();
                txbCorreo.Text = correo;

                string rfc = dgv.Rows[rowIndex].Cells[5].Value.ToString();
                txbRFC.Text = rfc;

                string cliente = dgv.Rows[rowIndex].Cells[6].Value.ToString();
                txbCliente.Text = cliente;

                string banco = dgv.Rows[rowIndex].Cells[7].Value.ToString();
                txbBanco.Text = banco;

                string nocuenta = dgv.Rows[rowIndex].Cells[8].Value.ToString();
                txbNoCuenta.Text = nocuenta;

                string clabe = dgv.Rows[rowIndex].Cells[9].Value.ToString();
                txbClabe.Text = clabe;




            }
            BotonesHabilitadosEInhabilitadosDGV();
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            BotonesHabilitadosEInhabilitadosNuevo();
            LimpiarDatosCliente();
            IDIncrementable();
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarRegistro();
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ActualizarRegistro();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Buscador();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txbBuscador_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txbBuscador_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Buscador();
            }
        }

        private void txbBuscador_TextChanged(object sender, EventArgs e)
        {
            Buscador();
        }
    }
}
