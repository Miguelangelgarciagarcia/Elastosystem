namespace ElastoSystem
{
    partial class Compras_Proovedores
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
            panel5 = new Panel();
            lblCritico = new Label();
            btnNuevo = new Button();
            chbCritico = new CheckBox();
            btnEliminar = new Button();
            btnModificar = new Button();
            btnAgregar = new Button();
            lblID = new Label();
            txbNoCuenta = new TextBox();
            txbTelefono = new TextBox();
            txbRFC = new TextBox();
            txbDireccion = new TextBox();
            txbProductos = new TextBox();
            txbContacto = new TextBox();
            txbEmail = new TextBox();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txbNombre = new TextBox();
            label6 = new Label();
            panel1 = new Panel();
            dgvProveedores = new DataGridView();
            panel2 = new Panel();
            chbMostrarTodos = new CheckBox();
            btnBuscar = new Button();
            txbBuscador = new TextBox();
            label13 = new Label();
            panel5.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProveedores).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Montserrat", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(27, 27);
            label1.Name = "label1";
            label1.Size = new Size(276, 44);
            label1.TabIndex = 3;
            label1.Text = "PROVEEDORES";
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(3, 42, 76);
            panel5.Controls.Add(lblCritico);
            panel5.Controls.Add(btnNuevo);
            panel5.Controls.Add(chbCritico);
            panel5.Controls.Add(btnEliminar);
            panel5.Controls.Add(btnModificar);
            panel5.Controls.Add(btnAgregar);
            panel5.Controls.Add(lblID);
            panel5.Controls.Add(txbNoCuenta);
            panel5.Controls.Add(txbTelefono);
            panel5.Controls.Add(txbRFC);
            panel5.Controls.Add(txbDireccion);
            panel5.Controls.Add(txbProductos);
            panel5.Controls.Add(txbContacto);
            panel5.Controls.Add(txbEmail);
            panel5.Controls.Add(label11);
            panel5.Controls.Add(label10);
            panel5.Controls.Add(label9);
            panel5.Controls.Add(label8);
            panel5.Controls.Add(label7);
            panel5.Controls.Add(label5);
            panel5.Controls.Add(label4);
            panel5.Controls.Add(label3);
            panel5.Controls.Add(label2);
            panel5.Controls.Add(txbNombre);
            panel5.Controls.Add(label6);
            panel5.Location = new Point(27, 104);
            panel5.Name = "panel5";
            panel5.Size = new Size(834, 347);
            panel5.TabIndex = 22;
            // 
            // lblCritico
            // 
            lblCritico.AutoSize = true;
            lblCritico.BackColor = Color.Transparent;
            lblCritico.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCritico.ForeColor = Color.White;
            lblCritico.Location = new Point(332, 294);
            lblCritico.Name = "lblCritico";
            lblCritico.Size = new Size(19, 22);
            lblCritico.TabIndex = 35;
            lblCritico.Text = "2";
            lblCritico.Visible = false;
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = Color.FromArgb(255, 102, 0);
            btnNuevo.Cursor = Cursors.Hand;
            btnNuevo.FlatAppearance.BorderSize = 0;
            btnNuevo.FlatStyle = FlatStyle.Flat;
            btnNuevo.Font = new Font("Montserrat", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnNuevo.ForeColor = Color.White;
            btnNuevo.Location = new Point(445, 13);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(113, 30);
            btnNuevo.TabIndex = 34;
            btnNuevo.Text = "NUEVO";
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Visible = false;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // chbCritico
            // 
            chbCritico.AutoSize = true;
            chbCritico.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point);
            chbCritico.ForeColor = Color.White;
            chbCritico.Location = new Point(219, 290);
            chbCritico.Name = "chbCritico";
            chbCritico.Size = new Size(107, 26);
            chbCritico.TabIndex = 33;
            chbCritico.Text = "No Critico";
            chbCritico.UseVisualStyleBackColor = true;
            chbCritico.CheckStateChanged += chbCritico_CheckStateChanged;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(255, 102, 0);
            btnEliminar.Cursor = Cursors.Hand;
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Montserrat", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(683, 13);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(113, 30);
            btnEliminar.TabIndex = 30;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Visible = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.FromArgb(255, 102, 0);
            btnModificar.Cursor = Cursors.Hand;
            btnModificar.FlatAppearance.BorderSize = 0;
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.Font = new Font("Montserrat", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnModificar.ForeColor = Color.White;
            btnModificar.Location = new Point(564, 13);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(113, 30);
            btnModificar.TabIndex = 29;
            btnModificar.Text = "MODIFICAR";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Visible = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(255, 102, 0);
            btnAgregar.Cursor = Cursors.Hand;
            btnAgregar.FlatAppearance.BorderSize = 0;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Montserrat", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(683, 13);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(113, 30);
            btnAgregar.TabIndex = 28;
            btnAgregar.Text = "AGREGAR";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.BackColor = Color.Transparent;
            lblID.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblID.ForeColor = Color.White;
            lblID.Location = new Point(219, 21);
            lblID.Name = "lblID";
            lblID.Size = new Size(74, 22);
            lblID.TabIndex = 29;
            lblID.Text = "240000";
            // 
            // txbNoCuenta
            // 
            txbNoCuenta.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txbNoCuenta.Location = new Point(219, 258);
            txbNoCuenta.Name = "txbNoCuenta";
            txbNoCuenta.Size = new Size(577, 27);
            txbNoCuenta.TabIndex = 27;
            // 
            // txbTelefono
            // 
            txbTelefono.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txbTelefono.Location = new Point(219, 108);
            txbTelefono.Name = "txbTelefono";
            txbTelefono.Size = new Size(577, 27);
            txbTelefono.TabIndex = 26;
            // 
            // txbRFC
            // 
            txbRFC.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txbRFC.Location = new Point(219, 138);
            txbRFC.Name = "txbRFC";
            txbRFC.Size = new Size(577, 27);
            txbRFC.TabIndex = 25;
            // 
            // txbDireccion
            // 
            txbDireccion.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txbDireccion.Location = new Point(219, 168);
            txbDireccion.Name = "txbDireccion";
            txbDireccion.Size = new Size(577, 27);
            txbDireccion.TabIndex = 24;
            // 
            // txbProductos
            // 
            txbProductos.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txbProductos.Location = new Point(219, 198);
            txbProductos.Name = "txbProductos";
            txbProductos.Size = new Size(577, 27);
            txbProductos.TabIndex = 23;
            // 
            // txbContacto
            // 
            txbContacto.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txbContacto.Location = new Point(219, 228);
            txbContacto.Name = "txbContacto";
            txbContacto.Size = new Size(577, 27);
            txbContacto.TabIndex = 22;
            // 
            // txbEmail
            // 
            txbEmail.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txbEmail.Location = new Point(219, 78);
            txbEmail.Name = "txbEmail";
            txbEmail.Size = new Size(577, 27);
            txbEmail.TabIndex = 21;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = Color.White;
            label11.Location = new Point(24, 291);
            label11.Name = "label11";
            label11.Size = new Size(61, 22);
            label11.TabIndex = 20;
            label11.Text = "Critico";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.White;
            label10.Location = new Point(24, 261);
            label10.Name = "label10";
            label10.Size = new Size(165, 22);
            label10.TabIndex = 19;
            label10.Text = "Numero de Cuenta";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(24, 231);
            label9.Name = "label9";
            label9.Size = new Size(83, 22);
            label9.TabIndex = 18;
            label9.Text = "Contacto";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(24, 201);
            label8.Name = "label8";
            label8.Size = new Size(92, 22);
            label8.TabIndex = 17;
            label8.Text = "Productos";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(24, 171);
            label7.Name = "label7";
            label7.Size = new Size(86, 22);
            label7.TabIndex = 16;
            label7.Text = "Dirección";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(24, 141);
            label5.Name = "label5";
            label5.Size = new Size(44, 22);
            label5.TabIndex = 15;
            label5.Text = "RFC";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(24, 111);
            label4.Name = "label4";
            label4.Size = new Size(78, 22);
            label4.TabIndex = 14;
            label4.Text = "Telefono";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(24, 81);
            label3.Name = "label3";
            label3.Size = new Size(55, 22);
            label3.TabIndex = 13;
            label3.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(24, 51);
            label2.Name = "label2";
            label2.Size = new Size(77, 22);
            label2.TabIndex = 12;
            label2.Text = "Nombre";
            // 
            // txbNombre
            // 
            txbNombre.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txbNombre.Location = new Point(219, 48);
            txbNombre.Name = "txbNombre";
            txbNombre.Size = new Size(577, 27);
            txbNombre.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(24, 21);
            label6.Name = "label6";
            label6.Size = new Size(28, 22);
            label6.TabIndex = 10;
            label6.Text = "ID";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(3, 42, 76);
            panel1.Controls.Add(dgvProveedores);
            panel1.Location = new Point(27, 472);
            panel1.Name = "panel1";
            panel1.Size = new Size(1285, 317);
            panel1.TabIndex = 23;
            // 
            // dgvProveedores
            // 
            dgvProveedores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProveedores.BackgroundColor = Color.FromArgb(205, 215, 224);
            dgvProveedores.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(255, 102, 0);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvProveedores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvProveedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.WindowFrame;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvProveedores.DefaultCellStyle = dataGridViewCellStyle2;
            dgvProveedores.GridColor = SystemColors.ActiveCaptionText;
            dgvProveedores.Location = new Point(24, 30);
            dgvProveedores.Name = "dgvProveedores";
            dgvProveedores.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(205, 215, 224);
            dataGridViewCellStyle3.Font = new Font("Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(255, 102, 0);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvProveedores.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvProveedores.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Montserrat", 11F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(255, 102, 0);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dgvProveedores.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvProveedores.RowTemplate.Height = 25;
            dgvProveedores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProveedores.Size = new Size(1236, 265);
            dgvProveedores.TabIndex = 18;
            dgvProveedores.DoubleClick += dgvProveedores_DoubleClick;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(3, 42, 76);
            panel2.Controls.Add(chbMostrarTodos);
            panel2.Controls.Add(btnBuscar);
            panel2.Controls.Add(txbBuscador);
            panel2.Controls.Add(label13);
            panel2.Location = new Point(889, 104);
            panel2.Name = "panel2";
            panel2.Size = new Size(423, 347);
            panel2.TabIndex = 24;
            // 
            // chbMostrarTodos
            // 
            chbMostrarTodos.AutoSize = true;
            chbMostrarTodos.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point);
            chbMostrarTodos.ForeColor = Color.White;
            chbMostrarTodos.Location = new Point(142, 162);
            chbMostrarTodos.Name = "chbMostrarTodos";
            chbMostrarTodos.Size = new Size(139, 26);
            chbMostrarTodos.TabIndex = 32;
            chbMostrarTodos.Text = "Mostrar Todos";
            chbMostrarTodos.UseVisualStyleBackColor = true;
            chbMostrarTodos.CheckedChanged += chbMostrarTodos_CheckedChanged;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(255, 102, 0);
            btnBuscar.Cursor = Cursors.Hand;
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Montserrat", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Location = new Point(155, 199);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(113, 30);
            btnBuscar.TabIndex = 31;
            btnBuscar.Text = "BUSCAR";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txbBuscador
            // 
            txbBuscador.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txbBuscador.Location = new Point(37, 120);
            txbBuscador.Name = "txbBuscador";
            txbBuscador.Size = new Size(361, 27);
            txbBuscador.TabIndex = 26;
            txbBuscador.TextChanged += txbBuscador_TextChanged;
            txbBuscador.KeyDown += txbBuscador_KeyDown;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.Font = new Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = Color.White;
            label13.Location = new Point(157, 77);
            label13.Name = "label13";
            label13.Size = new Size(108, 22);
            label13.TabIndex = 20;
            label13.Text = "BUSCADOR";
            // 
            // Compras_Proovedores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fondocontrolalmacen;
            ClientSize = new Size(1338, 831);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel5);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Compras_Proovedores";
            Text = "Compras_Proovedores";
            Load += Compras_Proovedores_Load;
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProveedores).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel5;
        private Panel panel1;
        private Panel panel2;
        private Label label2;
        private TextBox txbNombre;
        private Label label6;
        private Label label3;
        private Label label4;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label5;
        private Label label11;
        private Label lblID;
        private TextBox txbNoCuenta;
        private TextBox txbTelefono;
        private TextBox txbRFC;
        private TextBox txbDireccion;
        private TextBox txbProductos;
        private TextBox txbContacto;
        private TextBox txbEmail;
        private Button btnEliminar;
        private Button btnModificar;
        private Button btnAgregar;
        private Label label13;
        private TextBox txbBuscador;
        private CheckBox chbCritico;
        private CheckBox chbMostrarTodos;
        private Button btnBuscar;
        private DataGridView dgvProveedores;
        private Button btnNuevo;
        private Label lblCritico;
    }
}