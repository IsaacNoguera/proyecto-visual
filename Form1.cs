namespace Login
{
    public partial class Form1 : Form
    {
        int contador = 1;
        int pw;
        //bool hided;

        public Form1()
        {
            InitializeComponent();
            pw = panel5.Width;
            //hided = false;
        }

        private void textUsuario_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textUsuario.Text == "")
                {
                    textUsuario.Text = "Enter username";
                    return;
                }
                textUsuario.ForeColor = Color.White;
                panel5.Visible = false;
            }
            catch { }
        }

        private void textClave_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textClave.Text == "")
                {
                    return;
                }
                textClave.ForeColor = Color.White;
                textClave.PasswordChar = '*';
                panel7.Visible = false;
            }
            catch { }
        }

        private void textUsuario_Click(object sender, EventArgs e)
        {
            textUsuario.SelectAll();
        }

        private void textClave_Click(object sender, EventArgs e)
        {
            textClave.SelectAll();
        }

        private void btnAceptar_MouseEnter(object sender, EventArgs e)
        {
            btnAceptar.ForeColor = Color.Black;
        }

        private void btnAceptar_MouseLeave(object sender, EventArgs e)
        {
            btnAceptar.ForeColor = Color.White;
        }

        private void btnSalir_MouseEnter(object sender, EventArgs e)
        {
            btnSalir.ForeColor = Color.Black;
        }

        private void btnSalir_MouseLeave(object sender, EventArgs e)
        {
            btnSalir.ForeColor = Color.White;
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string usuario = textUsuario.Text;
            string clave = textClave.Text;

            if (textUsuario.Text == "Enter Username")
            {
                panel5.Visible = true;
                textUsuario.Focus();
                return;
            }

            if (textClave.Text == "Password")
            {
                panel7.Visible = true;
                textClave.Focus();
                return;
            }

            if (usuario == "isaac" && clave == "1234")
            {
                this.Hide();
                FrmPrincipal fr = new FrmPrincipal();
                fr.Show();
            }
            else
            {
                if (contador > 3)
                {
                    MessageBox.Show("Numero de intentos excedidos");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Usuario ingresado no existe");
                    textUsuario.Text = "";
                    textClave.Text = "";
                    textUsuario.Focus();
                }
                contador++;
            }
        }

        private void buttonX_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnConfirmar_MouseLeave(object sender, EventArgs e)
        {
            btnConfirmar.ForeColor = Color.Lime;
        }
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Enter Username")
            {
                pnlUsername.Visible = true;
                textBox1.Focus();
                textBox1.SelectAll();
                return;
            }

            if (textBox2.Text == "Enter Contact")
            {
                pnlContacto.Visible = true;
                textBox2.Focus();
                textBox2.SelectAll();
                return;
            }

            if (textBox4.Text == "Enter Password")
            {
                pnlContraseña.Visible = true;
                textBox4.Focus();
                textBox4.SelectAll();
                return;
            }

            if (textBox3.Text == "Confirmar Contraseña")
            {
                pnlCContraseña.Visible = true;
                textBox3.Focus();
                textBox3.SelectAll();
                return;
            }
            MessageBox.Show("Datos Guardados");
            pnlLogo.Dock = DockStyle.Left;
            pnlSingup.Visible = false;
            pnlLogin.Visible = true;
            pnlLogin.Dock = DockStyle.Fill;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pnlUsername.Visible = pnlContacto.Visible = pnlContraseña.Visible = pnlCContraseña.Visible = false;
        }
        /*
        private void GetV()
        {
            //return timer.Tick += IncreaseOpacity;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Opacity = .01;
            timer.Interval = 10; //replace 10 with whatever you want
            //timer.Tick += IncreaseOpacity;
            timer.Start();//timer1.Start();
        }
        
        private void Timer_Tick(object? sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }*/

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.White;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.ForeColor = Color.White;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            textBox4.ForeColor = Color.White;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox3.ForeColor = Color.White;
        }

        private void btnConfirmar_MouseEnter(object sender, EventArgs e)
        {
            btnConfirmar.ForeColor = Color.Black;
            btnConfirmar.BackColor = Color.Green;
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pnlLogo.Dock = DockStyle.Left;
            pnlSingup.Visible = false;
            pnlLogin.Visible = true;
            pnlLogin.Dock = DockStyle.Fill;

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pnlLogo.Dock = DockStyle.Right;
            pnlLogin.Visible = false;
            pnlSingup.Visible = true;
            pnlSingup.Dock = DockStyle.Fill;

        }
        /*
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            //ReleaseCapture();
            //SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_DragEnter(object sender, DragEventArgs e)
        {
            this.Opacity= 0.5;
        }

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            this.Opacity = 0.5;
        }

        private void Form1_ResizeBegin(object sender, EventArgs e)
        {
            this.Opacity = 0.5;
        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            this.Opacity = 1;
        }*/
    }
}