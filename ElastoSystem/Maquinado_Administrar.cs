using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using Org.BouncyCastle.Asn1.Cmp;
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
    public partial class Maquinado_Administrar : Form
    {
        string validacion = "0";
        public Maquinado_Administrar()
        {
            InitializeComponent();
            
        }
        private void MandarALlamarPendientesMaquinado()
        {
            try
            {
                string tabla = @"SELECT ID_MAQUINADO, SOLICITANTE, PRIORIDAD, FECHA, TIPO, DESCRIPCION 
                                FROM maquinado 
                                ORDER BY 
                                   CASE 
                                    WHEN PRIORIDAD = 'CRITICA' THEN 1
                                     WHEN PRIORIDAD = 'ALTA' THEN 2
                                    WHEN PRIORIDAD = 'MEDIA' THEN 3
                                    WHEN PRIORIDAD = 'BAJA' THEN 4
                                    ELSE 5
                                END,
                                ID_MAQUINADO DESC";
                MySqlDataAdapter mySqlAdapter = new MySqlDataAdapter(tabla, connectionStringelastotec);
                DataTable dt = new DataTable();
                mySqlAdapter.Fill(dt);
                dgvPendientesMaquinado.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void MandarALlamarRestoMaquinado()
        {
            MySqlConnection mySqlConnection = new MySqlConnection(connectionStringelastotec);
            mySqlConnection.Open();
            MySqlDataReader reader = null;
            string sql = "SELECT IMAGEN, RUTA, RECOMENDACION, TIPO_DESC, DEPTO FROM maquinado WHERE ID_MAQUINADO LIKE '" + txbFolio.Text + "' ";
            try
            {
                MySqlCommand comando = new MySqlCommand(sql, mySqlConnection);
                reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        try
                        {
                            byte[] imageData = (byte[])reader["IMAGEN"];
                            using (MemoryStream ms = new MemoryStream(imageData))
                            {
                                pbImagen.Image = Image.FromStream(ms);
                                validacion = "1";
                            }
                        }
                        catch
                        {
                            pbImagen.Image = null;
                            validacion = "0";
                        }
                        try
                        {
                            txbNombreArchivo.Text = reader.GetString("RUTA");
                        }
                        catch { }
                        txbRecomendaciones.Text = reader.GetString("RECOMENDACION");
                        txbDescripcion.Text = reader.GetString("TIPO_DESC");
                        txbDepartamento.Text = reader.GetString("DEPTO");

                        string rutacompleta = txbNombreArchivo.Text;
                        txbRuta.Text = rutacompleta;
                        string nombrearchivo = Path.GetFileName(rutacompleta);
                        txbNombreArchivo.Text = nombrearchivo;
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
        private void DescargarImagen()
        {
            if (pbImagen.Image != null)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Archivos de imagen (*.jpg)|*.jpg|Archivos de imagen (*.png)|*.png|Todos los archivos (*.*)|*.*";
                saveFileDialog.Title = "Guardar imagen";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string rutaArchivo = saveFileDialog.FileName;

                        // Verificar si el archivo ya existe y eliminarlo si es necesario
                        if (File.Exists(rutaArchivo))
                        {
                            File.Delete(rutaArchivo);
                        }

                        // Clona la imagen para evitar problemas con la imagen en uso
                        using (Image imagenClonada = (Image)pbImagen.Image.Clone())
                        {
                            using (MemoryStream ms = new MemoryStream())
                            {
                                // Guarda la imagen en un MemoryStream primero
                                if (Path.GetExtension(rutaArchivo).ToLower() == ".png")
                                {
                                    imagenClonada.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                                }
                                else
                                {
                                    imagenClonada.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                                }

                                // Luego escribe el MemoryStream a un archivo
                                File.WriteAllBytes(rutaArchivo, ms.ToArray());
                            }
                        }

                        MessageBox.Show("Imagen guardada correctamente en '" + rutaArchivo + "'", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (System.Runtime.InteropServices.ExternalException ex)
                    {
                        MessageBox.Show("Ocurrió un error al guardar la imagen. Detalles: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (UnauthorizedAccessException ex)
                    {
                        MessageBox.Show("No tienes permisos para escribir en la ubicación seleccionada. Detalles: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (IOException ex)
                    {
                        MessageBox.Show("Ocurrió un error de E/S al guardar la imagen. Detalles: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ocurrió un error inesperado. Detalles: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {

            }
        }
        private void EliminarRegistroDeMaquinado()
        {
            try
            {
                MySqlConnection mySqlConnection = new MySqlConnection(connectionStringelastotec);
                mySqlConnection.Open();
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = mySqlConnection;
                comando.CommandText = "DELETE FROM maquinado WHERE ID_MAQUINADO = '" + txbFolio.Text + "' ";
                comando.ExecuteNonQuery();
                mySqlConnection.Close();
                MessageBox.Show("Maquinado " + txbFolio.Text + " realizado");
                MandarAMaquinado2();
                
            }
            catch (Exception e)
            {
                MessageBox.Show(""+e);
            }  
        }
        private void MandarAMaquinado2()
        {
            string rutaarchivo = txbRuta.Text.Replace("\\", "\\\\");
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
                    cmd.CommandText = "INSERT INTO maquinado2 (FECHA, SOLICITANTE, DEPTO, TIPO, TIPO_DESC, PRIORIDAD, DESCRIPCION, RECOMENDACION, IMAGEN, RUTA) VALUES ('" + txbFecha.Text + "', '" + txbSolicitante.Text + "', '" + txbDepartamento.Text + "', '" + txbTipo.Text + "', '" + txbDescripcion.Text + "', '" + txbPrioridad.Text + "', '" + txbDescripcionMaquinado.Text + "', '" + txbRecomendaciones.Text + "', @Foto, '" + rutaarchivo + "');";
                    cmd.Parameters.AddWithValue("@Foto", bytesFoto);
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "INSERT INTO maquinado2 (FECHA, SOLICITANTE, DEPTO, TIPO, TIPO_DESC, PRIORIDAD, DESCRIPCION, RECOMENDACION) VALUES ('" + txbFecha.Text + "', '" + txbSolicitante.Text + "', '"+ txbDepartamento.Text +"', '"+ txbTipo.Text +"', '"+ txbDescripcion.Text +"', '"+ txbPrioridad.Text +"', '"+ txbDescripcionMaquinado.Text +"', '"+ txbRecomendaciones.Text +"');";
                    cmd.ExecuteNonQuery();
                }
                Limpiar();
                MandarALlamarPendientesMaquinado();

            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            
        }
        private void Limpiar()
        {
            txbSolicitante.Clear();
            txbPrioridad.Clear();
            txbFecha.Clear();
            txbTipo.Clear();
            txbFolio.Clear();
            pbImagen.Image = null;
            txbNombreArchivo.Clear();
            txbDescripcion.Clear();
            txbDescripcionMaquinado.Clear();
            txbRecomendaciones.Clear();
            dgvPendientesMaquinado.DataSource = null;
            dgvPendientesMaquinado.Rows.Clear();
            dgvPendientesMaquinado.Columns.Clear();
        }

        string connectionStringelastotec = "server=10.120.1.3 ; username=root; password=; database=elastotec";

        private void Maquinado_Administrar_Load(object sender, EventArgs e)
        {
            MandarALlamarPendientesMaquinado();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            MandarALlamarPendientesMaquinado();
        }

        private void dgvPendientesSistemas_DoubleClick(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;

            if (dgv.SelectedCells.Count > 0)
            {
                int rowIndex = dgv.SelectedCells[0].RowIndex;

                string folio = dgv.Rows[rowIndex].Cells[0].Value.ToString();
                txbFolio.Text = folio;

                string solicitante = dgv.Rows[rowIndex].Cells[1].Value.ToString();
                txbSolicitante.Text = solicitante;

                string prioridad = dgv.Rows[rowIndex].Cells[2].Value.ToString();
                txbPrioridad.Text = prioridad;

                string fechaConHora = dgv.Rows[rowIndex].Cells[3].Value.ToString();
                DateTime fecha = Convert.ToDateTime(fechaConHora);
                string fechaFormateada = fecha.ToString("yyyy-MM-dd");
                txbFecha.Text = fechaFormateada;

                string tipo = dgv.Rows[rowIndex].Cells[4].Value.ToString();
                txbTipo.Text = tipo;

                string descripcion = dgv.Rows[rowIndex].Cells[5].Value.ToString();
                txbDescripcionMaquinado.Text = descripcion;

            }
            MandarALlamarRestoMaquinado();
        }

        private void btnDescargar_Click(object sender, EventArgs e)
        {
            DescargarImagen();
        }

        private void btnRealizado_Click(object sender, EventArgs e)
        {
            EliminarRegistroDeMaquinado();
        }
    }
}
