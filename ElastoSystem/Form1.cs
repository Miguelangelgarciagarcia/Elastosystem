using MySql.Data.MySqlClient;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace ElastoSystem
{
    public partial class Form1 : Form
    {
        

        public void PruebaConexionMySql()
        {
            //PRUEBA CONEXION A BASE DE DATOS elastosystem

            string mysqlCon = "server=10.120.1.3; user=root; password=";
            MySqlConnection mySqlConnection = new MySqlConnection(mysqlCon);
            try
            {
                mySqlConnection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Conectarse a la Base de Datos de Elastotecnica");
                MessageBox.Show(ex.Message);
                Application.Exit();
            }
            finally
            {
                mySqlConnection.Close();
            }
        }
        public void login()
        {

            tbusuario.TabIndex = 0;
            tbpassword.TabIndex = 1;
            string query = "SELECT * FROM elastosystem_login WHERE Usuario = @Usuario AND Password = @Password ";
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            commandDatabase.Parameters.AddWithValue("@Usuario", tbusuario.Text);
            commandDatabase.Parameters.AddWithValue("@Password", tbpassword.Text);
            MySqlDataReader reader;

            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string id = reader["ID"].ToString();
                        MessageBox.Show("Bienvenido " + tbusuario.Text);
                        MenuPrincipal menuPrincipal = new();
                        menuPrincipal.TextoLabelID = id;
                        menuPrincipal.Show();
                        this.Hide();

                    }
                }
                else
                {
                    MessageBox.Show("ERROR en Usuario o Contrase�a, vuelve a intentarlo");
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
        }

        public Form1()
        {
            InitializeComponent();

            PruebaConexionMySql();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        //CODIGO PARA MOVER PANEL SUPERIOR
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void label1_Click(object sender, EventArgs e)
        {

        }


        string connectionString = "server=10.120.1.3 ; username=root; password=; database=elastosystem";

        private void btnlogin_Click(object sender, EventArgs e)
        {
            login();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void tbpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbusuario_Enter(object sender, EventArgs e)
        {
            if (tbusuario.Text == "Usuario")
            {
                tbusuario.Text = "";
                tbusuario.ForeColor = Color.DimGray;
            }
        }

        private void tbusuario_Leave(object sender, EventArgs e)
        {
            if (tbusuario.Text == "")
            {
                tbusuario.Text = "Usuario";
                tbusuario.ForeColor = Color.DarkGray;
            }
        }

        private void tbpassword_Enter(object sender, EventArgs e)
        {
            tbpassword.UseSystemPasswordChar = true;

            if (tbpassword.Text == "Contrase�a")
            {
                tbpassword.Text = "";
                tbpassword.ForeColor = Color.DimGray;
            }
        }

        private void tbpassword_Leave(object sender, EventArgs e)
        {
            if (tbpassword.Text == "")
            {
                tbpassword.Text = "Contrase�a";
                tbpassword.ForeColor = Color.DarkGray;
            }
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://www.facebook.com/elastotecnica/?locale=es_LA",
                UseShellExecute = true
            });
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "http://www.youtube.com/@elastotecnicasadecv1154",
                UseShellExecute = true
            });
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://www.instagram.com/elastotecnica/?hl=es",
                UseShellExecute = true
            });
        }

        private void tbpassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                login();
            }
        }

        private void tbusuario_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AlmacenTemporal frm2 = new AlmacenTemporal();
            frm2.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Maquinado_Administrar temporal = new();
            temporal.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tbpassword_MouseClick(object sender, MouseEventArgs e)
        {
            tbpassword.UseSystemPasswordChar = true;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void tbusuario_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void btncerrar_MouseLeave(object sender, EventArgs e)
        {
            pictureBox5.Visible = true;
        }

        private void pictureBox5_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox5.Visible = false;
        }

        private void btnminimizar_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.Visible = true;
        }

        private void pictureBox3_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox3.Visible = false;
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}