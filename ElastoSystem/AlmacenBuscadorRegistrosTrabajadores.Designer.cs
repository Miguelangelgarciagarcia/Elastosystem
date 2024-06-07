namespace ElastoSystem
{
    partial class AlmacenBuscadorRegistrosTrabajadores
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            label1 = new Label();
            cbApellidoPaterno = new ComboBox();
            Nombre = new Label();
            cbNombre = new ComboBox();
            label2 = new Label();
            txtbNoTrabajador = new TextBox();
            checkBox1 = new CheckBox();
            label3 = new Label();
            cbProducto = new ComboBox();
            checkBox2 = new CheckBox();
            label4 = new Label();
            label5 = new Label();
            txtbFechaInicio = new TextBox();
            txtbFechaTermino = new TextBox();
            checkBox3 = new CheckBox();
            dgv = new DataGridView();
            btnbuscar = new Button();
            pbCalendario1 = new PictureBox();
            pbCalendario2 = new PictureBox();
            Calendario1 = new MonthCalendar();
            pbCalendario1Cerrar = new PictureBox();
            Calendario2 = new MonthCalendar();
            pbCalendario2Cerrar = new PictureBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbCalendario1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbCalendario2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbCalendario1Cerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbCalendario2Cerrar).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Montserrat", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(36, 32);
            label1.Name = "label1";
            label1.Size = new Size(172, 26);
            label1.TabIndex = 0;
            label1.Text = "Apellido Paterno";
            // 
            // cbApellidoPaterno
            // 
            cbApellidoPaterno.Font = new Font("Montserrat", 14F, FontStyle.Regular, GraphicsUnit.Point);
            cbApellidoPaterno.FormattingEnabled = true;
            cbApellidoPaterno.Location = new Point(36, 61);
            cbApellidoPaterno.Name = "cbApellidoPaterno";
            cbApellidoPaterno.Size = new Size(280, 34);
            cbApellidoPaterno.TabIndex = 1;
            cbApellidoPaterno.SelectedIndexChanged += cbApellidoPaterno_SelectedIndexChanged;
            // 
            // Nombre
            // 
            Nombre.AutoSize = true;
            Nombre.BackColor = Color.Transparent;
            Nombre.Font = new Font("Montserrat", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Nombre.ForeColor = Color.White;
            Nombre.Location = new Point(386, 32);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(91, 26);
            Nombre.TabIndex = 2;
            Nombre.Text = "Nombre";
            // 
            // cbNombre
            // 
            cbNombre.Font = new Font("Montserrat", 14F, FontStyle.Regular, GraphicsUnit.Point);
            cbNombre.FormattingEnabled = true;
            cbNombre.Location = new Point(386, 60);
            cbNombre.Name = "cbNombre";
            cbNombre.Size = new Size(280, 34);
            cbNombre.TabIndex = 3;
            cbNombre.SelectedIndexChanged += cbNombre_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Montserrat", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(746, 32);
            label2.Name = "label2";
            label2.Size = new Size(150, 26);
            label2.TabIndex = 4;
            label2.Text = "No. Trabajador";
            // 
            // txtbNoTrabajador
            // 
            txtbNoTrabajador.Font = new Font("Montserrat", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtbNoTrabajador.Location = new Point(746, 61);
            txtbNoTrabajador.Name = "txtbNoTrabajador";
            txtbNoTrabajador.Size = new Size(280, 30);
            txtbNoTrabajador.TabIndex = 5;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.BackColor = Color.Transparent;
            checkBox1.Font = new Font("Montserrat", 14F, FontStyle.Bold, GraphicsUnit.Point);
            checkBox1.ForeColor = Color.White;
            checkBox1.Location = new Point(36, 101);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(261, 30);
            checkBox1.TabIndex = 6;
            checkBox1.Text = "Todos Los Trabajadores";
            checkBox1.UseVisualStyleBackColor = false;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            checkBox1.CheckStateChanged += checkBox1_CheckStateChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Montserrat", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(36, 137);
            label3.Name = "label3";
            label3.Size = new Size(103, 26);
            label3.TabIndex = 7;
            label3.Text = "Producto";
            // 
            // cbProducto
            // 
            cbProducto.Font = new Font("Montserrat", 14F, FontStyle.Regular, GraphicsUnit.Point);
            cbProducto.FormattingEnabled = true;
            cbProducto.Location = new Point(36, 166);
            cbProducto.Name = "cbProducto";
            cbProducto.Size = new Size(280, 34);
            cbProducto.TabIndex = 8;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.BackColor = Color.Transparent;
            checkBox2.Font = new Font("Montserrat", 14F, FontStyle.Bold, GraphicsUnit.Point);
            checkBox2.ForeColor = Color.White;
            checkBox2.Location = new Point(36, 206);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(233, 30);
            checkBox2.TabIndex = 9;
            checkBox2.Text = "Todos Los Productos";
            checkBox2.UseVisualStyleBackColor = false;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Montserrat", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(386, 137);
            label4.Name = "label4";
            label4.Size = new Size(127, 26);
            label4.TabIndex = 10;
            label4.Text = "Fecha Inicio";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Montserrat", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(746, 137);
            label5.Name = "label5";
            label5.Size = new Size(154, 26);
            label5.TabIndex = 11;
            label5.Text = "Fecha Termino";
            // 
            // txtbFechaInicio
            // 
            txtbFechaInicio.Font = new Font("Montserrat", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtbFechaInicio.Location = new Point(386, 170);
            txtbFechaInicio.Name = "txtbFechaInicio";
            txtbFechaInicio.Size = new Size(280, 30);
            txtbFechaInicio.TabIndex = 12;
            // 
            // txtbFechaTermino
            // 
            txtbFechaTermino.Font = new Font("Montserrat", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtbFechaTermino.Location = new Point(746, 170);
            txtbFechaTermino.Name = "txtbFechaTermino";
            txtbFechaTermino.Size = new Size(280, 30);
            txtbFechaTermino.TabIndex = 13;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.BackColor = Color.Transparent;
            checkBox3.Font = new Font("Montserrat", 14F, FontStyle.Bold, GraphicsUnit.Point);
            checkBox3.ForeColor = Color.White;
            checkBox3.Location = new Point(637, 206);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(119, 30);
            checkBox3.TabIndex = 14;
            checkBox3.Text = "Historico";
            checkBox3.UseVisualStyleBackColor = false;
            checkBox3.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // dgv
            // 
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Location = new Point(36, 259);
            dgv.Name = "dgv";
            dgv.RowHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(255, 102, 0);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dgv.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgv.RowTemplate.Height = 25;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.Size = new Size(1260, 489);
            dgv.TabIndex = 15;
            // 
            // btnbuscar
            // 
            btnbuscar.BackColor = Color.FromArgb(255, 102, 0);
            btnbuscar.FlatAppearance.BorderSize = 0;
            btnbuscar.FlatStyle = FlatStyle.Flat;
            btnbuscar.Font = new Font("Montserrat", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnbuscar.ForeColor = Color.White;
            btnbuscar.Location = new Point(1104, 161);
            btnbuscar.Name = "btnbuscar";
            btnbuscar.Size = new Size(184, 50);
            btnbuscar.TabIndex = 16;
            btnbuscar.Text = "BUSCAR";
            btnbuscar.UseVisualStyleBackColor = false;
            btnbuscar.Click += button1_Click;
            // 
            // pbCalendario1
            // 
            pbCalendario1.BackColor = Color.White;
            pbCalendario1.Cursor = Cursors.Hand;
            pbCalendario1.Image = Properties.Resources.calendario;
            pbCalendario1.Location = new Point(637, 175);
            pbCalendario1.Name = "pbCalendario1";
            pbCalendario1.Size = new Size(19, 18);
            pbCalendario1.SizeMode = PictureBoxSizeMode.Zoom;
            pbCalendario1.TabIndex = 21;
            pbCalendario1.TabStop = false;
            pbCalendario1.Click += pictureBox1_Click;
            // 
            // pbCalendario2
            // 
            pbCalendario2.BackColor = Color.White;
            pbCalendario2.Cursor = Cursors.Hand;
            pbCalendario2.Image = Properties.Resources.calendario;
            pbCalendario2.Location = new Point(998, 175);
            pbCalendario2.Name = "pbCalendario2";
            pbCalendario2.Size = new Size(19, 18);
            pbCalendario2.SizeMode = PictureBoxSizeMode.Zoom;
            pbCalendario2.TabIndex = 22;
            pbCalendario2.TabStop = false;
            pbCalendario2.Click += pbCalendario2_Click;
            // 
            // Calendario1
            // 
            Calendario1.Font = new Font("Montserrat", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Calendario1.Location = new Point(408, 205);
            Calendario1.Name = "Calendario1";
            Calendario1.TabIndex = 23;
            Calendario1.DateChanged += Calendario1_DateChanged;
            // 
            // pbCalendario1Cerrar
            // 
            pbCalendario1Cerrar.BackColor = Color.White;
            pbCalendario1Cerrar.Cursor = Cursors.Hand;
            pbCalendario1Cerrar.Image = Properties.Resources.calendario;
            pbCalendario1Cerrar.Location = new Point(637, 175);
            pbCalendario1Cerrar.Name = "pbCalendario1Cerrar";
            pbCalendario1Cerrar.Size = new Size(19, 18);
            pbCalendario1Cerrar.SizeMode = PictureBoxSizeMode.Zoom;
            pbCalendario1Cerrar.TabIndex = 24;
            pbCalendario1Cerrar.TabStop = false;
            pbCalendario1Cerrar.Click += pbCalendario1Cerrar_Click;
            // 
            // Calendario2
            // 
            Calendario2.Font = new Font("Montserrat", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Calendario2.Location = new Point(769, 205);
            Calendario2.Name = "Calendario2";
            Calendario2.TabIndex = 25;
            Calendario2.DateChanged += Calendario2_DateChanged;
            // 
            // pbCalendario2Cerrar
            // 
            pbCalendario2Cerrar.BackColor = Color.White;
            pbCalendario2Cerrar.Cursor = Cursors.Hand;
            pbCalendario2Cerrar.Image = Properties.Resources.calendario;
            pbCalendario2Cerrar.Location = new Point(998, 175);
            pbCalendario2Cerrar.Name = "pbCalendario2Cerrar";
            pbCalendario2Cerrar.Size = new Size(19, 18);
            pbCalendario2Cerrar.SizeMode = PictureBoxSizeMode.Zoom;
            pbCalendario2Cerrar.TabIndex = 26;
            pbCalendario2Cerrar.TabStop = false;
            pbCalendario2Cerrar.Click += pbCalendario2Cerrar_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 102, 0);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(1073, 770);
            button1.Name = "button1";
            button1.Size = new Size(215, 39);
            button1.TabIndex = 27;
            button1.Text = "EXPORTAR A EXCEL";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // AlmacenBuscadorRegistrosTrabajadores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fondocontrolalmacen;
            ClientSize = new Size(1338, 831);
            Controls.Add(button1);
            Controls.Add(pbCalendario2Cerrar);
            Controls.Add(Calendario2);
            Controls.Add(pbCalendario1Cerrar);
            Controls.Add(Calendario1);
            Controls.Add(pbCalendario2);
            Controls.Add(pbCalendario1);
            Controls.Add(btnbuscar);
            Controls.Add(dgv);
            Controls.Add(checkBox3);
            Controls.Add(txtbFechaTermino);
            Controls.Add(txtbFechaInicio);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(checkBox2);
            Controls.Add(cbProducto);
            Controls.Add(label3);
            Controls.Add(checkBox1);
            Controls.Add(txtbNoTrabajador);
            Controls.Add(label2);
            Controls.Add(cbNombre);
            Controls.Add(Nombre);
            Controls.Add(cbApellidoPaterno);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AlmacenBuscadorRegistrosTrabajadores";
            Text = "AlmacenBuscadorRegistrosTrabajadores";
            Load += AlmacenBuscadorRegistrosTrabajadores_Load;
            Click += AlmacenBuscadorRegistrosTrabajadores_Click;
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbCalendario1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbCalendario2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbCalendario1Cerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbCalendario2Cerrar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label label1;
        private ComboBox cbApellidoPaterno;
        private Label Nombre;
        private ComboBox cbNombre;
        private Label label2;
        private TextBox txtbNoTrabajador;
        private CheckBox checkBox1;
        private Label label3;
        private ComboBox cbProducto;
        private CheckBox checkBox2;
        private Label label4;
        private Label label5;
        private TextBox txtbFechaInicio;
        private TextBox txtbFechaTermino;
        private CheckBox checkBox3;
        private DataGridView dgv;
        private Button btnbuscar;
        private PictureBox pbCalendario1;
        private PictureBox pbCalendario2;
        private MonthCalendar Calendario1;
        private PictureBox pbCalendario1Cerrar;
        private MonthCalendar Calendario2;
        private PictureBox pbCalendario2Cerrar;
        private Button button1;
    }
}