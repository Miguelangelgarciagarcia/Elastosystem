namespace ElastoSystem
{
    partial class RFormAlmacen
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            tbid = new TextBox();
            tbproducto = new TextBox();
            tbdescripcion = new TextBox();
            tbminimo = new TextBox();
            button2 = new Button();
            btnactualizar = new Button();
            Unidad = new Label();
            cbunidad = new ComboBox();
            dgvbd = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvbd).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Montserrat", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(38, 561);
            label1.Name = "label1";
            label1.Size = new Size(134, 26);
            label1.TabIndex = 0;
            label1.Text = "ID_Producto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Montserrat", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(38, 610);
            label2.Name = "label2";
            label2.Size = new Size(103, 26);
            label2.TabIndex = 1;
            label2.Text = "Producto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Montserrat", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(38, 664);
            label3.Name = "label3";
            label3.Size = new Size(126, 26);
            label3.TabIndex = 2;
            label3.Text = "Descripción";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Montserrat", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(743, 561);
            label4.Name = "label4";
            label4.Size = new Size(144, 26);
            label4.TabIndex = 3;
            label4.Text = "Stock Minimo";
            // 
            // tbid
            // 
            tbid.Font = new Font("Montserrat", 14F, FontStyle.Regular, GraphicsUnit.Point);
            tbid.Location = new Point(215, 558);
            tbid.Name = "tbid";
            tbid.Size = new Size(389, 30);
            tbid.TabIndex = 6;
            tbid.TextChanged += tbid_TextChanged;
            tbid.KeyPress += tbid_KeyPress;
            // 
            // tbproducto
            // 
            tbproducto.Font = new Font("Montserrat", 14F, FontStyle.Regular, GraphicsUnit.Point);
            tbproducto.Location = new Point(215, 607);
            tbproducto.Name = "tbproducto";
            tbproducto.ReadOnly = true;
            tbproducto.Size = new Size(389, 30);
            tbproducto.TabIndex = 7;
            // 
            // tbdescripcion
            // 
            tbdescripcion.Font = new Font("Montserrat", 14F, FontStyle.Regular, GraphicsUnit.Point);
            tbdescripcion.Location = new Point(215, 660);
            tbdescripcion.Name = "tbdescripcion";
            tbdescripcion.Size = new Size(389, 30);
            tbdescripcion.TabIndex = 8;
            // 
            // tbminimo
            // 
            tbminimo.Font = new Font("Montserrat", 14F, FontStyle.Regular, GraphicsUnit.Point);
            tbminimo.Location = new Point(911, 558);
            tbminimo.Name = "tbminimo";
            tbminimo.Size = new Size(389, 30);
            tbminimo.TabIndex = 9;
            tbminimo.TextChanged += tbexistencias_TextChanged;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 102, 0);
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Montserrat", 13F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(623, 553);
            button2.Name = "button2";
            button2.Size = new Size(99, 42);
            button2.TabIndex = 10;
            button2.Text = "Buscar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // btnactualizar
            // 
            btnactualizar.BackColor = Color.FromArgb(255, 102, 0);
            btnactualizar.Cursor = Cursors.Hand;
            btnactualizar.FlatAppearance.BorderSize = 0;
            btnactualizar.FlatStyle = FlatStyle.Flat;
            btnactualizar.Font = new Font("Montserrat", 13F, FontStyle.Bold, GraphicsUnit.Point);
            btnactualizar.ForeColor = Color.White;
            btnactualizar.Location = new Point(862, 683);
            btnactualizar.Name = "btnactualizar";
            btnactualizar.Size = new Size(222, 43);
            btnactualizar.TabIndex = 11;
            btnactualizar.Text = "Actualizar Producto";
            btnactualizar.UseVisualStyleBackColor = false;
            btnactualizar.Click += button3_Click;
            // 
            // Unidad
            // 
            Unidad.AutoSize = true;
            Unidad.BackColor = Color.Transparent;
            Unidad.Font = new Font("Montserrat", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Unidad.ForeColor = Color.White;
            Unidad.Location = new Point(743, 610);
            Unidad.Name = "Unidad";
            Unidad.Size = new Size(82, 26);
            Unidad.TabIndex = 12;
            Unidad.Text = "Unidad";
            // 
            // cbunidad
            // 
            cbunidad.Font = new Font("Montserrat", 14F, FontStyle.Regular, GraphicsUnit.Point);
            cbunidad.FormattingEnabled = true;
            cbunidad.Items.AddRange(new object[] { "Kilogramos", "Litros", "Metros", "Pares", "Piezas" });
            cbunidad.Location = new Point(911, 607);
            cbunidad.Name = "cbunidad";
            cbunidad.Size = new Size(389, 34);
            cbunidad.TabIndex = 13;
            // 
            // dgvbd
            // 
            dgvbd.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvbd.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvbd.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvbd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvbd.Location = new Point(12, 12);
            dgvbd.Name = "dgvbd";
            dgvbd.ReadOnly = true;
            dgvbd.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvbd.RowHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Montserrat", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(255, 102, 0);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dgvbd.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvbd.RowTemplate.Height = 25;
            dgvbd.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvbd.Size = new Size(1298, 525);
            dgvbd.TabIndex = 14;
            dgvbd.CellContentClick += dgvbd_CellContentClick;
            dgvbd.CellContentDoubleClick += dgvbd_CellContentDoubleClick;
            dgvbd.SelectionChanged += dgvbd_SelectionChanged;
            // 
            // RFormAlmacen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fondocontrolalmacen;
            ClientSize = new Size(1322, 792);
            Controls.Add(dgvbd);
            Controls.Add(cbunidad);
            Controls.Add(Unidad);
            Controls.Add(btnactualizar);
            Controls.Add(button2);
            Controls.Add(tbminimo);
            Controls.Add(tbdescripcion);
            Controls.Add(tbproducto);
            Controls.Add(tbid);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RFormAlmacen";
            Text = "RFormAlmacen";
            Load += RFormAlmacen_Load;
            ((System.ComponentModel.ISupportInitialize)dgvbd).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox tbid;
        private TextBox tbproducto;
        private TextBox tbdescripcion;
        private Button button2;
        private Button btnactualizar;
        private Label Unidad;
        private ComboBox cbunidad;
        private DataGridView dgvbd;
        public TextBox tbminimo;
    }
}