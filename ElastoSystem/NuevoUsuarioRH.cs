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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using DocumentFormat.OpenXml.Office.Word;
using DocumentFormat.OpenXml.Vml;
using static QRCoder.PayloadGenerator;

namespace ElastoSystem
{
    public partial class NuevoUsuarioRH : Form
    {
        int opc = 0;
        public NuevoUsuarioRH()
        {
            InitializeComponent();
        }
        string connectionString = "server=10.120.1.3 ; username=root; password=; database=elastosystem";

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand();
            try
            {
                if (opc == 1)
                {
                    byte[] bytesFoto;
                    using (MemoryStream ms = new MemoryStream())
                    {
                        pbFoto.Image.Save(ms, ImageFormat.Jpeg);
                        bytesFoto = ms.ToArray();
                    }
                    cmd.Connection = conn;
                    cmd.CommandText = "INSERT INTO elastosystem_rh (ID, Nombre, Apellido_Paterno, Apellido_Materno, CURP, Foto, Estatus, Sexo, Fecha_Nacimiento, Lugar_Nacimiento, IMSS, RFC, CPF, Departamento, Puesto, CalleYNum, Colonia, Poblacion, EntidadFederativa, Pais, Correo1, Correo2, CP, Telefono1, Telefono2, Nivel_Estudios, Profesion, Estado_Civil, Tipo_Sangre) VALUES ('" + cbClave.Text + "', '" + txbNom.Text + "', '" + txbApPat.Text + "', '" + txbApMa.Text + "', '" + txCURP.Text + "', @Foto, '" + cbEstatus.Text + "', '" + cbSex.Text + "', '" + tbFechaNacimiento.Text + "', '" + cbLugarNacimiento.Text + "', '" + txbIM.Text + "', '" + txbRF.Text + "', '" + txbCPFiscal.Text + "', '" + cbDepartamento.Text + "', '" + cbPuesto.Text + "', '" + txbCalle.Text + "', '" + txbColonia.Text + "', '" + txbPoblacion.Text + "', '" + cbEntidadFederativa.Text + "', '" + txbPais.Text + "', '" + txbCorreo1.Text + "', '" + txbCorreo2.Text + "', '" + txbCP.Text + "', '" + txbTelefono1.Text + "', '" + txbTelefono2.Text + "', '" + cbNivelEstudios.Text + "', '" + txbProfesion.Text + "', '" + cbEstadoCivil.Text + "', '" + cbTipoSangre.Text + "');";
                    cmd.Parameters.AddWithValue("@Foto", bytesFoto);
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "INSERT INTO elastosystem_rh (ID, Nombre, Apellido_Paterno, Apellido_Materno, CURP, Estatus, Sexo, Fecha_Nacimiento, Lugar_Nacimiento, IMSS, RFC, CPF, Departamento, Puesto, CalleYNum, Colonia, Poblacion, EntidadFederativa, Pais, Correo1, Correo2, CP, Telefono1, Telefono2, Nivel_Estudios, Profesion, Estado_Civil, Tipo_Sangre) VALUES ('" + cbClave.Text + "', '" + txbNom.Text + "', '" + txbApPat.Text + "', '" + txbApMa.Text + "', '" + txCURP.Text + "', '" + cbEstatus.Text + "', '" + cbSex.Text + "', '" + tbFechaNacimiento.Text + "', '" + cbLugarNacimiento.Text + "', '" + txbIM.Text + "', '" + txbRF.Text + "', '" + txbCPFiscal.Text + "', '" + cbDepartamento.Text + "', '" + cbPuesto.Text + "', '" + txbCalle.Text + "', '" + txbColonia.Text + "', '" + txbPoblacion.Text + "', '" + cbEntidadFederativa.Text + "', '" + txbPais.Text + "', '" + txbCorreo1.Text + "', '" + txbCorreo2.Text + "', '" + txbCP.Text + "', '" + txbTelefono1.Text + "', '" + txbTelefono2.Text + "', '" + cbNivelEstudios.Text + "', '" + txbProfesion.Text + "', '" + cbEstadoCivil.Text + "', '" + cbTipoSangre.Text + "');";
                    cmd.ExecuteNonQuery();
                }
                pbFoto.Image = null;
                MessageBox.Show("TRABAJADOR " + cbClave.Text + " REGISTRADO CON EXITO");
                cbEstatus.Text = String.Empty; txbNom.Clear(); txbApPat.Clear(); txbApMa.Clear(); cbSex.Text = String.Empty; tbFechaNacimiento.Clear(); cbLugarNacimiento.Text = String.Empty; txbIM.Clear(); txbIM.Clear(); txbRF.Clear(); txCURP.Clear(); txbCPFiscal.Clear(); cbDepartamento.Text = String.Empty; cbPuesto.Text = String.Empty; txbCalle.Clear(); txbColonia.Clear(); txbPoblacion.Clear(); cbEntidadFederativa.Text = String.Empty; txbPais.Clear(); txbCorreo1.Clear(); txbCorreo2.Clear(); txbCP.Clear(); txbTelefono1.Clear(); txbTelefono2.Clear(); cbNivelEstudios.Text = String.Empty; txbProfesion.Clear(); cbEstadoCivil.Text = String.Empty; cbTipoSangre.Text = String.Empty; lblNombre.Text = "NUEVO TRABAJADOR"; btnAgergarUsuario.Enabled = true; btnEditarUsuario.Enabled = false;
                MandarALlamarNoTrabajadores();
                NuevoNoTrabajador();
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

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            GeneraQr();

        }

