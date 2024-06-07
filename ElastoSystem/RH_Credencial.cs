using iTextSharp.text.pdf;
using iTextSharp.text;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Cmp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Document = iTextSharp.text.Document;
using Image = iTextSharp.text.Image;
using Rectangle = System.Drawing.Rectangle;
using System.Drawing.Imaging;
using Gma.QrCodeNet.Encoding.Windows.Render;
using Gma.QrCodeNet.Encoding;
using DocumentFormat.OpenXml.Bibliography;

namespace ElastoSystem
{
    public partial class RH_Credencial : Form
    {
        public RH_Credencial()
        {
            InitializeComponent();
        }
        string connectionString = "server=10.120.1.3 ; username=root; password=; database=elastosystem";
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void RH_Credencial_Load(object sender, EventArgs e)
        {
            MandarALlamarNoTrabajadores();
        }
        private void MandarALlamarNoTrabajadores()
        {
            MySqlConnection mySqlConnection = new MySqlConnection(connectionString);
            mySqlConnection.Open();
            MySqlDataReader reader = null;
            string sql = "SELECT ID FROM elastosystem_rh";
            try
            {
                HashSet<string> unicos = new HashSet<string>();
                MySqlCommand comando = new MySqlCommand(sql, mySqlConnection);
                reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        cbClave.Items.Add(reader["ID"].ToString());
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
        private void MandarALlamarInformacion()
        {

            MySqlConnection mySqlConnection = new MySqlConnection(connectionString);
            mySqlConnection.Open();
            String codigo = cbClave.Text;
            MySqlDataReader reader = null;
            string sql = "SELECT Nombre, Apellido_Paterno, Apellido_Materno, Departamento, Foto FROM elastosystem_rh WHERE ID LIKE '" + codigo + "' ";
            try
            {
                MySqlCommand comando = new MySqlCommand(sql, mySqlConnection);
                reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string nombre = reader.GetString("Nombre");
                        string apellidoPaterno = reader.GetString("Apellido_Paterno");
                        string apellidoMaterno = reader.GetString("Apellido_Materno");
                        string departamento = reader.GetString("Departamento");

                        if (departamento == "ADMINISTRATIVO" || departamento == "VENTAS" || departamento == "COMPRAS")
                        {
                            pFrente.Visible = false;
                            pAtras.Visible = false;
                            label5.Visible = false;
                            pictureBox1.Visible = false;
                            label7.Visible = false;
                            label6.Visible = false;
                            label4.Visible = false;

                            panel1.Visible = true;
                            panel2.Visible = true;
                            lblnombres.Text = nombre;
                            lblApellidos.Text = $"{apellidoPaterno} {apellidoMaterno}";
                            try
                            {
                                byte[] imageData = (byte[])reader["Foto"];
                                using (MemoryStream ms = new MemoryStream(imageData))
                                {
                                    pbFoto.Image = System.Drawing.Image.FromStream(ms);
                                }
                            }
                            catch
                            {
                                pbFoto.Image = null;
                            }
                            lblNo.Text = "No. " + cbClave.Text;
                            lbldepartamentoa.Text = departamento;
                            lblDepartamentotemp.Text = departamento;
                        }
                        else
                        {
                            panel1.Visible=false;
                            panel2.Visible=false;
                            
                            pFrente.Visible = true; 
                            pAtras.Visible =true;
                            label5.Visible = true;
                            pictureBox1.Visible = true;


                            lblNom.Text = nombre;
                            lblAp.Text = $"{apellidoPaterno} {apellidoMaterno}";
                            try
                            {
                                byte[] imageData = (byte[])reader["Foto"];
                                using (MemoryStream ms = new MemoryStream(imageData))
                                {
                                    pbFotos.Image = System.Drawing.Image.FromStream(ms);
                                }
                            }
                            catch
                            {
                                pbFotos.Image = null;
                            }
                            lblNoTr.Text = "No. " + cbClave.Text;
                            lblDepartamentotemp.Text = departamento;
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
        private void cbClave_SelectedIndexChanged(object sender, EventArgs e)
        {
            MandarALlamarInformacion();
            GenerarQR();
            lblDepartamento.Invalidate();
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            if(lblDepartamentotemp.Text == "ADMINISTRATIVO" || lblDepartamentotemp.Text == "VENTAS" || lblDepartamentotemp.Text == "COMPRAS")
            {
                ExportarPanelAImagen(panel1);
                ExportarPanelAImagenTras(panel2);
            }
            else
            {
                ExportarPanelAImagen(pFrente);
                ExportarPanelAImagenTras(pAtras);
            }
            
        }

        private void ExportarPanelAImagen(Panel panel)
        {
            try
            {
                // Configurar el diálogo SaveFileDialog
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Imágenes JPG (*.jpg)|*.jpg";
                saveFileDialog.Title = "Guardar imagen JPG";
                saveFileDialog.FileName = cbClave.Text + " Frente";


                // Mostrar el diálogo SaveFileDialog
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Establecer la ruta del archivo JPG
                    string filePath = saveFileDialog.FileName;

                    // Crear una imagen de tipo JPEG a partir del contenido del panel
                    Bitmap bitmap = new Bitmap(panel.Width, panel.Height);
                    bitmap.SetResolution(300, 300);
                    panel.DrawToBitmap(bitmap, new Rectangle(0, 0, panel.Width, panel.Height));

                    // Guardar la imagen como archivo JPG
                    bitmap.Save(filePath, ImageFormat.Jpeg);

                    MessageBox.Show("PARTE DE ENFRENTE GUARDADA CON EXITO NO: " + cbClave.Text, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al exportar el panel como imagen JPG: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ExportarPanelAImagenTras(Panel panel)
        {
            try
            {
                // Configurar el diálogo SaveFileDialog
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Imágenes JPG (*.jpg)|*.jpg";
                saveFileDialog.Title = "Guardar imagen JPG";
                saveFileDialog.FileName = cbClave.Text + " Atras";

                // Mostrar el diálogo SaveFileDialog
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Establecer la ruta del archivo JPG
                    string filePath = saveFileDialog.FileName;

                    // Crear una imagen de tipo JPEG a partir del contenido del panel
                    Bitmap bitmap = new Bitmap(panel.Width, panel.Height);
                    bitmap.SetResolution(300, 300);
                    panel.DrawToBitmap(bitmap, new Rectangle(0, 0, panel.Width, panel.Height));

                    // Guardar la imagen como archivo JPG
                    bitmap.Save(filePath, ImageFormat.Jpeg);

                    MessageBox.Show("PARTE DE ATRAS GUARDADA CON EXITO NO: " + cbClave.Text, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al exportar el panel como imagen JPG: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void GenerarQR()
        {
            QrEncoder qrEncoder = new QrEncoder(ErrorCorrectionLevel.H);
            QrCode qrCode = new QrCode();
            qrEncoder.TryEncode(cbClave.Text.Trim(), out qrCode);


            GraphicsRenderer renderer = new GraphicsRenderer(new FixedCodeSize(400, QuietZoneModules.Zero), Brushes.Black, Brushes.White);
            MemoryStream ms = new MemoryStream();
            renderer.WriteToStream(qrCode.Matrix, ImageFormat.Png, ms);
            var imagenTemporal = new Bitmap(ms);
            var imagen = new Bitmap(imagenTemporal, new Size(new Point(200, 200)));
            pbQR.BackgroundImage = imagen;
            pbQR2.BackgroundImage = imagen;
        }

        private void lblDepartamento_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Font myfont = new System.Drawing.Font("Montserrat SemiBold", 62);
            Brush mybrush = new System.Drawing.SolidBrush(System.Drawing.Color.White);
            e.Graphics.TranslateTransform(0, 800);
            e.Graphics.RotateTransform(-90);
            e.Graphics.DrawString(lblDepartamentotemp.Text, myfont, mybrush, 0, 0);
        }

        private void pbQR_Click(object sender, EventArgs e)
        {

        }

        private void PBNaranja_MouseMove(object sender, MouseEventArgs e)
        {
            PBNaranja.Visible = false;
        }

        private void PBAzul_MouseMove(object sender, MouseEventArgs e)
        {
            PBAzul.Visible = false;
        }

        private void PBICerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void PBICerrar_MouseLeave(object sender, EventArgs e)
        {
            PBNaranja.Visible = true;
        }

        private void PBIconoMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void PBIconoMin_MouseLeave(object sender, EventArgs e)
        {
            PBAzul.Visible = true;
        }
    }
}
