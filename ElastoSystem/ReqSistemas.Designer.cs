namespace ElastoSystem
{
    partial class ReqSistemas
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            label1 = new Label();
            label2 = new Label();
            cbTipoReq = new ComboBox();
            label3 = new Label();
            tbusuario = new TextBox();
            label4 = new Label();
            tbpassword = new TextBox();
            label5 = new Label();
            lblfecha = new Label();
            fecha = new System.Windows.Forms.Timer(components);
            label6 = new Label();
            tbDescr = new TextBox();
            label7 = new Label();
            cbNivelPrio = new ComboBox();
            btnEnviarReq = new Button();
            label8 = new Label();
            lblFolio = new Label();
            panel5 = new Panel();
            label9 = new Label();
            panel1 = new Panel();
            dgvPendientesSistemas = new DataGridView();
            panel5.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPendientesSistemas).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Montserrat", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(41, 36);
            label1.Name = "label1";
            label1.Size = new Size(538, 44);
            label1.TabIndex = 0;
            label1.Text = "REQUERIMIENTO DE SISTEMAS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Montserrat", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(52, 135);
            label2.Name = "label2";
            label2.Size = new Size(183, 20);
            label2.TabIndex = 1;
            label2.Text = "Tipo de Requerimiento:";
            // 
            // cbTipoReq
            // 
            cbTipoReq.Font = new Font("Montserrat", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cbTipoReq.FormattingEnabled = true;
            cbTipoReq.Items.AddRange(new object[] { "Asesoría", "Base De Datos", "Capacitación", "Hardware", "Infraestructura", "Mantenimiento", "Software", "Otro..." });
            cbTipoReq.Location = new Point(240, 132);
            cbTipoReq.Name = "cbTipoReq";
            cbTipoReq.Size = new Size(262, 26);
            cbTipoReq.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(76, 40);
            label3.Name = "label3";
            label3.Size = new Size(78, 22);
            label3.TabIndex = 3;
            label3.Text = "Usuario:";
            // 
            // tbusuario
            // 
            tbusuario.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbusuario.Location = new Point(160, 37);
            tbusuario.Name = "tbusuario";
            tbusuario.Size = new Size(244, 27);
            tbusuario.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(45, 90);
            label4.Name = "label4";
            label4.Size = new Size(109, 22);
            label4.TabIndex = 5;
            label4.Text = "Contraseña:";
            // 
            // tbpassword
            // 
            tbpassword.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbpassword.Location = new Point(160, 85);
            tbpassword.Name = "tbpassword";
            tbpassword.Size = new Size(244, 27);
            tbpassword.TabIndex = 6;
            tbpassword.UseSystemPasswordChar = true;
            tbpassword.KeyPress += tbpassword_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Montserrat", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(995, 87);
            label5.Name = "label5";
            label5.Size = new Size(58, 20);
            label5.TabIndex = 7;
            label5.Text = "Fecha:";
            // 
            // lblfecha
            // 
            lblfecha.AutoSize = true;
            lblfecha.BackColor = Color.Transparent;
            lblfecha.Font = new Font("Montserrat", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblfecha.ForeColor = Color.White;
            lblfecha.Location = new Point(1051, 87);
            lblfecha.Name = "lblfecha";
            lblfecha.Size = new Size(100, 20);
            lblfecha.TabIndex = 8;
            lblfecha.Text = "Fecha Larga";
            // 
            // fecha
            // 
            fecha.Tick += fecha_Tick;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Montserrat", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(52, 222);
            label6.Name = "label6";
            label6.Size = new Size(100, 20);
            label6.TabIndex = 9;
            label6.Text = "Descripción:";
            // 
            // tbDescr
            // 
            tbDescr.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbDescr.Location = new Point(52, 260);
            tbDescr.Multiline = true;
            tbDescr.Name = "tbDescr";
            tbDescr.Size = new Size(650, 144);
            tbDescr.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Montserrat", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(52, 181);
            label7.Name = "label7";
            label7.Size = new Size(144, 20);
            label7.TabIndex = 11;
            label7.Text = "Nivel de Prioridad:";
            // 
            // cbNivelPrio
            // 
            cbNivelPrio.Font = new Font("Montserrat", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cbNivelPrio.FormattingEnabled = true;
            cbNivelPrio.Items.AddRange(new object[] { "Alta", "Media ", "Baja" });
            cbNivelPrio.Location = new Point(241, 181);
            cbNivelPrio.Name = "cbNivelPrio";
            cbNivelPrio.Size = new Size(262, 26);
            cbNivelPrio.TabIndex = 12;
            // 
            // btnEnviarReq
            // 
            btnEnviarReq.BackColor = Color.FromArgb(255, 102, 0);
            btnEnviarReq.Cursor = Cursors.Hand;
            btnEnviarReq.FlatAppearance.BorderSize = 0;
            btnEnviarReq.FlatStyle = FlatStyle.Flat;
            btnEnviarReq.Font = new Font("Montserrat", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnEnviarReq.ForeColor = Color.White;
            btnEnviarReq.Location = new Point(123, 142);
            btnEnviarReq.Name = "btnEnviarReq";
            btnEnviarReq.Size = new Size(238, 54);
            btnEnviarReq.TabIndex = 13;
            btnEnviarReq.Text = "Enviar Requerimiento";
            btnEnviarReq.UseVisualStyleBackColor = false;
            btnEnviarReq.Click += button1_Click;
            btnEnviarReq.KeyDown += btnEnviarReq_KeyDown;
            btnEnviarReq.KeyPress += btnEnviarReq_KeyPress;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Montserrat", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(1046, 56);
            label8.Name = "label8";
            label8.Size = new Size(75, 30);
            label8.TabIndex = 14;
            label8.Text = "Folio:";
            // 
            // lblFolio
            // 
            lblFolio.AutoSize = true;
            lblFolio.BackColor = Color.Transparent;
            lblFolio.Font = new Font("Montserrat", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lblFolio.ForeColor = Color.White;
            lblFolio.Location = new Point(1118, 57);
            lblFolio.Name = "lblFolio";
            lblFolio.Size = new Size(101, 30);
            lblFolio.TabIndex = 15;
            lblFolio.Text = "240000";
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(3, 42, 76);
            panel5.Controls.Add(label3);
            panel5.Controls.Add(tbusuario);
            panel5.Controls.Add(label4);
            panel5.Controls.Add(btnEnviarReq);
            panel5.Controls.Add(tbpassword);
            panel5.Location = new Point(823, 181);
            panel5.Name = "panel5";
            panel5.Size = new Size(453, 223);
            panel5.TabIndex = 16;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Montserrat", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(463, 20);
            label9.Name = "label9";
            label9.Size = new Size(324, 30);
            label9.TabIndex = 17;
            label9.Text = "PENDIENTES DE SISTEMAS";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(3, 42, 76);
            panel1.Controls.Add(dgvPendientesSistemas);
            panel1.Controls.Add(label9);
            panel1.Location = new Point(52, 446);
            panel1.Name = "panel1";
            panel1.Size = new Size(1224, 355);
            panel1.TabIndex = 18;
            // 
            // dgvPendientesSistemas
            // 
            dgvPendientesSistemas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPendientesSistemas.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(255, 102, 0);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvPendientesSistemas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvPendientesSistemas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPendientesSistemas.Location = new Point(40, 67);
            dgvPendientesSistemas.Name = "dgvPendientesSistemas";
            dgvPendientesSistemas.RowHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(255, 102, 0);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dgvPendientesSistemas.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvPendientesSistemas.RowTemplate.Height = 25;
            dgvPendientesSistemas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPendientesSistemas.Size = new Size(1148, 250);
            dgvPendientesSistemas.TabIndex = 18;
            // 
            // ReqSistemas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fondocontrolalmacen;
            ClientSize = new Size(1338, 831);
            Controls.Add(panel1);
            Controls.Add(panel5);
            Controls.Add(lblFolio);
            Controls.Add(label8);
            Controls.Add(cbNivelPrio);
            Controls.Add(label7);
            Controls.Add(tbDescr);
            Controls.Add(label6);
            Controls.Add(lblfecha);
            Controls.Add(label5);
            Controls.Add(cbTipoReq);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ReqSistemas";
            Text = "ReqSistemas";
            Load += ReqSistemas_Load;
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPendientesSistemas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox cbTipoReq;
        private Label label3;
        private TextBox tbusuario;
        private Label label4;
        private TextBox tbpassword;
        private Label label5;
        private Label lblfecha;
        private System.Windows.Forms.Timer fecha;
        private Label label6;
        private TextBox tbDescr;
        private Label label7;
        private ComboBox cbNivelPrio;
        private Button btnEnviarReq;
        private Label label8;
        private Label lblFolio;
        private Panel panel5;
        private Label label9;
        private Panel panel1;
        private DataGridView dgvPendientesSistemas;
    }
}