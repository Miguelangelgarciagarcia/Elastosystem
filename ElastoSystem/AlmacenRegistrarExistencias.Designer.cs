namespace ElastoSystem
{
    partial class AlmacenRegistrarExistencias
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txbID = new TextBox();
            txbNotas = new TextBox();
            txbAdd = new TextBox();
            txbExistencias = new TextBox();
            txbProducto = new TextBox();
            label6 = new Label();
            button1 = new Button();
            button2 = new Button();
            dgv = new DataGridView();
            label7 = new Label();
            txbclave = new TextBox();
            labelprueba = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Montserrat", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(31, 169);
            label1.Name = "label1";
            label1.Size = new Size(152, 30);
            label1.TabIndex = 0;
            label1.Text = "ID Producto:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Montserrat", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(31, 215);
            label2.Name = "label2";
            label2.Size = new Size(121, 30);
            label2.TabIndex = 1;
            label2.Text = "Producto:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Montserrat", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(31, 261);
            label3.Name = "label3";
            label3.Size = new Size(141, 30);
            label3.TabIndex = 2;
            label3.Text = "Existencias:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Montserrat", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(31, 348);
            label4.Name = "label4";
            label4.Size = new Size(197, 30);
            label4.TabIndex = 3;
            label4.Text = "Agregar / Quitar:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Montserrat", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(31, 408);
            label5.Name = "label5";
            label5.Size = new Size(72, 30);
            label5.TabIndex = 4;
            label5.Text = "Nota:";
            // 
            // txbID
            // 
            txbID.Font = new Font("Montserrat", 16F, FontStyle.Regular, GraphicsUnit.Point);
            txbID.Location = new Point(227, 166);
            txbID.Name = "txbID";
            txbID.Size = new Size(130, 34);
            txbID.TabIndex = 5;
            txbID.KeyPress += txbID_KeyPress;
            // 
            // txbNotas
            // 
            txbNotas.Font = new Font("Montserrat", 16F, FontStyle.Regular, GraphicsUnit.Point);
            txbNotas.Location = new Point(227, 405);
            txbNotas.Name = "txbNotas";
            txbNotas.Size = new Size(299, 34);
            txbNotas.TabIndex = 6;
            // 
            // txbAdd
            // 
            txbAdd.Font = new Font("Montserrat", 16F, FontStyle.Regular, GraphicsUnit.Point);
            txbAdd.Location = new Point(227, 345);
            txbAdd.Name = "txbAdd";
            txbAdd.Size = new Size(299, 34);
            txbAdd.TabIndex = 7;
            // 
            // txbExistencias
            // 
            txbExistencias.Font = new Font("Montserrat", 16F, FontStyle.Regular, GraphicsUnit.Point);
            txbExistencias.Location = new Point(227, 258);
            txbExistencias.Name = "txbExistencias";
            txbExistencias.Size = new Size(299, 34);
            txbExistencias.TabIndex = 8;
            // 
            // txbProducto
            // 
            txbProducto.Font = new Font("Montserrat", 16F, FontStyle.Regular, GraphicsUnit.Point);
            txbProducto.Location = new Point(227, 212);
            txbProducto.Name = "txbProducto";
            txbProducto.Size = new Size(299, 34);
            txbProducto.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Montserrat", 8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(91, 384);
            label6.Name = "label6";
            label6.Size = new Size(411, 15);
            label6.TabIndex = 10;
            label6.Text = "(PARA DESCONTAR PRODUCTOS SE DEBE AGREGAR EL SIGNO MENOS)";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 102, 0);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(386, 166);
            button1.Name = "button1";
            button1.Size = new Size(140, 40);
            button1.TabIndex = 11;
            button1.Text = "BUSCAR";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 102, 0);
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Montserrat", 14F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(167, 631);
            button2.Name = "button2";
            button2.Size = new Size(201, 49);
            button2.TabIndex = 12;
            button2.Text = "REGISTRAR";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // dgv
            // 
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 33, 64);
            dataGridViewCellStyle1.Font = new Font("Montserrat", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(255, 102, 0);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Location = new Point(560, 36);
            dgv.Name = "dgv";
            dgv.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.Transparent;
            dataGridViewCellStyle2.Font = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(255, 102, 0);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgv.RowHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(255, 102, 0);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dgv.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgv.RowTemplate.Height = 25;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.Size = new Size(744, 731);
            dgv.TabIndex = 13;
            dgv.DoubleClick += dgv_DoubleClick;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Montserrat", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(31, 551);
            label7.Name = "label7";
            label7.Size = new Size(177, 30);
            label7.TabIndex = 14;
            label7.Text = "Clave Registro:";
            // 
            // txbclave
            // 
            txbclave.Font = new Font("Montserrat", 16F, FontStyle.Regular, GraphicsUnit.Point);
            txbclave.Location = new Point(227, 547);
            txbclave.Name = "txbclave";
            txbclave.Size = new Size(299, 34);
            txbclave.TabIndex = 15;
            txbclave.UseSystemPasswordChar = true;
            txbclave.KeyPress += txbclave_KeyPress;
            // 
            // labelprueba
            // 
            labelprueba.AutoSize = true;
            labelprueba.BackColor = Color.Transparent;
            labelprueba.Location = new Point(12, 768);
            labelprueba.Name = "labelprueba";
            labelprueba.Size = new Size(38, 15);
            labelprueba.TabIndex = 16;
            labelprueba.Text = "label8";
            labelprueba.Visible = false;
            // 
            // AlmacenRegistrarExistencias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fondocontrolalmacen;
            ClientSize = new Size(1322, 792);
            Controls.Add(labelprueba);
            Controls.Add(txbclave);
            Controls.Add(label7);
            Controls.Add(dgv);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(txbProducto);
            Controls.Add(txbExistencias);
            Controls.Add(txbAdd);
            Controls.Add(txbNotas);
            Controls.Add(txbID);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AlmacenRegistrarExistencias";
            Text = "AlmacenRegistrarExistencias";
            Load += AlmacenRegistrarExistencias_Load;
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txbID;
        private TextBox txbNotas;
        private TextBox txbAdd;
        private TextBox txbExistencias;
        private TextBox txbProducto;
        private Label label6;
        private Button button1;
        private Button button2;
        private DataGridView dgv;
        private Label label7;
        private TextBox txbclave;
        private Label labelprueba;
    }
}