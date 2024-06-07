namespace ElastoSystem
{
    partial class Novedades
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Novedades));
            lblhora = new Label();
            lblfecha = new Label();
            horayfecha = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            pbSlide = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pbSlide).BeginInit();
            SuspendLayout();
            // 
            // lblhora
            // 
            lblhora.AutoSize = true;
            lblhora.BackColor = Color.Transparent;
            lblhora.Font = new Font("Montserrat", 30F, FontStyle.Bold, GraphicsUnit.Point);
            lblhora.ForeColor = Color.White;
            lblhora.Location = new Point(1045, 723);
            lblhora.Name = "lblhora";
            lblhora.Size = new Size(206, 55);
            lblhora.TabIndex = 0;
            lblhora.Text = "00:00:00";
            // 
            // lblfecha
            // 
            lblfecha.AutoSize = true;
            lblfecha.BackColor = Color.Transparent;
            lblfecha.Font = new Font("Montserrat SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblfecha.ForeColor = Color.White;
            lblfecha.Location = new Point(952, 774);
            lblfecha.Name = "lblfecha";
            lblfecha.Size = new Size(70, 26);
            lblfecha.TabIndex = 1;
            lblfecha.Text = "label2";
            lblfecha.Click += lblfecha_Click;
            // 
            // horayfecha
            // 
            horayfecha.Enabled = true;
            horayfecha.Tick += horayfecha_Tick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Montserrat", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(543, 45);
            label1.Name = "label1";
            label1.Size = new Size(251, 33);
            label1.TabIndex = 2;
            label1.Text = "Política de Calidad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Montserrat", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(47, 78);
            label2.Name = "label2";
            label2.Size = new Size(1250, 22);
            label2.TabIndex = 3;
            label2.Text = "En elastotecnica S.A. de C.V. estamos comprometidos a lograr la plena satisfacción del cliente en todos nuestros productos, basados en una mejora conti-";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Montserrat", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(357, 99);
            label3.Name = "label3";
            label3.Size = new Size(597, 22);
            label3.TabIndex = 4;
            label3.Text = "nua como organización, mediante la participación de nuestro personal.  ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Montserrat", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(27, 730);
            label4.Name = "label4";
            label4.Size = new Size(276, 33);
            label4.TabIndex = 5;
            label4.Text = "Objetivos de Calidad";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Montserrat", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(27, 763);
            label5.Name = "label5";
            label5.Size = new Size(320, 22);
            label5.TabIndex = 6;
            label5.Text = "a.\tMejora continua como organización.";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Montserrat", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(27, 784);
            label6.Name = "label6";
            label6.Size = new Size(327, 22);
            label6.TabIndex = 7;
            label6.Text = "b.\tLograr la satisfacción total del cliente.";
            // 
            // pbSlide
            // 
            pbSlide.BackColor = Color.Transparent;
            pbSlide.Image = (Image)resources.GetObject("pbSlide.Image");
            pbSlide.Location = new Point(239, 163);
            pbSlide.Name = "pbSlide";
            pbSlide.Size = new Size(860, 487);
            pbSlide.SizeMode = PictureBoxSizeMode.Zoom;
            pbSlide.TabIndex = 8;
            pbSlide.TabStop = false;
            pbSlide.Click += pbSlide_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 10000;
            timer1.Tick += timer1_Tick;
            // 
            // Novedades
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fondocontrolalmacen;
            ClientSize = new Size(1338, 831);
            Controls.Add(pbSlide);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblfecha);
            Controls.Add(lblhora);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Novedades";
            Text = "Novedades";
            Load += Novedades_Load;
            ((System.ComponentModel.ISupportInitialize)pbSlide).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblhora;
        private Label lblfecha;
        private System.Windows.Forms.Timer horayfecha;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private PictureBox pbSlide;
        private System.Windows.Forms.Timer timer1;
    }
}