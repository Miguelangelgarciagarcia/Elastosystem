namespace ElastoSystem
{
    partial class Compras_RequisicionesEnviadas
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
            label1 = new Label();
            panel5 = new Panel();
            lblFolio = new Label();
            dgvRequisicions = new DataGridView();
            cbUsuarios = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            txbTipoUso = new TextBox();
            label4 = new Label();
            txbNotas = new TextBox();
            panel2 = new Panel();
            label5 = new Label();
            dgvPartidas = new DataGridView();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRequisicions).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPartidas).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Montserrat", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(25, 33);
            label1.Name = "label1";
            label1.Size = new Size(469, 44);
            label1.TabIndex = 2;
            label1.Text = "REQUISICIONES ENVIADAS";
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(3, 42, 76);
            panel5.Controls.Add(lblFolio);
            panel5.Controls.Add(dgvRequisicions);
            panel5.Controls.Add(cbUsuarios);
            panel5.Controls.Add(label3);
            panel5.Location = new Point(25, 104);
            panel5.Name = "panel5";
            panel5.Size = new Size(834, 347);
            panel5.TabIndex = 21;
            // 
            // lblFolio
            // 
            lblFolio.AutoSize = true;
            lblFolio.BackColor = Color.Transparent;
            lblFolio.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblFolio.ForeColor = Color.White;
            lblFolio.Location = new Point(702, 28);
            lblFolio.Name = "lblFolio";
            lblFolio.Size = new Size(48, 22);
            lblFolio.TabIndex = 22;
            lblFolio.Text = "Folio";
            lblFolio.Visible = false;
            // 
            // dgvRequisicions
            // 
            dgvRequisicions.AllowUserToAddRows = false;
            dgvRequisicions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRequisicions.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Montserrat SemiBold", 9.749999F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(255, 102, 0);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvRequisicions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvRequisicions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRequisicions.Location = new Point(36, 74);
            dgvRequisicions.Name = "dgvRequisicions";
            dgvRequisicions.RowHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(255, 102, 0);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dgvRequisicions.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvRequisicions.RowTemplate.Height = 25;
            dgvRequisicions.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRequisicions.Size = new Size(765, 249);
            dgvRequisicions.TabIndex = 21;
            dgvRequisicions.SelectionChanged += dgvRequisicions_SelectionChanged;
            dgvRequisicions.Click += dgvRequisicions_Click;
            dgvRequisicions.DoubleClick += dgvRequisicions_DoubleClick;
            // 
            // cbUsuarios
            // 
            cbUsuarios.DropDownStyle = ComboBoxStyle.DropDownList;
            cbUsuarios.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbUsuarios.FormattingEnabled = true;
            cbUsuarios.Items.AddRange(new object[] { "TODOS" });
            cbUsuarios.Location = new Point(182, 20);
            cbUsuarios.Name = "cbUsuarios";
            cbUsuarios.Size = new Size(326, 30);
            cbUsuarios.TabIndex = 12;
            cbUsuarios.SelectedIndexChanged += cbUsuarios_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(36, 23);
            label3.Name = "label3";
            label3.Size = new Size(128, 22);
            label3.TabIndex = 3;
            label3.Text = "REQUISIONES";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(21, 28);
            label2.Name = "label2";
            label2.Size = new Size(256, 22);
            label2.TabIndex = 5;
            label2.Text = "Proyecto / Notas / Comentarios";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(3, 42, 76);
            panel1.Controls.Add(txbTipoUso);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txbNotas);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(891, 104);
            panel1.Name = "panel1";
            panel1.Size = new Size(402, 347);
            panel1.TabIndex = 22;
            // 
            // txbTipoUso
            // 
            txbTipoUso.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txbTipoUso.Location = new Point(21, 244);
            txbTipoUso.Multiline = true;
            txbTipoUso.Name = "txbTipoUso";
            txbTipoUso.ReadOnly = true;
            txbTipoUso.Size = new Size(353, 30);
            txbTipoUso.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(21, 219);
            label4.Name = "label4";
            label4.Size = new Size(104, 22);
            label4.TabIndex = 14;
            label4.Text = "Tipo de Uso";
            // 
            // txbNotas
            // 
            txbNotas.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txbNotas.Location = new Point(21, 62);
            txbNotas.Multiline = true;
            txbNotas.Name = "txbNotas";
            txbNotas.ReadOnly = true;
            txbNotas.Size = new Size(353, 131);
            txbNotas.TabIndex = 13;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(3, 42, 76);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(dgvPartidas);
            panel2.Location = new Point(25, 472);
            panel2.Name = "panel2";
            panel2.Size = new Size(1268, 282);
            panel2.TabIndex = 23;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(597, 22);
            label5.Name = "label5";
            label5.Size = new Size(74, 22);
            label5.TabIndex = 21;
            label5.Text = "Partidas";
            // 
            // dgvPartidas
            // 
            dgvPartidas.AllowUserToAddRows = false;
            dgvPartidas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPartidas.BackgroundColor = Color.White;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Montserrat SemiBold", 9.749999F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(255, 102, 0);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvPartidas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvPartidas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPartidas.Enabled = false;
            dgvPartidas.Location = new Point(36, 56);
            dgvPartidas.Name = "dgvPartidas";
            dgvPartidas.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(255, 102, 0);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dgvPartidas.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvPartidas.RowTemplate.Height = 25;
            dgvPartidas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPartidas.Size = new Size(1204, 197);
            dgvPartidas.TabIndex = 20;
            dgvPartidas.Click += dgvPartidas_Click;
            // 
            // Compras_RequisicionesEnviadas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fondocontrolalmacen;
            ClientSize = new Size(1338, 831);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel5);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Compras_RequisicionesEnviadas";
            Text = "Compras_RequisicionesEnviadas";
            Load += Compras_RequisicionesEnviadas_Load;
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRequisicions).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPartidas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel5;
        private Label label3;
        private Label label2;
        private ComboBox cbUsuarios;
        private Panel panel1;
        private TextBox txbNotas;
        private Label label4;
        private Panel panel2;
        private Label label5;
        private DataGridView dgvPartidas;
        private DataGridView dgvRequisicions;
        private TextBox txbTipoUso;
        private Label lblFolio;
    }
}