namespace ElastoSystem
{
    partial class RH_Credencial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RH_Credencial));
            pFrente = new Panel();
            lblNoTr = new Label();
            pbFotos = new PictureBox();
            lblDepartamento = new Label();
            lblAp = new Label();
            lblNom = new Label();
            panel1 = new Panel();
            pbFoto = new PictureBox();
            lblNo = new Label();
            lblApellidos = new Label();
            lblnombres = new Label();
            lbldepartamentoa = new Label();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            cbClave = new ComboBox();
            label1 = new Label();
            btnExportar = new Button();
            pAtras = new Panel();
            pbQR = new PictureBox();
            lblDepartamentotemp = new Label();
            PBarraTitulo = new Panel();
            PBNaranja = new PictureBox();
            PBAzul = new PictureBox();
            PBICerrar = new PictureBox();
            PBIconoMin = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            panel2 = new Panel();
            pbQR2 = new PictureBox();
            pFrente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbFotos).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbFoto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pAtras.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbQR).BeginInit();
            PBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PBNaranja).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PBAzul).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PBICerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PBIconoMin).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbQR2).BeginInit();
            SuspendLayout();
            // 
            // pFrente
            // 
            pFrente.BackColor = Color.White;
            pFrente.BackgroundImage = (Image)resources.GetObject("pFrente.BackgroundImage");
            pFrente.BackgroundImageLayout = ImageLayout.Stretch;
            pFrente.Controls.Add(lblNoTr);
            pFrente.Controls.Add(pbFotos);
            pFrente.Controls.Add(lblDepartamento);
            pFrente.Controls.Add(lblAp);
            pFrente.Controls.Add(lblNom);
            pFrente.ForeColor = Color.White;
            pFrente.Location = new Point(553, 49);
            pFrente.Margin = new Padding(0);
            pFrente.Name = "pFrente";
            pFrente.Size = new Size(650, 1016);
            pFrente.TabIndex = 0;
            pFrente.Paint += panel1_Paint;
            // 
            // lblNoTr
            // 
            lblNoTr.BackColor = Color.Transparent;
            lblNoTr.Font = new Font("Montserrat Black", 28F, FontStyle.Bold, GraphicsUnit.Point);
            lblNoTr.ForeColor = Color.Black;
            lblNoTr.Location = new Point(191, 911);
            lblNoTr.Name = "lblNoTr";
            lblNoTr.Size = new Size(380, 54);
            lblNoTr.TabIndex = 8;
            lblNoTr.Text = "NO.";
            lblNoTr.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pbFotos
            // 
            pbFotos.Location = new Point(223, 382);
            pbFotos.Name = "pbFotos";
            pbFotos.Size = new Size(332, 332);
            pbFotos.SizeMode = PictureBoxSizeMode.Zoom;
            pbFotos.TabIndex = 7;
            pbFotos.TabStop = false;
            // 
            // lblDepartamento
            // 
            lblDepartamento.BackColor = Color.FromArgb(0, 68, 109);
            lblDepartamento.Font = new Font("Montserrat SemiBold", 17F, FontStyle.Bold, GraphicsUnit.Point);
            lblDepartamento.ForeColor = Color.White;
            lblDepartamento.Location = new Point(17, 194);
            lblDepartamento.Name = "lblDepartamento";
            lblDepartamento.RightToLeft = RightToLeft.No;
            lblDepartamento.Size = new Size(91, 792);
            lblDepartamento.TabIndex = 6;
            lblDepartamento.TextAlign = ContentAlignment.MiddleLeft;
            lblDepartamento.Paint += lblDepartamento_Paint;
            // 
            // lblAp
            // 
            lblAp.BackColor = Color.Transparent;
            lblAp.Font = new Font("Montserrat SemiBold", 28F, FontStyle.Bold, GraphicsUnit.Point);
            lblAp.ForeColor = Color.Black;
            lblAp.Location = new Point(191, 832);
            lblAp.Name = "lblAp";
            lblAp.Size = new Size(380, 48);
            lblAp.TabIndex = 5;
            lblAp.Text = "APELLIDOS";
            lblAp.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNom
            // 
            lblNom.BackColor = Color.Transparent;
            lblNom.Font = new Font("Montserrat SemiBold", 28F, FontStyle.Bold, GraphicsUnit.Point);
            lblNom.ForeColor = Color.Black;
            lblNom.Location = new Point(191, 775);
            lblNom.Name = "lblNom";
            lblNom.Size = new Size(380, 57);
            lblNom.TabIndex = 4;
            lblNom.Text = "NOMBRE (S)";
            lblNom.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(pbFoto);
            panel1.Controls.Add(lblNo);
            panel1.Controls.Add(lblApellidos);
            panel1.Controls.Add(lblnombres);
            panel1.Controls.Add(lbldepartamentoa);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label7);
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(546, 49);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(650, 1016);
            panel1.TabIndex = 14;
            panel1.Visible = false;
            // 
            // pbFoto
            // 
            pbFoto.Location = new Point(157, 391);
            pbFoto.Name = "pbFoto";
            pbFoto.Size = new Size(290, 290);
            pbFoto.SizeMode = PictureBoxSizeMode.Zoom;
            pbFoto.TabIndex = 13;
            pbFoto.TabStop = false;
            // 
            // lblNo
            // 
            lblNo.BackColor = Color.Transparent;
            lblNo.Font = new Font("Montserrat Black", 28F, FontStyle.Bold, GraphicsUnit.Point);
            lblNo.ForeColor = Color.White;
            lblNo.Location = new Point(96, 880);
            lblNo.Name = "lblNo";
            lblNo.Size = new Size(413, 54);
            lblNo.TabIndex = 12;
            lblNo.Text = "No.";
            lblNo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblApellidos
            // 
            lblApellidos.BackColor = Color.Transparent;
            lblApellidos.Font = new Font("Montserrat SemiBold", 22F, FontStyle.Regular, GraphicsUnit.Point);
            lblApellidos.ForeColor = Color.White;
            lblApellidos.Location = new Point(96, 830);
            lblApellidos.Name = "lblApellidos";
            lblApellidos.Size = new Size(413, 35);
            lblApellidos.TabIndex = 11;
            lblApellidos.Text = "APELLIDOS";
            lblApellidos.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblnombres
            // 
            lblnombres.BackColor = Color.Transparent;
            lblnombres.Font = new Font("Montserrat SemiBold", 22F, FontStyle.Regular, GraphicsUnit.Point);
            lblnombres.ForeColor = Color.White;
            lblnombres.Location = new Point(96, 794);
            lblnombres.Name = "lblnombres";
            lblnombres.Size = new Size(413, 35);
            lblnombres.TabIndex = 10;
            lblnombres.Text = "NOMBRE (S)";
            lblnombres.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbldepartamentoa
            // 
            lbldepartamentoa.BackColor = Color.Transparent;
            lbldepartamentoa.Font = new Font("Montserrat", 30F, FontStyle.Bold, GraphicsUnit.Point);
            lbldepartamentoa.ForeColor = Color.White;
            lbldepartamentoa.Location = new Point(96, 719);
            lbldepartamentoa.Name = "lbldepartamentoa";
            lbldepartamentoa.Size = new Size(413, 47);
            lbldepartamentoa.TabIndex = 9;
            lbldepartamentoa.Text = "DEPARTAMENTO";
            lbldepartamentoa.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Montserrat Black", 28F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(191, 911);
            label4.Name = "label4";
            label4.Size = new Size(380, 54);
            label4.TabIndex = 8;
            label4.Text = "NO.";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(223, 382);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(332, 332);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.BackColor = Color.FromArgb(0, 68, 109);
            label5.Font = new Font("Montserrat SemiBold", 17F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(17, 194);
            label5.Name = "label5";
            label5.RightToLeft = RightToLeft.No;
            label5.Size = new Size(91, 792);
            label5.TabIndex = 6;
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Montserrat SemiBold", 28F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(191, 832);
            label6.Name = "label6";
            label6.Size = new Size(380, 48);
            label6.TabIndex = 5;
            label6.Text = "APELLIDOS";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Montserrat SemiBold", 28F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(191, 775);
            label7.Name = "label7";
            label7.Size = new Size(380, 57);
            label7.TabIndex = 4;
            label7.Text = "NOMBRE (S)";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cbClave
            // 
            cbClave.Font = new Font("Montserrat", 18F, FontStyle.Bold, GraphicsUnit.Point);
            cbClave.FormattingEnabled = true;
            cbClave.Location = new Point(195, 276);
            cbClave.Name = "cbClave";
            cbClave.Size = new Size(262, 41);
            cbClave.TabIndex = 1;
            cbClave.SelectedIndexChanged += cbClave_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Montserrat", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(77, 279);
            label1.Name = "label1";
            label1.Size = new Size(84, 33);
            label1.TabIndex = 2;
            label1.Text = "Clave";
            // 
            // btnExportar
            // 
            btnExportar.BackColor = Color.FromArgb(255, 102, 0);
            btnExportar.Cursor = Cursors.Hand;
            btnExportar.FlatAppearance.BorderSize = 0;
            btnExportar.FlatStyle = FlatStyle.Flat;
            btnExportar.Font = new Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnExportar.ForeColor = Color.White;
            btnExportar.Location = new Point(190, 367);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(267, 62);
            btnExportar.TabIndex = 7;
            btnExportar.Text = "GUARDAR CREDENCIAL";
            btnExportar.UseVisualStyleBackColor = false;
            btnExportar.Click += btnExportar_Click;
            // 
            // pAtras
            // 
            pAtras.BackColor = Color.White;
            pAtras.BackgroundImage = (Image)resources.GetObject("pAtras.BackgroundImage");
            pAtras.BackgroundImageLayout = ImageLayout.Stretch;
            pAtras.Controls.Add(pbQR);
            pAtras.ForeColor = Color.White;
            pAtras.Location = new Point(1251, 49);
            pAtras.Margin = new Padding(0);
            pAtras.Name = "pAtras";
            pAtras.Size = new Size(650, 1016);
            pAtras.TabIndex = 9;
            // 
            // pbQR
            // 
            pbQR.BackColor = Color.White;
            pbQR.BackgroundImageLayout = ImageLayout.Zoom;
            pbQR.Location = new Point(239, 762);
            pbQR.Name = "pbQR";
            pbQR.Size = new Size(190, 190);
            pbQR.TabIndex = 10;
            pbQR.TabStop = false;
            pbQR.Click += pbQR_Click;
            // 
            // lblDepartamentotemp
            // 
            lblDepartamentotemp.AutoSize = true;
            lblDepartamentotemp.Location = new Point(77, 331);
            lblDepartamentotemp.Name = "lblDepartamentotemp";
            lblDepartamentotemp.Size = new Size(94, 15);
            lblDepartamentotemp.TabIndex = 10;
            lblDepartamentotemp.Text = "DEPARTAMENTO";
            lblDepartamentotemp.Visible = false;
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
            PBarraTitulo.Size = new Size(1920, 30);
            PBarraTitulo.TabIndex = 11;
            // 
            // PBNaranja
            // 
            PBNaranja.BackColor = Color.Transparent;
            PBNaranja.Image = (Image)resources.GetObject("PBNaranja.Image");
            PBNaranja.Location = new Point(1877, 3);
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
            PBAzul.Location = new Point(1847, 3);
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
            PBICerrar.Location = new Point(1877, 3);
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
            PBIconoMin.Location = new Point(1847, 3);
            PBIconoMin.Name = "PBIconoMin";
            PBIconoMin.Size = new Size(24, 24);
            PBIconoMin.SizeMode = PictureBoxSizeMode.Zoom;
            PBIconoMin.TabIndex = 1;
            PBIconoMin.TabStop = false;
            PBIconoMin.Click += PBIconoMin_Click;
            PBIconoMin.MouseLeave += PBIconoMin_MouseLeave;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Montserrat", 22F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(136, 85);
            label2.Name = "label2";
            label2.Size = new Size(275, 41);
            label2.TabIndex = 12;
            label2.Text = "GENERADOR DE";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Montserrat", 22F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(136, 126);
            label3.Name = "label3";
            label3.Size = new Size(263, 41);
            label3.TabIndex = 13;
            label3.Text = "CREDENCIALES";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Controls.Add(pbQR2);
            panel2.ForeColor = Color.White;
            panel2.Location = new Point(1241, 49);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(650, 1016);
            panel2.TabIndex = 15;
            panel2.Visible = false;
            // 
            // pbQR2
            // 
            pbQR2.BackgroundImageLayout = ImageLayout.Zoom;
            pbQR2.Location = new Point(196, 711);
            pbQR2.Name = "pbQR2";
            pbQR2.Size = new Size(190, 190);
            pbQR2.TabIndex = 9;
            pbQR2.TabStop = false;
            // 
            // RH_Credencial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fondocontrolalmacen;
            ClientSize = new Size(1920, 1080);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(PBarraTitulo);
            Controls.Add(lblDepartamentotemp);
            Controls.Add(pAtras);
            Controls.Add(btnExportar);
            Controls.Add(label1);
            Controls.Add(cbClave);
            Controls.Add(pFrente);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "RH_Credencial";
            Text = "RH_Credencial";
            Load += RH_Credencial_Load;
            pFrente.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbFotos).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbFoto).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pAtras.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbQR).EndInit();
            PBarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PBNaranja).EndInit();
            ((System.ComponentModel.ISupportInitialize)PBAzul).EndInit();
            ((System.ComponentModel.ISupportInitialize)PBICerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)PBIconoMin).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbQR2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pFrente;
        private ComboBox cbClave;
        private Label label1;
        private Label lblNom;
        private Label lblAp;
        private Label lblDepartamento;
        private PictureBox pbFotos;
        private Label lblNoTr;
        private Button btnExportar;
        private Panel pAtras;
        private PictureBox pbQR;
        private Label lblDepartamentotemp;
        private Panel PBarraTitulo;
        private PictureBox PBNaranja;
        private PictureBox PBAzul;
        private PictureBox PBICerrar;
        private PictureBox PBIconoMin;
        private Label label2;
        private Label label3;
        private Panel panel1;
        private Label label4;
        private PictureBox pictureBox1;
        private Label label5;
        private Label label6;
        private Label label7;
        private Panel panel2;
        private PictureBox pbQR2;
        private Label lbldepartamentoa;
        private Label lblnombres;
        private Label lblApellidos;
        private Label lblNo;
        private PictureBox pbFoto;
    }
}