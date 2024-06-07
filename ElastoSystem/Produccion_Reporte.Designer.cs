namespace ElastoSystem
{
    partial class Produccion_Reporte
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            label1 = new Label();
            panel5 = new Panel();
            dtpTiempoFinal = new DateTimePicker();
            label10 = new Label();
            dtpTiempoInicio = new DateTimePicker();
            lblFolio = new Label();
            label9 = new Label();
            label2 = new Label();
            cbDecimal = new ComboBox();
            cbHora = new ComboBox();
            cbUnidad = new ComboBox();
            label8 = new Label();
            txbClave = new TextBox();
            txbFamilia = new TextBox();
            label7 = new Label();
            label6 = new Label();
            cbOperacion = new ComboBox();
            label5 = new Label();
            cbProducto = new ComboBox();
            lblNombreTrabajador = new Label();
            label3 = new Label();
            txbNoTrabajador = new TextBox();
            label4 = new Label();
            btnRegistrar = new Button();
            txbCantidad = new TextBox();
            lblfecha = new Label();
            label11 = new Label();
            fecha = new System.Windows.Forms.Timer(components);
            panel1 = new Panel();
            dgvReporte = new DataGridView();
            panel5.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReporte).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Montserrat", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(37, 26);
            label1.Name = "label1";
            label1.Size = new Size(478, 44);
            label1.TabIndex = 7;
            label1.Text = "REPORTE DE PRODUCCIÓN";
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(3, 42, 76);
            panel5.Controls.Add(dtpTiempoFinal);
            panel5.Controls.Add(label10);
            panel5.Controls.Add(dtpTiempoInicio);
            panel5.Controls.Add(lblFolio);
            panel5.Controls.Add(label9);
            panel5.Controls.Add(label2);
            panel5.Controls.Add(cbDecimal);
            panel5.Controls.Add(cbHora);
            panel5.Controls.Add(cbUnidad);
            panel5.Controls.Add(label8);
            panel5.Controls.Add(txbClave);
            panel5.Controls.Add(txbFamilia);
            panel5.Controls.Add(label7);
            panel5.Controls.Add(label6);
            panel5.Controls.Add(cbOperacion);
            panel5.Controls.Add(label5);
            panel5.Controls.Add(cbProducto);
            panel5.Controls.Add(lblNombreTrabajador);
            panel5.Controls.Add(label3);
            panel5.Controls.Add(txbNoTrabajador);
            panel5.Controls.Add(label4);
            panel5.Controls.Add(btnRegistrar);
            panel5.Controls.Add(txbCantidad);
            panel5.Location = new Point(37, 111);
            panel5.Name = "panel5";
            panel5.Size = new Size(1240, 285);
            panel5.TabIndex = 17;
            // 
            // dtpTiempoFinal
            // 
            dtpTiempoFinal.DropDownAlign = LeftRightAlignment.Right;
            dtpTiempoFinal.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtpTiempoFinal.Format = DateTimePickerFormat.Time;
            dtpTiempoFinal.ImeMode = ImeMode.NoControl;
            dtpTiempoFinal.Location = new Point(495, 212);
            dtpTiempoFinal.Name = "dtpTiempoFinal";
            dtpTiempoFinal.ShowUpDown = true;
            dtpTiempoFinal.Size = new Size(124, 26);
            dtpTiempoFinal.TabIndex = 30;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.White;
            label10.Location = new Point(353, 215);
            label10.Name = "label10";
            label10.Size = new Size(123, 22);
            label10.TabIndex = 29;
            label10.Text = "Tiempo Final:";
            // 
            // dtpTiempoInicio
            // 
            dtpTiempoInicio.DropDownAlign = LeftRightAlignment.Right;
            dtpTiempoInicio.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtpTiempoInicio.Format = DateTimePickerFormat.Time;
            dtpTiempoInicio.ImeMode = ImeMode.NoControl;
            dtpTiempoInicio.Location = new Point(190, 212);
            dtpTiempoInicio.Name = "dtpTiempoInicio";
            dtpTiempoInicio.ShowUpDown = true;
            dtpTiempoInicio.Size = new Size(124, 26);
            dtpTiempoInicio.TabIndex = 20;
            dtpTiempoInicio.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // lblFolio
            // 
            lblFolio.AutoSize = true;
            lblFolio.BackColor = Color.Transparent;
            lblFolio.Font = new Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblFolio.ForeColor = Color.White;
            lblFolio.Location = new Point(1114, 35);
            lblFolio.Name = "lblFolio";
            lblFolio.Size = new Size(85, 22);
            lblFolio.TabIndex = 28;
            lblFolio.Text = "2400000";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(921, 247);
            label9.Name = "label9";
            label9.Size = new Size(45, 22);
            label9.TabIndex = 23;
            label9.Text = "HRS";
            label9.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(1054, 35);
            label2.Name = "label2";
            label2.Size = new Size(54, 22);
            label2.TabIndex = 27;
            label2.Text = "Folio:";
            // 
            // cbDecimal
            // 
            cbDecimal.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbDecimal.FormattingEnabled = true;
            cbDecimal.Items.AddRange(new object[] { "0", "5" });
            cbDecimal.Location = new Point(873, 244);
            cbDecimal.Name = "cbDecimal";
            cbDecimal.Size = new Size(39, 30);
            cbDecimal.TabIndex = 22;
            cbDecimal.Visible = false;
            // 
            // cbHora
            // 
            cbHora.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbHora.FormattingEnabled = true;
            cbHora.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
            cbHora.Location = new Point(815, 244);
            cbHora.Name = "cbHora";
            cbHora.Size = new Size(40, 30);
            cbHora.TabIndex = 19;
            cbHora.Visible = false;
            cbHora.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // cbUnidad
            // 
            cbUnidad.DropDownStyle = ComboBoxStyle.DropDownList;
            cbUnidad.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbUnidad.FormattingEnabled = true;
            cbUnidad.Items.AddRange(new object[] { "Piezas", "Cajas", "Kilos" });
            cbUnidad.Location = new Point(456, 167);
            cbUnidad.Name = "cbUnidad";
            cbUnidad.Size = new Size(211, 30);
            cbUnidad.TabIndex = 26;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(858, 251);
            label8.Name = "label8";
            label8.Size = new Size(14, 22);
            label8.TabIndex = 21;
            label8.Text = ".";
            label8.Visible = false;
            // 
            // txbClave
            // 
            txbClave.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txbClave.Location = new Point(854, 181);
            txbClave.Name = "txbClave";
            txbClave.Size = new Size(157, 27);
            txbClave.TabIndex = 25;
            txbClave.Visible = false;
            // 
            // txbFamilia
            // 
            txbFamilia.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txbFamilia.Location = new Point(691, 181);
            txbFamilia.Name = "txbFamilia";
            txbFamilia.Size = new Size(157, 27);
            txbFamilia.TabIndex = 24;
            txbFamilia.Visible = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(43, 215);
            label7.Name = "label7";
            label7.Size = new Size(127, 22);
            label7.TabIndex = 20;
            label7.Text = "Tiempo Inicio:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(43, 125);
            label6.Name = "label6";
            label6.Size = new Size(100, 22);
            label6.TabIndex = 18;
            label6.Text = "Operacion:";
            // 
            // cbOperacion
            // 
            cbOperacion.DropDownStyle = ComboBoxStyle.DropDownList;
            cbOperacion.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbOperacion.FormattingEnabled = true;
            cbOperacion.Location = new Point(190, 122);
            cbOperacion.Name = "cbOperacion";
            cbOperacion.Size = new Size(1009, 30);
            cbOperacion.TabIndex = 17;
            cbOperacion.SelectedIndexChanged += cbOperacion_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(43, 80);
            label5.Name = "label5";
            label5.Size = new Size(91, 22);
            label5.TabIndex = 16;
            label5.Text = "Producto:";
            // 
            // cbProducto
            // 
            cbProducto.DropDownStyle = ComboBoxStyle.DropDownList;
            cbProducto.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbProducto.FormattingEnabled = true;
            cbProducto.Items.AddRange(new object[] { "Asesoría", "Base De Datos", "Capacitación", "Hardware", "Infraestructura", "Mantenimiento", "Software", "Otro..." });
            cbProducto.Location = new Point(190, 77);
            cbProducto.Name = "cbProducto";
            cbProducto.Size = new Size(1009, 30);
            cbProducto.TabIndex = 15;
            cbProducto.SelectedIndexChanged += cbProducto_SelectedIndexChanged;
            // 
            // lblNombreTrabajador
            // 
            lblNombreTrabajador.AutoSize = true;
            lblNombreTrabajador.BackColor = Color.Transparent;
            lblNombreTrabajador.Font = new Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombreTrabajador.ForeColor = Color.White;
            lblNombreTrabajador.Location = new Point(362, 35);
            lblNombreTrabajador.Name = "lblNombreTrabajador";
            lblNombreTrabajador.Size = new Size(173, 22);
            lblNombreTrabajador.TabIndex = 14;
            lblNombreTrabajador.Text = "Nombre Trabajador";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(43, 35);
            label3.Name = "label3";
            label3.Size = new Size(132, 22);
            label3.TabIndex = 3;
            label3.Text = "No Trabajador:";
            // 
            // txbNoTrabajador
            // 
            txbNoTrabajador.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txbNoTrabajador.Location = new Point(190, 32);
            txbNoTrabajador.Name = "txbNoTrabajador";
            txbNoTrabajador.Size = new Size(157, 27);
            txbNoTrabajador.TabIndex = 4;
            txbNoTrabajador.KeyPress += txbNoTrabajador_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(43, 170);
            label4.Name = "label4";
            label4.Size = new Size(91, 22);
            label4.TabIndex = 5;
            label4.Text = "Cantidad:";
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.FromArgb(255, 102, 0);
            btnRegistrar.Cursor = Cursors.Hand;
            btnRegistrar.FlatAppearance.BorderSize = 0;
            btnRegistrar.FlatStyle = FlatStyle.Flat;
            btnRegistrar.Font = new Font("Montserrat", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegistrar.ForeColor = Color.White;
            btnRegistrar.Location = new Point(990, 173);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(179, 45);
            btnRegistrar.TabIndex = 13;
            btnRegistrar.Text = "REGISTRAR";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // txbCantidad
            // 
            txbCantidad.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txbCantidad.Location = new Point(190, 167);
            txbCantidad.Name = "txbCantidad";
            txbCantidad.Size = new Size(244, 27);
            txbCantidad.TabIndex = 6;
            // 
            // lblfecha
            // 
            lblfecha.AutoSize = true;
            lblfecha.BackColor = Color.Transparent;
            lblfecha.Font = new Font("Montserrat", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblfecha.ForeColor = Color.White;
            lblfecha.Location = new Point(1027, 50);
            lblfecha.Name = "lblfecha";
            lblfecha.Size = new Size(100, 20);
            lblfecha.TabIndex = 19;
            lblfecha.Text = "Fecha Larga";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Montserrat", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.White;
            label11.Location = new Point(971, 50);
            label11.Name = "label11";
            label11.Size = new Size(58, 20);
            label11.TabIndex = 18;
            label11.Text = "Fecha:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(3, 42, 76);
            panel1.Controls.Add(dgvReporte);
            panel1.Location = new Point(37, 423);
            panel1.Name = "panel1";
            panel1.Size = new Size(1240, 331);
            panel1.TabIndex = 20;
            // 
            // dgvReporte
            // 
            dgvReporte.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReporte.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(255, 102, 0);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvReporte.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvReporte.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvReporte.DefaultCellStyle = dataGridViewCellStyle2;
            dgvReporte.Location = new Point(21, 25);
            dgvReporte.Name = "dgvReporte";
            dgvReporte.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvReporte.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvReporte.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(255, 102, 0);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dgvReporte.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvReporte.RowTemplate.Height = 25;
            dgvReporte.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReporte.Size = new Size(1195, 290);
            dgvReporte.TabIndex = 19;
            // 
            // Produccion_Reporte
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fondocontrolalmacen;
            ClientSize = new Size(1322, 786);
            Controls.Add(panel1);
            Controls.Add(lblfecha);
            Controls.Add(label11);
            Controls.Add(panel5);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Produccion_Reporte";
            Text = "Produccion_Reporte";
            Load += Produccion_Reporte_Load;
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvReporte).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel5;
        private Label lblNombreTrabajador;
        private Label label3;
        private TextBox txbNoTrabajador;
        private Label label4;
        private Button btnRegistrar;
        private TextBox txbCantidad;
        private Label label6;
        private ComboBox cbOperacion;
        private Label label5;
        private ComboBox cbProducto;
        private ComboBox cbDecimal;
        private Label label8;
        private Label label7;
        private ComboBox cbHora;
        private Label label9;
        private TextBox txbFamilia;
        private TextBox txbClave;
        private ComboBox cbUnidad;
        private Label lblFolio;
        private Label label2;
        private Label lblfecha;
        private Label label11;
        private System.Windows.Forms.Timer fecha;
        private DateTimePicker dtpTiempoInicio;
        private DateTimePicker dtpTiempoFinal;
        private Label label10;
        private Panel panel1;
        private DataGridView dgvReporte;
    }
}