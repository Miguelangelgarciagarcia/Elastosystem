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
    public partial class SistemasPermisos : Form
    {
        public SistemasPermisos()
        {
            InitializeComponent();
        }

        string connectionString = "server=10.120.1.3 ; username=root; password=; database=elastosystem";

        private void MandarALlamarUsuarios()
        {
            MySqlConnection mySqlConnection = new MySqlConnection(connectionString);
            mySqlConnection.Open();
            MySqlDataReader reader = null;
            string sql = "SELECT Usuario FROM elastosystem_login";
            try
            {
                HashSet<string> unicos = new HashSet<string>();
                MySqlCommand comando = new MySqlCommand(sql, mySqlConnection);
                reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        cbUsuarios.Items.Add(reader["Usuario"].ToString());
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

        private void MandarALlamarNo()
        {
            MySqlConnection mySqlConnection = new MySqlConnection(connectionString);
            mySqlConnection.Open();
            String no = cbUsuarios.Text;
            MySqlDataReader reader = null;
            string sql = "SELECT ID FROM elastosystem_login WHERE Usuario ='" + no + "' ";
            try
            {
                HashSet<string> unicos = new HashSet<string>();
                MySqlCommand comando = new MySqlCommand(sql, mySqlConnection);
                reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        lblNumeroTemp.Text = reader.GetString(0);

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

        private void MandarALlamarPermisos()
        {
            string id = lblNumeroTemp.Text;
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            try
            {
                string query = "SELECT Almacen, Nuevo_Producto, Editar_Producto, Registrar_Existencias, Control_Almacen, Consulta_Salidas, Compras, ComprasReq, Indicador_Compras, ComprasAdmiReq, ComprasAdmiPro, ComprasReqEnviadas, Consumibles_Almacen, Consumibles_Almacen, Recursos_Humanos, Registro_Trabajador, Generar_Credencial, Sistemas, Requisicion, Permisos, Ventas, BuscarCotizacion, Clientes, CatalogoProductos, NuevaCotizacion, Produccion, Reporte, Maquinado, Solicitud_Maquinado, Pendientes_Maquinado FROM elastosystem_permisos_menu WHERE ID = @id";

                cmd.CommandText = query;
                cmd.Parameters.AddWithValue("@id", id);

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string almacenValue = reader["Almacen"].ToString();
                    if (almacenValue == "True")
                    {
                        chbAlmacen.Checked = true;
                        string nuevoproductoValue = reader["Nuevo_Producto"].ToString();
                        if (nuevoproductoValue == "True")
                        {
                            chbNuevoProducto.Checked = true;
                        }

                        string editarproductoValue = reader["Editar_Producto"].ToString();
                        if (editarproductoValue == "True")
                        {
                            chbEditarProducto.Checked = true;
                        }

                        string registrarexistenciasValue = reader["Registrar_Existencias"].ToString();
                        if (registrarexistenciasValue == "True")
                        {
                            chbRegistrarExistencias.Checked = true;
                        }

                        string controlalmacenValue = reader["Control_Almacen"].ToString();
                        if (controlalmacenValue == "True")
                        {
                            chbControlAlmacen.Checked = true;
                        }

                        string consultasalidasValue = reader["Consulta_Salidas"].ToString();
                        if (consultasalidasValue == "True")
                        {
                            chbConsultaSalidas.Checked = true;
                        }
                    }

                    string comprasValue = reader["Compras"].ToString();
                    if (comprasValue == "True")
                    {
                        chbCompras.Checked = true;
                        string comprasreqValue = reader["ComprasReq"].ToString();
                        if (comprasreqValue == "True")
                        {
                            chbReqCompra.Checked = true;
                        }

                        string indicadorcomprasValue = reader["Indicador_Compras"].ToString();
                        if (indicadorcomprasValue == "True")
                        {
                            chbIndicadorCompras.Checked = true;
                        }

                        string comprasadmireqValue = reader["ComprasAdmiReq"].ToString();
                        if (comprasadmireqValue == "True")
                        {
                            chbAdmiReq.Checked = true;
                        }

                        string comprasadmiproValue = reader["ComprasAdmiPro"].ToString();
                        if (comprasadmiproValue == "True")
                        {
                            chbAdmiProvee.Checked = true;
                        }

                        string comprasreqenviadasValue = reader["ComprasReqEnviadas"].ToString();
                        if (comprasreqenviadasValue == "True")
                        {
                            chbReqEnviadas.Checked = true;
                        }

                        string consumiblesalmacenValue = reader["Consumibles_Almacen"].ToString();
                        if (consumiblesalmacenValue == "True")
                        {
                            chbConsumiblesAlmacen.Checked = true;
                        }

                    }

                    string recursoshumanosValue = reader["Recursos_Humanos"].ToString();
                    if (recursoshumanosValue == "True")
                    {
                        chbRecursosHumanos.Checked = true;
                        string registrotrabajadorValue = reader["Registro_Trabajador"].ToString();
                        if (registrotrabajadorValue == "True")
                        {
                            chbRegistroTrabajador.Checked = true;
                        }

                        string generarcredencialValue = reader["Generar_Credencial"].ToString();
                        if (generarcredencialValue == "True")
                        {
                            chbGenerarCredencial.Checked = true;
                        }

                    }

                    string sistemasValue = reader["Sistemas"].ToString();
                    if (sistemasValue == "True")
                    {
                        chbSistemas.Checked = true;
                        string requisicionValue = reader["Requisicion"].ToString();
                        if (requisicionValue == "True")
                        {
                            chbRequisicion.Checked = true;
                        }

                        string permisosValue = reader["Permisos"].ToString();
                        if (permisosValue == "True")
                        {
                            chbPermisos.Checked = true;
                        }

                    }

                    string ventasValue = reader["Ventas"].ToString();
                    if (ventasValue == "True")
                    {
                        chbVentas.Checked = true;
                        string buscarcotizacionValue = reader["BuscarCotizacion"].ToString();
                        if (buscarcotizacionValue == "True")
                        {
                            chbBuscarCotizacion.Checked = true;
                        }

                        string clientesValue = reader["Clientes"].ToString();
                        if (clientesValue == "True")
                        {
                            chbClientes.Checked = true;
                        }

                        string catalogoproductosValue = reader["CatalogoProductos"].ToString();
                        if (catalogoproductosValue == "True")
                        {
                            chbCatalogoProductos.Checked = true;
                        }

                        string nuevacotizacionValue = reader["NuevaCotizacion"].ToString();
                        if (nuevacotizacionValue == "True")
                        {
                            chbNuevaCotizacion.Checked = true;
                        }

                    }

                    string produccionValue = reader["Produccion"].ToString();
                    if (produccionValue == "True")
                    {
                        chbProduccion.Checked = true;
                        string reporteValue = reader["Reporte"].ToString();
                        if (reporteValue == "True")
                        {
                            chbReporteProduccion.Checked = true;
                        }

                    }

                    string maquinadoValue = reader["Maquinado"].ToString();
                    if (maquinadoValue == "True")
                    {
                        chbMaquinado.Checked = true;
                        string solicitud_maquinadoValue = reader["Solicitud_Maquinado"].ToString();
                        if (solicitud_maquinadoValue == "True")
                        {
                            chbSolicitudMaquinado.Checked = true;
                        }

                        string pendientes_maquinadoValue = reader["Pendientes_Maquinado"].ToString();
                        if (pendientes_maquinadoValue == "True")
                        {
                            chbPendientesMaquinado.Checked = true;
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
                conn.Close();
            }
        }

        private void LimpiarCheckBox()
        {
            chbAlmacen.Checked = false;
            chbNuevoProducto.Checked = false;
            chbEditarProducto.Checked = false;
            chbRegistrarExistencias.Checked = false;
            chbControlAlmacen.Checked = false;
            chbConsultaSalidas.Checked = false;
            chbCompras.Checked = false;
            chbConsumiblesAlmacen.Checked = false;
            chbReqCompra.Checked = false;
            chbAdmiReq.Checked = false;
            chbAdmiProvee.Checked = false;
            chbReqEnviadas.Checked = false;
            chbIndicadorCompras.Checked = false;
            chbConsumiblesAlmacen.Checked = false;
            chbRecursosHumanos.Checked = false;
            chbRegistroTrabajador.Checked = false;
            chbGenerarCredencial.Checked = false;
            chbSistemas.Checked = false;
            chbRequisicion.Checked = false;
            chbPermisos.Checked = false;
            chbVentas.Checked = false;
            chbBuscarCotizacion.Checked = false;
            chbClientes.Checked = false;
            chbCatalogoProductos.Checked = false;
            chbNuevaCotizacion.Checked = false;
            chbProduccion.Checked = false;
            chbReporteProduccion.Checked = false;
            chbMaquinado.Checked = false;
            chbSolicitudMaquinado.Checked = false;
            chbPendientesMaquinado.Checked = false;
        }

        private void ActualizarPermisos()
        {
            bool boolAlmacen = chbAlmacen.Checked;
            bool boolNuevoProducto = chbNuevoProducto.Checked;
            bool boolEditarProducto = chbEditarProducto.Checked;
            bool boolRegistrarExistencias = chbRegistrarExistencias.Checked;
            bool boolControlAlmacen = chbControlAlmacen.Checked;
            bool boolConsultaSalidas = chbConsultaSalidas.Checked;

            bool boolCompras = chbCompras.Checked;
            bool boolConsumiblesAlmacen = chbConsumiblesAlmacen.Checked;
            bool boolRequerimientosCompras = chbReqCompra.Checked;
            bool boolAdministrarReq = chbAdmiReq.Checked;
            bool boolAdmiProvee = chbAdmiProvee.Checked;
            bool boolReqEnviadas = chbReqEnviadas.Checked;
            bool boolIndicadorCompras = chbIndicadorCompras.Checked;

            bool boolRecursosHumanos = chbRecursosHumanos.Checked;
            bool boolRegistroTrabajador = chbRegistroTrabajador.Checked;
            bool boolGenerarCredencial = chbGenerarCredencial.Checked;

            bool boolSistemas = chbSistemas.Checked;
            bool boolRequisicion = chbRequisicion.Checked;
            bool boolPermisos = chbPermisos.Checked;

            bool boolVentas = chbVentas.Checked;
            bool boolBuscarCotizacion = chbBuscarCotizacion.Checked;
            bool boolClientes = chbClientes.Checked;
            bool boolCatalogoProductos = chbCatalogoProductos.Checked;
            bool boolNuevaCotizacion = chbNuevaCotizacion.Checked;

            bool boolProduccion = chbProduccion.Checked;
            bool boolReporte = chbReporteProduccion.Checked;

            bool boolMaquinado = chbMaquinado.Checked;
            bool boolSolicitud_Maquinado = chbSolicitudMaquinado.Checked;
            bool boolPendientes_Maquinado = chbPendientesMaquinado.Checked;

            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand();
            try
            {
                cmd.Connection = conn;
                cmd.CommandText = "UPDATE elastosystem_permisos_menu SET Almacen = " + boolAlmacen + ", Nuevo_Producto = " + boolNuevoProducto + ", Editar_Producto = " + boolEditarProducto + ", Registrar_Existencias = " + boolRegistrarExistencias + ", Control_Almacen = " + boolControlAlmacen + ", Consulta_Salidas = " + boolConsultaSalidas + ", Compras = " + boolCompras + ", ComprasReq = " + boolRequerimientosCompras + ", Indicador_Compras = " + boolIndicadorCompras + ", ComprasAdmiReq = " + boolAdministrarReq + ", ComprasAdmiPro = " + boolAdmiProvee + ", ComprasReqEnviadas = " + boolReqEnviadas + ", Consumibles_Almacen = " + boolConsumiblesAlmacen + ", Recursos_Humanos = " + boolRecursosHumanos + ", Registro_Trabajador = " + boolRegistroTrabajador + ", Generar_Credencial = " + boolGenerarCredencial + ", Sistemas = " + boolSistemas + ", Requisicion = " + boolRequisicion + ", Permisos = " + boolPermisos + ", Ventas = " + boolVentas + ", BuscarCotizacion = " + boolBuscarCotizacion + ", Clientes = " + boolClientes + ", CatalogoProductos = " + boolCatalogoProductos + ", NuevaCotizacion = " + boolNuevaCotizacion + ", Produccion = " + boolProduccion + ", Reporte = " + boolReporte + ", Maquinado = " + boolMaquinado + ", Solicitud_Maquinado = " + boolSolicitud_Maquinado + ", Pendientes_Maquinado = " + boolPendientes_Maquinado + " WHERE ID = '" + lblNumeroTemp.Text + "'";
                cmd.ExecuteNonQuery();
                MessageBox.Show("DATOS ACTUALIZADOS CON EXITO");
                LimpiarCheckBox();
                cbUsuarios.Text = String.Empty;
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
        private void SistemasPermisos_Load(object sender, EventArgs e)
        {
            MandarALlamarUsuarios();
        }

        private void cbUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            LimpiarCheckBox();
            MandarALlamarNo();
            MandarALlamarPermisos();
        }

        private void chbAlmacen_CheckedChanged(object sender, EventArgs e)
        {
            if (chbAlmacen.Checked == false)
            {
                chbNuevoProducto.Checked = false;
                chbEditarProducto.Checked = false;
                chbRegistrarExistencias.Checked = false;
                chbControlAlmacen.Checked = false;
                chbConsultaSalidas.Checked = false;
            }
        }

        private void chbCompras_CheckedChanged(object sender, EventArgs e)
        {
            if (chbCompras.Checked == false)
            {
                chbIndicadorCompras.Checked = false;
                chbReqCompra.Checked = false;
                chbAdmiReq.Checked = false;
                chbAdmiProvee.Checked = false;
                chbReqEnviadas.Checked = false;
                chbConsumiblesAlmacen.Checked = false;
            }
        }

        private void chbRecursosHumanos_CheckedChanged(object sender, EventArgs e)
        {
            if (chbRecursosHumanos.Checked == false)
            {
                chbRegistroTrabajador.Checked = false;
                chbGenerarCredencial.Checked = false;
            }
        }

        private void chbSistemas_CheckedChanged(object sender, EventArgs e)
        {
            if (chbSistemas.Checked == false)
            {
                chbRequisicion.Checked = false;
                chbPermisos.Checked = false;
            }
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            ActualizarPermisos();
            LimpiarCheckBox();
        }

        private void chbNuevoProducto_CheckedChanged(object sender, EventArgs e)
        {
            if (chbNuevoProducto.Checked == true)
            {
                chbAlmacen.Checked = true;
            }
        }

        private void chbEditarProducto_CheckedChanged(object sender, EventArgs e)
        {
            if (chbEditarProducto.Checked == true)
            {
                chbAlmacen.Checked = true;
            }
        }

        private void chbRegistrarExistencias_CheckedChanged(object sender, EventArgs e)
        {
            if (chbRegistrarExistencias.Checked == true)
            {
                chbAlmacen.Checked = true;
            }
        }

        private void chbControlAlmacen_CheckedChanged(object sender, EventArgs e)
        {
            if (chbControlAlmacen.Checked == true)
            {
                chbAlmacen.Checked = true;
            }
        }

        private void chbConsultaSalidas_CheckedChanged(object sender, EventArgs e)
        {
            if (chbConsultaSalidas.Checked == true)
            {
                chbAlmacen.Checked = true;
            }
        }

        private void chbIndicadorCompras_CheckedChanged(object sender, EventArgs e)
        {
            if (chbIndicadorCompras.Checked == true)
            {
                chbCompras.Checked = true;
            }
        }

        private void chbConsumiblesAlmacen_CheckedChanged(object sender, EventArgs e)
        {
            if (chbConsumiblesAlmacen.Checked == true)
            {
                chbCompras.Checked = true;
            }
        }

        private void chbRegistroTrabajador_CheckedChanged(object sender, EventArgs e)
        {
            if (chbRegistroTrabajador.Checked == true)
            {
                chbRecursosHumanos.Checked = true;
            }
        }

        private void chbGenerarCredencial_CheckedChanged(object sender, EventArgs e)
        {
            if (chbGenerarCredencial.Checked == true)
            {
                chbRecursosHumanos.Checked = true;
            }
        }

        private void chbRequisicion_CheckedChanged(object sender, EventArgs e)
        {
            if (chbRequisicion.Checked == true)
            {
                chbSistemas.Checked = true;
            }
        }

        private void chbPermisos_CheckedChanged(object sender, EventArgs e)
        {
            if (chbPermisos.Checked == true)
            {
                chbSistemas.Checked = true;
            }
        }

        private void chbVentas_CheckedChanged(object sender, EventArgs e)
        {
            if (chbVentas.Checked == false)
            {
                chbBuscarCotizacion.Checked = false;
                chbClientes.Checked = false;
                chbCatalogoProductos.Checked = false;
                chbNuevaCotizacion.Checked = false;
            }
        }

        private void chbClientes_CheckedChanged(object sender, EventArgs e)
        {
            if (chbClientes.Checked == true)
            {
                chbVentas.Checked = true;
            }
        }

        private void chbProduccion_CheckedChanged(object sender, EventArgs e)
        {
            if (chbProduccion.Checked == false)
            {
                chbReporteProduccion.Checked = false;
            }
        }

        private void chbReporteProduccion_CheckedChanged(object sender, EventArgs e)
        {
            if (chbReporteProduccion.Checked == true)
            {
                chbProduccion.Checked = true;
            }
        }

        private void chbReqCompra_CheckedChanged(object sender, EventArgs e)
        {
            if (chbReqCompra.Checked == true)
            {
                chbCompras.Checked = true;
            }
        }

        private void chbAdmiReq_CheckedChanged(object sender, EventArgs e)
        {
            if (chbAdmiReq.Checked == true)
            {
                chbCompras.Checked = true;
            }
        }

        private void chbAdmiProvee_CheckedChanged(object sender, EventArgs e)
        {
            if (chbAdmiProvee.Checked == true)
            {
                chbCompras.Checked = true;
            }
        }

        private void chbReqEnviadas_CheckedChanged(object sender, EventArgs e)
        {
            if (chbReqEnviadas.Checked == true)
            {
                chbCompras.Checked = true;
            }
        }

        private void chbBuscarCotizacion_CheckedChanged(object sender, EventArgs e)
        {
            if (chbClientes.Checked == true)
            {
                chbVentas.Checked = true;
            }
        }

        private void chbCatalogoProductos_CheckedChanged(object sender, EventArgs e)
        {
            if (chbClientes.Checked == true)
            {
                chbVentas.Checked = true;
            }
        }

        private void chbNuevaCotizacion_CheckedChanged(object sender, EventArgs e)
        {
            if (chbClientes.Checked == true)
            {
                chbVentas.Checked = true;
            }
        }

        private void chbMaquinado_CheckedChanged(object sender, EventArgs e)
        {
            if (chbMaquinado.Checked == false)
            {
                chbSolicitudMaquinado.Checked = false;
                chbPendientesMaquinado.Checked = false;
            }
        }

        private void chbSolicitudMaquinado_CheckedChanged(object sender, EventArgs e)
        {
            if (chbSolicitudMaquinado.Checked == true)
            {
                chbMaquinado.Checked = true;
            }
        }

        private void chbPendientesMaquinado_CheckedChanged(object sender, EventArgs e)
        {
            if (chbPendientesMaquinado.Checked == true)
            {
                chbMaquinado.Checked = true;
            }
        }
    }
}
