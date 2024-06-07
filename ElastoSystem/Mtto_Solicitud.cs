using MySql.Data.MySqlClient;
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
    public partial class Mtto_Solicitud : Form
    {
        public Mtto_Solicitud()
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
            MySqlConnection mySqlConnection = new MySqlConnection(connectionStringtec);
            mySqlConnection.Open();
            MySqlDataReader reader = null;
            string sql = "SELECT IDFOLIO FROM folio";

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
            string sql = "SELECT Folio FROM elastosystem_mtto_req";

            try
            {
                int ultimoFolio = 0;
                MySqlCommand comando = new MySqlCommand(sql, mySqlConnection);
                reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string folioString = reader["Folio"].ToString();
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
        private void MandarALlamarMaquinas()
        {
            MySqlConnection mySqlConnection = new MySqlConnection(connectionString);
            mySqlConnection.Open();
            MySqlDataReader reader = null;
            string sql = "SELECT Nombre FROM elastosystem_mtto_inventariomaquinas WHERE Estatus = 'ACTIVA'";
            try
            {
                HashSet<string> unicos = new HashSet<string>();
                MySqlCommand comando = new MySqlCommand(sql, mySqlConnection);
                reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string maquinas = reader["Nombre"].ToString();

                        if (!unicos.Contains(maquinas))
                        {
                            cbMaquinas.Items.Add(maquinas);
                            unicos.Add(maquinas);
                        }
                        else
                        {

                        }
                        cbMaquinas.Sorted = true;
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
        private void MandarALlamarUbicacion()
        {
            MySqlConnection mySqlConnection = new MySqlConnection(connectionString);
            mySqlConnection.Open();
            MySqlDataReader reader = null;
            string sql = "SELECT Ubicacion FROM elastosystem_mtto_inventariomaquinas WHERE Nombre LIKE '" + cbMaquinas.Text + "' ";
            string maq = cbMaquinas.Text;
            try
            {
                MySqlCommand comando = new MySqlCommand(sql, mySqlConnection);
                reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        cbUbicacion.Text = reader["Ubicacion"].ToString();
                    }
                }
                else
                {

                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                mySqlConnection.Close();
            }
            cbMaquinas.Text = maq;
        }
        private void MandarALlamarImagen()
        {
            MySqlConnection mySqlConnection = new MySqlConnection(connectionString);
            mySqlConnection.Open();
            MySqlDataReader reader = null;
            string sql = "SELECT Imagen FROM elastosystem_mtto_inventariomaquinas WHERE Nombre LIKE '" + cbMaquinas.Text + "' ";
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

                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                mySqlConnection.Close();
            }
        }
        private void MandarALlamarMaquinasXUbicaion()
        {
            cbMaquinas.Items.Clear();
            string ofi = cbUbicacion.Text;
            if (ofi == "OFICINAS")
            {
                cbMaquinas.Items.Add("AGREGAR DESCRIPCION");
            }
            else
            {
                MySqlConnection mySqlConnection = new MySqlConnection(connectionString);
                mySqlConnection.Open();
                MySqlDataReader reader = null;
                string sql = "SELECT Nombre FROM elastosystem_mtto_inventariomaquinas WHERE Ubicacion LIKE '" + cbUbicacion.Text + "' AND Estatus = 'ACTIVA' ";
                try
                {
                    HashSet<string> unicos = new HashSet<string>();
                    MySqlCommand comando = new MySqlCommand(sql, mySqlConnection);
                    reader = comando.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            cbMaquinas.Items.Add(reader["Nombre"].ToString());
                        }
                        cbMaquinas.Sorted = true;
                    }
                    else
                    {
                    }
                }
                catch
                {
                }
                mySqlConnection.Close();
            }

        }
        private void EnviarRequerimiento()
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
                string estats = "ACTIVA";
                DateTime fechainicio = DateTime.Now;
                string fechai = fechainicio.ToString("yyyy-MM-dd");
                MySqlConnection conn = new MySqlConnection(connectionString);
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                try
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "INSERT INTO elastosystem_mtto_req (Folio, Fecha, Solicitante, Prioridad, Tipo_Falla, Mantenimiento, Ubicacion, Maquina, Descripcion, Recomendaciones_Sugerencias, Refacciones, Estatus) VALUES ('" + lblFolio.Text + "', '" + fechai + "', '" + txbUsuario.Text + "', '" + cbPrioridad.Text + "', '" + cbTipoFalla.Text + "', '" + cbTipoReq.Text + "', '" + cbUbicacion.Text + "', '" + cbMaquinas.Text + "', '" + txbDescripcion.Text + "', '" + txbRecSug.Text + "', '" + txbRefacciones.Text + "', '" + estats + "');";
                    cmd.ExecuteNonQuery();
                    txbUsuario.Clear(); txbPassword.Clear(); cbPrioridad.Text = String.Empty; cbTipoFalla.Text = String.Empty; cbTipoReq.Text = String.Empty; cbUbicacion.Text = String.Empty; cbMaquinas.Text = String.Empty; txbDescripcion.Clear(); txbRecSug.Clear(); txbRefacciones.Clear();
                    MessageBox.Show("Orden: " + lblFolio.Text + " enviada con exito");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conn.Close();
                }
                Folio();
            }
        }

        string connectionString = "server=10.120.1.3 ; username=root; password=; database=elastosystem";
        string connectionStringtec = "server=10.120.1.3 ; username=root; password=; database=elastotec";

        private void Mtto_Solicitud_Load(object sender, EventArgs e)
        {
            Fecha();
            Folio();
        }

        private void cbMaquinas_SelectedIndexChanged(object sender, EventArgs e)
        {
            MandarALlamarUbicacion();
            MandarALlamarImagen();
        }

        private void cbUbicacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            MandarALlamarMaquinasXUbicaion();
        }

        private void btnEnviarReq_Click(object sender, EventArgs e)
        {
            EnviarRequerimiento();
        }

        private void cbTipoReq_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbMaquinas.Items.Clear();

            if(cbTipoReq.SelectedIndex == 2)
            {
                MandarALlamarMaquinas();
            }
            
        }
    }
}
