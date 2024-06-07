namespace ElastoSystem
{
    partial class Control_Almacen
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
            tbnotrabajador = new TextBox();
            label2 = new Label();
            label3 = new Label();
            tbnombre = new TextBox();
            tbapellido = new TextBox();
            button1 = new Button();
            button2 = new Button();
            label4 = new Label();
            tbidproducto = new TextBox();
            button3 = new Button();
            label5 = new Label();
            tbproducto = new TextBox();
            label6 = new Label();
            tbcantidad = new TextBox();
            label7 = new Label();
            tbnota = new TextBox();
            btnaceptar = new Button();
            dgv = new DataGridView();
            cbproducto = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 33);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 0;
            label1.Text = "No. Trabajador";
            // 
            // tbnotrabajador
            // 
            tbnotrabajador.Location = new Point(29, 59);
            tbnotrabajador.Name = "tbnotrabajador";
            tbnotrabajador.Size = new Size(81, 23);
            tbnotrabajador.TabIndex = 1;
            tbnotrabajador.KeyPress += tbnotrabajador_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(178, 33);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 2;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(334, 33);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 3;
            label3.Text = "Apellido";
            // 
            // tbnombre
            // 
            tbnombre.Location = new Point(178, 59);
            tbnombre.Name = "tbnombre";
            tbnombre.Size = new Size(125, 23);
            tbnombre.TabIndex = 4;
            // 
            // tbapellido
            // 
            tbapellido.Location = new Point(334, 59);
            tbapellido.Name = "tbapellido";
            tbapellido.Size = new Size(125, 23);
            tbapellido.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(116, 59);
            button1.Name = "button1";
            button1.Size = new Size(50, 26);
            button1.TabIndex = 6;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(1246, 33);
            button2.Name = "button2";
            button2.Size = new Size(136, 47);
            button2.TabIndex = 7;
            button2.Text = "Regresar al Menu";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(227, 102);
            label4.Name = "label4";
            label4.Size = new Size(70, 15);
            label4.TabIndex = 8;
            label4.Text = "ID Producto";
            // 
            // tbidproducto
            // 
            tbidproducto.Location = new Point(224, 124);
            tbidproducto.Name = "tbidproducto";
            tbidproducto.Size = new Size(84, 23);
            tbidproducto.TabIndex = 9;
            // 
            // button3
            // 
            button3.Location = new Point(161, 121);
            button3.Name = "button3";
            button3.Size = new Size(50, 26);
            button3.TabIndex = 10;
            button3.Text = "Buscar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(29, 102);
            label5.Name = "label5";
            label5.Size = new Size(56, 15);
            label5.TabIndex = 11;
            label5.Text = "Producto";
            // 
            // tbproducto
            // 
            tbproducto.Location = new Point(26, 124);
            tbproducto.Name = "tbproducto";
            tbproducto.Size = new Size(125, 23);
            tbproducto.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(330, 102);
            label6.Name = "label6";
            label6.Size = new Size(55, 15);
            label6.TabIndex = 13;
            label6.Text = "Cantidad";
            // 
            // tbcantidad
            // 
            tbcantidad.Location = new Point(334, 124);
            tbcantidad.Name = "tbcantidad";
            tbcantidad.Size = new Size(63, 23);
            tbcantidad.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(438, 102);
            label7.Name = "label7";
            label7.Size = new Size(33, 15);
            label7.TabIndex = 15;
            label7.Text = "Nota";
            label7.Click += label7_Click;
            // 
            // tbnota
            // 
            tbnota.Location = new Point(438, 124);
            tbnota.Name = "tbnota";
            tbnota.Size = new Size(633, 23);
            tbnota.TabIndex = 16;
            // 
            // btnaceptar
            // 
            btnaceptar.Location = new Point(1246, 108);
            btnaceptar.Name = "btnaceptar";
            btnaceptar.Size = new Size(136, 42);
            btnaceptar.TabIndex = 17;
            btnaceptar.Text = "ACEPTAR";
            btnaceptar.UseVisualStyleBackColor = true;
            btnaceptar.Click += btnaceptar_Click;
            // 
            // dgv
            // 
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.BorderStyle = BorderStyle.None;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Location = new Point(26, 182);
            dgv.Name = "dgv";
            dgv.RowTemplate.Height = 25;
            dgv.Size = new Size(1404, 612);
            dgv.TabIndex = 18;
            // 
            // cbproducto
            // 
            cbproducto.FormattingEnabled = true;
            cbproducto.Location = new Point(544, 59);
            cbproducto.Name = "cbproducto";
            cbproducto.Size = new Size(200, 23);
            cbproducto.TabIndex = 19;
            cbproducto.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // Control_Almacen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1456, 806);
            Controls.Add(cbproducto);
            Controls.Add(dgv);
            Controls.Add(btnaceptar);
            Controls.Add(tbnota);
            Controls.Add(label7);
            Controls.Add(tbcantidad);
            Controls.Add(label6);
            Controls.Add(tbproducto);
            Controls.Add(label5);
            Controls.Add(button3);
            Controls.Add(tbidproducto);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(tbapellido);
            Controls.Add(tbnombre);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(tbnotrabajador);
            Controls.Add(label1);
            Name = "Control_Almacen";
            Text = "Control_Almacen";
            Load += Control_Almacen_Load;
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbnotrabajador;
        private Label label2;
        private Label label3;
        private TextBox tbnombre;
        private TextBox tbapellido;
        private Button button1;
        private Button button2;
        private Label label4;
        private TextBox tbidproducto;
        private Button button3;
        private Label label5;
        private TextBox tbproducto;
        private Label label6;
        private TextBox tbcantidad;
        private Label label7;
        private TextBox tbnota;
        private Button btnaceptar;
        private DataGridView dgv;
        private ComboBox cbproducto;
    }
}