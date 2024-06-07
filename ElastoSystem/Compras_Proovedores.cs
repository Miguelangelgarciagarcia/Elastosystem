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
    public partial class Compras_Proovedores : Form
    {
        public Compras_Proovedores()
        {
            InitializeComponent();
        }
        private void CargarProveedores()
        {
            try
            {
                string tabla = "SELECT ID_PROVEE, NOMBRE, EMAIL, TELEFONO, PRODUCTO, DIRECCION, RFC, CONTACTO, NO_CUENTA FROM proveedores";
                MySqlDataAdapter mySqlAdapter = new MySqlDataAdapter(tabla, connectionStringelastotec);
                DataTable dt = new DataTable();
                mySqlAdapter.Fill(dt);
                //dt.Columns["Direccion"].ColumnName = "Dirección";
                //dt.Columns["NumeroCuenta"].ColumnName = "Numero de Cuenta";
                dgvProveedores.DataSource = dt;
                dt.DefaultView.Sort = "ID_PROVEE DESC";
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR AL CARGAR BD PROVEEDORES");
            }
            /*
            try
            {
                string tabla = "SELECT ID, Nombre, Email, Telefono, RFC, Direccion, Productos, Contacto, NumeroCuenta, Critico FROM elastosystem_compras_proveedores";
                MySqlDataAdapter mySqlAdapter = new MySqlDataAdapter(tabla, connectionString);
                DataTable dt = new DataTable();
                mySqlAdapter.Fill(dt);
                dt.Columns["Direccion"].ColumnName = "Dirección";
                dt.Columns["NumeroCuenta"].ColumnName = "Numero de Cuenta";
                dgvProveedores.DataSource = dt;
                dt.DefaultView.Sort = "ID DESC";
            }
            catch (Exception ex)
            {

            }
            */
        }
        private void NuevoID()
        {
            MySqlConnection mySqlConnection = new MySqlConnection(connectionStringelastotec);
            mySqlConnection.Open();
            MySqlDataReader reader = null;
            string sql = "SELECT ID_PROVEE FROM proveedores";

            try
            {
                int ultimoFolio = 0;
                MySqlCommand comando = new MySqlCommand(sql, mySqlConnection);
                reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string folioString = reader["ID_PROVEE"].ToString();
                        if (int.TryParse(folioString, out int folio))
                        {
                            ultimoFolio = folio;
                        }
                        else
                        {

                        }
                    }
                    ultimoFolio = ultimoFolio + 1;
                    lblID.Text = ultimoFolio.ToString();
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
            //CONEXION CON ELASTOSYSTEM
            /*
            MySqlConnection mySqlConnection = new MySqlConnection(connectionString);
            mySqlConnection.Open();
            MySqlDataReader reader = null;
            string sql = "SELECT ID FROM elastosystem_compras_proveedores";

            try
            {
                int ultimoFolio = 0;
                MySqlCommand comando = new MySqlCommand(sql, mySqlConnection);
                reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string folioString = reader["ID"].ToString();
                        if (int.TryParse(folioString, out int folio))
                        {
                            ultimoFolio = folio;
                        }
                        else
                        {

                        }
                    }
                    ultimoFolio = ultimoFolio + 1;
                    lblID.Text = ultimoFolio.ToString();
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
            */
        }
        private void Buscador()
        {
            try
            {

                string valorBusqueda = txbBuscador.Text;
                string consulta = "SELECT ID_PROVEE, NOMBRE, EMAIL, TELEFONO, PRODUCTO, DIRECCION, RFC, CONTACTO, NO_CUENTA FROM proveedores WHERE NOMBRE LIKE @ValorBusqueda OR PRODUCTO LIKE @ValorBusqueda";

                MySqlDataAdapter adaptador = new MySqlDataAdapter(consulta, connectionStringelastotec);

                adaptador.SelectCommand.Parameters.AddWithValue("@ValorBusqueda", "%" + valorBusqueda + "%");

                DataSet datos = new DataSet();

                adaptador.Fill(datos, "Resultados");

                dgvProveedores.DataSource = datos.Tables["Resultados"];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar datos: " + ex.Message);
            }
            /*
            try
            {

                string valorBusqueda = txbBuscador.Text;
                string consulta = "SELECT ID, Nombre, Email, Telefono, RFC, Direccion, Productos, Contacto, NumeroCuenta, Critico FROM elastosystem_compras_proveedores WHERE Nombre LIKE @ValorBusqueda OR Productos LIKE @ValorBusqueda";

                MySqlDataAdapter adaptador = new MySqlDataAdapter(consulta, connectionString);

                adaptador.SelectCommand.Parameters.AddWithValue("@ValorBusqueda", "%" + valorBusqueda + "%");

                DataSet datos = new DataSet();

                adaptador.Fill(datos, "Resultados");

                dgvProveedores.DataSource = datos.Tables["Resultados"];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar datos: " + ex.Message);
            }
            */
        }
        private void AgregarProveedor()
        {
            try
            {
                MySqlConnection mySqlConnection = new MySqlConnection(connectionStringelastotec);
                mySqlConnection.Open();
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = mySqlConnection;
                if (string.IsNullOrWhiteSpace(txbNombre.Text) || string.IsNullOrWhiteSpace(txbEmail.Text) || string.IsNullOrWhiteSpace(txbTelefono.Text) || string.IsNullOrEmpty(txbRFC.Text) || string.IsNullOrEmpty(txbDireccion.Text) || string.IsNullOrEmpty(txbProductos.Text) || string.IsNullOrEmpty(txbContacto.Text) || string.IsNullOrEmpty(txbNoCuenta.Text))
                {
                    MessageBox.Show("Favor de ingresar todos los datos");
                }
                else
                {
                    comando.CommandText = "INSERT INTO proveedores (ID_PROVEE, NOMBRE, EMAIL, TELEFONO, RFC, DIRECCION, PRODUCTO, CONTACTO, NO_CUENTA, CLASIFICACION) VALUES('" + lblID.Text + "','" + txbNombre.Text + "','" + txbEmail.Text + "','" + txbTelefono.Text + "' , '" + txbRFC.Text + "', '" + txbDireccion.Text + "', '" + txbProductos.Text + "', '" + txbContacto.Text + "', '" + txbNoCuenta.Text + "', '" + lblCritico.Text + "');";
                    comando.ExecuteNonQuery();
                    mySqlConnection.Close();
                    MessageBox.Show("Proveedor No. " + lblID.Text + " registrado");
                    LimpiarCampos();
                    CargarProveedores();
                    NuevoID();
                }
            }
            catch
            {
                MessageBox.Show("Error al registrar datos");
            }
            /*
            try
            {
                bool boolCritico = chbCritico.Checked;
                MySqlConnection mySqlConnection = new MySqlConnection(connectionString);
                mySqlConnection.Open();
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = mySqlConnection;
                if (string.IsNullOrWhiteSpace(txbNombre.Text) || string.IsNullOrWhiteSpace(txbEmail.Text) || string.IsNullOrWhiteSpace(txbTelefono.Text) || string.IsNullOrEmpty(txbRFC.Text) || string.IsNullOrEmpty(txbDireccion.Text) || string.IsNullOrEmpty(txbProductos.Text) || string.IsNullOrEmpty(txbContacto.Text) || string.IsNullOrEmpty(txbNoCuenta.Text))
                {
                    MessageBox.Show("Favor de ingresar todos los datos");
                }
                else
                {
                    comando.CommandText = "INSERT INTO elastosystem_compras_proveedores (ID, Nombre, Email, Telefono, RFC, Direccion, Productos, Contacto, NumeroCuenta, Critico) VALUES('" + lblID.Text + "','" + txbNombre.Text + "','" + txbEmail.Text + "','" + txbTelefono.Text + "' , '" + txbRFC.Text + "', '" + txbDireccion.Text + "', '" + txbProductos.Text + "', '" + txbContacto.Text + "', '" + txbNoCuenta.Text + "', " + boolCritico + ");";
                    comando.ExecuteNonQuery();
                    mySqlConnection.Close();
                    MessageBox.Show("Proveedor No. " + lblID.Text + " registrado");
                    LimpiarCampos();
                    CargarProveedores();
                    NuevoID();
                }
            }
            catch
            {
                MessageBox.Show("Error al registrar datos");
            }
            */
        }
        private void LimpiarCampos()
        {
            txbNombre.Clear();
            txbEmail.Clear();
            txbTelefono.Clear();
            txbRFC.Clear();
            txbDireccion.Clear();
            txbProductos.Clear();
            txbContacto.Clear();
            txbNoCuenta.Clear();
            chbCritico.Checked = false;
        }
        private void ModificarProveedor()
        {
            try
            {
                MySqlConnection mySqlConnection = new MySqlConnection(connectionStringelastotec);
                mySqlConnection.Open();
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = mySqlConnection;
                if (string.IsNullOrWhiteSpace(txbNombre.Text) || string.IsNullOrWhiteSpace(txbEmail.Text) || string.IsNullOrWhiteSpace(txbTelefono.Text) || string.IsNullOrEmpty(txbRFC.Text) || string.IsNullOrEmpty(txbDireccion.Text) || string.IsNullOrEmpty(txbProductos.Text) || string.IsNullOrEmpty(txbContacto.Text) || string.IsNullOrEmpty(txbNoCuenta.Text))
                {
                    MessageBox.Show("Favor de Ingresar todos los datos");
                }
                else
                {
                    comando.CommandText = "UPDATE proveedores SET NOMBRE = '" + txbNombre.Text + "', EMAIL = '" + txbEmail.Text + "', TELEFONO = '" + txbTelefono.Text + "', RFC = '" + txbRFC.Text + "', DIRECCION = '" + txbDireccion.Text + "', PRODUCTO = '" + txbProductos.Text + "', CONTACTO = '" + txbContacto.Text + "', NO_CUENTA = '" + txbNoCuenta.Text + "', CLASIFICACION = '" + lblCritico.Text + "' WHERE ID_PROVEE = '" + lblID.Text + "'";
                    comando.ExecuteNonQuery();
                    mySqlConnection.Close();
                    MessageBox.Show("Proveedor No. " + lblID.Text + " actaualizado");
                    LimpiarCampos();
                    CargarProveedores();
                    lblID.Text = " ";
                }
            }
            catch
            {
                MessageBox.Show("Error al actualizar datos");
            }
            /*
            try
            {
                bool boolCritico = chbCritico.Checked;
                MySqlConnection mySqlConnection = new MySqlConnection(connectionString);
                mySqlConnection.Open();
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = mySqlConnection;
                if (string.IsNullOrWhiteSpace(txbNombre.Text) || string.IsNullOrWhiteSpace(txbEmail.Text) || string.IsNullOrWhiteSpace(txbTelefono.Text) || string.IsNullOrEmpty(txbRFC.Text) || string.IsNullOrEmpty(txbDireccion.Text) || string.IsNullOrEmpty(txbProductos.Text) || string.IsNullOrEmpty(txbContacto.Text) || string.IsNullOrEmpty(txbNoCuenta.Text))
                {
                    MessageBox.Show("Favor de Ingresar todos los datos");
                }
                else
                {
                    comando.CommandText = "UPDATE elastosystem_compras_proveedores SET Nombre = '" + txbNombre.Text + "', Email = '" + txbEmail.Text + "', Telefono = '" + txbTelefono.Text + "', RFC = '" + txbRFC.Text + "', Direccion = '" + txbDireccion.Text + "', Productos = '" + txbProductos.Text + "', Contacto = '" + txbContacto.Text + "', NumeroCuenta = '" + txbNoCuenta.Text + "', Critico = " + boolCritico + " WHERE ID = '" + lblID.Text + "'";
                    comando.ExecuteNonQuery();
                    mySqlConnection.Close();
                    MessageBox.Show("Proveedor No. " + lblID.Text + " actaualizado");
                    LimpiarCampos();
                    CargarProveedores();
                    lblID.Text = " ";
                }
            }
            catch
            {
                MessageBox.Show("Error al actualizar datos");
            }
            */
        }
        private void EliminarProveedor()
        {
            try
            {
                MySqlConnection mySqlConnection = new MySqlConnection(connectionStringelastotec);
                mySqlConnection.Open();
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = mySqlConnection;
                comando.CommandText = "DELETE FROM proveedores WHERE ID_PROVEE = '" + lblID.Text + "'";
                comando.ExecuteNonQuery();
                mySqlConnection.Close();
                MessageBox.Show("Proveedor No. " + lblID.Text + " eliminado");
                LimpiarCampos();
                CargarProveedores();
                lblID.Text = " ";
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
                comando.CommandText = "DELETE FROM elastosystem_compras_proveedores WHERE ID = '" + lblID.Text + "'";
                comando.ExecuteNonQuery();
                mySqlConnection.Close();
                MessageBox.Show("Proveedor No. " + lblID.Text + " eliminado");
                LimpiarCampos();
                CargarProveedores();
                lblID.Text = " ";
            }
            catch
            {
                MessageBox.Show("Error al eliminar cliente");
            }
            */
        }

        string connectionStringelastotec = "server=10.120.1.3 ; username=root ; password= ; database=elastotec";
        string connectionString = "server=10.120.1.3 ; username=root; password= ; database=elastosystem";
        private void chbMostrarTodos_CheckedChanged(object sender, EventArgs e)
        {
            if (chbMostrarTodos.Checked)
            {
                txbBuscador.Clear();
            }
        }

        private void dgvProveedores_DoubleClick(object sender, EventArgs e)
        {
            btnAgregar.Visible = false;
            btnEliminar.Visible = true;
            btnModificar.Visible = true;
            btnNuevo.Visible = true;
            DataGridView dgv = (DataGridView)sender;

            if (dgv.SelectedCells.Count > 0)
            {
                int rowIndex = dgv.SelectedCells[0].RowIndex;

                string id = dgv.Rows[rowIndex].Cells[0].Value.ToString();
                lblID.Text = id;

                string nombre = dgv.Rows[rowIndex].Cells[1].Value.ToString();
                txbNombre.Text = nombre;

                string email = dgv.Rows[rowIndex].Cells[2].Value.ToString();
                txbEmail.Text = email;

                string telefono = dgv.Rows[rowIndex].Cells[3].Value.ToString();
                txbTelefono.Text = telefono;

                string productos = dgv.Rows[rowIndex].Cells[4].Value.ToString();
                txbProductos.Text = productos;

                string direccion = dgv.Rows[rowIndex].Cells[5].Value.ToString();
                txbDireccion.Text = direccion;

                string rfc = dgv.Rows[rowIndex].Cells[6].Value.ToString();
                txbRFC.Text = rfc;

                string contacto = dgv.Rows[rowIndex].Cells[7].Value.ToString();
                txbContacto.Text = contacto;

                string numerocuenta = dgv.Rows[rowIndex].Cells[8].Value.ToString();
                txbNoCuenta.Text = numerocuenta;

                MandarALlamarCritico();
            }
            /*
            btnAgregar.Visible = false;
            btnEliminar.Visible = true;
            btnModificar.Visible = true;
            btnNuevo.Visible = true;
            DataGridView dgv = (DataGridView)sender;

            if (dgv.SelectedCells.Count > 0)
            {
                int rowIndex = dgv.SelectedCells[0].RowIndex;

                string id = dgv.Rows[rowIndex].Cells[0].Value.ToString();
                lblID.Text = id;

                string nombre = dgv.Rows[rowIndex].Cells[1].Value.ToString();
                txbNombre.Text = nombre;

                string email = dgv.Rows[rowIndex].Cells[2].Value.ToString();
                txbEmail.Text = email;

                string telefono = dgv.Rows[rowIndex].Cells[3].Value.ToString();
                txbTelefono.Text = telefono;

                string rfc = dgv.Rows[rowIndex].Cells[4].Value.ToString();
                txbRFC.Text = rfc;

                string direccion = dgv.Rows[rowIndex].Cells[5].Value.ToString();
                txbDireccion.Text = direccion;

                string productos = dgv.Rows[rowIndex].Cells[6].Value.ToString();
                txbProductos.Text = productos;

                string contacto = dgv.Rows[rowIndex].Cells[7].Value.ToString();
                txbContacto.Text = contacto;

                string numerocuenta = dgv.Rows[rowIndex].Cells[8].Value.ToString();
                txbNoCuenta.Text = numerocuenta;

                bool valorBooleano = (bool)dgv.Rows[rowIndex].Cells[9].Value;
                chbCritico.Checked = valorBooleano;
            }
            */
        }
        private void MandarALlamarCritico()
        {
            MySqlConnection mySqlConnection = new MySqlConnection(connectionStringelastotec);
            mySqlConnection.Open();
            MySqlDataReader reader = null;
            string sql = "SELECT CLASIFICACION FROM proveedores WHERE ID_PROVEE LIKE '" + lblID.Text + "' ";
            try
            {
                MySqlCommand comando = new MySqlCommand(sql, mySqlConnection);
                reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        lblCritico.Text = reader.GetString("CLASIFICACION");
                    }
                    if (lblCritico.Text == "1")
                    {
                        chbCritico.Checked = true;
                    }
                    else
                    {
                        chbCritico.Checked = false;
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
        private void Tabuladores()
        {
            txbNombre.TabIndex = 0;
            txbEmail.TabIndex = 1;
            txbTelefono.TabIndex = 2;
            txbRFC.TabIndex = 3;
            txbDireccion.TabIndex = 4;
            txbProductos.TabIndex = 5;
            txbContacto.TabIndex = 6;
            txbNoCuenta.TabIndex = 7;
            chbCritico.TabIndex = 8;
            btnAgregar.TabIndex = 9;
            txbBuscador.TabIndex = 10;
            chbMostrarTodos.TabIndex = 11;
            btnBuscar.TabIndex = 12;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            btnNuevo.Visible = false;
            btnModificar.Visible = false;
            btnEliminar.Visible = false;
            btnAgregar.Visible = true;
            NuevoID();
            LimpiarCampos();
        }

        private void Compras_Proovedores_Load(object sender, EventArgs e)
        {
            Tabuladores();
            CargarProveedores();
            NuevoID();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (chbMostrarTodos.Checked)
            {
                CargarProveedores();
            }
            else
            {
                Buscador();
            }

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
            chbMostrarTodos.Checked = false;
            Buscador();
        }

        private void chbCritico_CheckStateChanged(object sender, EventArgs e)
        {
            if (chbCritico.Checked)
            {
                chbCritico.Text = "Critico";
                lblCritico.Text = "1";
            }
            else
            {
                chbCritico.Text = "No Critico";
                lblCritico.Text = "2";
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarProveedor();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            ModificarProveedor();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarProveedor();
        }
    }
}
