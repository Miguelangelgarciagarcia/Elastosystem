namespace ElastoSystem
{
    partial class AlmacenTemporal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlmacenTemporal));
            cbap = new ComboBox();
            cbnombre = new ComboBox();
            tbnotrabajador = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            cbproductos = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            tbcantidad = new TextBox();
            label6 = new Label();
            tbnota = new TextBox();
            button3 = new Button();
            dgv = new DataGridView();
            lbunidad = new Label();
            paneltop = new Panel();
            pictureBox4 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            pictureBox5 = new PictureBox();
            panel4 = new Panel();
            lblNombreTrabajador = new Label();
            label7 = new Label();
            txbIDProducto = new TextBox();
            lblNombreProducto = new Label();
            mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            label8 = new Label();
            txbCantidad = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            paneltop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // cbap
            // 
            cbap.BackColor = Color.FromArgb(205, 215, 224);
            cbap.FlatStyle = FlatStyle.Flat;
            cbap.Font = new Font("Montserrat", 16F, FontStyle.Regular, GraphicsUnit.Point);
            cbap.FormattingEnabled = true;
            cbap.Location = new Point(40, 418);
            cbap.Name = "cbap";
            cbap.Size = new Size(399, 37);
            cbap.TabIndex = 0;
            cbap.Visible = false;
            cbap.SelectedIndexChanged += cbap_SelectedIndexChanged;
            cbap.KeyPress += cbap_KeyPress;
            // 
            // cbnombre
            // 
            cbnombre.BackColor = Color.FromArgb(205, 215, 224);
            cbnombre.FlatStyle = FlatStyle.Flat;
            cbnombre.Font = new Font("Montserrat", 16F, FontStyle.Regular, GraphicsUnit.Point);
            cbnombre.FormattingEnabled = true;
            cbnombre.Location = new Point(478, 418);
            cbnombre.Name = "cbnombre";
            cbnombre.Size = new Size(399, 37);
            cbnombre.TabIndex = 1;
            cbnombre.Visible = false;
            cbnombre.SelectedIndexChanged += cbnombre_SelectedIndexChanged;
            // 
            // tbnotrabajador
            // 
            tbnotrabajador.BackColor = Color.FromArgb(205, 215, 224);
            tbnotrabajador.BorderStyle = BorderStyle.None;
            tbnotrabajador.Font = new Font("Montserrat", 16F, FontStyle.Regular, GraphicsUnit.Point);
            tbnotrabajador.Location = new Point(221, 58);
            tbnotrabajador.Multiline = true;
            tbnotrabajador.Name = "tbnotrabajador";
            tbnotrabajador.Size = new Size(165, 30);
            tbnotrabajador.TabIndex = 3;
            tbnotrabajador.TextAlign = HorizontalAlignment.Center;
            tbnotrabajador.KeyPress += tbnotrabajador_KeyPress;
            tbnotrabajador.PreviewKeyDown += tbnotrabajador_PreviewKeyDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Montserrat", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(40, 384);
            label1.Name = "label1";
            label1.Size = new Size(199, 30);
            label1.TabIndex = 4;
            label1.Text = "Apellido Paterno";
            label1.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Montserrat", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(478, 384);
            label2.Name = "label2";
            label2.Size = new Size(136, 30);
            label2.TabIndex = 5;
            label2.Text = "Nombre (s)";
            label2.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Montserrat", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(40, 58);
            label3.Name = "label3";
            label3.Size = new Size(175, 30);
            label3.TabIndex = 6;
            label3.Text = "No. Trabajador";
            // 
            // cbproductos
            // 
            cbproductos.BackColor = Color.FromArgb(205, 215, 224);
            cbproductos.FlatStyle = FlatStyle.Flat;
            cbproductos.Font = new Font("Montserrat", 16F, FontStyle.Regular, GraphicsUnit.Point);
            cbproductos.FormattingEnabled = true;
            cbproductos.Location = new Point(40, 508);
            cbproductos.Name = "cbproductos";
            cbproductos.Size = new Size(399, 37);
            cbproductos.TabIndex = 7;
            cbproductos.Visible = false;
            cbproductos.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Montserrat", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(40, 475);
            label4.Name = "label4";
            label4.Size = new Size(116, 30);
            label4.TabIndex = 8;
            label4.Text = "Producto";
            label4.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Montserrat", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(478, 475);
            label5.Name = "label5";
            label5.Size = new Size(115, 30);
            label5.TabIndex = 9;
            label5.Text = "Cantidad";
            label5.Visible = false;
            // 
            // tbcantidad
            // 
            tbcantidad.BackColor = Color.FromArgb(205, 215, 224);
            tbcantidad.BorderStyle = BorderStyle.None;
            tbcantidad.Font = new Font("Montserrat", 16F, FontStyle.Regular, GraphicsUnit.Point);
            tbcantidad.Location = new Point(0, 4);
            tbcantidad.Name = "tbcantidad";
            tbcantidad.Size = new Size(393, 27);
            tbcantidad.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Montserrat", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(40, 214);
            label6.Name = "label6";
            label6.Size = new Size(67, 30);
            label6.TabIndex = 11;
            label6.Text = "Nota";
            // 
            // tbnota
            // 
            tbnota.BackColor = Color.FromArgb(205, 215, 224);
            tbnota.BorderStyle = BorderStyle.None;
            tbnota.Font = new Font("Montserrat", 16F, FontStyle.Regular, GraphicsUnit.Point);
            tbnota.Location = new Point(221, 214);
            tbnota.Multiline = true;
            tbnota.Name = "tbnota";
            tbnota.Size = new Size(365, 30);
            tbnota.TabIndex = 12;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(255, 102, 0);
            button3.Cursor = Cursors.Hand;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Montserrat", 15F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(325, 273);
            button3.Name = "button3";
            button3.Size = new Size(163, 42);
            button3.TabIndex = 14;
            button3.Text = "Aceptar";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // dgv
            // 
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.BackgroundColor = Color.FromArgb(205, 215, 224);
            dgv.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Montserrat ExtraBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(255, 102, 0);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.WindowFrame;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgv.DefaultCellStyle = dataGridViewCellStyle2;
            dgv.GridColor = SystemColors.ActiveCaptionText;
            dgv.Location = new Point(102, 545);
            dgv.Name = "dgv";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(205, 215, 224);
            dataGridViewCellStyle3.Font = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(255, 102, 0);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgv.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Montserrat", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(255, 102, 0);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dgv.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgv.RowTemplate.Height = 25;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.Size = new Size(1806, 656);
            dgv.TabIndex = 15;
            // 
            // lbunidad
            // 
            lbunidad.AutoSize = true;
            lbunidad.BackColor = Color.Transparent;
            lbunidad.Font = new Font("Montserrat", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lbunidad.ForeColor = Color.White;
            lbunidad.Location = new Point(392, 162);
            lbunidad.Name = "lbunidad";
            lbunidad.Size = new Size(96, 30);
            lbunidad.TabIndex = 16;
            lbunidad.Text = "Unidad";
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
            paneltop.TabIndex = 17;
            paneltop.Paint += paneltop_Paint;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(1854, 21);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(23, 23);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 21;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            pictureBox4.MouseMove += pictureBox4_MouseMove;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1885, 21);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(23, 23);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 20;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            pictureBox2.MouseEnter += pictureBox2_MouseEnter;
            pictureBox2.MouseLeave += pictureBox2_MouseLeave;
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
            pictureBox1.MouseEnter += pictureBox1_MouseEnter;
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
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(205, 215, 224);
            panel1.Controls.Add(tbcantidad);
            panel1.Location = new Point(478, 508);
            panel1.Name = "panel1";
            panel1.Size = new Size(399, 37);
            panel1.TabIndex = 18;
            panel1.Visible = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(205, 215, 224);
            panel2.Location = new Point(910, 418);
            panel2.Name = "panel2";
            panel2.Size = new Size(399, 37);
            panel2.TabIndex = 19;
            panel2.Visible = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(205, 215, 224);
            panel3.Location = new Point(1349, 92);
            panel3.Name = "panel3";
            panel3.Size = new Size(506, 156);
            panel3.TabIndex = 20;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Transparent;
            pictureBox5.Cursor = Cursors.Hand;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(0, 0);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(98, 35);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 21;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(255, 102, 0);
            panel4.Controls.Add(pictureBox5);
            panel4.Location = new Point(40, 273);
            panel4.Name = "panel4";
            panel4.Size = new Size(98, 37);
            panel4.TabIndex = 23;
            // 
            // lblNombreTrabajador
            // 
            lblNombreTrabajador.AutoSize = true;
            lblNombreTrabajador.BackColor = Color.Transparent;
            lblNombreTrabajador.Font = new Font("Montserrat", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombreTrabajador.ForeColor = Color.White;
            lblNombreTrabajador.Location = new Point(392, 58);
            lblNombreTrabajador.Name = "lblNombreTrabajador";
            lblNombreTrabajador.Size = new Size(236, 30);
            lblNombreTrabajador.TabIndex = 24;
            lblNombreTrabajador.Text = "Nombre Trabajador";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Montserrat", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(40, 110);
            label7.Name = "label7";
            label7.Size = new Size(152, 30);
            label7.TabIndex = 25;
            label7.Text = "ID. Producto";
            // 
            // txbIDProducto
            // 
            txbIDProducto.BackColor = Color.FromArgb(205, 215, 224);
            txbIDProducto.BorderStyle = BorderStyle.None;
            txbIDProducto.Font = new Font("Montserrat", 16F, FontStyle.Regular, GraphicsUnit.Point);
            txbIDProducto.Location = new Point(221, 110);
            txbIDProducto.Multiline = true;
            txbIDProducto.Name = "txbIDProducto";
            txbIDProducto.Size = new Size(165, 30);
            txbIDProducto.TabIndex = 26;
            txbIDProducto.TextAlign = HorizontalAlignment.Center;
            txbIDProducto.TextChanged += txbIDProducto_TextChanged;
            txbIDProducto.KeyPress += txbIDProducto_KeyPress;
            // 
            // lblNombreProducto
            // 
            lblNombreProducto.AutoSize = true;
            lblNombreProducto.BackColor = Color.Transparent;
            lblNombreProducto.Font = new Font("Montserrat", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombreProducto.ForeColor = Color.White;
            lblNombreProducto.Location = new Point(392, 110);
            lblNombreProducto.Name = "lblNombreProducto";
            lblNombreProducto.Size = new Size(218, 30);
            lblNombreProducto.TabIndex = 27;
            lblNombreProducto.Text = "Nombre Producto";
            // 
            // mySqlCommand1
            // 
            mySqlCommand1.CacheAge = 0;
            mySqlCommand1.Connection = null;
            mySqlCommand1.EnableCaching = false;
            mySqlCommand1.Transaction = null;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Montserrat", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(40, 162);
            label8.Name = "label8";
            label8.Size = new Size(115, 30);
            label8.TabIndex = 28;
            label8.Text = "Cantidad";
            // 
            // txbCantidad
            // 
            txbCantidad.BackColor = Color.FromArgb(205, 215, 224);
            txbCantidad.BorderStyle = BorderStyle.None;
            txbCantidad.Font = new Font("Montserrat", 16F, FontStyle.Regular, GraphicsUnit.Point);
            txbCantidad.Location = new Point(221, 162);
            txbCantidad.Multiline = true;
            txbCantidad.Name = "txbCantidad";
            txbCantidad.Size = new Size(165, 30);
            txbCantidad.TabIndex = 29;
            txbCantidad.TextAlign = HorizontalAlignment.Center;
            txbCantidad.KeyPress += txbCantidad_KeyPress;
            // 
            // AlmacenTemporal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1920, 1080);
            Controls.Add(tbnota);
            Controls.Add(txbCantidad);
            Controls.Add(label8);
            Controls.Add(lblNombreProducto);
            Controls.Add(txbIDProducto);
            Controls.Add(label7);
            Controls.Add(lblNombreTrabajador);
            Controls.Add(tbnotrabajador);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(paneltop);
            Controls.Add(lbunidad);
            Controls.Add(dgv);
            Controls.Add(button3);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(cbproductos);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cbnombre);
            Controls.Add(cbap);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AlmacenTemporal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AlmacenTemporal";
            Load += AlmacenTemporal_Load;
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            paneltop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel4.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbap;
        private ComboBox cbnombre;
        private TextBox tbnotrabajador;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cbproductos;
        private Label label4;
        private Label label5;
        private TextBox tbcantidad;
        private Label label6;
        private TextBox tbnota;
        private Button button3;
        private DataGridView dgv;
        private Label lbunidad;
        private Panel paneltop;
        private PictureBox pictureBox3;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox4;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private PictureBox pictureBox5;
        private Panel panel4;
        private Label lblNombreTrabajador;
        private Label label7;
        private TextBox txbIDProducto;
        private Label lblNombreProducto;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private Label label8;
        private TextBox txbCantidad;
    }
}