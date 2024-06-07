namespace ElastoSystem
{
    partial class Ventas_Cotizacion
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
            panel2 = new Panel();
            txbCorreo = new TextBox();
            txbTelefono = new TextBox();
            cbEmpresa = new ComboBox();
            cbContacto = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            panel1 = new Panel();
            btnAgregarCliente = new Button();
            lblFecha = new Label();
            label7 = new Label();
            txbFolio = new TextBox();
            label6 = new Label();
            lblID = new Label();
            panel3 = new Panel();
            btnLimpiarCampos = new Button();
            btnAgregarProducto = new Button();
            txbPrecio = new TextBox();
            txbCantidad = new TextBox();
            cbProductos = new ComboBox();
            cbClave = new ComboBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            dgvListaProductos = new DataGridView();
            Clav = new DataGridViewTextBoxColumn();
            Producto = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            Importe = new DataGridViewTextBoxColumn();
            txbTotal = new TextBox();
            label14 = new Label();
            txbIVA = new TextBox();
            txbSubtotal = new TextBox();
            label12 = new Label();
            label13 = new Label();
            btnGenerarCot = new Button();
            btnEnvCorreo = new Button();
            txbTotalLetras = new TextBox();
            chbSigla03 = new CheckBox();
            txbPartidas = new TextBox();
            lblExcepto = new Label();
            txbDescuento = new TextBox();
            chbDescuento = new CheckBox();
            lblContactoOEmpresa = new Label();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListaProductos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Montserrat", 22F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(33, 35);
            label1.Name = "label1";
            label1.Size = new Size(218, 41);
            label1.TabIndex = 3;
            label1.Text = "COTIZACIÓN";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(3, 42, 76);
            panel2.Controls.Add(txbCorreo);
            panel2.Controls.Add(txbTelefono);
            panel2.Controls.Add(cbEmpresa);
            panel2.Controls.Add(cbContacto);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label5);
            panel2.Location = new Point(33, 102);
            panel2.Name = "panel2";
            panel2.Size = new Size(868, 177);
            panel2.TabIndex = 23;
            // 
            // txbCorreo
            // 
            txbCorreo.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txbCorreo.Location = new Point(153, 131);
            txbCorreo.Name = "txbCorreo";
            txbCorreo.Size = new Size(673, 27);
            txbCorreo.TabIndex = 32;
            // 
            // txbTelefono
            // 
            txbTelefono.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txbTelefono.Location = new Point(153, 93);
            txbTelefono.Name = "txbTelefono";
            txbTelefono.Size = new Size(673, 27);
            txbTelefono.TabIndex = 31;
            // 
            // cbEmpresa
            // 
            cbEmpresa.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbEmpresa.FormattingEnabled = true;
            cbEmpresa.Location = new Point(153, 51);
            cbEmpresa.Name = "cbEmpresa";
            cbEmpresa.Size = new Size(673, 30);
            cbEmpresa.TabIndex = 30;
            cbEmpresa.SelectedIndexChanged += cbEmpresa_SelectedIndexChanged;
            // 
            // cbContacto
            // 
            cbContacto.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbContacto.FormattingEnabled = true;
            cbContacto.Location = new Point(153, 13);
            cbContacto.Name = "cbContacto";
            cbContacto.Size = new Size(673, 30);
            cbContacto.TabIndex = 29;
            cbContacto.SelectedIndexChanged += cbContacto_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Montserrat", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(23, 17);
            label2.Name = "label2";
            label2.Size = new Size(101, 21);
            label2.TabIndex = 2;
            label2.Text = "CONTACTO:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Montserrat", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(23, 55);
            label3.Name = "label3";
            label3.Size = new Size(89, 21);
            label3.TabIndex = 3;
            label3.Text = "EMPRESA:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Montserrat", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(23, 96);
            label4.Name = "label4";
            label4.Size = new Size(98, 21);
            label4.TabIndex = 8;
            label4.Text = "TELEFONO:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Montserrat", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(23, 134);
            label5.Name = "label5";
            label5.Size = new Size(82, 21);
            label5.TabIndex = 12;
            label5.Text = "CORREO:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(3, 42, 76);
            panel1.Controls.Add(btnAgregarCliente);
            panel1.Controls.Add(lblFecha);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(txbFolio);
            panel1.Controls.Add(label6);
            panel1.Location = new Point(922, 102);
            panel1.Name = "panel1";
            panel1.Size = new Size(378, 177);
            panel1.TabIndex = 24;
            // 
            // btnAgregarCliente
            // 
            btnAgregarCliente.BackColor = Color.FromArgb(255, 102, 0);
            btnAgregarCliente.Cursor = Cursors.Hand;
            btnAgregarCliente.FlatAppearance.BorderSize = 0;
            btnAgregarCliente.FlatStyle = FlatStyle.Flat;
            btnAgregarCliente.Font = new Font("Montserrat", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregarCliente.ForeColor = Color.White;
            btnAgregarCliente.Location = new Point(53, 119);
            btnAgregarCliente.Name = "btnAgregarCliente";
            btnAgregarCliente.Size = new Size(286, 36);
            btnAgregarCliente.TabIndex = 36;
            btnAgregarCliente.Text = "AGREGAR CLIENTE";
            btnAgregarCliente.UseVisualStyleBackColor = false;
            btnAgregarCliente.Click += btnAgregarCliente_Click;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.BackColor = Color.Transparent;
            lblFecha.Font = new Font("Montserrat", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblFecha.ForeColor = Color.White;
            lblFecha.Location = new Point(85, 33);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(121, 21);
            lblFecha.TabIndex = 35;
            lblFecha.Text = "FECHA LARGA";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Montserrat", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(16, 33);
            label7.Name = "label7";
            label7.Size = new Size(66, 21);
            label7.TabIndex = 34;
            label7.Text = "FECHA:";
            // 
            // txbFolio
            // 
            txbFolio.Enabled = false;
            txbFolio.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txbFolio.Location = new Point(85, 71);
            txbFolio.Name = "txbFolio";
            txbFolio.ReadOnly = true;
            txbFolio.Size = new Size(272, 27);
            txbFolio.TabIndex = 34;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Montserrat", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(20, 75);
            label6.Name = "label6";
            label6.Size = new Size(62, 21);
            label6.TabIndex = 33;
            label6.Text = "FOLIO:";
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.BackColor = Color.Transparent;
            lblID.Font = new Font("Montserrat", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblID.ForeColor = Color.White;
            lblID.Location = new Point(1124, 35);
            lblID.Name = "lblID";
            lblID.Size = new Size(176, 21);
            lblID.TabIndex = 36;
            lblID.Text = "ID CLIENTES NUEVOS";
            lblID.Visible = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(3, 42, 76);
            panel3.Controls.Add(btnLimpiarCampos);
            panel3.Controls.Add(btnAgregarProducto);
            panel3.Controls.Add(txbPrecio);
            panel3.Controls.Add(txbCantidad);
            panel3.Controls.Add(cbProductos);
            panel3.Controls.Add(cbClave);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(label11);
            panel3.Location = new Point(33, 298);
            panel3.Name = "panel3";
            panel3.Size = new Size(1267, 97);
            panel3.TabIndex = 25;
            // 
            // btnLimpiarCampos
            // 
            btnLimpiarCampos.BackColor = Color.FromArgb(255, 102, 0);
            btnLimpiarCampos.Cursor = Cursors.Hand;
            btnLimpiarCampos.FlatAppearance.BorderSize = 0;
            btnLimpiarCampos.FlatStyle = FlatStyle.Flat;
            btnLimpiarCampos.Font = new Font("Montserrat", 8F, FontStyle.Bold, GraphicsUnit.Point);
            btnLimpiarCampos.ForeColor = Color.White;
            btnLimpiarCampos.Location = new Point(721, 55);
            btnLimpiarCampos.Name = "btnLimpiarCampos";
            btnLimpiarCampos.Size = new Size(185, 27);
            btnLimpiarCampos.TabIndex = 38;
            btnLimpiarCampos.Text = "LIMPIAR CAMPOS";
            btnLimpiarCampos.UseVisualStyleBackColor = false;
            btnLimpiarCampos.Click += btnLimpiarCampos_Click;
            // 
            // btnAgregarProducto
            // 
            btnAgregarProducto.BackColor = Color.FromArgb(255, 102, 0);
            btnAgregarProducto.Cursor = Cursors.Hand;
            btnAgregarProducto.FlatAppearance.BorderSize = 0;
            btnAgregarProducto.FlatStyle = FlatStyle.Flat;
            btnAgregarProducto.Font = new Font("Montserrat", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregarProducto.ForeColor = Color.White;
            btnAgregarProducto.Location = new Point(1089, 32);
            btnAgregarProducto.Name = "btnAgregarProducto";
            btnAgregarProducto.Size = new Size(143, 36);
            btnAgregarProducto.TabIndex = 37;
            btnAgregarProducto.Text = "AGREGAR";
            btnAgregarProducto.UseVisualStyleBackColor = false;
            btnAgregarProducto.Click += btnAgregarProducto_Click;
            // 
            // txbPrecio
            // 
            txbPrecio.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txbPrecio.Location = new Point(392, 55);
            txbPrecio.Name = "txbPrecio";
            txbPrecio.Size = new Size(109, 27);
            txbPrecio.TabIndex = 32;
            // 
            // txbCantidad
            // 
            txbCantidad.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txbCantidad.Location = new Point(125, 55);
            txbCantidad.Name = "txbCantidad";
            txbCantidad.Size = new Size(141, 27);
            txbCantidad.TabIndex = 31;
            // 
            // cbProductos
            // 
            cbProductos.DropDownStyle = ComboBoxStyle.DropDownList;
            cbProductos.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbProductos.FormattingEnabled = true;
            cbProductos.Location = new Point(392, 13);
            cbProductos.Name = "cbProductos";
            cbProductos.Size = new Size(673, 30);
            cbProductos.TabIndex = 30;
            cbProductos.SelectedIndexChanged += cbProductos_SelectedIndexChanged;
            // 
            // cbClave
            // 
            cbClave.DropDownStyle = ComboBoxStyle.DropDownList;
            cbClave.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbClave.FormattingEnabled = true;
            cbClave.Location = new Point(92, 13);
            cbClave.Name = "cbClave";
            cbClave.Size = new Size(174, 30);
            cbClave.TabIndex = 29;
            cbClave.SelectedIndexChanged += cbClave_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Montserrat", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(23, 17);
            label8.Name = "label8";
            label8.Size = new Size(63, 21);
            label8.TabIndex = 2;
            label8.Text = "CLAVE:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Montserrat", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(281, 17);
            label9.Name = "label9";
            label9.Size = new Size(105, 21);
            label9.TabIndex = 3;
            label9.Text = "PRODUCTO:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Montserrat", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.White;
            label10.Location = new Point(23, 59);
            label10.Name = "label10";
            label10.Size = new Size(96, 21);
            label10.TabIndex = 8;
            label10.Text = "CANTIDAD:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Montserrat", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = Color.White;
            label11.Location = new Point(281, 59);
            label11.Name = "label11";
            label11.Size = new Size(74, 21);
            label11.TabIndex = 12;
            label11.Text = "PRECIO:";
            // 
            // dgvListaProductos
            // 
            dgvListaProductos.AllowUserToAddRows = false;
            dgvListaProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvListaProductos.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Montserrat SemiBold", 9.749999F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(255, 102, 0);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvListaProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvListaProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListaProductos.Columns.AddRange(new DataGridViewColumn[] { Clav, Producto, Precio, Cantidad, Importe });
            dgvListaProductos.Enabled = false;
            dgvListaProductos.Location = new Point(33, 417);
            dgvListaProductos.Name = "dgvListaProductos";
            dgvListaProductos.ReadOnly = true;
            dgvListaProductos.RowHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(255, 102, 0);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dgvListaProductos.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvListaProductos.RowTemplate.Height = 25;
            dgvListaProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvListaProductos.Size = new Size(1267, 187);
            dgvListaProductos.TabIndex = 26;
            dgvListaProductos.CellDoubleClick += dgvListaProductos_CellDoubleClick;
            dgvListaProductos.DoubleClick += dgvListaProductos_DoubleClick;
            // 
            // Clav
            // 
            Clav.FillWeight = 45.98384F;
            Clav.HeaderText = "CLAVE";
            Clav.Name = "Clav";
            Clav.ReadOnly = true;
            // 
            // Producto
            // 
            Producto.FillWeight = 150.460724F;
            Producto.HeaderText = "PRODUCTO";
            Producto.Name = "Producto";
            Producto.ReadOnly = true;
            // 
            // Precio
            // 
            Precio.FillWeight = 25.9452248F;
            Precio.HeaderText = "PRECIO";
            Precio.Name = "Precio";
            Precio.ReadOnly = true;
            // 
            // Cantidad
            // 
            Cantidad.FillWeight = 25.66498F;
            Cantidad.HeaderText = "CANTIDAD";
            Cantidad.Name = "Cantidad";
            Cantidad.ReadOnly = true;
            // 
            // Importe
            // 
            Importe.FillWeight = 25.9452248F;
            Importe.HeaderText = "IMPORTE";
            Importe.Name = "Importe";
            Importe.ReadOnly = true;
            // 
            // txbTotal
            // 
            txbTotal.Enabled = false;
            txbTotal.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txbTotal.Location = new Point(1150, 714);
            txbTotal.Multiline = true;
            txbTotal.Name = "txbTotal";
            txbTotal.Size = new Size(149, 30);
            txbTotal.TabIndex = 55;
            txbTotal.TextChanged += txbTotal_TextChanged;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.Transparent;
            label14.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label14.ForeColor = Color.White;
            label14.Location = new Point(1018, 717);
            label14.Name = "label14";
            label14.Size = new Size(97, 22);
            label14.TabIndex = 54;
            label14.Text = "Total (USD)";
            // 
            // txbIVA
            // 
            txbIVA.Enabled = false;
            txbIVA.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txbIVA.Location = new Point(1150, 648);
            txbIVA.Multiline = true;
            txbIVA.Name = "txbIVA";
            txbIVA.Size = new Size(149, 30);
            txbIVA.TabIndex = 53;
            // 
            // txbSubtotal
            // 
            txbSubtotal.Enabled = false;
            txbSubtotal.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txbSubtotal.Location = new Point(1150, 615);
            txbSubtotal.Multiline = true;
            txbSubtotal.Name = "txbSubtotal";
            txbSubtotal.Size = new Size(149, 30);
            txbSubtotal.TabIndex = 52;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label12.ForeColor = Color.White;
            label12.Location = new Point(1018, 617);
            label12.Name = "label12";
            label12.Size = new Size(77, 22);
            label12.TabIndex = 51;
            label12.Text = "Subtotal";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label13.ForeColor = Color.White;
            label13.Location = new Point(1018, 651);
            label13.Name = "label13";
            label13.Size = new Size(69, 22);
            label13.TabIndex = 56;
            label13.Text = "IVA 16%";
            // 
            // btnGenerarCot
            // 
            btnGenerarCot.BackColor = Color.FromArgb(255, 102, 0);
            btnGenerarCot.Cursor = Cursors.Hand;
            btnGenerarCot.FlatAppearance.BorderSize = 0;
            btnGenerarCot.FlatStyle = FlatStyle.Flat;
            btnGenerarCot.Font = new Font("Montserrat", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnGenerarCot.ForeColor = Color.White;
            btnGenerarCot.Location = new Point(681, 695);
            btnGenerarCot.Name = "btnGenerarCot";
            btnGenerarCot.Size = new Size(258, 44);
            btnGenerarCot.TabIndex = 57;
            btnGenerarCot.Text = "GENERAR COTIZACION";
            btnGenerarCot.UseVisualStyleBackColor = false;
            btnGenerarCot.Click += btnGenerarCot_Click;
            // 
            // btnEnvCorreo
            // 
            btnEnvCorreo.BackColor = Color.FromArgb(255, 102, 0);
            btnEnvCorreo.Cursor = Cursors.Hand;
            btnEnvCorreo.FlatAppearance.BorderSize = 0;
            btnEnvCorreo.FlatStyle = FlatStyle.Flat;
            btnEnvCorreo.Font = new Font("Montserrat", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnEnvCorreo.ForeColor = Color.White;
            btnEnvCorreo.Location = new Point(130, 766);
            btnEnvCorreo.Name = "btnEnvCorreo";
            btnEnvCorreo.Size = new Size(258, 44);
            btnEnvCorreo.TabIndex = 58;
            btnEnvCorreo.Text = "ENVIAR CORREO";
            btnEnvCorreo.UseVisualStyleBackColor = false;
            btnEnvCorreo.Visible = false;
            btnEnvCorreo.Click += btnEnvCorreo_Click;
            // 
            // txbTotalLetras
            // 
            txbTotalLetras.Location = new Point(492, 796);
            txbTotalLetras.Name = "txbTotalLetras";
            txbTotalLetras.Size = new Size(834, 23);
            txbTotalLetras.TabIndex = 59;
            txbTotalLetras.Visible = false;
            // 
            // chbSigla03
            // 
            chbSigla03.AutoSize = true;
            chbSigla03.BackColor = Color.Transparent;
            chbSigla03.Checked = true;
            chbSigla03.CheckState = CheckState.Checked;
            chbSigla03.Font = new Font("Montserrat", 10F, FontStyle.Bold, GraphicsUnit.Point);
            chbSigla03.ForeColor = Color.White;
            chbSigla03.Location = new Point(33, 615);
            chbSigla03.Name = "chbSigla03";
            chbSigla03.Size = new Size(569, 24);
            chbSigla03.TabIndex = 60;
            chbSigla03.Text = "TODOS LOS MATERIALES CUENTAN CON AVISO DE PRUEBA SIGLA 03 CFE";
            chbSigla03.UseVisualStyleBackColor = false;
            chbSigla03.CheckedChanged += chbSigla03_CheckedChanged;
            // 
            // txbPartidas
            // 
            txbPartidas.Font = new Font("Montserrat", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txbPartidas.Location = new Point(144, 642);
            txbPartidas.Name = "txbPartidas";
            txbPartidas.Size = new Size(458, 24);
            txbPartidas.TabIndex = 61;
            txbPartidas.Visible = false;
            // 
            // lblExcepto
            // 
            lblExcepto.AutoSize = true;
            lblExcepto.BackColor = Color.Transparent;
            lblExcepto.Font = new Font("Montserrat", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblExcepto.ForeColor = Color.White;
            lblExcepto.Location = new Point(56, 642);
            lblExcepto.Name = "lblExcepto";
            lblExcepto.Size = new Size(87, 21);
            lblExcepto.TabIndex = 62;
            lblExcepto.Text = "EXCEPTO:";
            lblExcepto.Visible = false;
            // 
            // txbDescuento
            // 
            txbDescuento.Enabled = false;
            txbDescuento.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txbDescuento.Location = new Point(1150, 681);
            txbDescuento.Multiline = true;
            txbDescuento.Name = "txbDescuento";
            txbDescuento.Size = new Size(149, 30);
            txbDescuento.TabIndex = 63;
            txbDescuento.Text = "0";
            txbDescuento.TextChanged += txbDescuento_TextChanged;
            // 
            // chbDescuento
            // 
            chbDescuento.AutoSize = true;
            chbDescuento.BackColor = Color.Transparent;
            chbDescuento.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point);
            chbDescuento.ForeColor = Color.White;
            chbDescuento.Location = new Point(1001, 683);
            chbDescuento.Name = "chbDescuento";
            chbDescuento.Size = new Size(134, 26);
            chbDescuento.TabIndex = 64;
            chbDescuento.Text = "Descuento %";
            chbDescuento.UseVisualStyleBackColor = false;
            chbDescuento.CheckedChanged += chbDescuento_CheckedChanged;
            // 
            // lblContactoOEmpresa
            // 
            lblContactoOEmpresa.AutoSize = true;
            lblContactoOEmpresa.BackColor = Color.Transparent;
            lblContactoOEmpresa.Font = new Font("Montserrat", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblContactoOEmpresa.ForeColor = Color.White;
            lblContactoOEmpresa.Location = new Point(347, 78);
            lblContactoOEmpresa.Name = "lblContactoOEmpresa";
            lblContactoOEmpresa.Size = new Size(187, 21);
            lblContactoOEmpresa.TabIndex = 65;
            lblContactoOEmpresa.Text = "CONTACTO / EMPRESA";
            lblContactoOEmpresa.Visible = false;
            // 
            // Ventas_Cotizacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fondocontrolalmacen;
            ClientSize = new Size(1338, 831);
            Controls.Add(lblContactoOEmpresa);
            Controls.Add(lblID);
            Controls.Add(chbDescuento);
            Controls.Add(txbDescuento);
            Controls.Add(lblExcepto);
            Controls.Add(txbPartidas);
            Controls.Add(chbSigla03);
            Controls.Add(txbTotalLetras);
            Controls.Add(btnEnvCorreo);
            Controls.Add(btnGenerarCot);
            Controls.Add(label13);
            Controls.Add(txbTotal);
            Controls.Add(label14);
            Controls.Add(txbIVA);
            Controls.Add(txbSubtotal);
            Controls.Add(label12);
            Controls.Add(dgvListaProductos);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Ventas_Cotizacion";
            Text = "Ventas_Cotizacion";
            Load += Ventas_Cotizacion_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListaProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel2;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox cbEmpresa;
        private ComboBox cbContacto;
        private TextBox txbCorreo;
        private TextBox txbTelefono;
        private Panel panel1;
        private TextBox txbFolio;
        private Label label6;
        private Label label7;
        private Label lblFecha;
        private Button btnAgregarCliente;
        private Label lblID;
        private Panel panel3;
        private TextBox txbPrecio;
        private TextBox txbCantidad;
        private ComboBox cbProductos;
        private ComboBox cbClave;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Button btnAgregarProducto;
        private DataGridView dgvListaProductos;
        private DataGridViewTextBoxColumn Clav;
        private DataGridViewTextBoxColumn Producto;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Importe;
        private TextBox txbTotal;
        private Label label14;
        private TextBox txbIVA;
        private TextBox txbSubtotal;
        private Label label12;
        private Label label13;
        private Button btnLimpiarCampos;
        private Button btnGenerarCot;
        private Button btnEnvCorreo;
        private TextBox txbTotalLetras;
        private CheckBox chbSigla03;
        private TextBox txbPartidas;
        private Label lblExcepto;
        private TextBox txbDescuento;
        private CheckBox chbDescuento;
        private Label lblContactoOEmpresa;
    }
}