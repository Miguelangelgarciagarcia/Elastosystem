namespace ElastoSystem
{
    partial class Mtto_InventarioMaquinas
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
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle16 = new DataGridViewCellStyle();
            label1 = new Label();
            panel5 = new Panel();
            cbEstatus = new ComboBox();
            label9 = new Label();
            btnModificar = new Button();
            btnEliminar = new Button();
            btnNueva = new Button();
            cbUbicacion = new ComboBox();
            txbNumeroSerie = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            txbNombre = new TextBox();
            label4 = new Label();
            btnAgregar = new Button();
            txbModelo = new TextBox();
            panel1 = new Panel();
            btnCargarImagen = new Button();
            pbImagen = new PictureBox();
            label2 = new Label();
            panel2 = new Panel();
            chbIndicador = new CheckBox();
            chbMantenimiento = new CheckBox();
            chbOrdenTrabajo = new CheckBox();
            label8 = new Label();
            btnActualizarPermisos = new Button();
            dgvBD = new DataGridView();
            dgvPermisos = new DataGridView();
            panel5.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbImagen).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBD).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPermisos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Montserrat", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(37, 31);
            label1.Name = "label1";
            label1.Size = new Size(429, 44);
            label1.TabIndex = 1;
            label1.Text = "INVENTARIO MAQUINAS";
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(3, 42, 76);
            panel5.Controls.Add(cbEstatus);
            panel5.Controls.Add(label9);
            panel5.Controls.Add(btnModificar);
            panel5.Controls.Add(btnEliminar);
            panel5.Controls.Add(btnNueva);
            panel5.Controls.Add(cbUbicacion);
            panel5.Controls.Add(txbNumeroSerie);
            panel5.Controls.Add(label7);
            panel5.Controls.Add(label6);
            panel5.Controls.Add(label5);
            panel5.Controls.Add(label3);
            panel5.Controls.Add(txbNombre);
            panel5.Controls.Add(label4);
            panel5.Controls.Add(btnAgregar);
            panel5.Controls.Add(txbModelo);
            panel5.Location = new Point(54, 406);
            panel5.Name = "panel5";
            panel5.Size = new Size(612, 341);
            panel5.TabIndex = 17;
            // 
            // cbEstatus
            // 
            cbEstatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cbEstatus.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbEstatus.FormattingEnabled = true;
            cbEstatus.Items.AddRange(new object[] { "ACTIVA", "INACTIVA" });
            cbEstatus.Location = new Point(185, 230);
            cbEstatus.Name = "cbEstatus";
            cbEstatus.Size = new Size(389, 30);
            cbEstatus.TabIndex = 23;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(24, 233);
            label9.Name = "label9";
            label9.Size = new Size(76, 22);
            label9.TabIndex = 22;
            label9.Text = "Estatus:";
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.FromArgb(255, 102, 0);
            btnModificar.Cursor = Cursors.Hand;
            btnModificar.FlatAppearance.BorderSize = 0;
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.Font = new Font("Montserrat", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnModificar.ForeColor = Color.White;
            btnModificar.Location = new Point(318, 282);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(131, 35);
            btnModificar.TabIndex = 21;
            btnModificar.Text = "MODIFICAR";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Visible = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(255, 102, 0);
            btnEliminar.Cursor = Cursors.Hand;
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Montserrat", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(142, 282);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(131, 35);
            btnEliminar.TabIndex = 20;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Visible = false;
            btnEliminar.Click += button3_Click;
            // 
            // btnNueva
            // 
            btnNueva.BackColor = Color.FromArgb(255, 102, 0);
            btnNueva.Cursor = Cursors.Hand;
            btnNueva.FlatAppearance.BorderSize = 0;
            btnNueva.FlatStyle = FlatStyle.Flat;
            btnNueva.Font = new Font("Montserrat", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnNueva.ForeColor = Color.White;
            btnNueva.Location = new Point(443, 16);
            btnNueva.Name = "btnNueva";
            btnNueva.Size = new Size(131, 35);
            btnNueva.TabIndex = 19;
            btnNueva.Text = "NUEVA";
            btnNueva.UseVisualStyleBackColor = false;
            btnNueva.Visible = false;
            btnNueva.Click += btnNueva_Click;
            // 
            // cbUbicacion
            // 
            cbUbicacion.DropDownStyle = ComboBoxStyle.DropDownList;
            cbUbicacion.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbUbicacion.FormattingEnabled = true;
            cbUbicacion.Items.AddRange(new object[] { "NAVE 1", "NAVE 2" });
            cbUbicacion.Location = new Point(185, 190);
            cbUbicacion.Name = "cbUbicacion";
            cbUbicacion.Size = new Size(389, 30);
            cbUbicacion.TabIndex = 18;
            // 
            // txbNumeroSerie
            // 
            txbNumeroSerie.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txbNumeroSerie.Location = new Point(185, 150);
            txbNumeroSerie.Name = "txbNumeroSerie";
            txbNumeroSerie.Size = new Size(389, 27);
            txbNumeroSerie.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(24, 153);
            label7.Name = "label7";
            label7.Size = new Size(155, 22);
            label7.TabIndex = 16;
            label7.Text = "Número de Serie:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(24, 113);
            label6.Name = "label6";
            label6.Size = new Size(75, 22);
            label6.TabIndex = 15;
            label6.Text = "Modelo:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Montserrat", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(24, 19);
            label5.Name = "label5";
            label5.Size = new Size(82, 26);
            label5.TabIndex = 14;
            label5.Text = "DATOS";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(24, 73);
            label3.Name = "label3";
            label3.Size = new Size(82, 22);
            label3.TabIndex = 3;
            label3.Text = "Nombre:";
            // 
            // txbNombre
            // 
            txbNombre.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txbNombre.Location = new Point(185, 70);
            txbNombre.Name = "txbNombre";
            txbNombre.Size = new Size(389, 27);
            txbNombre.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(24, 193);
            label4.Name = "label4";
            label4.Size = new Size(97, 22);
            label4.TabIndex = 5;
            label4.Text = "Ubicacion:";
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(255, 102, 0);
            btnAgregar.Cursor = Cursors.Hand;
            btnAgregar.FlatAppearance.BorderSize = 0;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Montserrat", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(433, 282);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(131, 35);
            btnAgregar.TabIndex = 13;
            btnAgregar.Text = "AGREGAR";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // txbModelo
            // 
            txbModelo.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txbModelo.Location = new Point(185, 110);
            txbModelo.Name = "txbModelo";
            txbModelo.Size = new Size(389, 27);
            txbModelo.TabIndex = 6;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(3, 42, 76);
            panel1.Controls.Add(btnCargarImagen);
            panel1.Controls.Add(pbImagen);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(682, 406);
            panel1.Name = "panel1";
            panel1.Size = new Size(612, 341);
            panel1.TabIndex = 18;
            // 
            // btnCargarImagen
            // 
            btnCargarImagen.BackColor = Color.FromArgb(255, 102, 0);
            btnCargarImagen.Cursor = Cursors.Hand;
            btnCargarImagen.FlatAppearance.BorderSize = 0;
            btnCargarImagen.FlatStyle = FlatStyle.Flat;
            btnCargarImagen.Font = new Font("Montserrat", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnCargarImagen.ForeColor = Color.White;
            btnCargarImagen.Location = new Point(378, 154);
            btnCargarImagen.Name = "btnCargarImagen";
            btnCargarImagen.Size = new Size(195, 38);
            btnCargarImagen.TabIndex = 14;
            btnCargarImagen.Text = "CARGAR IMAGEN";
            btnCargarImagen.UseVisualStyleBackColor = false;
            btnCargarImagen.Click += button1_Click;
            // 
            // pbImagen
            // 
            pbImagen.BackColor = Color.White;
            pbImagen.Location = new Point(45, 56);
            pbImagen.Name = "pbImagen";
            pbImagen.Size = new Size(300, 225);
            pbImagen.SizeMode = PictureBoxSizeMode.Zoom;
            pbImagen.TabIndex = 4;
            pbImagen.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(45, 23);
            label2.Name = "label2";
            label2.Size = new Size(78, 22);
            label2.TabIndex = 3;
            label2.Text = "IMAGEN";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(3, 42, 76);
            panel2.Controls.Add(chbIndicador);
            panel2.Controls.Add(chbMantenimiento);
            panel2.Controls.Add(chbOrdenTrabajo);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(btnActualizarPermisos);
            panel2.Location = new Point(869, 104);
            panel2.Name = "panel2";
            panel2.Size = new Size(425, 279);
            panel2.TabIndex = 19;
            // 
            // chbIndicador
            // 
            chbIndicador.AutoSize = true;
            chbIndicador.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point);
            chbIndicador.ForeColor = Color.White;
            chbIndicador.Location = new Point(55, 142);
            chbIndicador.Name = "chbIndicador";
            chbIndicador.Size = new Size(105, 26);
            chbIndicador.TabIndex = 24;
            chbIndicador.Text = "Indicador";
            chbIndicador.UseVisualStyleBackColor = true;
            // 
            // chbMantenimiento
            // 
            chbMantenimiento.AutoSize = true;
            chbMantenimiento.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point);
            chbMantenimiento.ForeColor = Color.White;
            chbMantenimiento.Location = new Point(55, 110);
            chbMantenimiento.Name = "chbMantenimiento";
            chbMantenimiento.Size = new Size(153, 26);
            chbMantenimiento.TabIndex = 23;
            chbMantenimiento.Text = "Mantenimiento";
            chbMantenimiento.UseVisualStyleBackColor = true;
            // 
            // chbOrdenTrabajo
            // 
            chbOrdenTrabajo.AutoSize = true;
            chbOrdenTrabajo.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point);
            chbOrdenTrabajo.ForeColor = Color.White;
            chbOrdenTrabajo.Location = new Point(55, 78);
            chbOrdenTrabajo.Name = "chbOrdenTrabajo";
            chbOrdenTrabajo.Size = new Size(166, 26);
            chbOrdenTrabajo.TabIndex = 22;
            chbOrdenTrabajo.Text = "Orden de Trabajo";
            chbOrdenTrabajo.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Montserrat", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(153, 24);
            label8.Name = "label8";
            label8.Size = new Size(117, 26);
            label8.TabIndex = 21;
            label8.Text = "PERMISOS";
            // 
            // btnActualizarPermisos
            // 
            btnActualizarPermisos.BackColor = Color.FromArgb(255, 102, 0);
            btnActualizarPermisos.Cursor = Cursors.Hand;
            btnActualizarPermisos.FlatAppearance.BorderSize = 0;
            btnActualizarPermisos.FlatStyle = FlatStyle.Flat;
            btnActualizarPermisos.Font = new Font("Montserrat", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnActualizarPermisos.ForeColor = Color.White;
            btnActualizarPermisos.Location = new Point(85, 210);
            btnActualizarPermisos.Name = "btnActualizarPermisos";
            btnActualizarPermisos.Size = new Size(254, 35);
            btnActualizarPermisos.TabIndex = 20;
            btnActualizarPermisos.Text = "ACTUALIZAR PERMISOS";
            btnActualizarPermisos.UseVisualStyleBackColor = false;
            btnActualizarPermisos.Visible = false;
            btnActualizarPermisos.Click += btnActualizarPermisos_Click;
            // 
            // dgvBD
            // 
            dgvBD.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBD.BackgroundColor = Color.FromArgb(205, 215, 224);
            dgvBD.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = Color.White;
            dataGridViewCellStyle9.Font = new Font("Montserrat ExtraBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(255, 102, 0);
            dataGridViewCellStyle9.SelectionForeColor = Color.White;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dgvBD.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dgvBD.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = SystemColors.WindowFrame;
            dataGridViewCellStyle10.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.False;
            dgvBD.DefaultCellStyle = dataGridViewCellStyle10;
            dgvBD.GridColor = SystemColors.ActiveCaptionText;
            dgvBD.Location = new Point(54, 104);
            dgvBD.Name = "dgvBD";
            dgvBD.ReadOnly = true;
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = Color.FromArgb(205, 215, 224);
            dataGridViewCellStyle11.Font = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle11.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = Color.FromArgb(255, 102, 0);
            dataGridViewCellStyle11.SelectionForeColor = Color.White;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.True;
            dgvBD.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            dgvBD.RowHeadersVisible = false;
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = Color.White;
            dataGridViewCellStyle12.Font = new Font("Montserrat", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle12.ForeColor = Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = Color.FromArgb(255, 102, 0);
            dataGridViewCellStyle12.SelectionForeColor = Color.White;
            dgvBD.RowsDefaultCellStyle = dataGridViewCellStyle12;
            dgvBD.RowTemplate.Height = 25;
            dgvBD.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBD.Size = new Size(780, 279);
            dgvBD.TabIndex = 41;
            dgvBD.DoubleClick += dgvBD_DoubleClick;
            // 
            // dgvPermisos
            // 
            dgvPermisos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPermisos.BackgroundColor = Color.FromArgb(205, 215, 224);
            dgvPermisos.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = Color.White;
            dataGridViewCellStyle13.Font = new Font("Montserrat ExtraBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle13.ForeColor = Color.Black;
            dataGridViewCellStyle13.SelectionBackColor = Color.FromArgb(255, 102, 0);
            dataGridViewCellStyle13.SelectionForeColor = Color.White;
            dataGridViewCellStyle13.WrapMode = DataGridViewTriState.True;
            dgvPermisos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            dgvPermisos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = SystemColors.WindowFrame;
            dataGridViewCellStyle14.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle14.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = DataGridViewTriState.False;
            dgvPermisos.DefaultCellStyle = dataGridViewCellStyle14;
            dgvPermisos.GridColor = SystemColors.ActiveCaptionText;
            dgvPermisos.Location = new Point(1272, 42);
            dgvPermisos.Name = "dgvPermisos";
            dgvPermisos.ReadOnly = true;
            dataGridViewCellStyle15.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = Color.FromArgb(205, 215, 224);
            dataGridViewCellStyle15.Font = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle15.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = Color.FromArgb(255, 102, 0);
            dataGridViewCellStyle15.SelectionForeColor = Color.White;
            dataGridViewCellStyle15.WrapMode = DataGridViewTriState.True;
            dgvPermisos.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            dgvPermisos.RowHeadersVisible = false;
            dataGridViewCellStyle16.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = Color.White;
            dataGridViewCellStyle16.Font = new Font("Montserrat", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle16.ForeColor = Color.Black;
            dataGridViewCellStyle16.SelectionBackColor = Color.FromArgb(255, 102, 0);
            dataGridViewCellStyle16.SelectionForeColor = Color.White;
            dgvPermisos.RowsDefaultCellStyle = dataGridViewCellStyle16;
            dgvPermisos.RowTemplate.Height = 25;
            dgvPermisos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPermisos.Size = new Size(22, 24);
            dgvPermisos.TabIndex = 42;
            dgvPermisos.Visible = false;
            // 
            // Mtto_InventarioMaquinas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fondocontrolalmacen;
            ClientSize = new Size(1322, 792);
            Controls.Add(dgvPermisos);
            Controls.Add(dgvBD);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel5);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Mtto_InventarioMaquinas";
            Text = "Mtto_InventarioMaquinas";
            Load += Mtto_InventarioMaquinas_Load;
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbImagen).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBD).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPermisos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel5;
        private Label label3;
        private TextBox txbNombre;
        private Label label4;
        private Button btnAgregar;
        private TextBox txbModelo;
        private Panel panel1;
        private PictureBox pbImagen;
        private Label label2;
        private Button btnCargarImagen;
        private TextBox txbNumeroSerie;
        private Label label7;
        private Label label6;
        private Label label5;
        private ComboBox cbUbicacion;
        private Button btnModificar;
        private Button btnEliminar;
        private Button btnNueva;
        private Panel panel2;
        private Label label8;
        private Button btnActualizarPermisos;
        private CheckBox chbIndicador;
        private CheckBox chbMantenimiento;
        private CheckBox chbOrdenTrabajo;
        private DataGridView dgvBD;
        private ComboBox cbEstatus;
        private Label label9;
        private DataGridView dgvPermisos;
    }
}