using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Cmp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElastoSystem
{
    public partial class Maquinado_Solicitud : Form
    {
        string validacion = "0";
        public Maquinado_Solicitud()
        {
            InitializeComponent();
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
            MySqlConnection mySqlConnection = new MySqlConnection(connectionStringelastotec);
            mySqlConnection.Open();
            MySqlDataReader reader = null;
            string sql = "SELECT ID_MAQUINADO FROM maquinado";

            try
            {
                int ultimoFolio = 0;
                MySqlCommand comando = new MySqlCommand(sql, mySqlConnection);
                reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string folioString = reader["ID_MAQUINADO"].ToString();
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
        }
        private void Limpiar()
        {
            cbSolicitante.Text = null;
            txbDepartamento.Text = null;
            cbPrioridad.Text = null;
            txbRecomendacionesSugerencias.Text = null;
            cbTipo.Text = null;
            txbDescripcion.Text = null;
            txbDescripcionDelMaquinado.Text = null;
            lblRutaArchivo.Text = null;
            txbNombreArchivo.Text = null;
            pbImagen.Image = null;
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
                        string apaterno = reader["APATERNO"].ToString();
                        string amaterno = reader["AMATERNO"].ToString();
                        string nombre = reader["NOMBRE"].ToString();


                        string nombreCompleto = $"{nombre} {apaterno} {amaterno}";

                        if (!cbSolicitante.Items.Contains(nombreCompleto))
                        {
                            cbSolicitante.Items.Add(nombreCompleto);
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
                mySqlConnection.Close();
            }
        }
        private void ContarEspacios()
        {
            if (!string.IsNullOrEmpty(cbSolicitante.Text))
            {
                string nombrecompleto = cbSolicitante.Text;

                int espacios = nombrecompleto.Count(c => c == ' ');

                if (espacios > 2)
                {
                    int indiceespacio = nombrecompleto.IndexOf(' ');
                    int indiceespacio2 = nombrecompleto.IndexOf(' ', indiceespacio + 1);
                    int indiceespacio3 = nombrecompleto.IndexOf(' ', indiceespacio2 + 1);
                    string nombre1 = nombrecompleto.Substring(0, indiceespacio);
                    string nombre2 = nombrecompleto.Substring(indiceespacio + 1, indiceespacio2 - indiceespacio - 1);
                    string apellidopat = nombrecompleto.Substring(indiceespacio2 + 1, indiceespacio3 - indiceespacio2 - 1);
                    string apellidomat = nombrecompleto.Substring(indiceespacio3 + 1);
                    string nombr = nombre1 + " " + nombre2;

                    MySqlConnection mySqlConnection = new MySqlConnection(connectionStringelastotec);
                    mySqlConnection.Open();
                    MySqlDataReader reader = null;
                    string sql = "SELECT DEPTO FROM empleados WHERE APATERNO LIKE '" + apellidopat + "' AND AMATERNO LIKE '" + apellidomat + "' AND NOMBRE LIKE '" + nombr + "'";
                    try
                    {
                        MySqlCommand comando = new MySqlCommand(sql, mySqlConnection);
                        reader = comando.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                txbDepartamento.Text = reader.GetString("DEPTO");
                            }
                        }
                        else
                        {
                            txbDepartamento.Text = " ";
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
                else
                {
                    int indiceespacio = nombrecompleto.IndexOf(' ');
                    int indiceespacio2 = nombrecompleto.IndexOf(' ', indiceespacio + 1);
                    string nombre = nombrecompleto.Substring(0, indiceespacio);
                    string apellidopat = nombrecompleto.Substring(indiceespacio + 1, indiceespacio2 - indiceespacio - 1);
                    string apellidomat = nombrecompleto.Substring(indiceespacio2 + 1);

                    MySqlConnection mySqlConnection = new MySqlConnection(connectionStringelastotec);
                    mySqlConnection.Open();
                    MySqlDataReader reader = null;
                    string sql = "SELECT DEPTO FROM empleados WHERE APATERNO LIKE '" + apellidopat + "' AND AMATERNO LIKE '" + apellidomat + "' AND NOMBRE LIKE '" + nombre + "'";
                    try
                    {
                        MySqlCommand comando = new MySqlCommand(sql, mySqlConnection);
                        reader = comando.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                txbDepartamento.Text = reader.GetString("DEPTO");
                            }
                        }
                        else
                        {
                            txbDepartamento.Text = " ";
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
            }
            else
            {

            }
        }
        private void CargarArchivo()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos de imagen|*.png;*.jpg;*.jpeg;*.gif;*.bmp|Todos los archivos|*.*";
            openFileDialog.Title = "Seleccionar Archivo";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                string fileName = System.IO.Path.GetFileName(filePath);

                txbNombreArchivo.Text = fileName;
                lblRutaArchivo.Text = filePath;
                try
                {
                    pbImagen.Image = Image.FromFile(filePath);
                    validacion = "1";

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar el archivo" + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("No se seleccionó ningún archivo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void EnviarSolicitud()
        {
            string fecha = DateTime.Now.ToString("yyyy/MM/dd");
            string rutaarchivo = lblRutaArchivo.Text.Replace("\\", "\\\\");
            MySqlConnection conn = new MySqlConnection(connectionStringelastotec);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand();
            try
            {
                if (validacion == "1")
                {
                    byte[] bytesFoto;
                    using (MemoryStream ms = new MemoryStream())
                    {
                        pbImagen.Image.Save(ms, ImageFormat.Jpeg);
                        bytesFoto = ms.ToArray();
                    }
                    cmd.Connection = conn;
                    cmd.CommandText = "INSERT INTO maquinado (ID_MAQUINADO, FECHA, SOLICITANTE, DEPTO, TIPO, TIPO_DESC, PRIORIDAD, DESCRIPCION, RECOMENDACION, IMAGEN, RUTA) VALUES ('" + lblFolio.Text + "', '" + fecha + "', '" + cbSolicitante.Text + "', '" + txbDepartamento.Text + "', '" + cbTipo.Text + "', '" + txbDescripcion.Text + "', '" + cbPrioridad.Text + "', '" + txbDescripcionDelMaquinado.Text + "', '" + txbRecomendacionesSugerencias.Text + "', @Foto, '" + rutaarchivo + "');";
                    cmd.Parameters.AddWithValue("@Foto", bytesFoto);
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "INSERT INTO maquinado (ID_MAQUINADO, FECHA, SOLICITANTE, DEPTO, TIPO, TIPO_DESC, PRIORIDAD, DESCRIPCION, RECOMENDACION) VALUES ('" + lblFolio.Text + "', '" + fecha + "', '" + cbSolicitante.Text + "', '" + txbDepartamento.Text + "', '" + cbTipo.Text + "', '" + txbDescripcion.Text + "', '" + cbPrioridad.Text + "', '" + txbDescripcionDelMaquinado.Text + "', '" + txbRecomendacionesSugerencias.Text + "');";
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("REQUERIMIENTO " + lblFolio.Text + " ENVIADO CON EXITO");
                Limpiar();
                Folio();

                
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR AL REGISTRAR AL TRABAJADOR " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        string connectionStringelastotec = "server=10.120.1.3 ; username=root; password=; database=elastotec";

        private void Maquinado_Solicitud_Load(object sender, EventArgs e)
        {
            Fecha();
            Folio();
            CargarUsuarios();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void cbSolicitante_SelectedIndexChanged(object sender, EventArgs e)
        {
            ContarEspacios();
        }

        private void btnCargarArchivo_Click(object sender, EventArgs e)
        {
            CargarArchivo();
        }

        private void btnEnviarSolicitud_Click(object sender, EventArgs e)
        {
            EnviarSolicitud();
        }
    }
}
