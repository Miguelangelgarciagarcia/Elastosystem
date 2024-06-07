using DocumentFormat.OpenXml.Wordprocessing;
using Gma.QrCodeNet.Encoding.Windows.Render;
using Gma.QrCodeNet.Encoding;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElastoSystem
{
    public partial class Almacen_NuevoProducto : Form
    {
        public Almacen_NuevoProducto()
        {
            InitializeComponent();
            tbproducto.TabIndex = 0;
            tbdescripcion.TabIndex = 1;
            tbexistencias.TabIndex = 2;
            tbminimo.TabIndex = 3;
            cbunidad.TabIndex = 4;
            button1.TabIndex = 5;
        }
        private void IDIncremetable()
        {
            MySqlConnection mySqlConnection = new MySqlConnection(connectionString);
            mySqlConnection.Open();
            MySqlDataReader reader = null;
            int idprod;
            string sql = "SELECT ID_Producto FROM elastosystem_almacen ORDER BY ID_Producto DESC LIMIT 1 ";
            try
            {
                MySqlCommand comando = new MySqlCommand(sql, mySqlConnection);
                reader = comando.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        idprod = Convert.ToInt32(reader["ID_Producto"]);
                        int idnuevo = idprod + 1;
                        lbidproducto.Text = idnuevo.ToString();
                    }
                }
                else
                {

                }
                this.BeginInvoke(new Action(() =>
                {
                    tbproducto.Focus();
                }));

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void LlamarBaseDatosConsumibles()
        {
            string tabla = "SELECT ID_Producto, Producto, Descripcion, Unidad, Stock_Minimo, Estatus FROM elastosystem_almacen";
            MySqlDataAdapter mySqlAdapter = new MySqlDataAdapter(tabla, connectionString);
            DataTable dt = new DataTable();
            mySqlAdapter.Fill(dt);
            dgvConsumibles.DataSource = dt;
            dt.DefaultView.Sort = "ID_Producto DESC";
            this.BeginInvoke(new Action(() =>
            {
                tbproducto.Focus();
            }));

        }
        private void EditarProducto()
        {
            string usuariopc = Environment.UserName;
            DateTime saveNow = DateTime.Now;
            string fecha = saveNow.ToShortDateString();
            string hora = saveNow.ToLongTimeString();

            if (string.IsNullOrWhiteSpace(lbidproducto.Text) || string.IsNullOrWhiteSpace(tbproducto.Text) || string.IsNullOrWhiteSpace(tbdescripcion.Text) || cbEstatus.SelectedIndex == -1 || string.IsNullOrWhiteSpace(tbminimo.Text) || cbunidad.SelectedIndex == -1)
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
                        comando.CommandText = "UPDATE elastosystem_almacen SET Stock_Minimo = '" + tbminimo.Text + "' , Estatus = '" + cbEstatus.Text + "' ,Unidad = '" + cbunidad.Text + "' , Descripcion = '" + tbdescripcion.Text + "'  WHERE ID_Producto = '" + lbidproducto.Text + "'";
                        comando.ExecuteNonQuery();
                        mySqlConnection.Close();
                        MessageBox.Show("Producto No. " + lbidproducto.Text + " actualizado");

                        label4.Visible = true;
                        tbexistencias.Visible = true;
                        label8.Visible = false;
                        cbEstatus.Visible = false;
                        btnEditarProducto.Visible = false;
                        btnNuevoProducto.Visible = false;
                        button1.Visible = true;

                        tbproducto.Clear(); tbdescripcion.Clear(); tbexistencias.Clear(); tbminimo.Clear(); cbunidad.Text = string.Empty; cbEstatus.Text = string.Empty;
                        LlamarBaseDatosConsumibles();
                        IDIncremetable();
                    }
                    catch
                    {
                        MessageBox.Show("Error al actualizar datos");
                    }

                }

            }
        }
        private void GenerarQR()
        {
            QrEncoder qrEncoder = new QrEncoder(ErrorCorrectionLevel.H);
            QrCode qrCode = new QrCode();
            qrEncoder.TryEncode(lbidproducto.Text.Trim(), out qrCode);


            GraphicsRenderer renderer = new GraphicsRenderer(new FixedCodeSize(400, QuietZoneModules.Zero), Brushes.Black, Brushes.White);
            MemoryStream ms = new MemoryStream();
            renderer.WriteToStream(qrCode.Matrix, ImageFormat.Png, ms);
            var imagenTemporal = new Bitmap(ms);
            var imagen = new Bitmap(imagenTemporal, new Size(new Point(200, 200)));
            pbQR.Image = imagen;
        }
        private void GenerarQR2()
        {
            QrEncoder qrEncoder = new QrEncoder(ErrorCorrectionLevel.H);
            QrCode qrCode = new QrCode();
            qrEncoder.TryEncode(txbLink.Text.Trim(), out qrCode);


            GraphicsRenderer renderer = new GraphicsRenderer(new FixedCodeSize(400, QuietZoneModules.Zero), Brushes.Black, Brushes.White);
            MemoryStream ms = new MemoryStream();
            renderer.WriteToStream(qrCode.Matrix, ImageFormat.Png, ms);
            var imagenTemporal = new Bitmap(ms);
            var imagen = new Bitmap(imagenTemporal, new Size(new Point(200, 200)));
            pbQR.Image = imagen;
        }
        private void GuardarQR()
        {
            if (pbQR.Image != null)
            {
                try
                {
                    // Crear un cuadro de diálogo para seleccionar la ubicación de guardado
                    SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                    saveFileDialog1.Filter = "Archivos de imagen (*.png)|*.png|Todos los archivos (*.*)|*.*";
                    saveFileDialog1.Title = "Guardar imagen";

                    // Establecer el nombre predeterminado para el archivo
                    saveFileDialog1.FileName = lbidproducto.Text + ".png"; // Usar el texto de label1 como nombre de archivo

                    // Mostrar el cuadro de diálogo
                    DialogResult result = saveFileDialog1.ShowDialog();

                    // Si el usuario selecciona una ubicación y hace clic en "Guardar"
                    if (result == DialogResult.OK)
                    {
                        // Obtener la ruta completa del archivo seleccionado por el usuario
                        string nombreArchivo = saveFileDialog1.FileName;

                        // Guardar la imagen en el archivo seleccionado
                        pbQR.Image.Save(nombreArchivo, System.Drawing.Imaging.ImageFormat.Png);

                        MessageBox.Show("Imagen guardada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar la imagen: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No hay una imagen para guardar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        string connectionString = "server=10.120.1.3 ; username=root; password=; database=elastosystem";
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Almacen_NuevoProducto_Load(object sender, EventArgs e)
        {
            IDIncremetable();
            LlamarBaseDatosConsumibles();
            GenerarQR();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection mySqlConnection = new MySqlConnection(connectionString);
                mySqlConnection.Open();
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = mySqlConnection;
                if (string.IsNullOrWhiteSpace(tbproducto.Text) || string.IsNullOrWhiteSpace(tbdescripcion.Text) || string.IsNullOrWhiteSpace(tbexistencias.Text) || cbunidad.SelectedIndex == -1 || string.IsNullOrEmpty(tbminimo.Text))
                {
                    MessageBox.Show("Favor de Ingresar todos los datos");
                }
                else
                {
                    comando.CommandText = "INSERT INTO elastosystem_almacen (ID_Producto, Producto, Descripcion, Existencias, Unidad, Stock_Minimo, Estatus) VALUES('" + lbidproducto.Text + "','" + tbproducto.Text + "','" + tbdescripcion.Text + "','" + tbexistencias.Text + "' , '" + cbunidad.Text + "' , '" + tbminimo.Text + "', '" + "ACTIVO" + "');";
                    comando.ExecuteNonQuery();
                    mySqlConnection.Close();
                    MessageBox.Show("Producto No. " + lbidproducto.Text + " registrado");
                    lbidproducto.Text = string.Empty; tbproducto.Clear(); tbdescripcion.Clear(); tbexistencias.Clear(); cbunidad.Text = string.Empty; tbminimo.Text = string.Empty;
                    IDIncremetable();
                }
            }
            catch
            {
                MessageBox.Show("Error al registrar datos");
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dgvConsumibles_DoubleClick(object sender, EventArgs e)
        {
            btnNuevoProducto.Visible = true;

            DataGridView dgv = (DataGridView)sender;

            if (dgv.SelectedCells.Count > 0)
            {
                int rowIndex = dgv.SelectedCells[0].RowIndex;

                string id = dgv.Rows[rowIndex].Cells[0].Value.ToString();
                lbidproducto.Text = id;

                string producto = dgv.Rows[rowIndex].Cells[1].Value.ToString();
                tbproducto.Text = producto;

                string descripcion = dgv.Rows[rowIndex].Cells[2].Value.ToString();
                tbdescripcion.Text = descripcion;

                string estatus = dgv.Rows[rowIndex].Cells[5].Value.ToString();
                cbEstatus.Text = estatus;

                tbexistencias.Visible = false;
                label4.Visible = false;
                cbEstatus.Visible = true;
                label8.Visible = true;
                button1.Visible = false;
                btnEditarProducto.Visible = true;
                btnNuevoProducto.Visible = true;

                string minimo = dgv.Rows[rowIndex].Cells[4].Value.ToString();
                tbminimo.Text = minimo;

                string unidad = dgv.Rows[rowIndex].Cells[3].Value.ToString();
                cbunidad.Text = unidad;
            }

            GenerarQR();
        }

        private void btnNuevoProducto_Click(object sender, EventArgs e)
        {
            IDIncremetable();
            cbunidad.Text = null;
            tbproducto.Clear(); tbdescripcion.Clear(); tbexistencias.Clear(); tbminimo.Clear();
            label8.Visible = false; cbEstatus.Visible = false; label4.Visible = true; tbexistencias.Visible = true; btnEditarProducto.Visible = false; btnNuevoProducto.Visible = false; button1.Visible = true;
            GenerarQR();
        }

        private void btnEditarProducto_Click(object sender, EventArgs e)
        {
            EditarProducto();
        }

        private void btnGenerarQR_Click(object sender, EventArgs e)
        {
            GenerarQR();
        }

        private void btnGuardarQR_Click(object sender, EventArgs e)
        {
            GuardarQR();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            GenerarQR2();
        }
    }
}
