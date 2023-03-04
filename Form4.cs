using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Form4 : Form
    {
        string nombre = "";
        string ciudad = "";
        string telefono = "";
        string correo = "";
        string valor = "";
        int posicion = 0;
        bool actualizar = false;

        public Form4()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            nombre = textNombre.Text;
            ciudad = textCiudad.Text;
            telefono = textTelefono.Text;
            correo = textCorreo.Text;

            listContactos.Items.Add(nombre + ' ' + ciudad + ' ' + telefono + ' ' + correo);
            textNombre.Text = "";
            textCiudad.Text = "";
            textTelefono.Text = "";
            textCorreo.Text = "";
            textNombre.Focus();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            actualizar = true;
            int nposicion = 0;
            string valor2 = "";
            nombre = textNombre.Text;
            ciudad = textCiudad.Text;
            telefono = textTelefono.Text;
            correo = textCorreo.Text;
            valor2 = nombre + ' ' + ciudad + ' ' + telefono + ' ' + correo;
            nposicion = listContactos.SelectedIndex;
            listContactos.Items.RemoveAt(nposicion);
            listContactos.Items.Insert(nposicion, valor2);
            actualizar = false;
        }

        private ListBox GetListContactos()
        {
            return listContactos;
        }

        private void btnEliminar_Click(object sender, EventArgs e, ListBox listContactos)
        {
            int nposicion = 0;
            nposicion = listContactos.SelectedIndex;
            listContactos.Items.RemoveAt(nposicion);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void listContactos_SelectedIndexChanged(object sender, EventArgs e)
        {
            valor = "";
            valor = listContactos.GetItemText(listContactos.SelectedItem);
            posicion = listContactos.SelectedIndex;

            if (actualizar)
            {

            }
            else
            {
                modificoCampos(valor);
            }
        }
        private void modificoCampos(String valor)
        {
            if (valor.Equals(""))
            {

            }
            else
            {
                string[] subs;
                subs = valor.Split(' ');
                nombre = subs[0];
                ciudad = subs[1];
                telefono = subs[2];
                correo = subs[3];

                textNombre.Text = nombre;
                textCiudad.Text = ciudad;
                textTelefono.Text = telefono;
                textCorreo.Text = correo;
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
