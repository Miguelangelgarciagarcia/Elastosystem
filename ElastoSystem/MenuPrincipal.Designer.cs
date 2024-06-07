namespace ElastoSystem
{
    partial class MenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            PBarraTitulo = new Panel();
            PBNaranja = new PictureBox();
            PBAzul = new PictureBox();
            PBICerrar = new PictureBox();
            PBIconoMin = new PictureBox();
            panelSideMenu = new Panel();
            sbmMaquinado = new Panel();
            btnPendientesMaquinado = new Button();
            btnSolicitudMquinado = new Button();
            btnMaquinado = new Button();
            sbmProduccion = new Panel();
            btnReporte = new Button();
            btnProduccion = new Button();
            sbmVentas = new Panel();
            btnNuevaCotizacion = new Button();
            btnCatalogoProductos = new Button();
            btnCatalogoClientes = new Button();
            btnBuscarCotizacion = new Button();
            btnVentas = new Button();
            panelSubMenu4 = new Panel();
            btnPermisos = new Button();
            btnSistemasReq = new Button();
            button1 = new Button();
            panel1 = new Panel();
            btninfo = new Button();
            panelSubMenu3 = new Panel();
            btnCredencial = new Button();
            btnRegistroTrabajador = new Button();
            button11 = new Button();
            panelSubMenu2 = new Panel();
            btnIndCompras = new Button();
            btnReqEnv = new Button();
            btnAdmiProveedores = new Button();
            btnAdmiReq = new Button();
            btnReqCompra = new Button();
            btnConsumibles = new Button();
            button6 = new Button();
            panelSubMenuAlmacen = new Panel();
            btnConsultaSalidas = new Button();
            btnControlAlmacen = new Button();
            btnRegistrarExistencias = new Button();
            btnNuevoProducto = new Button();
            btnalmacen = new Button();
            panelLogo = new Panel();
            pictureBox1 = new PictureBox();
            panelPrincipal = new Panel();
            dgv = new DataGridView();
            labelid = new Label();
            PBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PBNaranja).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PBAzul).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PBICerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PBIconoMin).BeginInit();
            panelSideMenu.SuspendLayout();
            sbmMaquinado.SuspendLayout();
            sbmProduccion.SuspendLayout();
            sbmVentas.SuspendLayout();
            panelSubMenu4.SuspendLayout();
            panel1.SuspendLayout();
            panelSubMenu3.SuspendLayout();
            panelSubMenu2.SuspendLayout();
            panelSubMenuAlmacen.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            SuspendLayout();
            // 
            // PBarraTitulo
            // 
            PBarraTitulo.BackColor = Color.FromArgb(153, 255, 255, 255);
            PBarraTitulo.Controls.Add(PBNaranja);
            PBarraTitulo.Controls.Add(PBAzul);
            PBarraTitulo.Controls.Add(PBICerrar);
            PBarraTitulo.Controls.Add(PBIconoMin);
            PBarraTitulo.Dock = DockStyle.Top;
            PBarraTitulo.Location = new Point(0, 0);
            PBarraTitulo.Name = "PBarraTitulo";
            PBarraTitulo.Size = new Size(1542, 30);
            PBarraTitulo.TabIndex = 0;
            PBarraTitulo.MouseDown += PBarraTitulo_MouseDown;
            // 
            // PBNaranja
            // 
            PBNaranja.BackColor = Color.Transparent;
            PBNaranja.Image = (Image)resources.GetObject("PBNaranja.Image");
            PBNaranja.Location = new Point(1504, 3);
            PBNaranja.Name = "PBNaranja";
            PBNaranja.Size = new Size(24, 24);
            PBNaranja.SizeMode = PictureBoxSizeMode.Zoom;
            PBNaranja.TabIndex = 4;
            PBNaranja.TabStop = false;
            PBNaranja.MouseMove += PBNaranja_MouseMove;
            // 
            // PBAzul
            // 
            PBAzul.BackColor = Color.Transparent;
            PBAzul.Image = (Image)resources.GetObject("PBAzul.Image");
            PBAzul.Location = new Point(1474, 3);
            PBAzul.Name = "PBAzul";
            PBAzul.Size = new Size(24, 24);
            PBAzul.SizeMode = PictureBoxSizeMode.Zoom;
            PBAzul.TabIndex = 3;
            PBAzul.TabStop = false;
            PBAzul.MouseMove += PBAzul_MouseMove;
            // 
            // PBICerrar
            // 
            PBICerrar.BackColor = Color.Transparent;
            PBICerrar.Image = (Image)resources.GetObject("PBICerrar.Image");
            PBICerrar.Location = new Point(1504, 3);
            PBICerrar.Name = "PBICerrar";
            PBICerrar.Size = new Size(24, 24);
            PBICerrar.SizeMode = PictureBoxSizeMode.Zoom;
            PBICerrar.TabIndex = 2;
            PBICerrar.TabStop = false;
            PBICerrar.Click += PBICerrar_Click;
            PBICerrar.MouseLeave += PBICerrar_MouseLeave;
            // 
            // PBIconoMin
            // 
            PBIconoMin.BackColor = Color.Transparent;
            PBIconoMin.Image = Properties.Resources.circuloazulminimizar;
            PBIconoMin.Location = new Point(1474, 3);
            PBIconoMin.Name = "PBIconoMin";
            PBIconoMin.Size = new Size(24, 24);
            PBIconoMin.SizeMode = PictureBoxSizeMode.Zoom;
            PBIconoMin.TabIndex = 1;
            PBIconoMin.TabStop = false;
            PBIconoMin.Click += PBIconoMin_Click;
            PBIconoMin.MouseLeave += PBIconoMin_MouseLeave;
            // 
            // panelSideMenu
            // 
            panelSideMenu.AutoScroll = true;
            panelSideMenu.BackColor = Color.FromArgb(0, 33, 64);
            panelSideMenu.Controls.Add(sbmMaquinado);
            panelSideMenu.Controls.Add(btnMaquinado);
            panelSideMenu.Controls.Add(sbmProduccion);
            panelSideMenu.Controls.Add(btnProduccion);
            panelSideMenu.Controls.Add(sbmVentas);
            panelSideMenu.Controls.Add(btnVentas);
            panelSideMenu.Controls.Add(panelSubMenu4);
            panelSideMenu.Controls.Add(button1);
            panelSideMenu.Controls.Add(panel1);
            panelSideMenu.Controls.Add(panelSubMenu3);
            panelSideMenu.Controls.Add(button11);
            panelSideMenu.Controls.Add(panelSubMenu2);
            panelSideMenu.Controls.Add(button6);
            panelSideMenu.Controls.Add(panelSubMenuAlmacen);
            panelSideMenu.Controls.Add(btnalmacen);
            panelSideMenu.Controls.Add(panelLogo);
            panelSideMenu.Dock = DockStyle.Left;
            panelSideMenu.Location = new Point(0, 30);
            panelSideMenu.Name = "panelSideMenu";
            panelSideMenu.Size = new Size(204, 831);
            panelSideMenu.TabIndex = 1;
            panelSideMenu.Paint += panelSideMenu_Paint;
            // 
            // sbmMaquinado
            // 
            sbmMaquinado.BackColor = Color.FromArgb(3, 52, 92);
            sbmMaquinado.Controls.Add(btnPendientesMaquinado);
            sbmMaquinado.Controls.Add(btnSolicitudMquinado);
            sbmMaquinado.Dock = DockStyle.Top;
            sbmMaquinado.Location = new Point(0, 1103);
            sbmMaquinado.Name = "sbmMaquinado";
            sbmMaquinado.Size = new Size(187, 83);
            sbmMaquinado.TabIndex = 15;
            // 
            // btnPendientesMaquinado
            // 
            btnPendientesMaquinado.Dock = DockStyle.Top;
            btnPendientesMaquinado.Enabled = false;
            btnPendientesMaquinado.FlatAppearance.BorderSize = 0;
            btnPendientesMaquinado.FlatStyle = FlatStyle.Flat;
            btnPendientesMaquinado.Font = new Font("Montserrat", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnPendientesMaquinado.ForeColor = Color.White;
            btnPendientesMaquinado.Location = new Point(0, 36);
            btnPendientesMaquinado.Name = "btnPendientesMaquinado";
            btnPendientesMaquinado.Padding = new Padding(20, 0, 0, 0);
            btnPendientesMaquinado.Size = new Size(187, 36);
            btnPendientesMaquinado.TabIndex = 4;
            btnPendientesMaquinado.Text = "Pendientes Maquinado";
            btnPendientesMaquinado.TextAlign = ContentAlignment.MiddleLeft;
            btnPendientesMaquinado.UseVisualStyleBackColor = true;
            btnPendientesMaquinado.Visible = false;
            btnPendientesMaquinado.Click += btnPendientesMaquinado_Click;
            // 
            // btnSolicitudMquinado
            // 
            btnSolicitudMquinado.Dock = DockStyle.Top;
            btnSolicitudMquinado.Enabled = false;
            btnSolicitudMquinado.FlatAppearance.BorderSize = 0;
            btnSolicitudMquinado.FlatStyle = FlatStyle.Flat;
            btnSolicitudMquinado.Font = new Font("Montserrat", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnSolicitudMquinado.ForeColor = Color.White;
            btnSolicitudMquinado.Location = new Point(0, 0);
            btnSolicitudMquinado.Name = "btnSolicitudMquinado";
            btnSolicitudMquinado.Padding = new Padding(20, 0, 0, 0);
            btnSolicitudMquinado.Size = new Size(187, 36);
            btnSolicitudMquinado.TabIndex = 3;
            btnSolicitudMquinado.Text = "Solicitud Maquinado";
            btnSolicitudMquinado.TextAlign = ContentAlignment.MiddleLeft;
            btnSolicitudMquinado.UseVisualStyleBackColor = true;
            btnSolicitudMquinado.Visible = false;
            btnSolicitudMquinado.Click += btnSolicitudMquinado_Click;
            // 
            // btnMaquinado
            // 
            btnMaquinado.Dock = DockStyle.Top;
            btnMaquinado.Enabled = false;
            btnMaquinado.FlatAppearance.BorderSize = 0;
            btnMaquinado.FlatStyle = FlatStyle.Flat;
            btnMaquinado.Font = new Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnMaquinado.ForeColor = Color.White;
            btnMaquinado.Location = new Point(0, 1067);
            btnMaquinado.Name = "btnMaquinado";
            btnMaquinado.Padding = new Padding(10, 0, 0, 0);
            btnMaquinado.Size = new Size(187, 36);
            btnMaquinado.TabIndex = 14;
            btnMaquinado.Text = "Maquinado";
            btnMaquinado.TextAlign = ContentAlignment.MiddleLeft;
            btnMaquinado.UseVisualStyleBackColor = true;
            btnMaquinado.Visible = false;
            btnMaquinado.Click += btnMaquinado_Click;
            // 
            // sbmProduccion
            // 
            sbmProduccion.BackColor = Color.FromArgb(3, 52, 92);
            sbmProduccion.Controls.Add(btnReporte);
            sbmProduccion.Dock = DockStyle.Top;
            sbmProduccion.Location = new Point(0, 1015);
            sbmProduccion.Name = "sbmProduccion";
            sbmProduccion.Size = new Size(187, 52);
            sbmProduccion.TabIndex = 13;
            // 
            // btnReporte
            // 
            btnReporte.Dock = DockStyle.Top;
            btnReporte.Enabled = false;
            btnReporte.FlatAppearance.BorderSize = 0;
            btnReporte.FlatStyle = FlatStyle.Flat;
            btnReporte.Font = new Font("Montserrat", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnReporte.ForeColor = Color.White;
            btnReporte.Location = new Point(0, 0);
            btnReporte.Name = "btnReporte";
            btnReporte.Padding = new Padding(20, 0, 0, 0);
            btnReporte.Size = new Size(187, 36);
            btnReporte.TabIndex = 3;
            btnReporte.Text = "Reporte";
            btnReporte.TextAlign = ContentAlignment.MiddleLeft;
            btnReporte.UseVisualStyleBackColor = true;
            btnReporte.Visible = false;
            btnReporte.Click += btnReporte_Click;
            // 
            // btnProduccion
            // 
            btnProduccion.Dock = DockStyle.Top;
            btnProduccion.Enabled = false;
            btnProduccion.FlatAppearance.BorderSize = 0;
            btnProduccion.FlatStyle = FlatStyle.Flat;
            btnProduccion.Font = new Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnProduccion.ForeColor = Color.White;
            btnProduccion.Location = new Point(0, 979);
            btnProduccion.Name = "btnProduccion";
            btnProduccion.Padding = new Padding(10, 0, 0, 0);
            btnProduccion.Size = new Size(187, 36);
            btnProduccion.TabIndex = 12;
            btnProduccion.Text = "Producción";
            btnProduccion.TextAlign = ContentAlignment.MiddleLeft;
            btnProduccion.UseVisualStyleBackColor = true;
            btnProduccion.Visible = false;
            btnProduccion.Click += btnProduccion_Click;
            // 
            // sbmVentas
            // 
            sbmVentas.BackColor = Color.FromArgb(3, 52, 92);
            sbmVentas.Controls.Add(btnNuevaCotizacion);
            sbmVentas.Controls.Add(btnCatalogoProductos);
            sbmVentas.Controls.Add(btnCatalogoClientes);
            sbmVentas.Controls.Add(btnBuscarCotizacion);
            sbmVentas.Dock = DockStyle.Top;
            sbmVentas.Location = new Point(0, 823);
            sbmVentas.Name = "sbmVentas";
            sbmVentas.Size = new Size(187, 156);
            sbmVentas.TabIndex = 11;
            // 
            // btnNuevaCotizacion
            // 
            btnNuevaCotizacion.Dock = DockStyle.Top;
            btnNuevaCotizacion.Enabled = false;
            btnNuevaCotizacion.FlatAppearance.BorderSize = 0;
            btnNuevaCotizacion.FlatStyle = FlatStyle.Flat;
            btnNuevaCotizacion.Font = new Font("Montserrat", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnNuevaCotizacion.ForeColor = Color.White;
            btnNuevaCotizacion.Location = new Point(0, 108);
            btnNuevaCotizacion.Name = "btnNuevaCotizacion";
            btnNuevaCotizacion.Padding = new Padding(20, 0, 0, 0);
            btnNuevaCotizacion.Size = new Size(187, 36);
            btnNuevaCotizacion.TabIndex = 6;
            btnNuevaCotizacion.Text = "Nueva Cotización";
            btnNuevaCotizacion.TextAlign = ContentAlignment.MiddleLeft;
            btnNuevaCotizacion.UseVisualStyleBackColor = true;
            btnNuevaCotizacion.Visible = false;
            btnNuevaCotizacion.Click += btnNuevaCotizacion_Click;
            // 
            // btnCatalogoProductos
            // 
            btnCatalogoProductos.Dock = DockStyle.Top;
            btnCatalogoProductos.Enabled = false;
            btnCatalogoProductos.FlatAppearance.BorderSize = 0;
            btnCatalogoProductos.FlatStyle = FlatStyle.Flat;
            btnCatalogoProductos.Font = new Font("Montserrat", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnCatalogoProductos.ForeColor = Color.White;
            btnCatalogoProductos.Location = new Point(0, 72);
            btnCatalogoProductos.Name = "btnCatalogoProductos";
            btnCatalogoProductos.Padding = new Padding(20, 0, 0, 0);
            btnCatalogoProductos.Size = new Size(187, 36);
            btnCatalogoProductos.TabIndex = 3;
            btnCatalogoProductos.Text = "Catalogo Productos";
            btnCatalogoProductos.TextAlign = ContentAlignment.MiddleLeft;
            btnCatalogoProductos.UseVisualStyleBackColor = true;
            btnCatalogoProductos.Visible = false;
            btnCatalogoProductos.Click += btnCatalogoProductos_Click;
            // 
            // btnCatalogoClientes
            // 
            btnCatalogoClientes.Dock = DockStyle.Top;
            btnCatalogoClientes.Enabled = false;
            btnCatalogoClientes.FlatAppearance.BorderSize = 0;
            btnCatalogoClientes.FlatStyle = FlatStyle.Flat;
            btnCatalogoClientes.Font = new Font("Montserrat", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnCatalogoClientes.ForeColor = Color.White;
            btnCatalogoClientes.Location = new Point(0, 36);
            btnCatalogoClientes.Name = "btnCatalogoClientes";
            btnCatalogoClientes.Padding = new Padding(20, 0, 0, 0);
            btnCatalogoClientes.Size = new Size(187, 36);
            btnCatalogoClientes.TabIndex = 4;
            btnCatalogoClientes.Text = "Catalogo Clientes";
            btnCatalogoClientes.TextAlign = ContentAlignment.MiddleLeft;
            btnCatalogoClientes.UseVisualStyleBackColor = true;
            btnCatalogoClientes.Visible = false;
            btnCatalogoClientes.Click += btnCatalogoClientes_Click;
            // 
            // btnBuscarCotizacion
            // 
            btnBuscarCotizacion.Dock = DockStyle.Top;
            btnBuscarCotizacion.Enabled = false;
            btnBuscarCotizacion.FlatAppearance.BorderSize = 0;
            btnBuscarCotizacion.FlatStyle = FlatStyle.Flat;
            btnBuscarCotizacion.Font = new Font("Montserrat", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnBuscarCotizacion.ForeColor = Color.White;
            btnBuscarCotizacion.Location = new Point(0, 0);
            btnBuscarCotizacion.Name = "btnBuscarCotizacion";
            btnBuscarCotizacion.Padding = new Padding(20, 0, 0, 0);
            btnBuscarCotizacion.Size = new Size(187, 36);
            btnBuscarCotizacion.TabIndex = 3;
            btnBuscarCotizacion.Text = "Buscar Cotización";
            btnBuscarCotizacion.TextAlign = ContentAlignment.MiddleLeft;
            btnBuscarCotizacion.UseVisualStyleBackColor = true;
            btnBuscarCotizacion.Visible = false;
            btnBuscarCotizacion.Click += button4_Click;
            // 
            // btnVentas
            // 
            btnVentas.Dock = DockStyle.Top;
            btnVentas.Enabled = false;
            btnVentas.FlatAppearance.BorderSize = 0;
            btnVentas.FlatStyle = FlatStyle.Flat;
            btnVentas.Font = new Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnVentas.ForeColor = Color.White;
            btnVentas.Location = new Point(0, 787);
            btnVentas.Name = "btnVentas";
            btnVentas.Padding = new Padding(10, 0, 0, 0);
            btnVentas.Size = new Size(187, 36);
            btnVentas.TabIndex = 10;
            btnVentas.Text = "Ventas";
            btnVentas.TextAlign = ContentAlignment.MiddleLeft;
            btnVentas.UseVisualStyleBackColor = true;
            btnVentas.Visible = false;
            btnVentas.Click += button2_Click;
            // 
            // panelSubMenu4
            // 
            panelSubMenu4.BackColor = Color.FromArgb(3, 52, 92);
            panelSubMenu4.Controls.Add(btnPermisos);
            panelSubMenu4.Controls.Add(btnSistemasReq);
            panelSubMenu4.Dock = DockStyle.Top;
            panelSubMenu4.Location = new Point(0, 703);
            panelSubMenu4.Name = "panelSubMenu4";
            panelSubMenu4.Size = new Size(187, 84);
            panelSubMenu4.TabIndex = 9;
            // 
            // btnPermisos
            // 
            btnPermisos.Dock = DockStyle.Top;
            btnPermisos.Enabled = false;
            btnPermisos.FlatAppearance.BorderSize = 0;
            btnPermisos.FlatStyle = FlatStyle.Flat;
            btnPermisos.Font = new Font("Montserrat", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnPermisos.ForeColor = Color.White;
            btnPermisos.Location = new Point(0, 36);
            btnPermisos.Name = "btnPermisos";
            btnPermisos.Padding = new Padding(20, 0, 0, 0);
            btnPermisos.Size = new Size(187, 36);
            btnPermisos.TabIndex = 4;
            btnPermisos.Text = "Permisos";
            btnPermisos.TextAlign = ContentAlignment.MiddleLeft;
            btnPermisos.UseVisualStyleBackColor = true;
            btnPermisos.Visible = false;
            btnPermisos.Click += btnPermisos_Click;
            // 
            // btnSistemasReq
            // 
            btnSistemasReq.Dock = DockStyle.Top;
            btnSistemasReq.Enabled = false;
            btnSistemasReq.FlatAppearance.BorderSize = 0;
            btnSistemasReq.FlatStyle = FlatStyle.Flat;
            btnSistemasReq.Font = new Font("Montserrat", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnSistemasReq.ForeColor = Color.White;
            btnSistemasReq.Location = new Point(0, 0);
            btnSistemasReq.Name = "btnSistemasReq";
            btnSistemasReq.Padding = new Padding(20, 0, 0, 0);
            btnSistemasReq.Size = new Size(187, 36);
            btnSistemasReq.TabIndex = 3;
            btnSistemasReq.Text = "Requisicion";
            btnSistemasReq.TextAlign = ContentAlignment.MiddleLeft;
            btnSistemasReq.UseVisualStyleBackColor = true;
            btnSistemasReq.Visible = false;
            btnSistemasReq.Click += button3_Click;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Top;
            button1.Enabled = false;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(0, 667);
            button1.Name = "button1";
            button1.Padding = new Padding(10, 0, 0, 0);
            button1.Size = new Size(187, 36);
            button1.TabIndex = 8;
            button1.Text = "Sistemas";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = true;
            button1.Visible = false;
            button1.Click += button1_Click_1;
            // 
            // panel1
            // 
            panel1.Controls.Add(btninfo);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 1186);
            panel1.Name = "panel1";
            panel1.Size = new Size(187, 56);
            panel1.TabIndex = 0;
            // 
            // btninfo
            // 
            btninfo.Dock = DockStyle.Fill;
            btninfo.FlatAppearance.BorderSize = 0;
            btninfo.FlatStyle = FlatStyle.Flat;
            btninfo.Font = new Font("Montserrat", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btninfo.ForeColor = Color.White;
            btninfo.Location = new Point(0, 0);
            btninfo.Name = "btninfo";
            btninfo.Padding = new Padding(50, 0, 0, 0);
            btninfo.Size = new Size(187, 56);
            btninfo.TabIndex = 8;
            btninfo.Text = "Info.";
            btninfo.TextAlign = ContentAlignment.MiddleLeft;
            btninfo.UseVisualStyleBackColor = true;
            btninfo.Click += btninfo_Click;
            // 
            // panelSubMenu3
            // 
            panelSubMenu3.BackColor = Color.FromArgb(3, 52, 92);
            panelSubMenu3.Controls.Add(btnCredencial);
            panelSubMenu3.Controls.Add(btnRegistroTrabajador);
            panelSubMenu3.Dock = DockStyle.Top;
            panelSubMenu3.Location = new Point(0, 586);
            panelSubMenu3.Name = "panelSubMenu3";
            panelSubMenu3.Size = new Size(187, 81);
            panelSubMenu3.TabIndex = 7;
            panelSubMenu3.Paint += panelSubMenu3_Paint;
            // 
            // btnCredencial
            // 
            btnCredencial.Dock = DockStyle.Top;
            btnCredencial.Enabled = false;
            btnCredencial.FlatAppearance.BorderSize = 0;
            btnCredencial.FlatStyle = FlatStyle.Flat;
            btnCredencial.Font = new Font("Montserrat", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnCredencial.ForeColor = Color.White;
            btnCredencial.Location = new Point(0, 36);
            btnCredencial.Name = "btnCredencial";
            btnCredencial.Padding = new Padding(20, 0, 0, 0);
            btnCredencial.Size = new Size(187, 36);
            btnCredencial.TabIndex = 4;
            btnCredencial.Text = "Generar Credencial";
            btnCredencial.TextAlign = ContentAlignment.MiddleLeft;
            btnCredencial.UseVisualStyleBackColor = true;
            btnCredencial.Visible = false;
            btnCredencial.Click += btnCredencial_Click;
            // 
            // btnRegistroTrabajador
            // 
            btnRegistroTrabajador.Dock = DockStyle.Top;
            btnRegistroTrabajador.Enabled = false;
            btnRegistroTrabajador.FlatAppearance.BorderSize = 0;
            btnRegistroTrabajador.FlatStyle = FlatStyle.Flat;
            btnRegistroTrabajador.Font = new Font("Montserrat", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnRegistroTrabajador.ForeColor = Color.White;
            btnRegistroTrabajador.Location = new Point(0, 0);
            btnRegistroTrabajador.Name = "btnRegistroTrabajador";
            btnRegistroTrabajador.Padding = new Padding(20, 0, 0, 0);
            btnRegistroTrabajador.Size = new Size(187, 36);
            btnRegistroTrabajador.TabIndex = 3;
            btnRegistroTrabajador.Text = "Registro Trabajador";
            btnRegistroTrabajador.TextAlign = ContentAlignment.MiddleLeft;
            btnRegistroTrabajador.UseVisualStyleBackColor = true;
            btnRegistroTrabajador.Visible = false;
            btnRegistroTrabajador.Click += btnRegistroTrabajador_Click;
            // 
            // button11
            // 
            button11.Dock = DockStyle.Top;
            button11.Enabled = false;
            button11.FlatAppearance.BorderSize = 0;
            button11.FlatStyle = FlatStyle.Flat;
            button11.Font = new Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button11.ForeColor = Color.White;
            button11.Location = new Point(0, 550);
            button11.Name = "button11";
            button11.Padding = new Padding(10, 0, 0, 0);
            button11.Size = new Size(187, 36);
            button11.TabIndex = 6;
            button11.Text = "Recursos Humanos";
            button11.TextAlign = ContentAlignment.MiddleLeft;
            button11.UseVisualStyleBackColor = true;
            button11.Visible = false;
            button11.Click += button11_Click;
            // 
            // panelSubMenu2
            // 
            panelSubMenu2.BackColor = Color.FromArgb(3, 52, 92);
            panelSubMenu2.Controls.Add(btnIndCompras);
            panelSubMenu2.Controls.Add(btnReqEnv);
            panelSubMenu2.Controls.Add(btnAdmiProveedores);
            panelSubMenu2.Controls.Add(btnAdmiReq);
            panelSubMenu2.Controls.Add(btnReqCompra);
            panelSubMenu2.Controls.Add(btnConsumibles);
            panelSubMenu2.Dock = DockStyle.Top;
            panelSubMenu2.Location = new Point(0, 323);
            panelSubMenu2.Name = "panelSubMenu2";
            panelSubMenu2.Size = new Size(187, 227);
            panelSubMenu2.TabIndex = 5;
            // 
            // btnIndCompras
            // 
            btnIndCompras.Dock = DockStyle.Top;
            btnIndCompras.Enabled = false;
            btnIndCompras.FlatAppearance.BorderSize = 0;
            btnIndCompras.FlatStyle = FlatStyle.Flat;
            btnIndCompras.Font = new Font("Montserrat", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnIndCompras.ForeColor = Color.White;
            btnIndCompras.Location = new Point(0, 180);
            btnIndCompras.Name = "btnIndCompras";
            btnIndCompras.Padding = new Padding(20, 0, 0, 0);
            btnIndCompras.Size = new Size(187, 36);
            btnIndCompras.TabIndex = 10;
            btnIndCompras.Text = "Indicador Compras";
            btnIndCompras.TextAlign = ContentAlignment.MiddleLeft;
            btnIndCompras.UseVisualStyleBackColor = true;
            btnIndCompras.Visible = false;
            btnIndCompras.Click += btnIndCompras_Click;
            // 
            // btnReqEnv
            // 
            btnReqEnv.Dock = DockStyle.Top;
            btnReqEnv.Enabled = false;
            btnReqEnv.FlatAppearance.BorderSize = 0;
            btnReqEnv.FlatStyle = FlatStyle.Flat;
            btnReqEnv.Font = new Font("Montserrat", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnReqEnv.ForeColor = Color.White;
            btnReqEnv.Location = new Point(0, 144);
            btnReqEnv.Name = "btnReqEnv";
            btnReqEnv.Padding = new Padding(20, 0, 0, 0);
            btnReqEnv.Size = new Size(187, 36);
            btnReqEnv.TabIndex = 9;
            btnReqEnv.Text = "Req. Enviadas";
            btnReqEnv.TextAlign = ContentAlignment.MiddleLeft;
            btnReqEnv.UseVisualStyleBackColor = true;
            btnReqEnv.Visible = false;
            btnReqEnv.Click += btnReqEnv_Click;
            // 
            // btnAdmiProveedores
            // 
            btnAdmiProveedores.Dock = DockStyle.Top;
            btnAdmiProveedores.Enabled = false;
            btnAdmiProveedores.FlatAppearance.BorderSize = 0;
            btnAdmiProveedores.FlatStyle = FlatStyle.Flat;
            btnAdmiProveedores.Font = new Font("Montserrat", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdmiProveedores.ForeColor = Color.White;
            btnAdmiProveedores.Location = new Point(0, 108);
            btnAdmiProveedores.Name = "btnAdmiProveedores";
            btnAdmiProveedores.Padding = new Padding(20, 0, 0, 0);
            btnAdmiProveedores.Size = new Size(187, 36);
            btnAdmiProveedores.TabIndex = 8;
            btnAdmiProveedores.Text = "Admin. Prvdrs";
            btnAdmiProveedores.TextAlign = ContentAlignment.MiddleLeft;
            btnAdmiProveedores.UseVisualStyleBackColor = true;
            btnAdmiProveedores.Visible = false;
            btnAdmiProveedores.Click += btnAdmiProveedores_Click;
            // 
            // btnAdmiReq
            // 
            btnAdmiReq.Dock = DockStyle.Top;
            btnAdmiReq.Enabled = false;
            btnAdmiReq.FlatAppearance.BorderSize = 0;
            btnAdmiReq.FlatStyle = FlatStyle.Flat;
            btnAdmiReq.Font = new Font("Montserrat", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdmiReq.ForeColor = Color.White;
            btnAdmiReq.Location = new Point(0, 72);
            btnAdmiReq.Name = "btnAdmiReq";
            btnAdmiReq.Padding = new Padding(20, 0, 0, 0);
            btnAdmiReq.Size = new Size(187, 36);
            btnAdmiReq.TabIndex = 7;
            btnAdmiReq.Text = "Admin. Req";
            btnAdmiReq.TextAlign = ContentAlignment.MiddleLeft;
            btnAdmiReq.UseVisualStyleBackColor = true;
            btnAdmiReq.Visible = false;
            btnAdmiReq.Click += btnAdmiReq_Click;
            // 
            // btnReqCompra
            // 
            btnReqCompra.Dock = DockStyle.Top;
            btnReqCompra.Enabled = false;
            btnReqCompra.FlatAppearance.BorderSize = 0;
            btnReqCompra.FlatStyle = FlatStyle.Flat;
            btnReqCompra.Font = new Font("Montserrat", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnReqCompra.ForeColor = Color.White;
            btnReqCompra.Location = new Point(0, 36);
            btnReqCompra.Name = "btnReqCompra";
            btnReqCompra.Padding = new Padding(20, 0, 0, 0);
            btnReqCompra.Size = new Size(187, 36);
            btnReqCompra.TabIndex = 6;
            btnReqCompra.Text = "Req. Compra";
            btnReqCompra.TextAlign = ContentAlignment.MiddleLeft;
            btnReqCompra.UseVisualStyleBackColor = true;
            btnReqCompra.Visible = false;
            btnReqCompra.Click += button7_Click;
            // 
            // btnConsumibles
            // 
            btnConsumibles.Dock = DockStyle.Top;
            btnConsumibles.Enabled = false;
            btnConsumibles.FlatAppearance.BorderSize = 0;
            btnConsumibles.FlatStyle = FlatStyle.Flat;
            btnConsumibles.Font = new Font("Montserrat", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnConsumibles.ForeColor = Color.White;
            btnConsumibles.Location = new Point(0, 0);
            btnConsumibles.Name = "btnConsumibles";
            btnConsumibles.Padding = new Padding(20, 0, 0, 0);
            btnConsumibles.Size = new Size(187, 36);
            btnConsumibles.TabIndex = 3;
            btnConsumibles.Text = "Consumibles";
            btnConsumibles.TextAlign = ContentAlignment.MiddleLeft;
            btnConsumibles.UseVisualStyleBackColor = true;
            btnConsumibles.Visible = false;
            btnConsumibles.Click += button10_Click;
            // 
            // button6
            // 
            button6.Dock = DockStyle.Top;
            button6.Enabled = false;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button6.ForeColor = Color.White;
            button6.Location = new Point(0, 287);
            button6.Name = "button6";
            button6.Padding = new Padding(10, 0, 0, 0);
            button6.Size = new Size(187, 36);
            button6.TabIndex = 4;
            button6.Text = "Compras";
            button6.TextAlign = ContentAlignment.MiddleLeft;
            button6.UseVisualStyleBackColor = true;
            button6.Visible = false;
            button6.Click += button6_Click;
            // 
            // panelSubMenuAlmacen
            // 
            panelSubMenuAlmacen.BackColor = Color.FromArgb(3, 52, 92);
            panelSubMenuAlmacen.Controls.Add(btnConsultaSalidas);
            panelSubMenuAlmacen.Controls.Add(btnControlAlmacen);
            panelSubMenuAlmacen.Controls.Add(btnRegistrarExistencias);
            panelSubMenuAlmacen.Controls.Add(btnNuevoProducto);
            panelSubMenuAlmacen.Dock = DockStyle.Top;
            panelSubMenuAlmacen.Location = new Point(0, 134);
            panelSubMenuAlmacen.Name = "panelSubMenuAlmacen";
            panelSubMenuAlmacen.Size = new Size(187, 153);
            panelSubMenuAlmacen.TabIndex = 3;
            // 
            // btnConsultaSalidas
            // 
            btnConsultaSalidas.Dock = DockStyle.Top;
            btnConsultaSalidas.Enabled = false;
            btnConsultaSalidas.FlatAppearance.BorderSize = 0;
            btnConsultaSalidas.FlatStyle = FlatStyle.Flat;
            btnConsultaSalidas.Font = new Font("Montserrat", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnConsultaSalidas.ForeColor = Color.White;
            btnConsultaSalidas.Location = new Point(0, 108);
            btnConsultaSalidas.Name = "btnConsultaSalidas";
            btnConsultaSalidas.Padding = new Padding(20, 0, 0, 0);
            btnConsultaSalidas.Size = new Size(187, 36);
            btnConsultaSalidas.TabIndex = 7;
            btnConsultaSalidas.Text = "Reporte Consumibles";
            btnConsultaSalidas.TextAlign = ContentAlignment.MiddleLeft;
            btnConsultaSalidas.UseVisualStyleBackColor = true;
            btnConsultaSalidas.Visible = false;
            btnConsultaSalidas.Click += btnConsultaSalidas_Click_1;
            // 
            // btnControlAlmacen
            // 
            btnControlAlmacen.Dock = DockStyle.Top;
            btnControlAlmacen.Enabled = false;
            btnControlAlmacen.FlatAppearance.BorderSize = 0;
            btnControlAlmacen.FlatStyle = FlatStyle.Flat;
            btnControlAlmacen.Font = new Font("Montserrat", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnControlAlmacen.ForeColor = Color.White;
            btnControlAlmacen.Location = new Point(0, 72);
            btnControlAlmacen.Name = "btnControlAlmacen";
            btnControlAlmacen.Padding = new Padding(20, 0, 0, 0);
            btnControlAlmacen.Size = new Size(187, 36);
            btnControlAlmacen.TabIndex = 6;
            btnControlAlmacen.Text = "Control Almacen";
            btnControlAlmacen.TextAlign = ContentAlignment.MiddleLeft;
            btnControlAlmacen.UseVisualStyleBackColor = true;
            btnControlAlmacen.Visible = false;
            btnControlAlmacen.Click += btnConsultaSalidas_Click;
            // 
            // btnRegistrarExistencias
            // 
            btnRegistrarExistencias.Dock = DockStyle.Top;
            btnRegistrarExistencias.Enabled = false;
            btnRegistrarExistencias.FlatAppearance.BorderSize = 0;
            btnRegistrarExistencias.FlatStyle = FlatStyle.Flat;
            btnRegistrarExistencias.Font = new Font("Montserrat", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnRegistrarExistencias.ForeColor = Color.White;
            btnRegistrarExistencias.Location = new Point(0, 36);
            btnRegistrarExistencias.Name = "btnRegistrarExistencias";
            btnRegistrarExistencias.Padding = new Padding(20, 0, 0, 0);
            btnRegistrarExistencias.Size = new Size(187, 36);
            btnRegistrarExistencias.TabIndex = 5;
            btnRegistrarExistencias.Text = "Registro Consumibles";
            btnRegistrarExistencias.TextAlign = ContentAlignment.MiddleLeft;
            btnRegistrarExistencias.UseVisualStyleBackColor = true;
            btnRegistrarExistencias.Visible = false;
            btnRegistrarExistencias.Click += btnControlAlmacen_Click;
            // 
            // btnNuevoProducto
            // 
            btnNuevoProducto.Dock = DockStyle.Top;
            btnNuevoProducto.Enabled = false;
            btnNuevoProducto.FlatAppearance.BorderSize = 0;
            btnNuevoProducto.FlatStyle = FlatStyle.Flat;
            btnNuevoProducto.Font = new Font("Montserrat", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnNuevoProducto.ForeColor = Color.White;
            btnNuevoProducto.Location = new Point(0, 0);
            btnNuevoProducto.Name = "btnNuevoProducto";
            btnNuevoProducto.Padding = new Padding(20, 0, 0, 0);
            btnNuevoProducto.Size = new Size(187, 36);
            btnNuevoProducto.TabIndex = 3;
            btnNuevoProducto.Text = "Consumibles";
            btnNuevoProducto.TextAlign = ContentAlignment.MiddleLeft;
            btnNuevoProducto.UseVisualStyleBackColor = true;
            btnNuevoProducto.Visible = false;
            btnNuevoProducto.Click += btnNuevoProducto_Click;
            // 
            // btnalmacen
            // 
            btnalmacen.Dock = DockStyle.Top;
            btnalmacen.Enabled = false;
            btnalmacen.FlatAppearance.BorderSize = 0;
            btnalmacen.FlatStyle = FlatStyle.Flat;
            btnalmacen.Font = new Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnalmacen.ForeColor = Color.White;
            btnalmacen.Location = new Point(0, 98);
            btnalmacen.Name = "btnalmacen";
            btnalmacen.Padding = new Padding(10, 0, 0, 0);
            btnalmacen.Size = new Size(187, 36);
            btnalmacen.TabIndex = 2;
            btnalmacen.Text = "Almacen";
            btnalmacen.TextAlign = ContentAlignment.MiddleLeft;
            btnalmacen.UseVisualStyleBackColor = true;
            btnalmacen.Visible = false;
            btnalmacen.Click += button1_Click;
            // 
            // panelLogo
            // 
            panelLogo.Controls.Add(pictureBox1);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(187, 98);
            panelLogo.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(15, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(174, 83);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panelPrincipal
            // 
            panelPrincipal.BackColor = Color.Transparent;
            panelPrincipal.Controls.Add(dgv);
            panelPrincipal.Controls.Add(labelid);
            panelPrincipal.Dock = DockStyle.Fill;
            panelPrincipal.Location = new Point(204, 30);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(1338, 831);
            panelPrincipal.TabIndex = 2;
            panelPrincipal.Paint += panelPrincipal_Paint;
            // 
            // dgv
            // 
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Location = new Point(3, 54);
            dgv.Name = "dgv";
            dgv.RowTemplate.Height = 25;
            dgv.Size = new Size(46, 38);
            dgv.TabIndex = 1;
            dgv.Visible = false;
            // 
            // labelid
            // 
            labelid.AutoSize = true;
            labelid.Location = new Point(6, 24);
            labelid.Name = "labelid";
            labelid.Size = new Size(38, 15);
            labelid.TabIndex = 0;
            labelid.Text = "label1";
            labelid.Visible = false;
            labelid.TextChanged += labelrol_TextChanged;
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1542, 861);
            Controls.Add(panelPrincipal);
            Controls.Add(panelSideMenu);
            Controls.Add(PBarraTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MenuPrincipal";
            Opacity = 0.95D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MenuPrincipal";
            PBarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PBNaranja).EndInit();
            ((System.ComponentModel.ISupportInitialize)PBAzul).EndInit();
            ((System.ComponentModel.ISupportInitialize)PBICerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)PBIconoMin).EndInit();
            panelSideMenu.ResumeLayout(false);
            sbmMaquinado.ResumeLayout(false);
            sbmProduccion.ResumeLayout(false);
            sbmVentas.ResumeLayout(false);
            panelSubMenu4.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panelSubMenu3.ResumeLayout(false);
            panelSubMenu2.ResumeLayout(false);
            panelSubMenuAlmacen.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelPrincipal.ResumeLayout(false);
            panelPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel PBarraTitulo;
        private PictureBox PBIconoMin;
        private PictureBox PBICerrar;
        private PictureBox PBNaranja;
        private PictureBox PBAzul;
        private Panel panelSideMenu;
        private Panel panelLogo;
        private Button btnalmacen;
        private PictureBox pictureBox1;
        private Panel panelSubMenuAlmacen;
        private Button btnNuevoProducto;
        private Button btnControlAlmacen;
        private Button btnRegistrarExistencias;
        private Panel panelSubMenu3;
        private Button button13;
        private Button button14;
        private Button btnRegistroTrabajador;
        private Panel panelSubMenu2;
        private Button btnReqCompra;
        private Button btnConsumibles;
        private Button button6;
        private Panel panelPrincipal;
        private Panel panel1;
        private Button btninfo;
        private Button button11;
        private Button btnConsultaSalidas;
        private Label labelid;
        private DataGridView dgv;
        private Button btnCredencial;
        private Panel panelSubMenu4;
        private Button btnSistemasReq;
        private Button button1;
        private Button btnPermisos;
        private Panel sbmVentas;
        private Button btnBuscarCotizacion;
        private Button btnVentas;
        private Panel sbmProduccion;
        private Button btnReporte;
        private Button btnProduccion;
        private Button btnIndCompras;
        private Button btnReqEnv;
        private Button btnAdmiProveedores;
        private Button btnAdmiReq;
        private Button btnNuevaCotizacion;
        private Button btnCatalogoProductos;
        private Button btnCatalogoClientes;
        private Panel sbmMaquinado;
        private Button btnPendientesMaquinado;
        private Button btnSolicitudMquinado;
        private Button btnMaquinado;
    }
}