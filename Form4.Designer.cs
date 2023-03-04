namespace Login
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            listContactos = new ListBox();
            btnGuardar = new Button();
            btnActualizar = new Button();
            btnSalir = new Button();
            btnEliminar = new Button();
            label5 = new Label();
            panel1 = new Panel();
            panel4 = new Panel();
            panel3 = new Panel();
            panel2 = new Panel();
            panel14 = new Panel();
            textCorreo = new TextBox();
            textTelefono = new TextBox();
            textCiudad = new TextBox();
            textNombre = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label6 = new Label();
            btnAtras = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // listContactos
            // 
            listContactos.BackColor = SystemColors.WindowFrame;
            listContactos.ForeColor = SystemColors.Window;
            listContactos.FormattingEnabled = true;
            listContactos.ItemHeight = 20;
            listContactos.Location = new Point(365, 39);
            listContactos.Margin = new Padding(4);
            listContactos.Name = "listContactos";
            listContactos.Size = new Size(347, 424);
            listContactos.TabIndex = 4;
            listContactos.SelectedIndexChanged += listContactos_SelectedIndexChanged;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.Black;
            btnGuardar.FlatAppearance.BorderColor = Color.Lime;
            btnGuardar.FlatAppearance.BorderSize = 2;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnGuardar.ForeColor = Color.Lime;
            btnGuardar.Location = new Point(27, 389);
            btnGuardar.Margin = new Padding(4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(85, 30);
            btnGuardar.TabIndex = 9;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.Black;
            btnActualizar.FlatAppearance.BorderColor = Color.Lime;
            btnActualizar.FlatAppearance.BorderSize = 2;
            btnActualizar.FlatStyle = FlatStyle.Flat;
            btnActualizar.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnActualizar.ForeColor = Color.Lime;
            btnActualizar.Location = new Point(27, 443);
            btnActualizar.Margin = new Padding(4);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(85, 30);
            btnActualizar.TabIndex = 10;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.Black;
            btnSalir.FlatAppearance.BorderColor = Color.Lime;
            btnSalir.FlatAppearance.BorderSize = 2;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSalir.ForeColor = Color.Lime;
            btnSalir.Location = new Point(180, 440);
            btnSalir.Margin = new Padding(4);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(85, 30);
            btnSalir.TabIndex = 12;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Black;
            btnEliminar.FlatAppearance.BorderColor = Color.Lime;
            btnEliminar.FlatAppearance.BorderSize = 2;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnEliminar.ForeColor = Color.Lime;
            btnEliminar.Location = new Point(180, 389);
            btnEliminar.Margin = new Padding(4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(85, 30);
            btnEliminar.TabIndex = 13;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            //btnEliminar.Click += btnEliminar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Britannic Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(94, 9);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(171, 27);
            label5.TabIndex = 14;
            label5.Text = "Crear contacto";
            // 
            // panel1
            // 
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(panel14);
            panel1.Controls.Add(textCorreo);
            panel1.Controls.Add(textTelefono);
            panel1.Controls.Add(textCiudad);
            panel1.Controls.Add(textNombre);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 140);
            panel1.Name = "panel1";
            panel1.Size = new Size(313, 242);
            panel1.TabIndex = 15;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.Window;
            panel4.Location = new Point(89, 215);
            panel4.Name = "panel4";
            panel4.Size = new Size(392, 1);
            panel4.TabIndex = 21;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.Window;
            panel3.Location = new Point(89, 157);
            panel3.Name = "panel3";
            panel3.Size = new Size(392, 1);
            panel3.TabIndex = 20;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Window;
            panel2.Location = new Point(89, 97);
            panel2.Name = "panel2";
            panel2.Size = new Size(392, 1);
            panel2.TabIndex = 19;
            // 
            // panel14
            // 
            panel14.BackColor = SystemColors.Window;
            panel14.Location = new Point(90, 43);
            panel14.Name = "panel14";
            panel14.Size = new Size(392, 1);
            panel14.TabIndex = 18;
            // 
            // textCorreo
            // 
            textCorreo.BackColor = Color.Black;
            textCorreo.BorderStyle = BorderStyle.None;
            textCorreo.ForeColor = Color.White;
            textCorreo.Location = new Point(91, 191);
            textCorreo.Margin = new Padding(4);
            textCorreo.Name = "textCorreo";
            textCorreo.Size = new Size(210, 20);
            textCorreo.TabIndex = 16;
            // 
            // textTelefono
            // 
            textTelefono.BackColor = Color.Black;
            textTelefono.BorderStyle = BorderStyle.None;
            textTelefono.ForeColor = Color.White;
            textTelefono.Location = new Point(91, 133);
            textTelefono.Margin = new Padding(4);
            textTelefono.Name = "textTelefono";
            textTelefono.Size = new Size(210, 20);
            textTelefono.TabIndex = 15;
            // 
            // textCiudad
            // 
            textCiudad.BackColor = Color.Black;
            textCiudad.BorderStyle = BorderStyle.None;
            textCiudad.ForeColor = Color.White;
            textCiudad.Location = new Point(91, 74);
            textCiudad.Margin = new Padding(4);
            textCiudad.Name = "textCiudad";
            textCiudad.Size = new Size(210, 20);
            textCiudad.TabIndex = 14;
            // 
            // textNombre
            // 
            textNombre.BackColor = Color.Black;
            textNombre.BorderStyle = BorderStyle.None;
            textNombre.ForeColor = Color.White;
            textNombre.Location = new Point(91, 20);
            textNombre.Margin = new Padding(4);
            textNombre.Name = "textNombre";
            textNombre.Size = new Size(210, 20);
            textNombre.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(15, 188);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(57, 20);
            label4.TabIndex = 12;
            label4.Text = "Correo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(15, 131);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 11;
            label3.Text = "Telefono:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(15, 72);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(59, 20);
            label2.TabIndex = 10;
            label2.Text = "Ciudad:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(15, 18);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 9;
            label1.Text = "Nombre:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(106, 39);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(131, 95);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Britannic Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(440, 8);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(208, 27);
            label6.TabIndex = 17;
            label6.Text = "Lista de Contactos";
            // 
            // btnAtras
            // 
            btnAtras.BackColor = Color.Black;
            btnAtras.BackgroundImage = (Image)resources.GetObject("btnAtras.BackgroundImage");
            btnAtras.BackgroundImageLayout = ImageLayout.Stretch;
            btnAtras.FlatAppearance.BorderSize = 0;
            btnAtras.FlatStyle = FlatStyle.Popup;
            btnAtras.Location = new Point(0, -3);
            btnAtras.Margin = new Padding(1);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(55, 39);
            btnAtras.TabIndex = 18;
            btnAtras.UseVisualStyleBackColor = false;
            btnAtras.Click += btnAtras_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(725, 478);
            Controls.Add(btnAtras);
            Controls.Add(label6);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(label5);
            Controls.Add(btnEliminar);
            Controls.Add(btnSalir);
            Controls.Add(btnActualizar);
            Controls.Add(btnGuardar);
            Controls.Add(listContactos);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Form4";
            Text = "Contactos";
            Load += Form4_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListBox listContactos;
        private Button btnGuardar;
        private Button btnActualizar;
        private Button btnSalir;
        private Button btnEliminar;
        private Label label5;
        private Panel panel1;
        private TextBox textCorreo;
        private TextBox textTelefono;
        private TextBox textCiudad;
        private TextBox textNombre;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label6;
        private Panel panel4;
        private Panel panel3;
        private Panel panel2;
        private Panel panel14;
        private Button btnAtras;
    }
}