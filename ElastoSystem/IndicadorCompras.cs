using DocumentFormat.OpenXml.Vml;
using DocumentFormat.OpenXml.Wordprocessing;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElastoSystem
{
    public partial class IndicadorCompras : Form
    {
        public IndicadorCompras()
        {
            InitializeComponent();
        }
        string connectionString = "server=10.120.1.3 ; username=root; password=; database=elastotec";
        private void IndicadorCompras_Load(object sender, EventArgs e)
        {
            string tabla = "SELECT FOLIO_REQ, FECHA_REQ, FECHA_REF FROM indicador_compras";
            MySqlDataAdapter mySqlAdapter = new MySqlDataAdapter(tabla, connectionString);
            DataTable dt = new DataTable();
            mySqlAdapter.Fill(dt);
            dgv.DataSource = dt;
            
            if (dgv.Columns.Contains("FECHA_REQ"))
            {
                dgv.Columns["FECHA_REQ"].HeaderText = "Fecha de Requisición";
            }

            // Cambiar el encabezado de la columna FECHA_REF
            if (dgv.Columns.Contains("FECHA_REF"))
            {
                dgv.Columns["FECHA_REF"].HeaderText = "Fecha de OC";
            }

            if (dgv.Columns.Contains("FOLIO_REQ"))
            {
                dgv.Columns["FOLIO_REQ"].HeaderText = "Folio";
            }

            // Ordenar por la columna FECHA_REQ
            if (dgv.Columns.Contains("FECHA_REQ"))
            {
                DataGridViewColumn columna = dgv.Columns["FECHA_REQ"];

                if (columna != null)
                {
                    dgv.Sort(columna, System.ComponentModel.ListSortDirection.Descending);
                }
            }


        }
        private void indicecompra()
        {
            int anio = Convert.ToInt32(cbanio.SelectedItem);
            double promedio = 0;
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "DELETE FROM indicador_comprastemp";
            cmd.ExecuteNonQuery();
            string mes = cbbimestre.Text;
            if (mes == "Enero-Febrero")
            {
                cmd.CommandText = $"INSERT INTO indicador_comprastemp (fecha_req, fecha_ref, diferencia_dias_sin_fin_de_semana) " +
                              $"SELECT fecha_req, fecha_ref, " +
                              $"DATEDIFF(fecha_ref, fecha_req) - (DATEDIFF(fecha_ref, fecha_req) DIV 7 * 2) - " +
                              $"CASE " +
                              $"WHEN WEEKDAY(fecha_req) = 5 AND WEEKDAY(fecha_ref) = 6 THEN 1 " +
                              $"WHEN WEEKDAY(fecha_req) = 5 AND WEEKDAY(fecha_ref) = 0 THEN 2 " +
                              $"WHEN WEEKDAY(fecha_req) = 6 AND WEEKDAY(fecha_ref) = 0 THEN 1 " +
                              $"ELSE 0 " +
                              $"END AS diferencia_dias_sin_fin_de_semana " +
                              $"FROM indicador_compras " +
                              $"WHERE YEAR(fecha_req) = {anio} AND YEAR(fecha_ref) = {anio} " +
                              $"AND fecha_req BETWEEN '{anio}-01-01' AND '{anio}-02-31' " +
                              $"AND fecha_ref BETWEEN '{anio}-01-01' AND '{anio}-02-31';";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "SELECT AVG(diferencia_dias_sin_fin_de_semana) AS promedio_diferencias FROM indicador_comprastemp;";
                
                object resultado = cmd.ExecuteScalar();
                if (resultado != null && resultado != DBNull.Value)
                {
                    promedio = Convert.ToDouble(resultado);
                }
                txbic.Text = promedio.ToString();
                cmd.CommandText = "SELECT COUNT(*) FROM indicador_comprastemp";
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                lblOCTotal.Text = "Las Ordenes de Compra correspondiente a este bimestre fueron: " + count.ToString();
                conn.Close();
            }
            else if (mes == "Marzo-Abril")
            {
                cmd.CommandText = $"INSERT INTO indicador_comprastemp (fecha_req, fecha_ref, diferencia_dias_sin_fin_de_semana) " +
                              $"SELECT fecha_req, fecha_ref, " +
                              $"DATEDIFF(fecha_ref, fecha_req) - (DATEDIFF(fecha_ref, fecha_req) DIV 7 * 2) - " +
                              $"CASE " +
                              $"WHEN WEEKDAY(fecha_req) = 5 AND WEEKDAY(fecha_ref) = 6 THEN 1 " +
                              $"WHEN WEEKDAY(fecha_req) = 5 AND WEEKDAY(fecha_ref) = 0 THEN 2 " +
                              $"WHEN WEEKDAY(fecha_req) = 6 AND WEEKDAY(fecha_ref) = 0 THEN 1 " +
                              $"ELSE 0 " +
                              $"END AS diferencia_dias_sin_fin_de_semana " +
                              $"FROM indicador_compras " +
                              $"WHERE YEAR(fecha_req) = {anio} AND YEAR(fecha_ref) = {anio} " +
                              $"AND fecha_req BETWEEN '{anio}-03-01' AND '{anio}-04-31' " +
                              $"AND fecha_ref BETWEEN '{anio}-03-01' AND '{anio}-04-31';";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "SELECT AVG(diferencia_dias_sin_fin_de_semana) AS promedio_diferencias FROM indicador_comprastemp;";
                object resultado = cmd.ExecuteScalar();
                if (resultado != null && resultado != DBNull.Value)
                {
                    promedio = Convert.ToDouble(resultado);
                }
                txbic.Text = promedio.ToString();
                cmd.CommandText = "SELECT COUNT(*) FROM indicador_comprastemp";
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                lblOCTotal.Text = "Las Ordenes de Compra correspondiente a este bimestre fueron: " + count.ToString();
                conn.Close();
            }
            else if (mes == "Mayo-Junio")
            {
                cmd.CommandText = $"INSERT INTO indicador_comprastemp (fecha_req, fecha_ref, diferencia_dias_sin_fin_de_semana) " +
                              $"SELECT fecha_req, fecha_ref, " +
                              $"DATEDIFF(fecha_ref, fecha_req) - (DATEDIFF(fecha_ref, fecha_req) DIV 7 * 2) - " +
                              $"CASE " +
                              $"WHEN WEEKDAY(fecha_req) = 5 AND WEEKDAY(fecha_ref) = 6 THEN 1 " +
                              $"WHEN WEEKDAY(fecha_req) = 5 AND WEEKDAY(fecha_ref) = 0 THEN 2 " +
                              $"WHEN WEEKDAY(fecha_req) = 6 AND WEEKDAY(fecha_ref) = 0 THEN 1 " +
                              $"ELSE 0 " +
                              $"END AS diferencia_dias_sin_fin_de_semana " +
                              $"FROM indicador_compras " +
                              $"WHERE YEAR(fecha_req) = {anio} AND YEAR(fecha_ref) = {anio} " +
                              $"AND fecha_req BETWEEN '{anio}-05-01' AND '{anio}-06-31' " +
                              $"AND fecha_ref BETWEEN '{anio}-05-01' AND '{anio}-06-31';";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "SELECT AVG(diferencia_dias_sin_fin_de_semana) AS promedio_diferencias FROM indicador_comprastemp;";
                object resultado = cmd.ExecuteScalar();
                if (resultado != null && resultado != DBNull.Value)
                {
                    promedio = Convert.ToDouble(resultado);
                }
                txbic.Text = promedio.ToString();
                cmd.CommandText = "SELECT COUNT(*) FROM indicador_comprastemp";
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                lblOCTotal.Text = "Las Ordenes de Compra correspondiente a este bimestre fueron: " + count.ToString();
                conn.Close();
            }
            else if (mes == "Julio-Agosto")
            {
                cmd.CommandText = $"INSERT INTO indicador_comprastemp (fecha_req, fecha_ref, diferencia_dias_sin_fin_de_semana) " +
                              $"SELECT fecha_req, fecha_ref, " +
                              $"DATEDIFF(fecha_ref, fecha_req) - (DATEDIFF(fecha_ref, fecha_req) DIV 7 * 2) - " +
                              $"CASE " +
                              $"WHEN WEEKDAY(fecha_req) = 5 AND WEEKDAY(fecha_ref) = 6 THEN 1 " +
                              $"WHEN WEEKDAY(fecha_req) = 5 AND WEEKDAY(fecha_ref) = 0 THEN 2 " +
                              $"WHEN WEEKDAY(fecha_req) = 6 AND WEEKDAY(fecha_ref) = 0 THEN 1 " +
                              $"ELSE 0 " +
                              $"END AS diferencia_dias_sin_fin_de_semana " +
                              $"FROM indicador_compras " +
                              $"WHERE YEAR(fecha_req) = {anio} AND YEAR(fecha_ref) = {anio} " +
                              $"AND fecha_req BETWEEN '{anio}-07-01' AND '{anio}-08-31' " +
                              $"AND fecha_ref BETWEEN '{anio}-07-01' AND '{anio}-08-31';";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "SELECT AVG(diferencia_dias_sin_fin_de_semana) AS promedio_diferencias FROM indicador_comprastemp;";
                object resultado = cmd.ExecuteScalar();
                if (resultado != null && resultado != DBNull.Value)
                {
                    promedio = Convert.ToDouble(resultado);
                }
                txbic.Text = promedio.ToString();
                cmd.CommandText = "SELECT COUNT(*) FROM indicador_comprastemp";
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                lblOCTotal.Text = "Las Ordenes de Compra correspondiente a este bimestre fueron: " + count.ToString();
                conn.Close();
            }
            else if (mes == "Septiembre-Octubre")
            {
                cmd.CommandText = $"INSERT INTO indicador_comprastemp (fecha_req, fecha_ref, diferencia_dias_sin_fin_de_semana) " +
                              $"SELECT fecha_req, fecha_ref, " +
                              $"DATEDIFF(fecha_ref, fecha_req) - (DATEDIFF(fecha_ref, fecha_req) DIV 7 * 2) - " +
                              $"CASE " +
                              $"WHEN WEEKDAY(fecha_req) = 5 AND WEEKDAY(fecha_ref) = 6 THEN 1 " +
                              $"WHEN WEEKDAY(fecha_req) = 5 AND WEEKDAY(fecha_ref) = 0 THEN 2 " +
                              $"WHEN WEEKDAY(fecha_req) = 6 AND WEEKDAY(fecha_ref) = 0 THEN 1 " +
                              $"ELSE 0 " +
                              $"END AS diferencia_dias_sin_fin_de_semana " +
                              $"FROM indicador_compras " +
                              $"WHERE YEAR(fecha_req) = {anio} AND YEAR(fecha_ref) = {anio} " +
                              $"AND fecha_req BETWEEN '{anio}-09-01' AND '{anio}-10-31' " +
                              $"AND fecha_ref BETWEEN '{anio}-09-01' AND '{anio}-10-31';";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "SELECT AVG(diferencia_dias_sin_fin_de_semana) AS promedio_diferencias FROM indicador_comprastemp;";
                object resultado = cmd.ExecuteScalar();
                if (resultado != null && resultado != DBNull.Value)
                {
                    promedio = Convert.ToDouble(resultado);
                }
                txbic.Text = promedio.ToString();
                cmd.CommandText = "SELECT COUNT(*) FROM indicador_comprastemp";
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                lblOCTotal.Text = "Las Ordenes de Compra correspondiente a este bimestre fueron: " + count.ToString();
                conn.Close();
            }
            else
            {
                cmd.CommandText = $"INSERT INTO indicador_comprastemp (fecha_req, fecha_ref, diferencia_dias_sin_fin_de_semana) " +
                              $"SELECT fecha_req, fecha_ref, " +
                              $"DATEDIFF(fecha_ref, fecha_req) - (DATEDIFF(fecha_ref, fecha_req) DIV 7 * 2) - " +
                              $"CASE " +
                              $"WHEN WEEKDAY(fecha_req) = 5 AND WEEKDAY(fecha_ref) = 6 THEN 1 " +
                              $"WHEN WEEKDAY(fecha_req) = 5 AND WEEKDAY(fecha_ref) = 0 THEN 2 " +
                              $"WHEN WEEKDAY(fecha_req) = 6 AND WEEKDAY(fecha_ref) = 0 THEN 1 " +
                              $"ELSE 0 " +
                              $"END AS diferencia_dias_sin_fin_de_semana " +
                              $"FROM indicador_compras " +
                              $"WHERE YEAR(fecha_req) = {anio} AND YEAR(fecha_ref) = {anio} " +
                              $"AND fecha_req BETWEEN '{anio}-11-01' AND '{anio}-12-31' " +
                              $"AND fecha_ref BETWEEN '{anio}-11-01' AND '{anio}-12-31';";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "SELECT AVG(diferencia_dias_sin_fin_de_semana) AS promedio_diferencias FROM indicador_comprastemp;";
                object resultado = cmd.ExecuteScalar();
                if (resultado != null && resultado != DBNull.Value)
                {
                    promedio = Convert.ToDouble(resultado);
                }
                txbic.Text = promedio.ToString();
                cmd.CommandText = "SELECT COUNT(*) FROM indicador_comprastemp";
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                lblOCTotal.Text = "Las Ordenes de Compra correspondiente a este bimestre fueron: " + count.ToString();
                conn.Close();
            }
        }
        private void cbbimestre_SelectedIndexChanged(object sender, EventArgs e)
        {
            indicecompra();

        }

        private void cbanio_SelectedIndexChanged(object sender, EventArgs e)
        {
            object selectedValue = cbbimestre.SelectedItem;
            if (selectedValue == null)
            {

            }
            else
            {
                indicecompra();
            }

        }

        private void txbic_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(txbic.Text, out double valor))
            {
                if (valor <= 3)
                {
                    txbic.BackColor = System.Drawing.Color.Green;
                    txbic.ForeColor = System.Drawing.Color.White;
                }
                else
                {
                    txbic.BackColor = System.Drawing.Color.Red;
                    txbic.ForeColor = System.Drawing.Color.White;
                }
            }
        }
    }
}
