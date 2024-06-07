using DocumentFormat.OpenXml.Spreadsheet;
using iTextSharp.text.pdf;
using iTextSharp.text;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Cmp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ElastoSystem.Compras_Administrar_Requisiciones;

namespace ElastoSystem
{
    public partial class Ventas_BuscarCotizacion : Form
    {
        public Ventas_BuscarCotizacion()
        {
            InitializeComponent();
        }
        private void Fecha()
        {
            DateTime fechaActual = DateTime.Now;
            TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
            string fechaLarga = fechaActual.ToString("dd '/' MMMM '/' yyyy", CultureInfo.CurrentCulture);
            fechaLarga = textInfo.ToTitleCase(fechaLarga);
            lblFecha.Text = fechaLarga;
        }
        private void MandarALlamarCotizacion()
        {
            MySqlConnection mySqlConnection = new MySqlConnection(connectionStringelastotec);
            mySqlConnection.Open();
            MySqlDataReader reader = null;
            string sql = "SELECT DIA, MES, ANO, IDCLIENTE, DESCUENTO, SUBTOTAL, IVA, TOTAL FROM cotizacion WHERE IDFOLIO LIKE '" + cbFolio.Text + "' ";
            try
            {
                MySqlCommand comando = new MySqlCommand(sql, mySqlConnection);
                reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string dia = reader.GetString("DIA");
                        string mes = reader.GetString("MES");
                        string anio = reader.GetString("ANO");
                        if (mes == "1")
                        {
                            mes = "Enero";
                        }
                        else if (mes == "2")
                        {
                            mes = "Febrero";
                        }
                        else if (mes == "3")
                        {
                            mes = "Marzo";
                        }
                        else if (mes == "4")
                        {
                            mes = "Abril";
                        }
                        else if (mes == "5")
                        {
                            mes = "Mayo";
                        }
                        else if (mes == "6")
                        {
                            mes = "Junio";
                        }
                        else if (mes == "7")
                        {
                            mes = "Julio";
                        }
                        else if (mes == "8")
                        {
                            mes = "Agosto";
                        }
                        else if (mes == "9")
                        {
                            mes = "Septiembre";
                        }
                        else if (mes == "10")
                        {
                            mes = "Octubre";
                        }
                        else if (mes == "11")
                        {
                            mes = "Noviembre";
                        }
                        else if (mes == "12")
                        {
                            mes = "Diciembre";
                        }
                        else
                        {

                        }
                        lblFecha.Text = $"{dia} / {mes} / {anio}";
                        lblIDCliente.Text = reader.GetString("IDCLIENTE");
                        txbDescuento.Text = reader.GetString("DESCUENTO");
                        if (txbDescuento.Text == "0")
                        {
                            chbDescuento.Checked = false;
                        }
                        else
                        {
                            chbDescuento.Checked = true;
                        }
                        txbSubtotal.Text = reader.GetString("SUBTOTAL");
                        txbIVA.Text = reader.GetString("IVA");
                        txbTotal.Text = reader.GetString("TOTAL");
                    }
                    MandarALlamarDatosCliente();
                }
                else
                {
                    MessageBox.Show("NO EXISTE LA COTIZACION: " + cbFolio.Text);
                    LimpiarCotizacion();
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
        private void MandarALlamarDatosCliente()
        {
            MySqlConnection mySqlConnection = new MySqlConnection(connectionStringelastotec);
            mySqlConnection.Open();
            MySqlDataReader reader = null;
            string sql = "SELECT NOMBRE, TELEFONO, EMAIL, CONTACTO FROM clientes WHERE ID LIKE '" + lblIDCliente.Text + "' ";
            try
            {
                MySqlCommand comando = new MySqlCommand(sql, mySqlConnection);
                reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        cbContacto.Text = reader.GetString("CONTACTO");
                        cbEmpresa.Text = reader.GetString("NOMBRE");
                        txbTelefono.Text = reader.GetString("TELEFONO");
                        txbCorreo.Text = reader.GetString("EMAIL");
                    }
                    MandarALlamarPartidas();
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
        private void MandarALlamarPartidas()
        {
            try
            {
                string tabla = "SELECT CLAVE, PRODUCTO, PRECIO, CANTIDAD, TOTAL FROM pedidos WHERE IDFOLIO = '" + cbFolio.Text + "'";
                MySqlDataAdapter mySqlAdapter = new MySqlDataAdapter(tabla, connectionStringelastotec);
                DataTable dt = new DataTable();
                mySqlAdapter.Fill(dt);
                dgvListaProductos.DataSource = dt;
                dgvListaProductos.Columns["CLAVE"].Width = 212;
                dgvListaProductos.Columns["PRODUCTO"].Width = 694;
                dgvListaProductos.Columns["PRECIO"].Width = 120;
                dgvListaProductos.Columns["CANTIDAD"].Width = 118;
                dgvListaProductos.Columns["TOTAL"].Width = 120;
                Total();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void LimpiarCotizacion()
        {
            Fecha();
            lblIDCliente.Text = null;
            cbContacto.Text = null;
            cbEmpresa.Text = null;
            txbTelefono.Text = null;
            txbCorreo.Text = null;
            cbClave.Text = null;
            cbProductos.Text = null;
            txbCantidad.Text = null;
            txbPrecio.Text = null;
            dgvListaProductos.Rows.Clear();
            txbPartidas.Text = null;
            chbSigla03.Checked = true;
            txbSubtotal.Text = null;
            txbIVA.Text = null;
            chbDescuento.Checked = false;
            txbTotal.Text = null;
        }
        private void Clave()
        {
            cbClave.Items.Clear();
            MySqlConnection mySqlConnection = new MySqlConnection(connectionStringelastotec);
            mySqlConnection.Open();
            MySqlDataReader reader = null;
            string sql = "SELECT CLAVE FROM productos";
            try
            {
                HashSet<string> unicos = new HashSet<string>();
                MySqlCommand comando = new MySqlCommand(sql, mySqlConnection);
                reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        cbClave.Items.Add(reader["CLAVE"].ToString());
                    }
                    cbClave.Sorted = true;
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
        private void Productos()
        {
            cbProductos.Items.Clear();
            MySqlConnection mySqlConnection = new MySqlConnection(connectionStringelastotec);
            mySqlConnection.Open();
            MySqlDataReader reader = null;
            string sql = "SELECT NOMBRE FROM productos";
            try
            {
                HashSet<string> unicos = new HashSet<string>();
                MySqlCommand comando = new MySqlCommand(sql, mySqlConnection);
                reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        cbProductos.Items.Add(reader["NOMBRE"].ToString());
                    }
                    cbProductos.Sorted = true;
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
        private void MandarALlamarContactos()
        {
            MySqlConnection mySqlConnection = new MySqlConnection(connectionStringelastotec);
            mySqlConnection.Open();
            MySqlDataReader reader = null;
            string sql = "SELECT CONCAT (ID, '-', CONTACTO) CONTAC FROM clientes";
            try
            {
                HashSet<string> unicos = new HashSet<string>();
                MySqlCommand comando = new MySqlCommand(sql, mySqlConnection);
                reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string contacto = reader["CONTAC"].ToString();
                        if (!string.IsNullOrWhiteSpace(contacto))
                        {
                            cbContacto.Items.Add(contacto);
                        }
                    }
                    cbContacto.Sorted = true;
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
        private void MandarALlamarEmpresas()
        {
            MySqlConnection mySqlConnection = new MySqlConnection(connectionStringelastotec);
            mySqlConnection.Open();
            MySqlDataReader reader = null;
            string sql = "SELECT CONCAT (ID, '-', NOMBRE) NOM FROM clientes";
            try
            {
                HashSet<string> unicos = new HashSet<string>();
                MySqlCommand comando = new MySqlCommand(sql, mySqlConnection);
                reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string contacto = reader["NOM"].ToString();
                        if (!string.IsNullOrWhiteSpace(contacto))
                        {
                            cbEmpresa.Items.Add(contacto);
                        }
                    }
                    cbEmpresa.Sorted = true;
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
        private void MandarALlamarInfoEmpresa()
        {
            MySqlConnection mySqlConnection = new MySqlConnection(connectionStringelastotec);
            mySqlConnection.Open();

            String empresa = cbEmpresa.Text;
            int guionIndex = empresa.IndexOf("-");
            string nempresa = guionIndex != -1 ? empresa.Substring(0, guionIndex).Trim() : empresa;
            lblIDConEmp.Text = nempresa;

            MySqlDataReader reader = null;
            string sql = "SELECT CONTACTO, TELEFONO, EMAIL FROM clientes WHERE ID LIKE '" + nempresa + "' ";
            try
            {
                MySqlCommand comando = new MySqlCommand(sql, mySqlConnection);
                reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        cbContacto.Text = reader.GetString("CONTACTO");
                        txbTelefono.Text = reader.GetString("TELEFONO");
                        txbCorreo.Text = reader.GetString("EMAIL");
                    }

                    MandarALlamarFolios();
                }
                else
                {
                    //MessageBox.Show("ERROR AL LLAMAR LOS DATOS");
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
        private void MandarALlamarInfoContacto()
        {
            MySqlConnection mySqlConnection = new MySqlConnection(connectionStringelastotec);
            mySqlConnection.Open();

            String contacto = cbContacto.Text;
            int guionIndex = contacto.IndexOf("-");
            string ncontacto = guionIndex != -1 ? contacto.Substring(0, guionIndex).Trim() : contacto;
            lblIDConEmp.Text = ncontacto;

            MySqlDataReader reader = null;
            string sql = "SELECT NOMBRE, TELEFONO, EMAIL FROM clientes WHERE ID LIKE '" + ncontacto + "' ";
            try
            {
                MySqlCommand comando = new MySqlCommand(sql, mySqlConnection);
                reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        cbEmpresa.Text = reader.GetString("NOMBRE");
                        txbTelefono.Text = reader.GetString("TELEFONO");
                        txbCorreo.Text = reader.GetString("EMAIL");
                    }

                    MandarALlamarFolios();
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
        private void MandarALlamarFolios()
        {
            cbFolio.Items.Clear();
            MySqlConnection mySqlConnection = new MySqlConnection(connectionStringelastotec);
            mySqlConnection.Open();
            MySqlDataReader reader = null;
            string sql = "SELECT IDFOLIO FROM cotizacion WHERE IDCLIENTE LIKE '" + lblIDConEmp.Text + "'";
            try
            {
                HashSet<string> unicos = new HashSet<string>();
                MySqlCommand comando = new MySqlCommand(sql, mySqlConnection);
                reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        cbFolio.Items.Add(reader["IDFOLIO"].ToString());
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
        private void AgregarADGV()
        {
            if (string.IsNullOrEmpty(txbCantidad.Text) || string.IsNullOrEmpty(txbPrecio.Text) || string.IsNullOrEmpty(cbClave.Text) || string.IsNullOrEmpty(cbProductos.Text))
            {
                MessageBox.Show("DEBES DE LLENAR TODOS LOS CAMPOS PARA AGREGAR UN PRODUCTO");
            }
            else
            {
                double valor1;
                double valor2;
                string pre = txbPrecio.Text;
                pre = pre.Replace("$", "").Replace(" ", " ");
                txbPrecio.Text = pre;

                if (double.TryParse(txbPrecio.Text, out valor1) && double.TryParse(txbCantidad.Text, out valor2))
                {
                    double importe = valor1 * valor2;
                    importe = Math.Round(importe, 2);
                    string clave = cbClave.Text;
                    string producto = cbProductos.Text;
                    string cantidad = txbCantidad.Text;
                    string precio = txbPrecio.Text;

                    DataTable dt = (DataTable)dgvListaProductos.DataSource;
                    DataRow newrow = dt.NewRow();
                    newrow["CLAVE"] = clave;
                    newrow["PRODUCTO"] = producto;
                    newrow["PRECIO"] = precio;
                    newrow["CANTIDAD"] = cantidad;
                    newrow["TOTAL"] = importe;
                    dt.Rows.Add(newrow);

                    cbClave.Text = null; cbProductos.Text = null; txbCantidad.Clear(); txbPrecio.Clear();
                    dgvListaProductos.Enabled = true;

                    Total();
                }
                else
                {
                    MessageBox.Show("REVISA TUS DATOS EN PRECIO O CANTIDAD, NO SON NUMEROS VALIDOS");
                }
            }
        }
        private void InfoClave()
        {
            MySqlConnection mySqlConnection = new MySqlConnection(connectionStringelastotec);
            mySqlConnection.Open();
            String clave = cbClave.Text;
            MySqlDataReader reader = null;
            string sql = "SELECT NOMBRE, PRECIO_A FROM productos WHERE CLAVE LIKE '" + clave + "' ";
            try
            {
                MySqlCommand comando = new MySqlCommand(sql, mySqlConnection);
                reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        cbProductos.Text = reader.GetString("NOMBRE");
                        txbPrecio.Text = reader.GetString("PRECIO_A");
                    }
                }
                else
                {
                    //MessageBox.Show("ERROR AL LLAMAR LOS DATOS");
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
        private void InfoProducto()
        {
            MySqlConnection mySqlConnection = new MySqlConnection(connectionStringelastotec);
            mySqlConnection.Open();
            String producto = cbProductos.Text;
            MySqlDataReader reader = null;
            string sql = "SELECT CLAVE, PRECIO_A FROM productos WHERE NOMBRE LIKE '" + producto + "' ";
            try
            {
                MySqlCommand comando = new MySqlCommand(sql, mySqlConnection);
                reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        cbClave.Text = reader.GetString("CLAVE");
                        txbPrecio.Text = reader.GetString("PRECIO_A");
                    }
                }
                else
                {
                    //MessageBox.Show("ERROR AL LLAMAR LOS DATOS");
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
        private void Total()
        {
            if (chbDescuento.Checked && !string.IsNullOrEmpty(txbDescuento.Text))
            {
                txbDescuento.Text = txbDescuento.Text.Replace("%", "").Replace(" ", "");
                double descuento = 0;
                double.TryParse(txbDescuento.Text, out descuento);

                double suma = 0;
                double iva = 0;
                double total = 0;
                foreach (DataGridViewRow fila in dgvListaProductos.Rows)
                {
                    double valorCelda;
                    if (double.TryParse(fila.Cells[4].Value.ToString(), out valorCelda))
                    {
                        suma += valorCelda;
                    }
                }
                descuento = descuento * 0.01;
                double op = suma * descuento;
                double sumadescuento = suma - op;
                double ivades = sumadescuento * 0.16;
                ivades = Math.Round(ivades, 2);
                double totaldes = sumadescuento + ivades;
                totaldes = Math.Round(totaldes, 2);
                txbTotal.Text = totaldes.ToString();

                iva = suma * 0.16;
                iva = Math.Round(iva, 2);
                total = suma + iva;
                total = Math.Round(total, 2);
                suma = Math.Round(suma, 2);
                txbSubtotal.Text = suma.ToString();
                txbIVA.Text = iva.ToString();
            }
            else
            {
                double suma = 0;
                double iva = 0;
                double total = 0;
                foreach (DataGridViewRow fila in dgvListaProductos.Rows)
                {
                    double valorCelda;
                    if (double.TryParse(fila.Cells[4].Value.ToString(), out valorCelda))
                    {
                        suma += valorCelda;
                    }
                }
                iva = suma * 0.16;
                iva = Math.Round(iva, 2);
                total = suma + iva;
                total = Math.Round(total, 2);
                suma = Math.Round(suma, 2);
                txbSubtotal.Text = suma.ToString();
                txbIVA.Text = iva.ToString();
                txbTotal.Text = total.ToString();
            }
        }
        private void MandarACotizacion()
        {
            DateTime fechaActual = DateTime.Now;
            int dia = fechaActual.Day;
            int mes = fechaActual.Month;
            int anio = fechaActual.Year;

            MySqlConnection conn = new MySqlConnection(connectionStringelastotec);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand();
            try
            {
                cmd.Connection = conn;
                cmd.CommandText = "UPDATE cotizacion SET DIA = '" + dia + "', MES = '" + mes + "', ANO = '" + anio + "', DESCUENTO = '" + txbDescuento.Text + "', SUBTOTAL = '" + txbSubtotal.Text + "', IVA = '" + txbIVA.Text + "', TOTAL = '" + txbTotal.Text + "' WHERE IDFOLIO = '"+cbFolio.Text+"'";
                cmd.ExecuteNonQuery();
                EliminarPedidos();
                MandarAPedidos();
                Limpiar();

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
        private void Limpiar()
        {
            Fecha();
            cbFolio.Text = null;
            cbFolio.Items.Clear();
            cbContacto.Text = null;
            cbEmpresa.Text = null;
            txbTelefono.Clear();
            txbCorreo.Clear();
            cbClave.Text = null;
            cbProductos.Text = null;
            txbCantidad.Text = null;
            txbPrecio.Text = null;
            chbSigla03.Checked = true;
            chbDescuento.Checked = false;
            txbTotal.Clear();
            txbTotalLetras.Clear();
            dgvListaProductos.DataSource = null;
            dgvListaProductos.Rows.Clear();
            dgvListaProductos.Columns.Clear();
            txbSubtotal.Text= null;
            txbIVA.Text = null;

        }
        private void EliminarPedidos()
        {
            MySqlConnection conn = new MySqlConnection(connectionStringelastotec);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            try
            {
                cmd.CommandText = "DELETE FROM pedidos WHERE IDFOLIO = '"+cbFolio.Text+"'";
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
        private void MandarAPedidos()
        {
            int filas = dgvListaProductos.Rows.Count;
            for (int i = 0; i < filas; i++)
            {
                string clave = dgvListaProductos.Rows[i].Cells["CLAVE"].Value.ToString();
                string producto = dgvListaProductos.Rows[i].Cells["PRODUCTO"].Value.ToString();
                float precio = Convert.ToSingle(dgvListaProductos.Rows[i].Cells["PRECIO"].Value);
                float cantidad = Convert.ToSingle(dgvListaProductos.Rows[i].Cells["CANTIDAD"].Value);
                float importe = Convert.ToSingle(dgvListaProductos.Rows[i].Cells["TOTAL"].Value);

                MySqlConnection conn = new MySqlConnection(connectionStringelastotec);
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                try
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "INSERT INTO pedidos (CLAVE, PRODUCTO, PRECIO, CANTIDAD, TOTAL, IDFOLIO) VALUES ('" + clave + "', '" + producto + "', '" + precio + "', '" + cantidad + "', '" + importe + "', '" + cbFolio.Text + "');";
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

        string connectionStringelastotec = "server=10.120.1.3 ; username=root; password=; database=elastotec";

        private void Ventas_BuscarCotizacion_Load(object sender, EventArgs e)
        {
            Fecha();
            Clave();
            Productos();
            MandarALlamarContactos();
            MandarALlamarEmpresas();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            MandarALlamarCotizacion();
        }

        private void cbFolio_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                MandarALlamarCotizacion();
            }
        }

        private void chbSigla03_CheckedChanged(object sender, EventArgs e)
        {
            if (chbSigla03.Checked)
            {
                txbPartidas.Visible = false;
                lblExcepto.Visible = false;
            }
            else
            {
                txbPartidas.Visible = true;
                lblExcepto.Visible = true;
            }
        }

        private void chbDescuento_CheckedChanged(object sender, EventArgs e)
        {
            if (chbDescuento.Checked)
            {
                txbDescuento.Enabled = true;
                Total();
            }
            else
            {
                txbDescuento.Text = "0";
                txbDescuento.Enabled = false;
                Total();
            }
        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            cbClave.Text = null;
            cbProductos.Text = null;
            txbCantidad.Clear();
            txbPrecio.Clear();
        }

        private void cbContacto_SelectedIndexChanged(object sender, EventArgs e)
        {
            MandarALlamarInfoContacto();
        }

        private void cbEmpresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            MandarALlamarInfoEmpresa();
        }

        private void cbFolio_SelectedIndexChanged(object sender, EventArgs e)
        {
            MandarALlamarCotizacion();
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            AgregarADGV();
        }

        private void cbClave_SelectedIndexChanged(object sender, EventArgs e)
        {
            InfoClave();
        }

        private void cbProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            InfoProducto();
        }

        private void txbDescuento_TextChanged(object sender, EventArgs e)
        {
            Total();
        }

        private void dgvListaProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int indiceFilaSeleccionada = e.RowIndex;

            if (indiceFilaSeleccionada >= 0 && indiceFilaSeleccionada < dgvListaProductos.Rows.Count)
            {
                DataGridViewRow filaSeleccionada = dgvListaProductos.Rows[indiceFilaSeleccionada];

                string clave = filaSeleccionada.Cells[0].Value.ToString();
                string producto = filaSeleccionada.Cells[1].Value.ToString();
                string precio = filaSeleccionada.Cells[2].Value.ToString();
                string cantidad = filaSeleccionada.Cells[3].Value.ToString();

                cbClave.Text = clave;
                cbProductos.Text = producto;
                txbPrecio.Text = precio;
                txbCantidad.Text = cantidad;

                dgvListaProductos.Rows.RemoveAt(indiceFilaSeleccionada);
            }
            Total();
        }

        private void btnGenerarCot_Click(object sender, EventArgs e)
        {
            if (cbContacto.Text.Length > 0 && cbEmpresa.Text.Length > 0 && txbTelefono.Text.Length > 0 && txbCorreo.Text.Length > 0 && dgvListaProductos.Rows.Count > 0)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Archivos PDF (*.pdf)|*.pdf";
                saveFileDialog.Title = "Guardar PDF";
                saveFileDialog.FileName = cbFolio.Text + ".pdf";

                string contactocguion = cbContacto.Text;
                string contactosguion;
                try
                {
                    string[] partes = contactocguion.Split('-');
                    contactosguion = partes[1].Trim();
                }
                catch
                {
                    contactosguion = contactocguion;
                }


                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string aviso = "";
                    if (chbSigla03.Checked)
                    {
                        aviso = "LOS MATERIALES CUENTAN CON AVISO DE PRUEBA SIGLA 03 CFE";
                    }
                    else if (!chbSigla03.Checked && string.IsNullOrEmpty(txbPartidas.Text))
                    {
                        aviso = "LOS MATERIALES NO CUENTAN CON AVISO DE PRUEBA SIGLA 03 CFE";
                    }
                    else
                    {
                        aviso = "LOS MATERIALES CUENTAN CON AVISO DE PRUEBA SIGLA 03 CFE, EXCEPTO: " + txbPartidas.Text;
                    }
                    string rutaArchivoPDF = saveFileDialog.FileName;
                    iTextSharp.text.Document doc = new iTextSharp.text.Document();
                    PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(rutaArchivoPDF, FileMode.Create));
                    doc.Open();


                    // ENCABEZADO
                    string rutaImagen = "\\\\10.120.1.3\\Departments$\\Sistemas\\Recursos_Sistemas\\Elastosystem\\cotizacion_encabezado.jpg";
                    iTextSharp.text.Image imagen = iTextSharp.text.Image.GetInstance(rutaImagen);
                    float anchoObjetivoencabezado = 520f;
                    float altoObjetivoencabezado = 68f;
                    imagen.ScaleToFit(anchoObjetivoencabezado, altoObjetivoencabezado);
                    float posYImagen1 = doc.PageSize.Height - doc.TopMargin - imagen.ScaledHeight;
                    imagen.SetAbsolutePosition(doc.Left, posYImagen1);
                    doc.Add(imagen);

                    // DATOS CLIENTE
                    string rutaImagen2 = "\\\\10.120.1.3\\Departments$\\Sistemas\\Recursos_Sistemas\\Elastosystem\\cotizacion_datoscliente.jpg";
                    iTextSharp.text.Image imagen2 = iTextSharp.text.Image.GetInstance(rutaImagen2);
                    float anchoObjetivoproveedor = 520f;
                    float altoObjetivoproveedor = 68f;
                    imagen2.ScaleToFit(anchoObjetivoproveedor, altoObjetivoproveedor);
                    float posYImagen2 = posYImagen1 - imagen2.ScaledHeight - 0.5f;
                    imagen2.SetAbsolutePosition(doc.Left, posYImagen2);
                    doc.Add(imagen2);

                    //PIE DE PAGINA
                    string rutaimagenpie = "\\\\10.120.1.3\\Departments$\\Sistemas\\Recursos_Sistemas\\Elastosystem\\cotizacion_pie.jpg";
                    iTextSharp.text.Image imagepie = iTextSharp.text.Image.GetInstance(rutaimagenpie);
                    float anchopie = 520f;
                    float altopie = 68f;
                    imagepie.ScaleToFit(anchopie, altopie);
                    float posypie = 40f;
                    imagepie.SetAbsolutePosition(doc.Left, posypie);
                    doc.Add(imagepie);


                    iTextSharp.text.Font font = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 7);
                    iTextSharp.text.Font fontceldas = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8);
                    iTextSharp.text.Font fontnegritas = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD);
                    iTextSharp.text.Font fontcantidades = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9);
                    iTextSharp.text.Font fontgrandes = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9);
                    iTextSharp.text.Font whiteFontb = new iTextSharp.text.Font(fontcantidades);
                    whiteFontb.Color = BaseColor.WHITE;

                    string fecha = lblFecha.Text;
                    string cotizacion = cbFolio.Text;
                    string ocyrequi = "FECHA DE COTIZACIÓN: \n  " + fecha + "\n" + "NO. COTIZACIÓN: \n   " + cotizacion;

                    string contacto = contactosguion;
                    string telefono = txbTelefono.Text;
                    string correo = txbCorreo.Text;
                    string empresa = cbEmpresa.Text;
                    string datosdelproveedor = "A NOMBRE DE: " + contacto + "\n " + telefono + "\n " + correo + "\n " + empresa;


                    PdfPTable tableaa = new PdfPTable(2);
                    tableaa.WidthPercentage = 100;
                    tableaa.SetWidths(new float[] { 60, 40 });

                    PdfPCell cellOC = new PdfPCell(new Phrase(ocyrequi, font));
                    cellOC.HorizontalAlignment = Element.ALIGN_LEFT;
                    cellOC.PaddingLeft = 68;
                    cellOC.BorderWidth = 0;
                    tableaa.AddCell(cellOC);

                    PdfPCell cellProo = new PdfPCell(new Phrase(datosdelproveedor, font));
                    cellProo.HorizontalAlignment = Element.ALIGN_CENTER;
                    cellProo.BorderWidth = 0;
                    tableaa.AddCell(cellProo);

                    //doc.Add(tableaa);
                    float pocisionYTableaa = 733f;
                    float pocisionXTableaa = -32f;
                    tableaa.TotalWidth = doc.PageSize.Width;
                    tableaa.WriteSelectedRows(0, -1, pocisionXTableaa, pocisionYTableaa, writer.DirectContent);

                    doc.Add(new iTextSharp.text.Paragraph("\n \n \n \n \n \n \n \n"));


                    PdfPTable table = new PdfPTable(dgvListaProductos.Columns.Count);
                    table.WidthPercentage = 100;

                    float[] columnWidths = new float[] { 15f, 55f, 10f, 10f, 10f };
                    table.SetWidths(columnWidths);
                    for (int i = 0; i < dgvListaProductos.Columns.Count; i++)
                    {
                        iTextSharp.text.Font whiteFont = new iTextSharp.text.Font(font);
                        whiteFont.Color = BaseColor.WHITE;

                        PdfPCell cell = new PdfPCell(new Phrase(dgvListaProductos.Columns[i].HeaderText, whiteFont));
                        cell.HorizontalAlignment = PdfPCell.ALIGN_CENTER;
                        cell.BackgroundColor = new BaseColor(7, 34, 59);
                        table.AddCell(cell);
                    }
                    doc.Add(table);

                    int maxFilasPorPagina = 20;
                    int numFilas = dgvListaProductos.Rows.Count;
                    int filaActual = 0;
                    int limiteFilasPrimeraPagina = 20;
                    while (filaActual < numFilas)
                    {
                        if (filaActual % maxFilasPorPagina == 0 && filaActual != 0)
                        {
                            doc.NewPage();
                        }
                        int filasRestantes = numFilas - filaActual;
                        int filasEnEstaPagina = Math.Min(filasRestantes, maxFilasPorPagina);
                        PdfPTable tableParte1 = new PdfPTable(dgvListaProductos.Columns.Count);
                        tableParte1.WidthPercentage = 100;
                        float[] columnWidths1 = new float[] { 15f, 55f, 10f, 10f, 10f };
                        tableParte1.SetWidths(columnWidths1);

                        PdfPTable tableParte2 = new PdfPTable(dgvListaProductos.Columns.Count);
                        tableParte2.WidthPercentage = 100;
                        float[] columnWidths2 = new float[] { 15f, 55f, 10f, 10f, 10f };
                        tableParte2.SetWidths(columnWidths2);

                        for (int i = 0; i < filasEnEstaPagina; i++)
                        {
                            int indiceFila = filaActual + i;
                            PdfPTable tablaActual = indiceFila < limiteFilasPrimeraPagina ? tableParte1 : tableParte2;

                            for (int j = 0; j < dgvListaProductos.Columns.Count; j++)
                            {
                                string valorCelda = dgvListaProductos.Rows[indiceFila].Cells[j].Value.ToString();
                                PdfPCell cell;

                                if (j == 2 || j == 4)
                                {
                                    valorCelda = "$ " + valorCelda;
                                    cell = new PdfPCell(new Phrase(valorCelda, fontceldas));
                                }
                                else
                                {
                                    cell = new PdfPCell(new Phrase(valorCelda, fontceldas));
                                }

                                cell.HorizontalAlignment = PdfPCell.ALIGN_CENTER;
                                tablaActual.AddCell(cell);
                            }
                        }

                        doc.Add(tableParte1);

                        doc.Add(tableParte2);

                        filaActual += filasEnEstaPagina;
                    }



                    string cantidadletras = txbTotalLetras.Text;
                    string cantidadeneletracompleta = "\n \n **" + cantidadletras + " DE DOLARES" + "**";
                    string cantidades = "";
                    if (chbDescuento.Checked)
                    {
                        string subtotal = txbSubtotal.Text;
                        string iva = txbIVA.Text;
                        string total = txbTotal.Text;
                        string descuento = txbDescuento.Text + " %";
                        cantidades = "\n $" + subtotal + "\n \n" + "$" + iva + "\n \n " + descuento + "\n \n" + "$" + total;
                    }
                    else
                    {
                        string subtotal = txbSubtotal.Text;
                        string iva = txbIVA.Text;
                        string total = txbTotal.Text;
                        cantidades = "\n $" + subtotal + "\n \n" + "$" + iva + "\n \n " + "$" + total;
                    }

                    PdfPTable tableTotales = new PdfPTable(2);
                    tableTotales.WidthPercentage = 100;
                    tableTotales.SetWidths(new float[] { 70, 30 });

                    PdfPCell cellLet = new PdfPCell(new Phrase(cantidadeneletracompleta, fontnegritas));
                    cellLet.HorizontalAlignment = Element.ALIGN_CENTER;
                    cellLet.BorderWidth = 0;
                    tableTotales.AddCell(cellLet);


                    PdfPCell cellTotales = new PdfPCell(new Phrase(cantidades, whiteFontb));
                    cellTotales.HorizontalAlignment = Element.ALIGN_LEFT;
                    cellTotales.PaddingLeft = 80;
                    cellTotales.BorderWidth = 0;
                    tableTotales.AddCell(cellTotales);
                    float tableY = writer.GetVerticalPosition(false);
                    float tableeY = tableY - 65;
                    doc.Add(tableTotales);

                    if (chbDescuento.Checked)
                    {
                        // CANTIDAD CON DESCUENTO
                        string rutaImagen4 = "\\\\10.120.1.3\\Departments$\\Sistemas\\Recursos_Sistemas\\Elastosystem\\cotizacion_cantidadesdescuento.jpg";
                        iTextSharp.text.Image imagen4 = iTextSharp.text.Image.GetInstance(rutaImagen4);
                        imagen4.ScaleToFit(165f, 165f);
                        imagen4.SetAbsolutePosition(385, tableeY - 16);
                        doc.Add(imagen4);
                    }
                    else
                    {
                        // CANTIDAD
                        string rutaImagen4 = "\\\\10.120.1.3\\Departments$\\Sistemas\\Recursos_Sistemas\\Elastosystem\\cotizacion_cantidades.jpg";
                        iTextSharp.text.Image imagen4 = iTextSharp.text.Image.GetInstance(rutaImagen4);
                        imagen4.ScaleToFit(165f, 165f);
                        imagen4.SetAbsolutePosition(385, tableeY);
                        doc.Add(imagen4);
                    }

                    string condi = "TODOS LOS MATERIALES SON MARCA ELASTOTECNICA" + "\n" + aviso + "\n" + "LAB PLANTA Ó LINEA DE CARGA DE SU PREFERENCIA" + "\n" + "TIPO DE CAMBIO AL DIA DEL DEPOSITO: http://dof.gob.mx/indicadores.php" + "\n" + "VIGENCIA DE COTIZACIÓN: 7 DIAS NATURALES" + "\n" + "TIEMPO DE ENTREGA INMEDIATO SPV" + "\n" + "ENVIO A AREA METROPOLITANA EN MONTOS MAYORES A $500 USD" + "\n" + "EL ENVIO CORRE POR PARTE DEL CLIENTE POR LA FLETERA DE SU ELECCION";


                    string firma = "\n \n \n \n" + "FLETERA:" + "\n" + "TIPO DE CAMBIO:" + "\n" + "FACTURACION:" + "\n" + "OCURRE / DOMICILIO";

                    PdfPTable tablea = new PdfPTable(3);
                    tablea.WidthPercentage = 100;
                    tablea.SetWidths(new float[] { 60, 40, 10 });

                    PdfPCell cellCondiciones = new PdfPCell(new Phrase(condi, font));
                    cellCondiciones.HorizontalAlignment = Element.ALIGN_LEFT;
                    cellCondiciones.BorderWidth = 0;
                    tablea.AddCell(cellCondiciones);

                    PdfPCell cellFirma = new PdfPCell(new Phrase(firma, font));
                    cellFirma.HorizontalAlignment = Element.ALIGN_LEFT;
                    cellFirma.BorderWidth = 0;
                    tablea.AddCell(cellFirma);
                    string f = " ";
                    PdfPCell cellF = new PdfPCell(new Phrase(f, font));
                    cellF.HorizontalAlignment = Element.ALIGN_LEFT;
                    cellF.BorderWidth = 0;
                    tablea.AddCell(cellF);
                    float posXTabla = 40f;
                    float posYTabla = 175f;
                    float pie = 40f;
                    tablea.TotalWidth = doc.PageSize.Width;
                    tablea.WriteSelectedRows(0, -1, posXTabla, posYTabla, writer.DirectContent);


                    //PIE DE PAGINA
                    string rutaImagen3 = "\\\\10.120.1.3\\Departments$\\Sistemas\\Recursos_Sistemas\\Elastosystem\\cotizacion_pie.jpg";
                    float anchoObjetiv = 520f;
                    float altoObjetiv = 68f;
                    iTextSharp.text.Image imagen3 = iTextSharp.text.Image.GetInstance(rutaImagen3);
                    imagen3.ScaleToFit(anchoObjetiv, altoObjetiv);
                    imagen3.SetAbsolutePosition(doc.Left, pie);
                    doc.Add(imagen3);


                    doc.Close();


                    MessageBox.Show("PDF guardado como '" + System.IO.Path.GetFileName(rutaArchivoPDF) + "'", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MandarACotizacion();


                    if (System.IO.File.Exists(rutaArchivoPDF))
                    {
                        System.Diagnostics.Process.Start("explorer.exe", rutaArchivoPDF);
                    }
                    else
                    {
                        MessageBox.Show("El archivo no se pudo encontrar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("DEBES DE LLENAR TODOS LOS CAMPOS OBLIGATORIOS");
            }
        }

        private void txbTotal_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(txbTotal.Text, out decimal numero))
            {
                string numeroEnLetras = ConvertidorNumerosALetras.ConvertirNumeroALetras(numero);

                txbTotalLetras.Text = numeroEnLetras;
            }
            else
            {

            }
        }
    }
}
