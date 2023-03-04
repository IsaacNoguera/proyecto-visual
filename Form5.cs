using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Login
{
    public partial class Form5 : Form
    {

        public Form5()
        {
            InitializeComponent();
        }

        private void CFantasia()
        {
            cbxLibro.Items.Clear();
            cbxLibro.Items.Add("The Witcher: el ultimo deseo");
            cbxLibro.Items.Add("Cancion de hielo y fuego");
            cbxLibro.Items.Add("El señor de los anillos");
        }
        private void CTerror()
        {
            cbxLibro.Items.Clear();
            cbxLibro.Items.Add("El Gato Negro");
            cbxLibro.Items.Add("En las montañas de la locura");
            cbxLibro.Items.Add("Drácula");
        }
        private void CAventura()
        {
            cbxLibro.Items.Clear();
            cbxLibro.Items.Add("La Isla del Tesoro");
            cbxLibro.Items.Add("Robin Crusoe");
            cbxLibro.Items.Add("Moby Dick");
        }

        private void buttonX_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            string Codigo = textCodigo.Text;
            switch (Codigo)
            {
                case "L0001":
                    {
                        textNombre.Text = "Isaac Noguera";
                        break;
                    }

                case "L0002":
                    {
                        textNombre.Text = "Darwin Eche";
                        break;
                    }

                case "L0003":
                    {
                        textNombre.Text = "Kerly Rosas";
                        break;
                    }

                default:
                    {
                        MessageBox.Show("Lo sentimos el usuario no pudo ser encontrado");
                        break;
                    }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int genero;
            genero = cbxGenero.SelectedIndex;

            switch ((genero))
            {
                case 0:
                    {
                        break;
                    }

                case 1:
                    {
                        CFantasia();
                        break;
                    }

                case 2:
                    {
                        CTerror();
                        break;
                    }

                case 3:
                    {
                        CAventura();
                        break;
                    }
            }

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int dias;
            double pago;
            int n = 0;

            if (textNombre.Text == "")
                Interaction.MsgBox("Lector no encontrado!", MsgBoxStyle.Critical, "Sistema");
            else if (cbxGenero.SelectedIndex == 0)
                Interaction.MsgBox("Falta seleccionar un libro!", MsgBoxStyle.Critical, "Sistema");
            else
            {
                for (var index = 0; index <= listEstudiante.Items.Count - 1; index++)
                {
                    if (listEstudiante.Items.Count.ToString().Equals(textNombre.Text))
                    {
                        n = +1;
                    }
                }
                if (n == 2)
                {
                    Interaction.MsgBox("Capacidad alcanzada del lector", MsgBoxStyle.Information, "Sistema");

                }
                else
                {
                    TimeSpan ts = dtpFin.Value - dtpInicio.Value;

                    dias = (int)ts.TotalDays;
                    listEstudiante.Items.Add(textNombre.Text);
                    listLibro.Items.Add(cbxLibro.SelectedItem);
                    listDias.Items.Add(dias);
                    if (dias <= 2)
                    {
                        pago = 0.0;
                        listPago.Items.Add("S/. " + pago);
                    }
                    else
                    {
                        pago = (dias - 2) * 1.5;
                        listPago.Items.Add("S/. " + pago);
                    }
                    cbxGenero.SelectedIndex = 0;
                    cbxLibro.SelectedIndex = -1;
                    textCodigo.Clear();
                    textNombre.Text = "";
                    textCodigo.Focus();
                }
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            listEstudiante.Items.Clear();
            listLibro.Items.Clear();
            listDias.Items.Clear();
            listPago.Items.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int i = listEstudiante.SelectedIndex;
            if (i >= 0)
            {
                listLibro.Items.RemoveAt(i);
                listDias.Items.RemoveAt(i);
                listPago.Items.RemoveAt((int)i);
                listEstudiante.Items.RemoveAt(i);
            }

        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textCodigo_TextChanged(object sender, EventArgs e)
        {
            textCodigo.CharacterCasing = CharacterCasing.Upper;
            if (textCodigo.Text.Length > 5)
            {
                btnConfirmar.Enabled = false;
            }
            else
            {
                btnConfirmar.Enabled = true;
            }
        }
    }
}
