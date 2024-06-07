namespace ElastoSystem
{
    partial class SistemasPermisos
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
            label1 = new Label();
            label2 = new Label();
            cbUsuarios = new ComboBox();
            panel1 = new Panel();
            chbConsultaSalidas = new CheckBox();
            chbControlAlmacen = new CheckBox();
            chbRegistrarExistencias = new CheckBox();
            chbEditarProducto = new CheckBox();
            chbNuevoProducto = new CheckBox();
            chbAlmacen = new CheckBox();
            lblNumeroTemp = new Label();
            panel2 = new Panel();
            chbReqEnviadas = new CheckBox();
            chbAdmiProvee = new CheckBox();
            chbAdmiReq = new CheckBox();
            chbReqCompra = new CheckBox();
            chbConsumiblesAlmacen = new CheckBox();
            chbIndicadorCompras = new CheckBox();
            chbCompras = new CheckBox();
            panel3 = new Panel();
            chbGenerarCredencial = new CheckBox();
            chbRegistroTrabajador = new CheckBox();
            chbRecursosHumanos = new CheckBox();
            panel4 = new Panel();
            chbPermisos = new CheckBox();
            chbRequisicion = new CheckBox();
            chbSistemas = new CheckBox();
            btnactualizar = new Button();
            panel5 = new Panel();
            chbBuscarCotizacion = new CheckBox();
            chbCatalogoProductos = new CheckBox();
            chbNuevaCotizacion = new CheckBox();
            chbClientes = new CheckBox();
            chbVentas = new CheckBox();
            panel6 = new Panel();
            chbReporteProduccion = new CheckBox();
            chbProduccion = new CheckBox();
            panel7 = new Panel();
            chbPendientesMaquinado = new CheckBox();
            chbSolicitudMaquinado = new CheckBox();
            chbMaquinado = new CheckBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Montserrat", 22F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(38, 44);
            label1.Name = "label1";
            label1.Size = new Size(411, 41);
            label1.TabIndex = 0;
            label1.Text = "PERMISOS DE USUARIOS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Montserrat", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(38, 111);
            label2.Name = "label2";
            label2.Size = new Size(98, 27);
            label2.TabIndex = 1;
            label2.Text = "Usuario:";
            // 
            // cbUsuarios
            // 
            cbUsuarios.Font = new Font("Montserrat", 15F, FontStyle.Regular, GraphicsUnit.Point);
            cbUsuarios.FormattingEnabled = true;
            cbUsuarios.Location = new Point(152, 108);
            cbUsuarios.Name = "cbUsuarios";
            cbUsuarios.Size = new Size(288, 35);
            cbUsuarios.TabIndex = 2;
            cbUsuarios.SelectedIndexChanged += cbUsuarios_SelectedIndexChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(3, 42, 76);
            panel1.Controls.Add(chbConsultaSalidas);
            panel1.Controls.Add(chbControlAlmacen);
            panel1.Controls.Add(chbRegistrarExistencias);
            panel1.Controls.Add(chbEditarProducto);
            panel1.Controls.Add(chbNuevoProducto);
            panel1.Controls.Add(chbAlmacen);
            panel1.Location = new Point(48, 165);
            panel1.Name = "panel1";
            panel1.Size = new Size(240, 224);
            panel1.TabIndex = 3;
            // 
            // chbConsultaSalidas
            // 
            chbConsultaSalidas.AutoSize = true;
            chbConsultaSalidas.Font = new Font("Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point);
            chbConsultaSalidas.ForeColor = Color.White;
            chbConsultaSalidas.Location = new Point(15, 152);
            chbConsultaSalidas.Name = "chbConsultaSalidas";
            chbConsultaSalidas.Size = new Size(124, 20);
            chbConsultaSalidas.TabIndex = 5;
            chbConsultaSalidas.Text = "Consulta Salidas";
            chbConsultaSalidas.UseVisualStyleBackColor = true;
            chbConsultaSalidas.CheckedChanged += chbConsultaSalidas_CheckedChanged;
            // 
            // chbControlAlmacen
            // 
            chbControlAlmacen.AutoSize = true;
            chbControlAlmacen.Font = new Font("Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point);
            chbControlAlmacen.ForeColor = Color.White;
            chbControlAlmacen.Location = new Point(15, 126);
            chbControlAlmacen.Name = "chbControlAlmacen";
            chbControlAlmacen.Size = new Size(129, 20);
            chbControlAlmacen.TabIndex = 4;
            chbControlAlmacen.Text = "Control Almacen";
            chbControlAlmacen.UseVisualStyleBackColor = true;
            chbControlAlmacen.CheckedChanged += chbControlAlmacen_CheckedChanged;
            // 
            // chbRegistrarExistencias
            // 
            chbRegistrarExistencias.AutoSize = true;
            chbRegistrarExistencias.Font = new Font("Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point);
            chbRegistrarExistencias.ForeColor = Color.White;
            chbRegistrarExistencias.Location = new Point(15, 100);
            chbRegistrarExistencias.Name = "chbRegistrarExistencias";
            chbRegistrarExistencias.Size = new Size(149, 20);
            chbRegistrarExistencias.TabIndex = 3;
            chbRegistrarExistencias.Text = "Registrar Existencias";
            chbRegistrarExistencias.UseVisualStyleBackColor = true;
            chbRegistrarExistencias.CheckedChanged += chbRegistrarExistencias_CheckedChanged;
            // 
            // chbEditarProducto
            // 
            chbEditarProducto.AutoSize = true;
            chbEditarProducto.Font = new Font("Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point);
            chbEditarProducto.ForeColor = Color.White;
            chbEditarProducto.Location = new Point(15, 74);
            chbEditarProducto.Name = "chbEditarProducto";
            chbEditarProducto.Size = new Size(123, 20);
            chbEditarProducto.TabIndex = 2;
            chbEditarProducto.Text = "Editar Producto";
            chbEditarProducto.UseVisualStyleBackColor = true;
            chbEditarProducto.CheckedChanged += chbEditarProducto_CheckedChanged;
            // 
            // chbNuevoProducto
            // 
            chbNuevoProducto.AutoSize = true;
            chbNuevoProducto.Font = new Font("Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point);
            chbNuevoProducto.ForeColor = Color.White;
            chbNuevoProducto.Location = new Point(15, 48);
            chbNuevoProducto.Name = "chbNuevoProducto";
            chbNuevoProducto.Size = new Size(127, 20);
            chbNuevoProducto.TabIndex = 1;
            chbNuevoProducto.Text = "Nuevo Producto";
            chbNuevoProducto.UseVisualStyleBackColor = true;
            chbNuevoProducto.CheckedChanged += chbNuevoProducto_CheckedChanged;
            // 
            // chbAlmacen
            // 
            chbAlmacen.AutoSize = true;
            chbAlmacen.Font = new Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point);
            chbAlmacen.ForeColor = Color.White;
            chbAlmacen.Location = new Point(15, 13);
            chbAlmacen.Name = "chbAlmacen";
            chbAlmacen.Size = new Size(114, 26);
            chbAlmacen.TabIndex = 0;
            chbAlmacen.Text = "ALMACEN";
            chbAlmacen.UseVisualStyleBackColor = true;
            chbAlmacen.CheckedChanged += chbAlmacen_CheckedChanged;
            // 
            // lblNumeroTemp
            // 
            lblNumeroTemp.AutoSize = true;
            lblNumeroTemp.BackColor = Color.Transparent;
            lblNumeroTemp.Location = new Point(38, 147);
            lblNumeroTemp.Name = "lblNumeroTemp";
            lblNumeroTemp.Size = new Size(80, 15);
            lblNumeroTemp.TabIndex = 4;
            lblNumeroTemp.Text = "NumeroTemp";
            lblNumeroTemp.Visible = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(3, 42, 76);
            panel2.Controls.Add(chbReqEnviadas);
            panel2.Controls.Add(chbAdmiProvee);
            panel2.Controls.Add(chbAdmiReq);
            panel2.Controls.Add(chbReqCompra);
            panel2.Controls.Add(chbConsumiblesAlmacen);
            panel2.Controls.Add(chbIndicadorCompras);
            panel2.Controls.Add(chbCompras);
            panel2.Location = new Point(298, 165);
            panel2.Name = "panel2";
            panel2.Size = new Size(240, 224);
            panel2.TabIndex = 5;
            // 
            // chbReqEnviadas
            // 
            chbReqEnviadas.AutoSize = true;
            chbReqEnviadas.Font = new Font("Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point);
            chbReqEnviadas.ForeColor = Color.White;
            chbReqEnviadas.Location = new Point(15, 152);
            chbReqEnviadas.Name = "chbReqEnviadas";
            chbReqEnviadas.Size = new Size(166, 20);
            chbReqEnviadas.TabIndex = 6;
            chbReqEnviadas.Text = "Requisiciones Enviadas";
            chbReqEnviadas.UseVisualStyleBackColor = true;
            chbReqEnviadas.CheckedChanged += chbReqEnviadas_CheckedChanged;
            // 
            // chbAdmiProvee
            // 
            chbAdmiProvee.AutoSize = true;
            chbAdmiProvee.Font = new Font("Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point);
            chbAdmiProvee.ForeColor = Color.White;
            chbAdmiProvee.Location = new Point(15, 126);
            chbAdmiProvee.Name = "chbAdmiProvee";
            chbAdmiProvee.Size = new Size(177, 20);
            chbAdmiProvee.TabIndex = 5;
            chbAdmiProvee.Text = "Administrar Proveedores";
            chbAdmiProvee.UseVisualStyleBackColor = true;
            chbAdmiProvee.CheckedChanged += chbAdmiProvee_CheckedChanged;
            // 
            // chbAdmiReq
            // 
            chbAdmiReq.AutoSize = true;
            chbAdmiReq.Font = new Font("Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point);
            chbAdmiReq.ForeColor = Color.White;
            chbAdmiReq.Location = new Point(15, 100);
            chbAdmiReq.Name = "chbAdmiReq";
            chbAdmiReq.Size = new Size(197, 20);
            chbAdmiReq.TabIndex = 4;
            chbAdmiReq.Text = "Administrar Requerimientos";
            chbAdmiReq.UseVisualStyleBackColor = true;
            chbAdmiReq.CheckedChanged += chbAdmiReq_CheckedChanged;
            // 
            // chbReqCompra
            // 
            chbReqCompra.AutoSize = true;
            chbReqCompra.Font = new Font("Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point);
            chbReqCompra.ForeColor = Color.White;
            chbReqCompra.Location = new Point(15, 74);
            chbReqCompra.Name = "chbReqCompra";
            chbReqCompra.Size = new Size(169, 20);
            chbReqCompra.TabIndex = 3;
            chbReqCompra.Text = "Requerimiento Compra";
            chbReqCompra.UseVisualStyleBackColor = true;
            chbReqCompra.CheckedChanged += chbReqCompra_CheckedChanged;
            // 
            // chbConsumiblesAlmacen
            // 
            chbConsumiblesAlmacen.AutoSize = true;
            chbConsumiblesAlmacen.Font = new Font("Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point);
            chbConsumiblesAlmacen.ForeColor = Color.White;
            chbConsumiblesAlmacen.Location = new Point(15, 48);
            chbConsumiblesAlmacen.Name = "chbConsumiblesAlmacen";
            chbConsumiblesAlmacen.Size = new Size(162, 20);
            chbConsumiblesAlmacen.TabIndex = 2;
            chbConsumiblesAlmacen.Text = "Consumibles Almacen";
            chbConsumiblesAlmacen.UseVisualStyleBackColor = true;
            chbConsumiblesAlmacen.CheckedChanged += chbConsumiblesAlmacen_CheckedChanged;
            // 
            // chbIndicadorCompras
            // 
            chbIndicadorCompras.AutoSize = true;
            chbIndicadorCompras.Font = new Font("Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point);
            chbIndicadorCompras.ForeColor = Color.White;
            chbIndicadorCompras.Location = new Point(15, 178);
            chbIndicadorCompras.Name = "chbIndicadorCompras";
            chbIndicadorCompras.Size = new Size(142, 20);
            chbIndicadorCompras.TabIndex = 1;
            chbIndicadorCompras.Text = "Indicador Compras";
            chbIndicadorCompras.UseVisualStyleBackColor = true;
            chbIndicadorCompras.CheckedChanged += chbIndicadorCompras_CheckedChanged;
            // 
            // chbCompras
            // 
            chbCompras.AutoSize = true;
            chbCompras.Font = new Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point);
            chbCompras.ForeColor = Color.White;
            chbCompras.Location = new Point(15, 13);
            chbCompras.Name = "chbCompras";
            chbCompras.Size = new Size(116, 26);
            chbCompras.TabIndex = 0;
            chbCompras.Text = "COMPRAS";
            chbCompras.UseVisualStyleBackColor = true;
            chbCompras.CheckedChanged += chbCompras_CheckedChanged;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(3, 42, 76);
            panel3.Controls.Add(chbGenerarCredencial);
            panel3.Controls.Add(chbRegistroTrabajador);
            panel3.Controls.Add(chbRecursosHumanos);
            panel3.Location = new Point(1048, 165);
            panel3.Name = "panel3";
            panel3.Size = new Size(240, 224);
            panel3.TabIndex = 6;
            // 
            // chbGenerarCredencial
            // 
            chbGenerarCredencial.AutoSize = true;
            chbGenerarCredencial.Font = new Font("Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point);
            chbGenerarCredencial.ForeColor = Color.White;
            chbGenerarCredencial.Location = new Point(15, 74);
            chbGenerarCredencial.Name = "chbGenerarCredencial";
            chbGenerarCredencial.Size = new Size(140, 20);
            chbGenerarCredencial.TabIndex = 2;
            chbGenerarCredencial.Text = "Generar Credencial";
            chbGenerarCredencial.UseVisualStyleBackColor = true;
            chbGenerarCredencial.CheckedChanged += chbGenerarCredencial_CheckedChanged;
            // 
            // chbRegistroTrabajador
            // 
            chbRegistroTrabajador.AutoSize = true;
            chbRegistroTrabajador.Font = new Font("Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point);
            chbRegistroTrabajador.ForeColor = Color.White;
            chbRegistroTrabajador.Location = new Point(15, 48);
            chbRegistroTrabajador.Name = "chbRegistroTrabajador";
            chbRegistroTrabajador.Size = new Size(144, 20);
            chbRegistroTrabajador.TabIndex = 1;
            chbRegistroTrabajador.Text = "Registro Trabajador";
            chbRegistroTrabajador.UseVisualStyleBackColor = true;
            chbRegistroTrabajador.CheckedChanged += chbRegistroTrabajador_CheckedChanged;
            // 
            // chbRecursosHumanos
            // 
            chbRecursosHumanos.AutoSize = true;
            chbRecursosHumanos.Font = new Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point);
            chbRecursosHumanos.ForeColor = Color.White;
            chbRecursosHumanos.Location = new Point(15, 13);
            chbRecursosHumanos.Name = "chbRecursosHumanos";
            chbRecursosHumanos.Size = new Size(218, 26);
            chbRecursosHumanos.TabIndex = 0;
            chbRecursosHumanos.Text = "RECURSOS HUMANOS";
            chbRecursosHumanos.UseVisualStyleBackColor = true;
            chbRecursosHumanos.CheckedChanged += chbRecursosHumanos_CheckedChanged;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(3, 42, 76);
            panel4.Controls.Add(chbPermisos);
            panel4.Controls.Add(chbRequisicion);
            panel4.Controls.Add(chbSistemas);
            panel4.Location = new Point(48, 395);
            panel4.Name = "panel4";
            panel4.Size = new Size(240, 224);
            panel4.TabIndex = 7;
            // 
            // chbPermisos
            // 
            chbPermisos.AutoSize = true;
            chbPermisos.Font = new Font("Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point);
            chbPermisos.ForeColor = Color.White;
            chbPermisos.Location = new Point(15, 74);
            chbPermisos.Name = "chbPermisos";
            chbPermisos.Size = new Size(83, 20);
            chbPermisos.TabIndex = 2;
            chbPermisos.Text = "Permisos";
            chbPermisos.UseVisualStyleBackColor = true;
            chbPermisos.CheckedChanged += chbPermisos_CheckedChanged;
            // 
            // chbRequisicion
            // 
            chbRequisicion.AutoSize = true;
            chbRequisicion.Font = new Font("Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point);
            chbRequisicion.ForeColor = Color.White;
            chbRequisicion.Location = new Point(15, 48);
            chbRequisicion.Name = "chbRequisicion";
            chbRequisicion.Size = new Size(96, 20);
            chbRequisicion.TabIndex = 1;
            chbRequisicion.Text = "Requisicion";
            chbRequisicion.UseVisualStyleBackColor = true;
            chbRequisicion.CheckedChanged += chbRequisicion_CheckedChanged;
            // 
            // chbSistemas
            // 
            chbSistemas.AutoSize = true;
            chbSistemas.Font = new Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point);
            chbSistemas.ForeColor = Color.White;
            chbSistemas.Location = new Point(15, 13);
            chbSistemas.Name = "chbSistemas";
            chbSistemas.Size = new Size(112, 26);
            chbSistemas.TabIndex = 0;
            chbSistemas.Text = "SISTEMAS";
            chbSistemas.UseVisualStyleBackColor = true;
            chbSistemas.CheckedChanged += chbSistemas_CheckedChanged;
            // 
            // btnactualizar
            // 
            btnactualizar.BackColor = Color.FromArgb(255, 102, 0);
            btnactualizar.Cursor = Cursors.Hand;
            btnactualizar.FlatAppearance.BorderSize = 0;
            btnactualizar.FlatStyle = FlatStyle.Flat;
            btnactualizar.Font = new Font("Montserrat", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnactualizar.ForeColor = Color.White;
            btnactualizar.Location = new Point(944, 665);
            btnactualizar.Name = "btnactualizar";
            btnactualizar.Size = new Size(318, 47);
            btnactualizar.TabIndex = 8;
            btnactualizar.Text = "ACTUALIZAR PERMISOS";
            btnactualizar.UseVisualStyleBackColor = false;
            btnactualizar.Click += btnactualizar_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(3, 42, 76);
            panel5.Controls.Add(chbBuscarCotizacion);
            panel5.Controls.Add(chbCatalogoProductos);
            panel5.Controls.Add(chbNuevaCotizacion);
            panel5.Controls.Add(chbClientes);
            panel5.Controls.Add(chbVentas);
            panel5.Location = new Point(298, 395);
            panel5.Name = "panel5";
            panel5.Size = new Size(240, 224);
            panel5.TabIndex = 9;
            // 
            // chbBuscarCotizacion
            // 
            chbBuscarCotizacion.AutoSize = true;
            chbBuscarCotizacion.Font = new Font("Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point);
            chbBuscarCotizacion.ForeColor = Color.White;
            chbBuscarCotizacion.Location = new Point(15, 48);
            chbBuscarCotizacion.Name = "chbBuscarCotizacion";
            chbBuscarCotizacion.Size = new Size(135, 20);
            chbBuscarCotizacion.TabIndex = 4;
            chbBuscarCotizacion.Text = "Buscar Cotización";
            chbBuscarCotizacion.UseVisualStyleBackColor = true;
            chbBuscarCotizacion.CheckedChanged += chbBuscarCotizacion_CheckedChanged;
            // 
            // chbCatalogoProductos
            // 
            chbCatalogoProductos.AutoSize = true;
            chbCatalogoProductos.Font = new Font("Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point);
            chbCatalogoProductos.ForeColor = Color.White;
            chbCatalogoProductos.Location = new Point(15, 100);
            chbCatalogoProductos.Name = "chbCatalogoProductos";
            chbCatalogoProductos.Size = new Size(148, 20);
            chbCatalogoProductos.TabIndex = 3;
            chbCatalogoProductos.Text = "Catalogo Productos";
            chbCatalogoProductos.UseVisualStyleBackColor = true;
            chbCatalogoProductos.CheckedChanged += chbCatalogoProductos_CheckedChanged;
            // 
            // chbNuevaCotizacion
            // 
            chbNuevaCotizacion.AutoSize = true;
            chbNuevaCotizacion.Font = new Font("Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point);
            chbNuevaCotizacion.ForeColor = Color.White;
            chbNuevaCotizacion.Location = new Point(15, 126);
            chbNuevaCotizacion.Name = "chbNuevaCotizacion";
            chbNuevaCotizacion.Size = new Size(132, 20);
            chbNuevaCotizacion.TabIndex = 2;
            chbNuevaCotizacion.Text = "Nueva Cotización";
            chbNuevaCotizacion.UseVisualStyleBackColor = true;
            chbNuevaCotizacion.CheckedChanged += chbNuevaCotizacion_CheckedChanged;
            // 
            // chbClientes
            // 
            chbClientes.AutoSize = true;
            chbClientes.Font = new Font("Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point);
            chbClientes.ForeColor = Color.White;
            chbClientes.Location = new Point(15, 74);
            chbClientes.Name = "chbClientes";
            chbClientes.Size = new Size(132, 20);
            chbClientes.TabIndex = 1;
            chbClientes.Text = "Catalogo Clientes";
            chbClientes.UseVisualStyleBackColor = true;
            chbClientes.CheckedChanged += chbClientes_CheckedChanged;
            // 
            // chbVentas
            // 
            chbVentas.AutoSize = true;
            chbVentas.Font = new Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point);
            chbVentas.ForeColor = Color.White;
            chbVentas.Location = new Point(15, 13);
            chbVentas.Name = "chbVentas";
            chbVentas.Size = new Size(96, 26);
            chbVentas.TabIndex = 0;
            chbVentas.Text = "VENTAS";
            chbVentas.UseVisualStyleBackColor = true;
            chbVentas.CheckedChanged += chbVentas_CheckedChanged;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(3, 42, 76);
            panel6.Controls.Add(chbReporteProduccion);
            panel6.Controls.Add(chbProduccion);
            panel6.Location = new Point(798, 165);
            panel6.Name = "panel6";
            panel6.Size = new Size(240, 224);
            panel6.TabIndex = 10;
            // 
            // chbReporteProduccion
            // 
            chbReporteProduccion.AutoSize = true;
            chbReporteProduccion.Font = new Font("Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point);
            chbReporteProduccion.ForeColor = Color.White;
            chbReporteProduccion.Location = new Point(15, 48);
            chbReporteProduccion.Name = "chbReporteProduccion";
            chbReporteProduccion.Size = new Size(167, 20);
            chbReporteProduccion.TabIndex = 1;
            chbReporteProduccion.Text = "Reporte de Producción";
            chbReporteProduccion.UseVisualStyleBackColor = true;
            chbReporteProduccion.CheckedChanged += chbReporteProduccion_CheckedChanged;
            // 
            // chbProduccion
            // 
            chbProduccion.AutoSize = true;
            chbProduccion.Font = new Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point);
            chbProduccion.ForeColor = Color.White;
            chbProduccion.Location = new Point(15, 13);
            chbProduccion.Name = "chbProduccion";
            chbProduccion.Size = new Size(149, 26);
            chbProduccion.TabIndex = 0;
            chbProduccion.Text = "PRODUCCIÓN";
            chbProduccion.UseVisualStyleBackColor = true;
            chbProduccion.CheckedChanged += chbProduccion_CheckedChanged;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(3, 42, 76);
            panel7.Controls.Add(chbPendientesMaquinado);
            panel7.Controls.Add(chbSolicitudMaquinado);
            panel7.Controls.Add(chbMaquinado);
            panel7.Location = new Point(548, 165);
            panel7.Name = "panel7";
            panel7.Size = new Size(240, 224);
            panel7.TabIndex = 11;
            // 
            // chbPendientesMaquinado
            // 
            chbPendientesMaquinado.AutoSize = true;
            chbPendientesMaquinado.Font = new Font("Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point);
            chbPendientesMaquinado.ForeColor = Color.White;
            chbPendientesMaquinado.Location = new Point(15, 74);
            chbPendientesMaquinado.Name = "chbPendientesMaquinado";
            chbPendientesMaquinado.Size = new Size(165, 20);
            chbPendientesMaquinado.TabIndex = 2;
            chbPendientesMaquinado.Text = "Pendientes Maquinado";
            chbPendientesMaquinado.UseVisualStyleBackColor = true;
            chbPendientesMaquinado.CheckedChanged += chbPendientesMaquinado_CheckedChanged;
            // 
            // chbSolicitudMaquinado
            // 
            chbSolicitudMaquinado.AutoSize = true;
            chbSolicitudMaquinado.Font = new Font("Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point);
            chbSolicitudMaquinado.ForeColor = Color.White;
            chbSolicitudMaquinado.Location = new Point(15, 48);
            chbSolicitudMaquinado.Name = "chbSolicitudMaquinado";
            chbSolicitudMaquinado.Size = new Size(149, 20);
            chbSolicitudMaquinado.TabIndex = 1;
            chbSolicitudMaquinado.Text = "Solicitud Maquinado";
            chbSolicitudMaquinado.UseVisualStyleBackColor = true;
            chbSolicitudMaquinado.CheckedChanged += chbSolicitudMaquinado_CheckedChanged;
            // 
            // chbMaquinado
            // 
            chbMaquinado.AutoSize = true;
            chbMaquinado.Font = new Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point);
            chbMaquinado.ForeColor = Color.White;
            chbMaquinado.Location = new Point(15, 13);
            chbMaquinado.Name = "chbMaquinado";
            chbMaquinado.Size = new Size(140, 26);
            chbMaquinado.TabIndex = 0;
            chbMaquinado.Text = "MAQUINADO";
            chbMaquinado.UseVisualStyleBackColor = true;
            chbMaquinado.CheckedChanged += chbMaquinado_CheckedChanged;
            // 
            // SistemasPermisos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fondocontrolalmacen;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1322, 792);
            Controls.Add(panel7);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(btnactualizar);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(lblNumeroTemp);
            Controls.Add(panel1);
            Controls.Add(cbUsuarios);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SistemasPermisos";
            Text = "SistemasPermisos";
            Load += SistemasPermisos_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox cbUsuarios;
        private Panel panel1;
        private CheckBox chbAlmacen;
        private CheckBox chbNuevoProducto;
        private CheckBox chbEditarProducto;
        private CheckBox chbRegistrarExistencias;
        private CheckBox chbControlAlmacen;
        private CheckBox chbConsultaSalidas;
        private Label lblNumeroTemp;
        private Panel panel2;
        private CheckBox chbConsumiblesAlmacen;
        private CheckBox chbIndicadorCompras;
        private CheckBox chbCompras;
        private Panel panel3;
        private CheckBox chbGenerarCredencial;
        private CheckBox chbRegistroTrabajador;
        private CheckBox chbRecursosHumanos;
        private Panel panel4;
        private CheckBox chbPermisos;
        private CheckBox chbRequisicion;
        private CheckBox chbSistemas;
        private Button btnactualizar;
        private Panel panel5;
        private CheckBox chbReqCompra;
        private CheckBox chbClientes;
        private CheckBox chbVentas;
        private Panel panel6;
        private CheckBox chbReporteProduccion;
        private CheckBox chbProduccion;
        private CheckBox chbReqEnviadas;
        private CheckBox chbAdmiProvee;
        private CheckBox chbAdmiReq;
        private CheckBox chbBuscarCotizacion;
        private CheckBox chbCatalogoProductos;
        private CheckBox chbNuevaCotizacion;
        private Panel panel7;
        private CheckBox chbPendientesMaquinado;
        private CheckBox chbSolicitudMaquinado;
        private CheckBox chbMaquinado;
    }
}