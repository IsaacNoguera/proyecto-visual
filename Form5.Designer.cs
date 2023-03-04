namespace Login
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            panel1 = new Panel();
            btnAtras = new Button();
            buttonX = new Button();
            label1 = new Label();
            panel2 = new Panel();
            btnEliminar = new Button();
            btnBorrar = new Button();
            btnConfirmar = new Button();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            panel4 = new Panel();
            panel14 = new Panel();
            textNombre = new TextBox();
            textCodigo = new TextBox();
            label3 = new Label();
            label2 = new Label();
            groupBox2 = new GroupBox();
            listPago = new ListBox();
            label11 = new Label();
            listDias = new ListBox();
            label10 = new Label();
            listLibro = new ListBox();
            label9 = new Label();
            listEstudiante = new ListBox();
            label8 = new Label();
            groupBox1 = new GroupBox();
            btnAgregar = new Button();
            dtpFin = new DateTimePicker();
            label7 = new Label();
            dtpInicio = new DateTimePicker();
            label6 = new Label();
            cbxLibro = new ComboBox();
            label5 = new Label();
            cbxGenero = new ComboBox();
            label4 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkGreen;
            panel1.Controls.Add(btnAtras);
            panel1.Controls.Add(buttonX);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(685, 31);
            panel1.TabIndex = 0;
            // 
            // btnAtras
            // 
            btnAtras.BackColor = Color.Transparent;
            btnAtras.BackgroundImage = (Image)resources.GetObject("btnAtras.BackgroundImage");
            btnAtras.BackgroundImageLayout = ImageLayout.Stretch;
            btnAtras.Dock = DockStyle.Left;
            btnAtras.FlatAppearance.BorderSize = 0;
            btnAtras.FlatStyle = FlatStyle.Popup;
            btnAtras.Location = new Point(0, 0);
            btnAtras.Margin = new Padding(1);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(44, 31);
            btnAtras.TabIndex = 36;
            btnAtras.UseVisualStyleBackColor = false;
            btnAtras.Click += btnAtras_Click;
            // 
            // buttonX
            // 
            buttonX.BackgroundImage = (Image)resources.GetObject("buttonX.BackgroundImage");
            buttonX.BackgroundImageLayout = ImageLayout.Zoom;
            buttonX.Dock = DockStyle.Right;
            buttonX.FlatAppearance.BorderSize = 0;
            buttonX.FlatAppearance.MouseOverBackColor = Color.Red;
            buttonX.FlatStyle = FlatStyle.Flat;
            buttonX.Location = new Point(654, 0);
            buttonX.Name = "buttonX";
            buttonX.Size = new Size(31, 31);
            buttonX.TabIndex = 1;
            buttonX.UseVisualStyleBackColor = false;
            buttonX.Click += buttonX_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(197, 1);
            label1.Name = "label1";
            label1.Size = new Size(285, 28);
            label1.TabIndex = 0;
            label1.Text = "PRESTAMOS DE LIBRO";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Controls.Add(btnEliminar);
            panel2.Controls.Add(btnBorrar);
            panel2.Controls.Add(btnConfirmar);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(groupBox2);
            panel2.Controls.Add(groupBox1);
            panel2.Dock = DockStyle.Fill;
            panel2.ForeColor = Color.White;
            panel2.Location = new Point(0, 31);
            panel2.Name = "panel2";
            panel2.Size = new Size(685, 551);
            panel2.TabIndex = 1;
            // 
            // btnEliminar
            // 
            btnEliminar.FlatAppearance.BorderColor = Color.Lime;
            btnEliminar.FlatAppearance.BorderSize = 2;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.ForeColor = Color.Lime;
            btnEliminar.Location = new Point(580, 392);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(93, 28);
            btnEliminar.TabIndex = 35;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.FlatAppearance.BorderColor = Color.Lime;
            btnBorrar.FlatAppearance.BorderSize = 2;
            btnBorrar.FlatStyle = FlatStyle.Flat;
            btnBorrar.ForeColor = Color.Lime;
            btnBorrar.Location = new Point(580, 449);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(93, 28);
            btnBorrar.TabIndex = 34;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // btnConfirmar
            // 
            btnConfirmar.FlatAppearance.BorderColor = Color.Lime;
            btnConfirmar.FlatAppearance.BorderSize = 2;
            btnConfirmar.FlatStyle = FlatStyle.Flat;
            btnConfirmar.ForeColor = Color.Lime;
            btnConfirmar.Location = new Point(70, 113);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(149, 28);
            btnConfirmar.TabIndex = 33;
            btnConfirmar.Text = "Buscar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(359, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(314, 146);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(panel14);
            panel3.Controls.Add(textNombre);
            panel3.Controls.Add(textCodigo);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(12, 17);
            panel3.Name = "panel3";
            panel3.Size = new Size(328, 87);
            panel3.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.Window;
            panel4.Location = new Point(60, 71);
            panel4.Name = "panel4";
            panel4.Size = new Size(392, 1);
            panel4.TabIndex = 19;
            // 
            // panel14
            // 
            panel14.BackColor = SystemColors.Window;
            panel14.Location = new Point(62, 34);
            panel14.Name = "panel14";
            panel14.Size = new Size(392, 1);
            panel14.TabIndex = 18;
            // 
            // textNombre
            // 
            textNombre.BackColor = Color.Black;
            textNombre.BorderStyle = BorderStyle.None;
            textNombre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textNombre.ForeColor = Color.White;
            textNombre.Location = new Point(58, 49);
            textNombre.Name = "textNombre";
            textNombre.Size = new Size(257, 22);
            textNombre.TabIndex = 9;
            // 
            // textCodigo
            // 
            textCodigo.BackColor = Color.Black;
            textCodigo.BorderStyle = BorderStyle.None;
            textCodigo.CharacterCasing = CharacterCasing.Upper;
            textCodigo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textCodigo.ForeColor = Color.White;
            textCodigo.Location = new Point(58, 12);
            textCodigo.Name = "textCodigo";
            textCodigo.Size = new Size(257, 22);
            textCodigo.TabIndex = 8;
            textCodigo.TextChanged += textCodigo_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 53);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 7;
            label3.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 15);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 6;
            label2.Text = "Codigo:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(listPago);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(listDias);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(listLibro);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(listEstudiante);
            groupBox2.Controls.Add(label8);
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(13, 320);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(561, 208);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "REGISTRO";
            // 
            // listPago
            // 
            listPago.BackColor = Color.Gray;
            listPago.ForeColor = Color.Black;
            listPago.FormattingEnabled = true;
            listPago.ItemHeight = 15;
            listPago.Location = new Point(490, 36);
            listPago.Name = "listPago";
            listPago.Size = new Size(64, 154);
            listPago.TabIndex = 7;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(490, 18);
            label11.Name = "label11";
            label11.Size = new Size(34, 15);
            label11.TabIndex = 6;
            label11.Text = "Pago";
            // 
            // listDias
            // 
            listDias.BackColor = Color.Gray;
            listDias.ForeColor = Color.Black;
            listDias.FormattingEnabled = true;
            listDias.ItemHeight = 15;
            listDias.Location = new Point(420, 37);
            listDias.Name = "listDias";
            listDias.Size = new Size(64, 154);
            listDias.TabIndex = 5;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(420, 19);
            label10.Name = "label10";
            label10.Size = new Size(44, 15);
            label10.TabIndex = 4;
            label10.Text = "N. Dias";
            // 
            // listLibro
            // 
            listLibro.BackColor = Color.Gray;
            listLibro.ForeColor = Color.Black;
            listLibro.FormattingEnabled = true;
            listLibro.ItemHeight = 15;
            listLibro.Location = new Point(148, 36);
            listLibro.Name = "listLibro";
            listLibro.Size = new Size(266, 154);
            listLibro.TabIndex = 3;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(148, 18);
            label9.Name = "label9";
            label9.Size = new Size(34, 15);
            label9.TabIndex = 2;
            label9.Text = "Libro";
            // 
            // listEstudiante
            // 
            listEstudiante.BackColor = Color.Gray;
            listEstudiante.ForeColor = Color.Black;
            listEstudiante.FormattingEnabled = true;
            listEstudiante.ItemHeight = 15;
            listEstudiante.Location = new Point(6, 36);
            listEstudiante.Name = "listEstudiante";
            listEstudiante.Size = new Size(135, 154);
            listEstudiante.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 18);
            label8.Name = "label8";
            label8.Size = new Size(62, 15);
            label8.TabIndex = 0;
            label8.Text = "Estudiante";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnAgregar);
            groupBox1.Controls.Add(dtpFin);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(dtpInicio);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(cbxLibro);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(cbxGenero);
            groupBox1.Controls.Add(label4);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(12, 158);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(667, 156);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos Del Libro.";
            // 
            // btnAgregar
            // 
            btnAgregar.FlatAppearance.BorderColor = Color.Lime;
            btnAgregar.FlatAppearance.BorderSize = 2;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.ForeColor = Color.Lime;
            btnAgregar.Location = new Point(257, 114);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(135, 28);
            btnAgregar.TabIndex = 36;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // dtpFin
            // 
            dtpFin.CalendarForeColor = Color.Black;
            dtpFin.Format = DateTimePickerFormat.Short;
            dtpFin.Location = new Point(456, 78);
            dtpFin.Name = "dtpFin";
            dtpFin.Size = new Size(200, 23);
            dtpFin.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(344, 84);
            label7.Name = "label7";
            label7.Size = new Size(110, 15);
            label7.TabIndex = 6;
            label7.Text = "Fecha de Prestamo ";
            // 
            // dtpInicio
            // 
            dtpInicio.CalendarForeColor = Color.Black;
            dtpInicio.Format = DateTimePickerFormat.Short;
            dtpInicio.ImeMode = ImeMode.NoControl;
            dtpInicio.Location = new Point(115, 78);
            dtpInicio.Name = "dtpInicio";
            dtpInicio.Size = new Size(200, 23);
            dtpInicio.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 84);
            label6.Name = "label6";
            label6.Size = new Size(110, 15);
            label6.TabIndex = 4;
            label6.Text = "Fecha de Prestamo ";
            // 
            // cbxLibro
            // 
            cbxLibro.BackColor = Color.Black;
            cbxLibro.FlatStyle = FlatStyle.Flat;
            cbxLibro.ForeColor = SystemColors.Window;
            cbxLibro.FormattingEnabled = true;
            cbxLibro.Location = new Point(391, 32);
            cbxLibro.Name = "cbxLibro";
            cbxLibro.Size = new Size(264, 23);
            cbxLibro.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(337, 35);
            label5.Name = "label5";
            label5.Size = new Size(37, 15);
            label5.TabIndex = 2;
            label5.Text = "Libro:";
            // 
            // cbxGenero
            // 
            cbxGenero.BackColor = Color.Black;
            cbxGenero.FlatStyle = FlatStyle.Flat;
            cbxGenero.ForeColor = SystemColors.Window;
            cbxGenero.FormattingEnabled = true;
            cbxGenero.Items.AddRange(new object[] { "Seleccione", "Fantasia", "Terror", "Aventura" });
            cbxGenero.Location = new Point(68, 32);
            cbxGenero.Name = "cbxGenero";
            cbxGenero.Size = new Size(160, 23);
            cbxGenero.TabIndex = 1;
            cbxGenero.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(4, 35);
            label4.Name = "label4";
            label4.Size = new Size(48, 15);
            label4.TabIndex = 0;
            label4.Text = "Género:";
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(685, 582);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form5";
            Text = "Form5";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button buttonX;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Panel panel3;
        private TextBox textNombre;
        private TextBox textCodigo;
        private Label label3;
        private Label label2;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private Panel panel4;
        private Panel panel14;
        private Button btnEliminar;
        private Button btnBorrar;
        private Button btnConfirmar;
        private Button btnAgregar;
        private DateTimePicker dtpFin;
        private Label label7;
        private DateTimePicker dtpInicio;
        private Label label6;
        private ComboBox cbxLibro;
        private Label label5;
        private ComboBox cbxGenero;
        private Label label4;
        private ListBox listPago;
        private Label label11;
        private ListBox listDias;
        private Label label10;
        private ListBox listLibro;
        private Label label9;
        private ListBox listEstudiante;
        private Label label8;
        private Button btnAtras;
    }
}