        private void NuevoUsuarioRH_Load(object sender, EventArgs e)
        {

            if (rbJS.Checked = true)
            {
                rbJN.Checked = false;
                txbSalarioxHora.ReadOnly = true;
                txbHorasxDia.ReadOnly = true;
                txbDiasxSemana.ReadOnly = true;
            }
            else if (rbJN.Checked = true)
            {
                rbJS.Checked = false;
                txbSalarioxHora.ReadOnly = false;
                txbHorasxDia.ReadOnly = false;
                txbDiasxSemana.ReadOnly = false;
            }
            else
            {

            }

            MandarALlamarNoTrabajadores();
            NuevoNoTrabajador();
            BloquearBotonDeEditar();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MandarALlamarInformacion();
            BloquearBotonDeAgregar();
            HabilitarBotonDeEditar();
        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }
        private void HabilitarBotonDeEditar()
        {
            btnEditarUsuario.Enabled = true;
        }
        private void BloquearBotonDeEditar()
        {
            btnEditarUsuario.Enabled = false;
        }
        private void BloquearBotonDeAgregar()
        {
            btnAgergarUsuario.Enabled = false;
        }
        private void GeneraQr()
        {
            QrEncoder qrEncoder = new QrEncoder(ErrorCorrectionLevel.H);
            QrCode qrCode = new QrCode();
            qrEncoder.TryEncode(cbClave.Text.Trim(), out qrCode);

            GraphicsRenderer renderer = new GraphicsRenderer(new FixedCodeSize(400, QuietZoneModules.Zero), Brushes.Black, Brushes.White);
            MemoryStream ms = new MemoryStream();
            renderer.WriteToStream(qrCode.Matrix, ImageFormat.Png, ms);

            var imagenTemporal = new Bitmap(ms);
            var imagen = new Bitmap(imagenTemporal, new Size(new Point(150, 150)));
            pbqr.Image = imagen;

        }
        private void NuevoNoTrabajador()
        {
            string ultimoItem = cbClave.Items[cbClave.Items.Count - 1].ToString();
            int.TryParse(ultimoItem, out int resultado);
            resultado = resultado + 1;
            cbClave.Text = resultado.ToString();
        }
        private void MandarALlamarNoTrabajadores()
        {
            cbClave.Items.Clear();
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
        private void ActualizarDatos()
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand();
            try
            {
                if (opc == 1)
                {
                    byte[] bytesFoto;
                    using (MemoryStream ms = new MemoryStream())
                    {
                        pbFoto.Image.Save(ms, ImageFormat.Jpeg);
                        bytesFoto = ms.ToArray();
                    }
                    cmd.Connection = conn;
                    cmd.CommandText = "UPDATE elastosystem_rh SET Foto = @Foto, Estatus = '" + cbEstatus.Text + "', Nombre = '" + txbNom.Text + "', Apellido_Paterno = '" + txbApPat.Text + "', Apellido_Materno = '" + txbApMa.Text + "', Sexo = '" + cbSex.Text + "', Fecha_Nacimiento = '" + tbFechaNacimiento.Text + "', Lugar_Nacimiento = '" + cbLugarNacimiento.Text + "', IMSS = '" + txbIM.Text + "', RFC = '" + txbRF.Text + "', CURP = '" + txCURP.Text + "', CPF = '" + txbCPFiscal.Text + "', Departamento = '" + cbDepartamento.Text + "', Puesto = '" + cbPuesto.Text + "', CalleYNum = '" + txbCalle.Text + "', Colonia = '" + txbColonia.Text + "' , Poblacion = '" + txbPoblacion.Text + "', EntidadFederativa = '" + cbEntidadFederativa.Text + "', Pais = '" + txbPais.Text + "', Correo1 = '" + txbCorreo1.Text + "', Correo2 = '" + txbCorreo2.Text + "', CP = '" + txbCP.Text + "', Telefono1 = '" + txbTelefono1.Text + "', Telefono2 = '" + txbTelefono2.Text + "', Nivel_Estudios = '" + cbNivelEstudios.Text + "', Profesion = '" + txbProfesion.Text + "', Estado_Civil = '" + cbEstadoCivil.Text + "', Tipo_Sangre = '" + cbTipoSangre.Text + "'  WHERE ID = '" + cbClave.Text + "'";
                    cmd.Parameters.AddWithValue("@Foto", bytesFoto);
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "UPDATE elastosystem_rh SET Estatus = '" + cbEstatus.Text + "', Nombre = '" + txbNom.Text + "', Apellido_Paterno = '" + txbApPat.Text + "', Apellido_Materno = '" + txbApMa.Text + "', Sexo = '" + cbSex.Text + "', Fecha_Nacimiento = '" + tbFechaNacimiento.Text + "', Lugar_Nacimiento = '" + cbLugarNacimiento.Text + "', IMSS = '" + txbIM.Text + "', RFC = '" + txbRF.Text + "', CURP = '" + txCURP.Text + "', CPF = '" + txbCPFiscal.Text + "', Departamento = '" + cbDepartamento.Text + "', Puesto = '" + cbPuesto.Text + "', CalleYNum = '" + txbCalle.Text + "', Colonia = '" + txbColonia.Text + "' , Poblacion = '" + txbPoblacion.Text + "', EntidadFederativa = '" + cbEntidadFederativa.Text + "', Pais = '" + txbPais.Text + "', Correo1 = '" + txbCorreo1.Text + "', Correo2 = '" + txbCorreo2.Text + "', CP = '" + txbCP.Text + "', Telefono1 = '" + txbTelefono1.Text + "', Telefono2 = '" + txbTelefono2.Text + "', Nivel_Estudios = '" + cbNivelEstudios.Text + "', Profesion = '" + txbProfesion.Text + "', Estado_Civil = '" + cbEstadoCivil.Text + "', Tipo_Sangre = '" + cbTipoSangre.Text + "'  WHERE ID = '" + cbClave.Text + "'";
                    cmd.ExecuteNonQuery();
                }
                pbFoto.Image = null;
                MessageBox.Show("DATOS ACTUALIZADOS CON EXITO");
                cbEstatus.Text = String.Empty; txbNom.Clear(); txbApPat.Clear(); txbApMa.Clear(); cbSex.Text = String.Empty; tbFechaNacimiento.Clear(); cbLugarNacimiento.Text = String.Empty; txbIM.Clear(); txbIM.Clear(); txbRF.Clear(); txCURP.Clear(); txbCPFiscal.Clear(); cbDepartamento.Text = String.Empty; cbPuesto.Text = String.Empty; txbCalle.Clear(); txbColonia.Clear(); txbPoblacion.Clear(); cbEntidadFederativa.Text = String.Empty; txbPais.Clear(); txbCorreo1.Clear(); txbCorreo2.Clear(); txbCP.Clear(); txbTelefono1.Clear(); txbTelefono2.Clear(); cbNivelEstudios.Text = String.Empty; txbProfesion.Clear(); cbEstadoCivil.Text = String.Empty; cbTipoSangre.Text = String.Empty; lblNombre.Text = "NUEVO TRABAJADOR"; btnAgergarUsuario.Enabled = true; btnEditarUsuario.Enabled = false;
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
        private void MandarALlamarInformacion()
        {
            MySqlConnection mySqlConnection = new MySqlConnection(connectionString);
            mySqlConnection.Open();
            String codigo = cbClave.Text;
            MySqlDataReader reader = null;
            string sql = "SELECT Nombre, Apellido_Paterno, Apellido_Materno, Foto, Estatus, Sexo, Fecha_Nacimiento, CURP, Lugar_Nacimiento, IMSS, RFC, CPF, Departamento, Puesto, CalleYNum, Colonia, Poblacion, EntidadFederativa, Pais, Correo1, Correo2, CP, Telefono1, Telefono2, Nivel_Estudios, Profesion, Estado_Civil, Tipo_Sangre, Jornada_Completa, Salario_Dia, Salario_Hora, Horas_Dia, Dias_Semana, Fecha_Aplica, Forma_Pago FROM elastosystem_rh WHERE ID LIKE '" + codigo + "' ";
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
                        lblNombre.Text = $"{nombre} {apellidoPaterno} {apellidoMaterno}";
                        txbNom.Text = nombre;
                        txbApPat.Text = apellidoPaterno;
                        txbApMa.Text = apellidoMaterno;
                        try
                        {
                            byte[] imageData = (byte[])reader["Foto"];
                            using (MemoryStream ms = new MemoryStream(imageData))
                            {
                                pbFoto.Image = Image.FromStream(ms);
                            }
                        }
                        catch
                        {
                            pbFoto.Image = null;
                        }
                        cbEstatus.Text = reader.GetString("Estatus");
                        cbSex.Text = reader.GetString("Sexo");
                        tbFechaNacimiento.Text = reader.GetString("Fecha_Nacimiento");
                        txCURP.Text = reader.GetString("CURP");
                        cbLugarNacimiento.Text = reader.GetString("Lugar_Nacimiento");
                        txbIM.Text = reader.GetString("IMSS");
                        txbRF.Text = reader.GetString("RFC");
                        txbCPFiscal.Text = reader.GetString("CPF");
                        cbDepartamento.Text = reader.GetString("Departamento");
                        cbPuesto.Text = reader.GetString("Puesto");
                        txbCalle.Text = reader.GetString("CalleYNum");
                        txbColonia.Text = reader.GetString("Colonia");
                        txbPoblacion.Text = reader.GetString("Poblacion");
                        cbEntidadFederativa.Text = reader.GetString("EntidadFederativa");
                        txbPais.Text = reader.GetString("Pais");
                        txbCorreo1.Text = reader.GetString("Correo1");
                        txbCorreo2.Text = reader.GetString("Correo2");
                        txbCP.Text = reader.GetString("CP");
                        txbTelefono1.Text = reader.GetString("Telefono1");
                        txbTelefono2.Text = reader.GetString("Telefono2");
                        cbNivelEstudios.Text = reader.GetString("Nivel_Estudios");
                        txbProfesion.Text = reader.GetString("Profesion");
                        cbEstadoCivil.Text = reader.GetString("Estado_Civil");
                        cbTipoSangre.Text = reader.GetString("Tipo_Sangre");
                        int jcompleta = reader.GetInt32("Jornada_Completa");
                        if (jcompleta == 0)
                        {
                            rbJN.Checked = true;
                            txbSalarioxHora.ReadOnly = false;
                            txbHorasxDia.ReadOnly = false;
                            txbDiasxSemana.ReadOnly = false;
                        }
                        else
                        {
                            rbJS.Checked = true;
                        }
                        txbSalarioxDia.Text = reader.GetString("Salario_Dia");
                        txbSalarioxHora.Text = reader.GetString("Salario_Hora");
                        txbHorasxDia.Text = reader.GetString("Horas_Dia");
                        txbDiasxSemana.Text = reader.GetString("Dias_Semana");
                        txbFechaApli.Text = reader.GetString("Fecha_Aplica");
                        cbFormaPago.Text = reader.GetString("Forma_Pago");
                    }
                }
                else
                {
                    lblNombre.Text = "ERROR LLAMAR A SISTEMAS";
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            //NuevoUsuarioRH_Load(this, EventArgs.Empty);
        }

        private void rbJS_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnEditarUsuario_Click(object sender, EventArgs e)
        {
            ActualizarDatos();
            NuevoNoTrabajador();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            opc = 1;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos de imagen|*.png;*.jpg;*.jpeg;*.gif;*.bmp|Todos los archivos|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string rutaImagen = openFileDialog.FileName;

                try
                {
                    pbFoto.Image = Image.FromFile(rutaImagen);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar la imagen: " + ex.Message);
                }
            }
        }

        private void cbEstatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
