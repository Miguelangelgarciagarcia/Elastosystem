namespace ElastoSystem
{
    partial class Almacen_NuevoProducto
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            tbproducto = new TextBox();
            tbdescripcion = new TextBox();
            tbexistencias = new TextBox();
            cbunidad = new ComboBox();
            button1 = new Button();
            lbidproducto = new Label();
            tbminimo = new TextBox();
            label6 = new Label();
            label7 = new Label();
            panel5 = new Panel();
            cbEstatus = new ComboBox();
            btnNuevoProducto = new Button();
            btnEditarProducto = new Button();
            label8 = new Label();
            dgvConsumibles = new DataGridView();
            panel1 = new Panel();
            panel2 = new Panel();
            pbQR = new PictureBox();
            btnGuardarQR = new Button();
            txbLink = new TextBox();
            button2 = new Button();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvConsumibles).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbQR).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Montserrat", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(21, 21);
            label1.Name = "label1";
            label1.Size = new Size(130, 26);
            label1.TabIndex = 0;
            label1.Text = "ID Producto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Montserrat", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(21, 61);
            label2.Name = "label2";
            label2.Size = new Size(103, 26);
            label2.TabIndex = 1;
            label2.Text = "Producto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Montserrat", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(21, 101);
            label3.Name = "label3";
            label3.Size = new Size(126, 26);
            label3.TabIndex = 2;
            label3.Text = "Descripción";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Montserrat", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(21, 141);
            label4.Name = "label4";
            label4.Size = new Size(117, 26);
            label4.TabIndex = 3;
            label4.Text = "Existencias";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Montserrat", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(21, 221);
            label5.Name = "label5";
            label5.Size = new Size(82, 26);
            label5.TabIndex = 4;
            label5.Text = "Unidad";
            label5.Click += label5_Click;
            // 
            // tbproducto
            // 
            tbproducto.Font = new Font("Montserrat", 14F, FontStyle.Regular, GraphicsUnit.Point);
            tbproducto.Location = new Point(200, 61);
            tbproducto.Name = "tbproducto";
            tbproducto.Size = new Size(513, 30);
            tbproducto.TabIndex = 6;
            // 
            // tbdescripcion
            // 
            tbdescripcion.Font = new Font("Montserrat", 14F, FontStyle.Regular, GraphicsUnit.Point);
            tbdescripcion.Location = new Point(200, 101);
            tbdescripcion.Name = "tbdescripcion";
            tbdescripcion.Size = new Size(513, 30);
            tbdescripcion.TabIndex = 7;
            // 
            // tbexistencias
            // 
            tbexistencias.Font = new Font("Montserrat", 14F, FontStyle.Regular, GraphicsUnit.Point);
            tbexistencias.Location = new Point(200, 141);
            tbexistencias.Name = "tbexistencias";
            tbexistencias.Size = new Size(513, 30);
            tbexistencias.TabIndex = 8;
            // 
            // cbunidad
            // 
            cbunidad.DropDownStyle = ComboBoxStyle.DropDownList;
            cbunidad.Font = new Font("Montserrat", 14F, FontStyle.Regular, GraphicsUnit.Point);
            cbunidad.FormattingEnabled = true;
            cbunidad.Items.AddRange(new object[] { "Piezas", "Litros", "Kilogramos", "Pares" });
            cbunidad.Location = new Point(200, 221);
            cbunidad.Name = "cbunidad";
            cbunidad.Size = new Size(513, 34);
            cbunidad.TabIndex = 9;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 102, 0);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Montserrat", 14F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(504, 275);
            button1.Name = "button1";
            button1.Size = new Size(209, 46);
            button1.TabIndex = 10;
            button1.Text = "Registrar Producto";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // lbidproducto
            // 
            lbidproducto.AutoSize = true;
            lbidproducto.BackColor = Color.Transparent;
            lbidproducto.Font = new Font("Montserrat", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lbidproducto.ForeColor = Color.White;
            lbidproducto.Location = new Point(200, 21);
            lbidproducto.Name = "lbidproducto";
            lbidproducto.Size = new Size(230, 26);
            lbidproducto.TabIndex = 12;
            lbidproducto.Text = "ID_PRODUCTOERROR";
            // 
            // tbminimo
            // 
            tbminimo.Font = new Font("Montserrat", 14F, FontStyle.Regular, GraphicsUnit.Point);
            tbminimo.Location = new Point(200, 181);
            tbminimo.Name = "tbminimo";
            tbminimo.Size = new Size(513, 30);
            tbminimo.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Montserrat", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(21, 181);
            label6.Name = "label6";
            label6.Size = new Size(144, 26);
            label6.TabIndex = 14;
            label6.Text = "Stock Minimo";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Montserrat", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(28, 26);
            label7.Name = "label7";
            label7.Size = new Size(444, 44);
            label7.TabIndex = 15;
            label7.Text = "CONSUMIBLES ALMACEN";
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(3, 42, 76);
            panel5.Controls.Add(cbEstatus);
            panel5.Controls.Add(btnNuevoProducto);
            panel5.Controls.Add(btnEditarProducto);
            panel5.Controls.Add(label8);
            panel5.Controls.Add(label1);
            panel5.Controls.Add(label2);
            panel5.Controls.Add(button1);
            panel5.Controls.Add(tbminimo);
            panel5.Controls.Add(cbunidad);
            panel5.Controls.Add(label6);
            panel5.Controls.Add(lbidproducto);
            panel5.Controls.Add(label3);
            panel5.Controls.Add(tbexistencias);
            panel5.Controls.Add(label4);
            panel5.Controls.Add(tbdescripcion);
            panel5.Controls.Add(label5);
            panel5.Controls.Add(tbproducto);
            panel5.Location = new Point(28, 96);
            panel5.Name = "panel5";
            panel5.Size = new Size(743, 351);
            panel5.TabIndex = 17;
            // 
            // cbEstatus
            // 
            cbEstatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cbEstatus.Font = new Font("Montserrat", 14F, FontStyle.Regular, GraphicsUnit.Point);
            cbEstatus.FormattingEnabled = true;
            cbEstatus.Items.AddRange(new object[] { "ACTIVO", "INACTIVO" });
            cbEstatus.Location = new Point(200, 139);
            cbEstatus.Name = "cbEstatus";
            cbEstatus.Size = new Size(513, 34);
            cbEstatus.TabIndex = 19;
            cbEstatus.Visible = false;
            // 
            // btnNuevoProducto
            // 
            btnNuevoProducto.BackColor = Color.FromArgb(255, 102, 0);
            btnNuevoProducto.Cursor = Cursors.Hand;
            btnNuevoProducto.FlatAppearance.BorderSize = 0;
            btnNuevoProducto.FlatStyle = FlatStyle.Flat;
            btnNuevoProducto.Font = new Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnNuevoProducto.ForeColor = Color.White;
            btnNuevoProducto.Location = new Point(557, 16);
            btnNuevoProducto.Name = "btnNuevoProducto";
            btnNuevoProducto.Size = new Size(156, 39);
            btnNuevoProducto.TabIndex = 18;
            btnNuevoProducto.Text = "Nuevo Producto";
            btnNuevoProducto.UseVisualStyleBackColor = false;
            btnNuevoProducto.Visible = false;
            btnNuevoProducto.Click += btnNuevoProducto_Click;
            // 
            // btnEditarProducto
            // 
            btnEditarProducto.BackColor = Color.FromArgb(255, 102, 0);
            btnEditarProducto.Cursor = Cursors.Hand;
            btnEditarProducto.FlatAppearance.BorderSize = 0;
            btnEditarProducto.FlatStyle = FlatStyle.Flat;
            btnEditarProducto.Font = new Font("Montserrat", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnEditarProducto.ForeColor = Color.White;
            btnEditarProducto.Location = new Point(504, 275);
            btnEditarProducto.Name = "btnEditarProducto";
            btnEditarProducto.Size = new Size(209, 46);
            btnEditarProducto.TabIndex = 17;
            btnEditarProducto.Text = "Editar Producto";
            btnEditarProducto.UseVisualStyleBackColor = false;
            btnEditarProducto.Visible = false;
            btnEditarProducto.Click += btnEditarProducto_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Montserrat", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(21, 141);
            label8.Name = "label8";
            label8.Size = new Size(83, 26);
            label8.TabIndex = 15;
            label8.Text = "Estatus";
            label8.Visible = false;
            // 
            // dgvConsumibles
            // 
            dgvConsumibles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvConsumibles.BackgroundColor = Color.FromArgb(205, 215, 224);
            dgvConsumibles.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(255, 102, 0);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvConsumibles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvConsumibles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.WindowFrame;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvConsumibles.DefaultCellStyle = dataGridViewCellStyle2;
            dgvConsumibles.GridColor = SystemColors.ActiveCaptionText;
            dgvConsumibles.Location = new Point(28, 476);
            dgvConsumibles.Name = "dgvConsumibles";
            dgvConsumibles.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(205, 215, 224);
            dataGridViewCellStyle3.Font = new Font("Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(255, 102, 0);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvConsumibles.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvConsumibles.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Montserrat", 11F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(255, 102, 0);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dgvConsumibles.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvConsumibles.RowTemplate.Height = 25;
            dgvConsumibles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvConsumibles.Size = new Size(1264, 279);
            dgvConsumibles.TabIndex = 18;
            dgvConsumibles.DoubleClick += dgvConsumibles_DoubleClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(3, 42, 76);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(btnGuardarQR);
            panel1.Location = new Point(895, 96);
            panel1.Name = "panel1";
            panel1.Size = new Size(351, 351);
            panel1.TabIndex = 19;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(pbQR);
            panel2.Location = new Point(50, 28);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 250);
            panel2.TabIndex = 20;
            // 
            // pbQR
            // 
            pbQR.Location = new Point(25, 25);
            pbQR.Name = "pbQR";
            pbQR.Size = new Size(200, 200);
            pbQR.TabIndex = 20;
            pbQR.TabStop = false;
            // 
            // btnGuardarQR
            // 
            btnGuardarQR.BackColor = Color.FromArgb(255, 102, 0);
            btnGuardarQR.Cursor = Cursors.Hand;
            btnGuardarQR.FlatAppearance.BorderSize = 0;
            btnGuardarQR.FlatStyle = FlatStyle.Flat;
            btnGuardarQR.Font = new Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuardarQR.ForeColor = Color.White;
            btnGuardarQR.Location = new Point(107, 298);
            btnGuardarQR.Name = "btnGuardarQR";
            btnGuardarQR.Size = new Size(136, 35);
            btnGuardarQR.TabIndex = 19;
            btnGuardarQR.Text = "Guardar QR";
            btnGuardarQR.UseVisualStyleBackColor = false;
            btnGuardarQR.Click += btnGuardarQR_Click;
            // 
            // txbLink
            // 
            txbLink.Font = new Font("Montserrat", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txbLink.Location = new Point(543, 37);
            txbLink.Name = "txbLink";
            txbLink.Size = new Size(513, 30);
            txbLink.TabIndex = 20;
            txbLink.Visible = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 102, 0);
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(1084, 35);
            button2.Name = "button2";
            button2.Size = new Size(101, 39);
            button2.TabIndex = 21;
            button2.Text = "Generar";
            button2.UseVisualStyleBackColor = false;
            button2.Visible = false;
            button2.Click += button2_Click_1;
            // 
            // Almacen_NuevoProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fondocontrolalmacen;
            ClientSize = new Size(1322, 792);
            Controls.Add(button2);
            Controls.Add(txbLink);
            Controls.Add(panel1);
            Controls.Add(dgvConsumibles);
            Controls.Add(panel5);
            Controls.Add(label7);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Almacen_NuevoProducto";
            Text = "Generar";
            Load += Almacen_NuevoProducto_Load;
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvConsumibles).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbQR).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox tbproducto;
        private TextBox tbdescripcion;
        private TextBox tbexistencias;
        private ComboBox cbunidad;
        private Button button1;
        private Label lbidproducto;
        private TextBox tbminimo;
        private Label label6;
        private Label label7;
        private Panel panel5;
        private Label label8;
        private Button btnEditarProducto;
        private Button btnNuevoProducto;
        private DataGridView dgvConsumibles;
        private ComboBox cbEstatus;
        private Panel panel1;
        private Button btnGuardarQR;
        private PictureBox pbQR;
        private Panel panel2;
        private TextBox txbLink;
        private Button button2;
    }
}