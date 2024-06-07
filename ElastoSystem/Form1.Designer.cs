namespace ElastoSystem
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnlogin = new Button();
            tbpassword = new TextBox();
            tbusuario = new TextBox();
            label1 = new Label();
            chbRecordarme = new CheckBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox4 = new PictureBox();
            btncerrar = new PictureBox();
            btnminimizar = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox7 = new PictureBox();
            pictureBox8 = new PictureBox();
            button1 = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            pictureBox3 = new PictureBox();
            pictureBox5 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btncerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnminimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // btnlogin
            // 
            btnlogin.BackColor = Color.FromArgb(255, 102, 0);
            btnlogin.Cursor = Cursors.Hand;
            btnlogin.FlatAppearance.BorderSize = 0;
            btnlogin.FlatStyle = FlatStyle.Flat;
            btnlogin.Font = new Font("Montserrat", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnlogin.ForeColor = Color.White;
            btnlogin.Location = new Point(240, 468);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(210, 47);
            btnlogin.TabIndex = 2;
            btnlogin.Text = "ENTRAR";
            btnlogin.UseVisualStyleBackColor = false;
            btnlogin.Click += btnlogin_Click;
            // 
            // tbpassword
            // 
            tbpassword.BorderStyle = BorderStyle.None;
            tbpassword.Font = new Font("Montserrat", 15F, FontStyle.Regular, GraphicsUnit.Point);
            tbpassword.ForeColor = Color.DimGray;
            tbpassword.Location = new Point(38, 3);
            tbpassword.Name = "tbpassword";
            tbpassword.Size = new Size(330, 25);
            tbpassword.TabIndex = 4;
            tbpassword.Text = "Contraseña";
            tbpassword.MouseClick += tbpassword_MouseClick;
            tbpassword.TextChanged += tbpassword_TextChanged;
            tbpassword.Enter += tbpassword_Enter;
            tbpassword.KeyPress += tbpassword_KeyPress;
            tbpassword.Leave += tbpassword_Leave;
            // 
            // tbusuario
            // 
            tbusuario.BorderStyle = BorderStyle.None;
            tbusuario.Font = new Font("Montserrat", 15F, FontStyle.Regular, GraphicsUnit.Point);
            tbusuario.ForeColor = Color.DimGray;
            tbusuario.Location = new Point(40, 1);
            tbusuario.Multiline = true;
            tbusuario.Name = "tbusuario";
            tbusuario.Size = new Size(330, 30);
            tbusuario.TabIndex = 5;
            tbusuario.Text = "Usuario";
            tbusuario.Enter += tbusuario_Enter;
            tbusuario.KeyDown += tbusuario_KeyDown;
            tbusuario.KeyPress += tbusuario_KeyPress;
            tbusuario.Leave += tbusuario_Leave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Cursor = Cursors.Hand;
            label1.Font = new Font("Montserrat", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.AppWorkspace;
            label1.Location = new Point(360, 412);
            label1.Name = "label1";
            label1.Size = new Size(168, 16);
            label1.TabIndex = 6;
            label1.Text = "¿Olvidaste tu Contraseña?";
            // 
            // chbRecordarme
            // 
            chbRecordarme.AutoSize = true;
            chbRecordarme.BackColor = Color.Transparent;
            chbRecordarme.FlatStyle = FlatStyle.Flat;
            chbRecordarme.Font = new Font("Montserrat", 9F, FontStyle.Bold, GraphicsUnit.Point);
            chbRecordarme.ForeColor = SystemColors.AppWorkspace;
            chbRecordarme.Location = new Point(160, 410);
            chbRecordarme.Name = "chbRecordarme";
            chbRecordarme.Size = new Size(101, 20);
            chbRecordarme.TabIndex = 7;
            chbRecordarme.Text = "Recordarme";
            chbRecordarme.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.Logotipo;
            pictureBox1.Location = new Point(272, 97);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(146, 136);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.White;
            pictureBox2.Image = Properties.Resources.Icono_Usuario;
            pictureBox2.Location = new Point(16, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(14, 28);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.White;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(16, 3);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(14, 28);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 13;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // btncerrar
            // 
            btncerrar.BackColor = Color.Transparent;
            btncerrar.Cursor = Cursors.Hand;
            btncerrar.Image = (Image)resources.GetObject("btncerrar.Image");
            btncerrar.Location = new Point(641, 4);
            btncerrar.Name = "btncerrar";
            btncerrar.Size = new Size(23, 23);
            btncerrar.SizeMode = PictureBoxSizeMode.Zoom;
            btncerrar.TabIndex = 14;
            btncerrar.TabStop = false;
            btncerrar.Click += btncerrar_Click;
            btncerrar.MouseLeave += btncerrar_MouseLeave;
            // 
            // btnminimizar
            // 
            btnminimizar.BackColor = Color.Transparent;
            btnminimizar.Cursor = Cursors.Hand;
            btnminimizar.Image = (Image)resources.GetObject("btnminimizar.Image");
            btnminimizar.Location = new Point(611, 4);
            btnminimizar.Name = "btnminimizar";
            btnminimizar.Size = new Size(24, 24);
            btnminimizar.SizeMode = PictureBoxSizeMode.Zoom;
            btnminimizar.TabIndex = 15;
            btnminimizar.TabStop = false;
            btnminimizar.Click += btnminimizar_Click;
            btnminimizar.MouseLeave += btnminimizar_MouseLeave;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.Transparent;
            pictureBox6.Cursor = Cursors.Hand;
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(300, 580);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(20, 20);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 16;
            pictureBox6.TabStop = false;
            pictureBox6.Click += pictureBox6_Click;
            // 
            // pictureBox7
            // 
            pictureBox7.BackColor = Color.Transparent;
            pictureBox7.Cursor = Cursors.Hand;
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(335, 580);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(20, 20);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 17;
            pictureBox7.TabStop = false;
            pictureBox7.Click += pictureBox7_Click;
            // 
            // pictureBox8
            // 
            pictureBox8.BackColor = Color.Transparent;
            pictureBox8.Cursor = Cursors.Hand;
            pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new Point(370, 580);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(20, 20);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 18;
            pictureBox8.TabStop = false;
            pictureBox8.Click += pictureBox8_Click;
            // 
            // button1
            // 
            button1.Location = new Point(28, 555);
            button1.Name = "button1";
            button1.Size = new Size(162, 57);
            button1.TabIndex = 21;
            button1.Text = "pruebas";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(tbusuario);
            panel1.Location = new Point(160, 281);
            panel1.Name = "panel1";
            panel1.Size = new Size(371, 32);
            panel1.TabIndex = 22;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(tbpassword);
            panel2.Controls.Add(pictureBox4);
            panel2.Location = new Point(160, 337);
            panel2.Name = "panel2";
            panel2.Size = new Size(371, 32);
            panel2.TabIndex = 23;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(153, 255, 255, 255);
            panel3.Controls.Add(pictureBox3);
            panel3.Controls.Add(btnminimizar);
            panel3.Controls.Add(pictureBox5);
            panel3.Controls.Add(btncerrar);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(674, 30);
            panel3.TabIndex = 24;
            panel3.Paint += panel3_Paint;
            panel3.MouseDown += panel3_MouseDown;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Cursor = Cursors.Hand;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(611, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(24, 24);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 17;
            pictureBox3.TabStop = false;
            pictureBox3.MouseMove += pictureBox3_MouseMove;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Transparent;
            pictureBox5.Cursor = Cursors.Hand;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(641, 4);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(23, 23);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 16;
            pictureBox5.TabStop = false;
            pictureBox5.MouseMove += pictureBox5_MouseMove;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(674, 653);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(pictureBox8);
            Controls.Add(pictureBox7);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox1);
            Controls.Add(chbRecordarme);
            Controls.Add(label1);
            Controls.Add(btnlogin);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            Opacity = 0.95D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            KeyDown += Form1_KeyDown;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)btncerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnminimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnlogin;
        private TextBox tbpassword;
        private TextBox tbusuario;
        private Label label1;
        private CheckBox chbRecordarme;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox4;
        private PictureBox btncerrar;
        private PictureBox btnminimizar;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
        private PictureBox pictureBox8;
        private Button button1;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private PictureBox pictureBox3;
        private PictureBox pictureBox5;
    }
}