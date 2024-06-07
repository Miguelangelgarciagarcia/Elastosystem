using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Cmp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElastoSystem
{
    public partial class Compras_RequisicionMaterial : Form
    {
        public Compras_RequisicionMaterial()
        {
            InitializeComponent();
        }

        private void AgregarADgv()
        {
            if (string.IsNullOrEmpty(txbDescripcion.Text) || string.IsNullOrEmpty(txbCantidad.Text) || cbUnidad.SelectedIndex == -1)
            {
                MessageBox.Show("DEBES DE LLENAR LOS CAMPOS OBLIGATORIOS");
                return;
            }
            else
            {
                if (string.IsNullOrEmpty(txbPrecio.Text))
                {
                    string preciosnt = "0";
                    string descripcionsnt = txbDescripcion.Text;
                    string cantidadsnt = txbCantidad.Text;
                    string unidadsnt = cbUnidad.Text;
                    string proveedorsnt = cbProveedor.Text;
                    dgvListaMateriales.Rows.Add(descripcionsnt, cantidadsnt, unidadsnt, preciosnt, proveedorsnt);

                    txbDescripcion.Clear(); txbCantidad.Clear(); cbUnidad.Text = null; txbPrecio.Clear(); cbProveedor.Text = null;
                    dgvListaMateriales.Enabled = true;
                }
                else
                {
                    string descripcion = txbDescripcion.Text;
                    string cantidad = txbCantidad.Text;
                    string unidad = cbUnidad.Text;
                    string precio = txbPrecio.Text;
                    string proveedor = cbProveedor.Text;
                    dgvListaMateriales.Rows.Add(descripcion, cantidad, unidad, precio, proveedor);

                    txbDescripcion.Clear(); txbCantidad.Clear(); cbUnidad.Text = null; txbPrecio.Clear(); cbProveedor.Text = null;
                    dgvListaMateriales.Enabled = true;
                }

            }

        }
        private void Tabs()
        {
            txbDescripcion.Focus();
            txbDescripcion.TabIndex = 0;
            txbCantidad.TabIndex = 1;
            cbUnidad.TabIndex = 2;
            txbPrecio.TabIndex = 3;
            cbProveedor.TabIndex = 4;
            btnAgregar.TabIndex = 5;
        }
        private void Eliminar()
        {
            foreach (DataGridViewRow row in dgvListaMateriales.SelectedRows)
            {
                dgvListaMateriales.Rows.Remove(row);
            }
            txbDescripcion.Clear(); txbCantidad.Clear(); cbUnidad.Text = null; txbPrecio.Clear(); cbProveedor.Text = null;
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
            btnAgregar.Visible = true;
            btnNuevo.Visible = false;
            txbDescripcion.Focus();
            dgvListaMateriales.Enabled = false;
        }
        private void Nuevo()
        {
            txbDescripcion.Clear(); txbCantidad.Clear(); cbUnidad.Text = null; txbPrecio.Clear(); cbProveedor.Text = null;
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
            btnAgregar.Visible = true;
            btnNuevo.Visible = false;
            txbDescripcion.Focus();
        }
        private void Modificar()
        {
            foreach (DataGridViewRow row in dgvListaMateriales.SelectedRows)
            {
                dgvListaMateriales.Rows.Remove(row);
            }
            AgregarADgv();
        }
        private void MaNdarALlamarProveedores()
        {
            MySqlConnection mySqlConnection = new MySqlConnection(connectionStringb);
            mySqlConnection.Open();
            MySqlDataReader reader = null;
            string sql = "SELECT NOMBRE FROM proveedores";
            try
            {
                HashSet<string> unicos = new HashSet<string>();
                MySqlCommand comando = new MySqlCommand(sql, mySqlConnection);
                reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        cbProveedor.Items.Add(reader["Nombre"].ToString());
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
            cbProveedor.Sorted = true;
        }
        private void Fecha()
        {
            DateTime fechaActual = DateTime.Now;
            TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
            string fechaLarga = fechaActual.ToString("dddd, dd 'de' MMMM 'del' yyyy", CultureInfo.CurrentCulture);
            fechaLarga = textInfo.ToTitleCase(fechaLarga);
            lblfecha.Text = fechaLarga;
        }
        private void Folio()
        {
            MySqlConnection mySqlConnection = new MySqlConnection(connectionStringb);
            mySqlConnection.Open();
            MySqlDataReader reader = null;
            string sql = "SELECT IDFOLIO FROM folioreq";

            try
            {
                int ultimoFolio = 0;
                MySqlCommand comando = new MySqlCommand(sql, mySqlConnection);
                reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string folioString = reader["IDFOLIO"].ToString();
                        if (int.TryParse(folioString, out int folio))
                        {
                            ultimoFolio = folio;
                        }
                        else
                        {

                        }
                    }
                    ultimoFolio = ultimoFolio + 1;
                    lblFolio.Text = ultimoFolio.ToString();
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
            /*
            MySqlConnection mySqlConnection = new MySqlConnection(connectionString);
            mySqlConnection.Open();
            MySqlDataReader reader = null;
            string sql = "SELECT ID FROM elastosystem_compras_requisicion";

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
                    lblFolio.Text = ultimoFolio.ToString();
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
        private void MandarAIndicador()
        {
            DateTime fechainicio = DateTime.Now;
            string fechai = fechainicio.ToString("yyyy-MM-dd");
            int folio = int.Parse(lblFolio.Text);
            string fechacero = "0000-00-00";
            MySqlConnection conn = new MySqlConnection(connectionStringb);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand();
            try
            {
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO indicador_compras (FOLIO_REQ, FECHA_REQ, FECHA_ORD) VALUES ('" + folio + "','" + fechai + "','"+fechacero+"');";
                cmd.ExecuteNonQuery();
                conn.Close();
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
        private void EnviarRequerimiento()
        {
            DateTime fechainicio = DateTime.Now;
            int dia = fechainicio.Day;
            int mes = fechainicio.Month;
            int anio = fechainicio.Year;
            MySqlConnection conn = new MySqlConnection(connectionStringb);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand();
            try
            {
                cmd.Connection = conn;
                cmd.CommandText = "SELECT COUNT(*) FROM folioreq WHERE IDFOLIO = @IDFOLIO";
                cmd.Parameters.AddWithValue("@IDFOLIO", lblFolio.Text);

                int count = Convert.ToInt32(cmd.ExecuteScalar());
                if (count > 0)
                {
                    Folio();
                    EnviarRequerimiento();
                }
                else
                {
                    OcuparFolio();
                    cmd.CommandText = "INSERT INTO reqversion2 (ID_REQ, SOLICITANTE, DIA, MES, ANO, NOTAS, USO)" + "VALUES (@ID_REQ, @SOLICITANTE, @DIA, @MES, @ANO, @NOTAS, @USO)";
                    cmd.Parameters.AddWithValue("@ID_REQ", lblFolio.Text);
                    cmd.Parameters.AddWithValue("@SOLICITANTE", cbUsuarios.Text);
                    cmd.Parameters.AddWithValue("@DIA", dia);
                    cmd.Parameters.AddWithValue("@MES", mes);
                    cmd.Parameters.AddWithValue("@ANO", anio);
                    cmd.Parameters.AddWithValue("@NOTAS", txbNotas.Text);
                    cmd.Parameters.AddWithValue("@USO", cbTipoUso.Text);

                    cmd.ExecuteNonQuery();
                    MandarAIndicador();
                    EnviarRequisicionDesglosada();
                    txbDescripcion.Clear(); txbCantidad.Clear(); cbUnidad.Text = null; txbPrecio.Clear(); cbProveedor.Text = null; dgvListaMateriales.Rows.Clear(); txbNotas.Clear(); cbTipoUso.Text = null; txbUsuario.Clear(); txbPassword.Clear();
                    MessageBox.Show("Orden: " + lblFolio.Text + " enviada con exito");
                    Folio();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally { conn.Close(); }


            /*
            try
            {
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO reqversion2 (ID_REQ, SOLICITANTE, DIA, MES, ANO, NOTAS, USO) VALUES ('" + lblFolio.Text + "', '" + cbUsuarios.Text + "', '" + dia + "', '" + mes + "', '" + anio + "', '" + txbNotas.Text + "', '" + cbTipoUso.Text + "');";
                cmd.ExecuteNonQuery();
                conn.Close();
                EnviarRequisicionDesglosada();
                OcuparFolio();
                MandarAIndicador();
                txbDescripcion.Clear(); txbCantidad.Clear(); cbUnidad.Text = null; txbPrecio.Clear(); cbProveedor.Text = null; dgvListaMateriales.Rows.Clear(); txbNotas.Clear(); cbTipoUso.Text = null; txbUsuario.Clear(); txbPassword.Clear();
                MessageBox.Show("Orden: " + lblFolio.Text + " enviada con exito");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Folio();
            */



            //CODIGO QUE FUNCIONA CON LA BASE DE DATOS ELASTOSYSTEM
            /*
            if (dgvListaMateriales.RowCount > 0)
            {
                string query = "SELECT * FROM elastosystem_login WHERE Usuario='" + txbUsuario.Text + "' AND Password='" + txbPassword.Text + "'";
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                commandDatabase.CommandTimeout = 60;
                MySqlDataReader reader;
                int verificacion = 0;
                try
                {
                    databaseConnection.Open();
                    reader = commandDatabase.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            verificacion = 1;
                        }
                    }
                    else
                    {
                        MessageBox.Show("ERROR en Usuario o Contraseña, vuelve a intentarlo");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    databaseConnection.Close();
                }
                if (verificacion == 0)
                {

                }
                else
                {
                    DateTime fechainicio = DateTime.Now;
                    string fechai = fechainicio.ToString("yyyy-MM-dd");
                    string estatus = "PENDIENTE";
                    MySqlConnection conn = new MySqlConnection(connectionString);
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand();
                    try
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = "INSERT INTO elastosystem_compras_requisicion (ID, Usuario, Fecha, Notas, TipoUso, Estatus) VALUES ('" + lblFolio.Text + "', '" + txbUsuario.Text + "', '" + fechai + "', '" + txbNotas.Text + "', '" + cbTipoUso.Text + "', '" + estatus + "');";
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        EnviarRequisicionDesglosada();
                        txbDescripcion.Clear(); txbCantidad.Clear(); cbUnidad.Text = null; txbPrecio.Clear(); cbProveedor.Text = null; dgvListaMateriales.Rows.Clear(); txbNotas.Clear(); cbTipoUso.Text = null; txbUsuario.Clear(); txbPassword.Clear();
                        MessageBox.Show("Orden: " + lblFolio.Text + " enviada con exito");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    Folio();
                }
            }
            else
            {
                MessageBox.Show("No puedes enviar un requisicion vacia");
            }
            */
        }
        private void EnviarRequisicionDesglosada()
        {
            int filas = dgvListaMateriales.Rows.Count;
            for (int i = 0; i < filas; i++)
            {
                string descripcion = dgvListaMateriales.Rows[i].Cells["Descripcion"].Value.ToString();
                float cantidad = Convert.ToSingle(dgvListaMateriales.Rows[i].Cells["Cantidad"].Value);
                string unidad = dgvListaMateriales.Rows[i].Cells["Unidad"].Value.ToString();
                float precio = Convert.ToSingle(dgvListaMateriales.Rows[i].Cells["Precio"].Value);
                string proveedor = dgvListaMateriales.Rows[i].Cells["Proveedor"].Value.ToString();
                string estatus = "PENDIENTE";

                MySqlConnection conn = new MySqlConnection(connectionStringb);
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                try
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "INSERT INTO req_partidas (DESCRIPCION_P, CANTIDAD_P, UNIDAD_P, PRECIO_P, PROVEEDOR_P, STATUS_P, IDFOLIO) VALUES ('" + descripcion + "', '" + cantidad + "', '" + unidad + "', '" + precio + "', '" + proveedor + "', '" + estatus + "', '" + lblFolio.Text + "');";
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
        }
        private void CargarUsuarios()
        {
            MySqlConnection mySqlConnection = new MySqlConnection(connectionStringb);
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
                        string apaterno = reader["APATERNO"].ToString();
                        string amaterno = reader["AMATERNO"].ToString();
                        string nombre = reader["NOMBRE"].ToString();


                        string nombreCompleto = $"{nombre} {apaterno} {amaterno}";

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
        }
        private void OcuparFolio()
        {
            MySqlConnection conn = new MySqlConnection(connectionStringb);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand();
            try
            {
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO folioreq (IDFOLIO) VALUES ('" + lblFolio.Text + "');";
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conn.Close(); }
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AgregarADgv();
        }

        private void Compras_RequisicionMaterial_Load(object sender, EventArgs e)
        {
            MaNdarALlamarProveedores();
            CargarUsuarios();
            Fecha();
            Folio();
            Tabs();
        }


        string connectionStringb = "server=10.120.1.3 ; username=root; password= ; database=elastotec";
        string connectionString = "server=10.120.1.3 ; username=root; password= ; database=elastosystem";

        private void dgvListaMateriales_DoubleClick(object sender, EventArgs e)
        {
            btnEliminar.Enabled = true;
            btnModificar.Enabled = true;
            btnAgregar.Visible = false;
            btnNuevo.Visible = true;

            DataGridView dgv = (DataGridView)sender;

            if (dgv.SelectedCells.Count > 0)
            {
                int rowIndex = dgv.SelectedCells[0].RowIndex;

                string descripcion = dgv.Rows[rowIndex].Cells[0].Value.ToString();
                txbDescripcion.Text = descripcion;

                string cantidad = dgv.Rows[rowIndex].Cells[1].Value.ToString();
                txbCantidad.Text = cantidad;

                string unidad = dgv.Rows[rowIndex].Cells[2].Value.ToString();
                cbUnidad.Text = unidad;

                string precio = dgv.Rows[rowIndex].Cells[3].Value.ToString();
                txbPrecio.Text = precio;

                string proveedor = dgv.Rows[rowIndex].Cells[4].Value.ToString();
                cbProveedor.Text = proveedor;

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Nuevo();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Modificar();
        }

        private void btnEnviarReq_Click(object sender, EventArgs e)
        {
            EnviarRequerimiento();
        }

        private void btnEnviarReq_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txbPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                EnviarRequerimiento();
            }
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            EnviarRequerimiento();
        }

        private void cbUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            
        }
    }
}
