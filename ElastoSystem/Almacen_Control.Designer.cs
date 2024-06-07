namespace ElastoSystem
{
    partial class Almacen_Control
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Almacen_Control));
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle16 = new DataGridViewCellStyle();
            paneltop = new Panel();
            pictureBox4 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            lblNombreProducto = new Label();
            txbIDProducto = new TextBox();
            label7 = new Label();
            lblNombreTrabajador = new Label();
            txbNoTrabajador = new TextBox();
            label3 = new Label();
            lblUnidad = new Label();
            label1 = new Label();
            dgvTemporal = new DataGridView();
            txbNota = new TextBox();
            label6 = new Label();
            btnAceptar = new Button();
            dgvBD = new DataGridView();
            lblFecha = new Label();
            lblHora = new Label();
            horayfecha = new System.Windows.Forms.Timer(components);
            paneltop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvTemporal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvBD).BeginInit();
            SuspendLayout();
            // 
            // paneltop
            // 
            paneltop.BackColor = Color.FromArgb(153, 255, 255, 255);
            paneltop.Controls.Add(pictureBox4);
            paneltop.Controls.Add(pictureBox2);
            paneltop.Controls.Add(pictureBox1);
            paneltop.Controls.Add(pictureBox3);
            paneltop.Dock = DockStyle.Top;
            paneltop.Location = new Point(0, 0);
            paneltop.Name = "paneltop";
            paneltop.Size = new Size(1920, 30);
            paneltop.TabIndex = 18;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(1854, 4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(23, 23);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 21;
            pictureBox4.TabStop = false;
            pictureBox4.MouseMove += pictureBox4_MouseMove;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1885, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(23, 23);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 20;
            pictureBox2.TabStop = false;
            pictureBox2.MouseMove += pictureBox2_MouseMove;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1885, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(23, 23);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            pictureBox1.MouseLeave += pictureBox1_MouseLeave;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Cursor = Cursors.Hand;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(1854, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(23, 23);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 18;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            pictureBox3.MouseLeave += pictureBox3_MouseLeave;
            // 
            // lblNombreProducto
            // 
            lblNombreProducto.AutoSize = true;
            lblNombreProducto.BackColor = Color.Transparent;
            lblNombreProducto.Font = new Font("Montserrat", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombreProducto.ForeColor = Color.White;
            lblNombreProducto.Location = new Point(407, 203);
            lblNombreProducto.Name = "lblNombreProducto";
            lblNombreProducto.Size = new Size(218, 30);
            lblNombreProducto.TabIndex = 33;
            lblNombreProducto.Text = "Nombre Producto";
            lblNombreProducto.Visible = false;
            // 
            // txbIDProducto
            // 
            txbIDProducto.BackColor = Color.FromArgb(205, 215, 224);
            txbIDProducto.BorderStyle = BorderStyle.None;
            txbIDProducto.Font = new Font("Montserrat", 16F, FontStyle.Regular, GraphicsUnit.Point);
            txbIDProducto.Location = new Point(236, 203);
            txbIDProducto.Multiline = true;
            txbIDProducto.Name = "txbIDProducto";
            txbIDProducto.Size = new Size(165, 30);
            txbIDProducto.TabIndex = 32;
            txbIDProducto.TextAlign = HorizontalAlignment.Center;
            txbIDProducto.KeyPress += txbIDProducto_KeyPress;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Montserrat", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(55, 203);
            label7.Name = "label7";
            label7.Size = new Size(152, 30);
            label7.TabIndex = 31;
            label7.Text = "ID. Producto";
            // 
            // lblNombreTrabajador
            // 
            lblNombreTrabajador.AutoSize = true;
            lblNombreTrabajador.BackColor = Color.Transparent;
            lblNombreTrabajador.Font = new Font("Montserrat", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombreTrabajador.ForeColor = Color.White;
            lblNombreTrabajador.Location = new Point(55, 161);
            lblNombreTrabajador.Name = "lblNombreTrabajador";
            lblNombreTrabajador.Size = new Size(236, 30);
            lblNombreTrabajador.TabIndex = 30;
            lblNombreTrabajador.Text = "Nombre Trabajador";
            // 
            // txbNoTrabajador
            // 
            txbNoTrabajador.BackColor = Color.FromArgb(205, 215, 224);
            txbNoTrabajador.BorderStyle = BorderStyle.None;
            txbNoTrabajador.Font = new Font("Montserrat", 16F, FontStyle.Regular, GraphicsUnit.Point);
            txbNoTrabajador.Location = new Point(236, 117);
            txbNoTrabajador.Multiline = true;
            txbNoTrabajador.Name = "txbNoTrabajador";
            txbNoTrabajador.Size = new Size(165, 30);
            txbNoTrabajador.TabIndex = 28;
            txbNoTrabajador.TextAlign = HorizontalAlignment.Center;
            txbNoTrabajador.KeyPress += txbNoTrabajador_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Montserrat", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(55, 117);
            label3.Name = "label3";
            label3.Size = new Size(175, 30);
            label3.TabIndex = 29;
            label3.Text = "No. Trabajador";
            // 
            // lblUnidad
            // 
            lblUnidad.AutoSize = true;
            lblUnidad.BackColor = Color.Transparent;
            lblUnidad.Font = new Font("Montserrat", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblUnidad.ForeColor = Color.White;
            lblUnidad.Location = new Point(407, 233);
            lblUnidad.Name = "lblUnidad";
            lblUnidad.Size = new Size(65, 21);
            lblUnidad.TabIndex = 34;
            lblUnidad.Text = "Unidad";
            lblUnidad.TextAlign = ContentAlignment.MiddleRight;
            lblUnidad.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Montserrat", 22F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(55, 49);
            label1.Name = "label1";
            label1.Size = new Size(340, 41);
            label1.TabIndex = 35;
            label1.Text = "CONTROL ALMACEN";
            // 
            // dgvTemporal
            // 
            dgvTemporal.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTemporal.BackgroundColor = Color.FromArgb(205, 215, 224);
            dgvTemporal.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = Color.White;
            dataGridViewCellStyle9.Font = new Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(255, 102, 0);
            dataGridViewCellStyle9.SelectionForeColor = Color.White;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dgvTemporal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dgvTemporal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = SystemColors.WindowFrame;
            dataGridViewCellStyle10.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.False;
            dgvTemporal.DefaultCellStyle = dataGridViewCellStyle10;
            dgvTemporal.GridColor = SystemColors.ActiveCaptionText;
            dgvTemporal.Location = new Point(542, 108);
            dgvTemporal.Name = "dgvTemporal";
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = Color.FromArgb(205, 215, 224);
            dataGridViewCellStyle11.Font = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle11.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = Color.FromArgb(255, 102, 0);
            dataGridViewCellStyle11.SelectionForeColor = Color.White;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.True;
            dgvTemporal.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            dgvTemporal.RowHeadersVisible = false;
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = Color.White;
            dataGridViewCellStyle12.Font = new Font("Montserrat", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle12.ForeColor = Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = Color.FromArgb(255, 102, 0);
            dataGridViewCellStyle12.SelectionForeColor = Color.White;
            dgvTemporal.RowsDefaultCellStyle = dataGridViewCellStyle12;
            dgvTemporal.RowTemplate.Height = 25;
            dgvTemporal.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTemporal.Size = new Size(647, 146);
            dgvTemporal.TabIndex = 36;
            // 
            // txbNota
            // 
            txbNota.BackColor = Color.FromArgb(205, 215, 224);
            txbNota.BorderStyle = BorderStyle.None;
            txbNota.Font = new Font("Montserrat", 16F, FontStyle.Regular, GraphicsUnit.Point);
            txbNota.Location = new Point(1265, 108);
            txbNota.Multiline = true;
            txbNota.Name = "txbNota";
            txbNota.Size = new Size(365, 146);
            txbNota.TabIndex = 38;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Montserrat", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(1265, 75);
            label6.Name = "label6";
            label6.Size = new Size(67, 30);
            label6.TabIndex = 37;
            label6.Text = "Nota";
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.FromArgb(255, 102, 0);
            btnAceptar.Cursor = Cursors.Hand;
            btnAceptar.FlatAppearance.BorderSize = 0;
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.Font = new Font("Montserrat", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnAceptar.ForeColor = Color.White;
            btnAceptar.Location = new Point(1684, 139);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(163, 42);
            btnAceptar.TabIndex = 39;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // dgvBD
            // 
            dgvBD.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBD.BackgroundColor = Color.FromArgb(205, 215, 224);
            dgvBD.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = Color.White;
            dataGridViewCellStyle13.Font = new Font("Montserrat ExtraBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle13.ForeColor = Color.Black;
            dataGridViewCellStyle13.SelectionBackColor = Color.FromArgb(255, 102, 0);
            dataGridViewCellStyle13.SelectionForeColor = Color.White;
            dataGridViewCellStyle13.WrapMode = DataGridViewTriState.True;
            dgvBD.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            dgvBD.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = SystemColors.WindowFrame;
            dataGridViewCellStyle14.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle14.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = DataGridViewTriState.False;
            dgvBD.DefaultCellStyle = dataGridViewCellStyle14;
            dgvBD.GridColor = SystemColors.ActiveCaptionText;
            dgvBD.Location = new Point(55, 302);
            dgvBD.Name = "dgvBD";
            dataGridViewCellStyle15.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = Color.FromArgb(205, 215, 224);
            dataGridViewCellStyle15.Font = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle15.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = Color.FromArgb(255, 102, 0);
            dataGridViewCellStyle15.SelectionForeColor = Color.White;
            dataGridViewCellStyle15.WrapMode = DataGridViewTriState.True;
            dgvBD.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            dgvBD.RowHeadersVisible = false;
            dataGridViewCellStyle16.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = Color.White;
            dataGridViewCellStyle16.Font = new Font("Montserrat", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle16.ForeColor = Color.Black;
            dataGridViewCellStyle16.SelectionBackColor = Color.FromArgb(255, 102, 0);
            dataGridViewCellStyle16.SelectionForeColor = Color.White;
            dgvBD.RowsDefaultCellStyle = dataGridViewCellStyle16;
            dgvBD.RowTemplate.Height = 25;
            dgvBD.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBD.Size = new Size(1810, 638);
            dgvBD.TabIndex = 40;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.BackColor = Color.Transparent;
            lblFecha.Font = new Font("Montserrat SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblFecha.ForeColor = Color.White;
            lblFecha.Location = new Point(1571, 1009);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(70, 26);
            lblFecha.TabIndex = 42;
            lblFecha.Text = "label2";
            lblFecha.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblHora
            // 
            lblHora.AutoSize = true;
            lblHora.BackColor = Color.Transparent;
            lblHora.Font = new Font("Montserrat", 30F, FontStyle.Bold, GraphicsUnit.Point);
            lblHora.ForeColor = Color.White;
            lblHora.Location = new Point(1659, 957);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(206, 55);
            lblHora.TabIndex = 41;
            lblHora.Text = "00:00:00";
            // 
            // horayfecha
            // 
            horayfecha.Enabled = true;
            horayfecha.Tick += horayfecha_Tick;
            // 
            // Almacen_Control
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fondocontrolalmacen;
            ClientSize = new Size(1920, 1080);
            Controls.Add(lblFecha);
            Controls.Add(lblHora);
            Controls.Add(dgvBD);
            Controls.Add(btnAceptar);
            Controls.Add(txbNota);
            Controls.Add(label6);
            Controls.Add(dgvTemporal);
            Controls.Add(label1);
            Controls.Add(lblUnidad);
            Controls.Add(lblNombreProducto);
            Controls.Add(txbIDProducto);
            Controls.Add(label7);
            Controls.Add(lblNombreTrabajador);
            Controls.Add(txbNoTrabajador);
            Controls.Add(label3);
            Controls.Add(paneltop);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Almacen_Control";
            Text = "Almacen_Control";
            Load += Almacen_Control_Load;
            paneltop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvTemporal).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvBD).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel paneltop;
        private PictureBox pictureBox4;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private Label lblNombreProducto;
        private TextBox txbIDProducto;
        private Label label7;
        private Label lblNombreTrabajador;
        private TextBox txbNoTrabajador;
        private Label label3;
        private Label lblUnidad;
        private Label label1;
        private DataGridView dgvTemporal;
        private TextBox txbNota;
        private Label label6;
        private Button btnAceptar;
        private DataGridView dgvBD;
        private Label lblFecha;
        private Label lblHora;
        private System.Windows.Forms.Timer horayfecha;
    }
}