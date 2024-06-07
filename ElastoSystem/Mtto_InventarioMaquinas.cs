using DocumentFormat.OpenXml.Office.Word;
using MySql.Data.MySqlClient;
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
    public partial class Mtto_InventarioMaquinas : Form
    {
        int opc = 0; //VERIFICAR SI SE HA SUBIDO UNA NUEVA FOTO
        public Mtto_InventarioMaquinas()
        {
            InitializeComponent();
        }
        private void MandarALlamarBDInventarioMaquinas()
        {
            string tabla = "SELECT Nombre, Modelo, No_Serie, Ubicacion, Estatus, Orden_Trabajo, Mantenimiento, Indicador FROM elastosystem_mtto_inventariomaquinas";
            MySqlDataAdapter mySqlAdapter = new MySqlDataAdapter(tabla, connectionString);
            DataTable dt = new DataTable();
            mySqlAdapter.Fill(dt);
            dt.Columns.Remove("Orden_Trabajo");
            dt.Columns.Remove("Mantenimiento");
            dt.Columns.Remove("Indicador");
            dgvBD.DataSource = dt;

            //Mandamos a llamar esta segunda tabla donde estaran los permisos de manera oculta
            DataTable dt2 = new DataTable();
            mySqlAdapter.Fill(dt2);
            dgvPermisos.DataSource = dt2;
        }
        private void EliminarRegistro()
        {
            MySqlConnection mySqlConnection = new MySqlConnection(connectionString);
            mySqlConnection.Open();
            MySqlCommand comando = new MySqlCommand();
            comando.Connection = mySqlConnection;
            comando.CommandText = "DELETE FROM elastosystem_mtto_inventariomaquinas WHERE No_Serie = '" + txbNumeroSerie.Text + "' ";
            comando.ExecuteNonQuery();
            mySqlConnection.Close();
            MessageBox.Show("Maquina " + txbNombre.Text + " eliminada");
            MandarALlamarBDInventarioMaquinas();
            LimpiarCajas();
        }
        private void AgregarRegistro()
        {
            bool booordentrabajo = chbOrdenTrabajo.Checked;
            bool boomantenimiento = chbMantenimiento.Checked;
            bool booindicador = chbIndicador.Checked;
            MySqlConnection mySqlConnection = new MySqlConnection(connectionString);
            mySqlConnection.Open();
            MySqlCommand comando = new MySqlCommand();
            try
            {
                if (opc == 1)
                {
                    byte[] bytesFoto;
                    using (MemoryStream ms = new MemoryStream())
                    {
                        pbImagen.Image.Save(ms, ImageFormat.Jpeg);
                        bytesFoto = ms.ToArray();
                    }
                    comando.Connection = mySqlConnection;
                    comando.CommandText = "INSERT INTO elastosystem_mtto_inventariomaquinas (Nombre, Modelo, No_Serie, Ubicacion, Imagen, Estatus, Orden_Trabajo, Mantenimiento, Indicador) VALUES('" + txbNombre.Text + "','" + txbModelo.Text + "','" + txbNumeroSerie.Text + "','" + cbUbicacion.Text + "', @Foto, '" + cbEstatus.Text + "', " + booordentrabajo + ", " + boomantenimiento + ", " + booindicador + ");";
                    comando.Parameters.AddWithValue("@Foto", bytesFoto);
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Maquina " + txbNombre.Text + " agregada con exito");
                }
                else
                {
                    comando.Connection = mySqlConnection;
                    comando.CommandText = "INSERT INTO elastosystem_mtto_inventariomaquinas (Nombre, Modelo, No_Serie, Ubicacion, Estatus, Orden_Trabajo, Mantenimiento, Indicador) VALUES('" + txbNombre.Text + "','" + txbModelo.Text + "','" + txbNumeroSerie.Text + "','" + cbUbicacion.Text + "' , '" + cbEstatus.Text + "', " + booordentrabajo + ", " + boomantenimiento + ", " + booindicador + ");";
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Maquina " + txbNombre.Text + " agregada con exito");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR AL REGISTRAR LA MAQUINA " + ex.Message);
            }
            finally
            {
                mySqlConnection.Close();
            }
            MandarALlamarBDInventarioMaquinas();
            LimpiarCajas();
            opc = 0;
        }
        private void EditarRegistro()
        {
            MySqlConnection mySqlConnection = new MySqlConnection(connectionString);
            mySqlConnection.Open();
            MySqlCommand comando = new MySqlCommand();
            try
            {
                if (opc == 1)
                {
                    byte[] bytesFoto;
                    using (MemoryStream ms = new MemoryStream())
                    {
                        pbImagen.Image.Save(ms, ImageFormat.Jpeg);
                        bytesFoto = ms.ToArray();
                    }
                    comando.Connection = mySqlConnection;
                    comando.CommandText = "UPDATE elastosystem_mtto_inventariomaquinas SET Nombre = '" + txbNombre.Text + "' , Modelo = '" + txbModelo.Text + "' , No_Serie = '" + txbNumeroSerie.Text + "' , Ubicacion = '" + cbUbicacion.Text + "', Imagen = @Foto, Estatus = '" + cbEstatus.Text + "' WHERE No_Serie = '" + txbNumeroSerie.Text + "'";
                    comando.Parameters.AddWithValue("@Foto", bytesFoto);
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Maquina " + txbNombre.Text + " modificada con exito");
                }
                else
                {
                    comando.Connection = mySqlConnection;
                    comando.CommandText = "UPDATE elastosystem_mtto_inventariomaquinas SET Nombre = '" + txbNombre.Text + "' , Modelo = '" + txbModelo.Text + "' , No_Serie = '" + txbNumeroSerie.Text + "' , Ubicacion = '" + cbUbicacion.Text + "', Estatus = '" + cbEstatus.Text + "' WHERE No_Serie = '" + txbNumeroSerie.Text + "'";
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Maquina " + txbNombre.Text + " modificada con exito");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR AL MODIFICAR LA MAQUINA " + ex.Message);
            }
            finally
            {
                mySqlConnection.Close();
            }
            MandarALlamarBDInventarioMaquinas();
            LimpiarCajas();
            opc = 0;
        }
        private void LimpiarCajas()
        {
            txbNombre.Clear(); txbModelo.Clear(); txbNumeroSerie.Clear(); cbUbicacion.SelectedIndex = -1; cbEstatus.SelectedIndex = -1; chbOrdenTrabajo.Checked = false; chbMantenimiento.Checked = false; chbIndicador.Checked = false; pbImagen.Image = null;
        }
        private void CargarImagen()
        {
            opc = 1;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos de imagen|*.png;*.jpg;*.jpeg;*.gif;*.bmp|Todos los archivos|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string rutaImagen = openFileDialog.FileName;

                try
                {
                    pbImagen.Image = Image.FromFile(rutaImagen);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar la imagen: " + ex.Message);
                }
            }
        }
        private void ActualizarPermisos()
        {
            bool boolordencompra = chbOrdenTrabajo.Checked;
            bool boolmantenimiento = chbMantenimiento.Checked;
            bool boolindicador = chbIndicador.Checked;

            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand();
            try
            {
                cmd.Connection = conn;
                cmd.CommandText = "UPDATE elastosystem_mtto_inventariomaquinas SET Orden_Trabajo = " + boolordencompra + ", Mantenimiento = " + boolmantenimiento + ", Indicador = " + boolindicador + " WHERE No_Serie = '" + txbNumeroSerie.Text + "'";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Permisos de "+txbNombre.Text+" actualizados con exito");
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
        private void MandarALlamarImagen()
        {
            MySqlConnection mySqlConnection = new MySqlConnection(connectionString);
            mySqlConnection.Open();
            MySqlDataReader reader = null;
            string sql = "SELECT Imagen FROM elastosystem_mtto_inventariomaquinas WHERE No_Serie LIKE '" + txbNumeroSerie.Text + "' ";
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
                            byte[] imageData = (byte[])reader["Imagen"];
                            using (MemoryStream ms = new MemoryStream(imageData))
                            {
                                pbImagen.Image = Image.FromStream(ms);
                            }
                        }
                        catch
                        {
                            pbImagen.Image = null;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("ERROR LLAMAR A SISTEMAS");
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
            txbModelo.TabIndex = 1;
            txbNumeroSerie.TabIndex = 2;
            cbUbicacion.TabIndex = 3;
            cbEstatus.TabIndex = 4;
            btnAgregar.TabIndex = 5;
        }
        private void TabuladoresSelect()
        {
            txbNombre.TabIndex = 0;
            txbModelo.TabIndex = 1;
            txbNumeroSerie.TabIndex = 2;
            cbUbicacion.TabIndex = 3;
            cbEstatus.TabIndex = 4;
            btnModificar.TabIndex = 5;
        }

        string connectionString = "server=10.120.1.3 ; username=root; password=; database=elastosystem";

        private void button3_Click(object sender, EventArgs e)
        {
            EliminarRegistro();
        }
        private void Mtto_InventarioMaquinas_Load(object sender, EventArgs e)
        {
            MandarALlamarBDInventarioMaquinas();
            Tabuladores();
        }
        private void dgvBD_DoubleClick(object sender, EventArgs e)
        {
            TabuladoresSelect();
            LimpiarCajas();
            DataGridView dgvBD = (DataGridView)sender;
            DataGridView dgvPerm = (DataGridView)dgvPermisos;

            if (dgvBD.SelectedCells.Count > 0)
            {
                int rowIndex = dgvBD.SelectedCells[0].RowIndex;

                string nombre = dgvBD.Rows[rowIndex].Cells[0].Value.ToString();
                txbNombre.Text = nombre;

                string modelo = dgvBD.Rows[rowIndex].Cells[1].Value.ToString();
                txbModelo.Text = modelo;

                string no_serie = dgvBD.Rows[rowIndex].Cells[2].Value.ToString();
                txbNumeroSerie.Text = no_serie;

                string ubicacion = dgvBD.Rows[rowIndex].Cells[3].Value.ToString();
                cbUbicacion.Text = ubicacion;

                string estatus = dgvBD.Rows[rowIndex].Cells[4].Value.ToString();
                cbEstatus.Text = estatus;

                string orden_trabajo = dgvPerm.Rows[rowIndex].Cells[5].Value.ToString();
                if (orden_trabajo == "True")
                {
                    chbOrdenTrabajo.Checked = true;
                }

                string mantenimiento = dgvPerm.Rows[rowIndex].Cells[6].Value.ToString();
                if (mantenimiento == "True")
                {
                    chbMantenimiento.Checked = true;
                }

                string indicador = dgvPerm.Rows[rowIndex].Cells[7].Value.ToString();
                if (indicador == "True")
                {
                    chbIndicador.Checked = true;
                }
                MandarALlamarImagen();
                btnAgregar.Visible = false;
                btnNueva.Visible = true;
                btnEliminar.Visible = true;
                btnModificar.Visible = true;
                btnActualizarPermisos.Visible = true;
            }
        }
        private void btnNueva_Click(object sender, EventArgs e)
        {
            LimpiarCajas();
            btnNueva.Visible = false;
            btnAgregar.Visible = true;
            btnEliminar.Visible = false;
            btnModificar.Visible = false;
            btnActualizarPermisos.Visible = false;
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarRegistro();
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            EditarRegistro();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            CargarImagen();
        }
        private void btnActualizarPermisos_Click(object sender, EventArgs e)
        {
            ActualizarPermisos();
            MandarALlamarBDInventarioMaquinas();
        }
    }
}
