using DocumentFormat.OpenXml.Wordprocessing;
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
    public partial class ReqSistemas : Form
    {
        public ReqSistemas()
        {
            InitializeComponent();
        }
        string connectionString = "server=10.120.1.3 ; username=root; password=; database=elastosystem";
        private void fecha_Tick(object sender, EventArgs e)
        {

        }
        private void MandarALlamarPendientesSistemas()
        {
            try
            {
                string tabla = "SELECT Folio, Descripcion, Solicitante, Prioridad FROM elastosystem_sistemas_req WHERE Estatus = 'ACTIVO'";
                MySqlDataAdapter mySqlAdapter = new MySqlDataAdapter(tabla, connectionString);
                DataTable dt = new DataTable();
                mySqlAdapter.Fill(dt);
                dgvPendientesSistemas.DataSource = dt;
                dt.DefaultView.Sort = "Folio DESC";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

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
            MySqlConnection mySqlConnection = new MySqlConnection(connectionString);
            mySqlConnection.Open();
            MySqlDataReader reader = null;
            string sql = "SELECT Folio FROM elastosystem_sistemas_req";

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
        }
        private void EnviarRequerimiento()
        {
            string query = "SELECT * FROM elastosystem_login WHERE Usuario='" + tbusuario.Text + "' AND Password='" + tbpassword.Text + "'";
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
                MessageBox.Show("ERROR VERIFICACION 0");
            }
            else
            {
                string estats = "ACTIVO";
                DateTime fechainicio = DateTime.Now;
                string fechai = fechainicio.ToString("yyyy-MM-dd");
                MySqlConnection conn = new MySqlConnection(connectionString);
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                try
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "INSERT INTO elastosystem_sistemas_req (Folio, TipoReq, FechaInicio, Descripcion, Solicitante, Prioridad, Estatus) VALUES ('" + lblFolio.Text + "', '" + cbTipoReq.Text + "', '" + fechai + "', '" + tbDescr.Text + "', '" + tbusuario.Text + "', '" + cbNivelPrio.Text + "', '" + estats + "');";
                    cmd.ExecuteNonQuery();
                    cbTipoReq.Text = String.Empty; tbDescr.Clear(); cbNivelPrio.Text = String.Empty; tbusuario.Clear(); tbpassword.Clear();
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
        private void ReqSistemas_Load(object sender, EventArgs e)
        {
            MandarALlamarPendientesSistemas();
            Fecha();
            Folio();
        }

        private void btnCargarImagen_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            EnviarRequerimiento();
            MandarALlamarPendientesSistemas();
        }

        private void btnEnviarReq_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void btnEnviarReq_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void tbpassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }
    }
}
