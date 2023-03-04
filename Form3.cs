using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace Login
{
    public partial class Form3 : Form
    {

        public Form3()
        {
            InitializeComponent();
        }
        decimal dividendo = 0;
        decimal divisor = 0;
        string operacion = "";
        double uno = 0;
        double resp = 0;

        private void btn1_Click(object sender, EventArgs e)
        {
            textResultado.Text = textResultado.Text + btn1.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            textResultado.Text = textResultado.Text + btn2.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            textResultado.Text = textResultado.Text + btn3.Text;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            textResultado.Text = textResultado.Text + btn4.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            textResultado.Text = textResultado.Text + btn5.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            textResultado.Text = textResultado.Text + btn6.Text;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            textResultado.Text = textResultado.Text + btn7.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            textResultado.Text = textResultado.Text + btn8.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            textResultado.Text = textResultado.Text + btn9.Text;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            textResultado.Text = textResultado.Text + btn0.Text;
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            textResultado.Text = ".".ToString();
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            dividendo = (decimal)Double.Parse(textResultado.Text);
            decimal resultado = 0;
            switch (operacion)
            {
                case "suma":
                    try
                    {
                        resultado = dividendo + divisor;
                        textResultado.Text = resultado.ToString();
                        operacion = "";
                    }
                    catch (Exception ex)
                    {

                        Console.WriteLine("{0} Exception caught.", ex);
                    }

                    break;
                case "resta":
                    try
                    {
                        resultado = dividendo - divisor;
                        textResultado.Text = resultado.ToString();
                        operacion = "";
                    }
                    catch (Exception ex)
                    {

                        Console.WriteLine("{0} Exception caught.", ex);
                    }

                    break;
                case "multiplicacion":
                    try
                    {
                        resultado = dividendo * divisor;
                        textResultado.Text = resultado.ToString();
                        operacion = "";
                    }
                    catch (Exception ex)
                    {

                        Console.WriteLine("{0} Exception caught.", ex);
                    }


                    break;
                case "division":
                    try
                    {
                        resultado = dividendo / divisor;
                        textResultado.Text = resultado.ToString();
                        operacion = "";
                    }
                    catch (Exception ex)
                    {

                        Console.WriteLine("{0} Exception caught.", ex);
                    }

                    break;
            }
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            dividendo = decimal.Parse(textResultado.Text);
            textResultado.Text = "";
            operacion = "division";
        }

        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            dividendo = decimal.Parse(textResultado.Text);
            textResultado.Text = "";
            operacion = "multiplicacion";
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            dividendo = decimal.Parse(textResultado.Text);
            textResultado.Text = "";
            operacion = "Resta";
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            dividendo = decimal.Parse(textResultado.Text);
            textResultado.Text = "";
            operacion = "Suma";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            textResultado.Clear();
            textVisualzar.Clear();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (textResultado.Text.Length == 1)
                textResultado.Text = "0";
            else
                textResultado.Text = textResultado.Text.Substring(0, textResultado.Text.Length - 1);
        }

        private void btnPotencia_Click(object sender, EventArgs e)
        {
            uno = double.Parse(textResultado.Text);
            resp = uno;
            textVisualzar.Text = textVisualzar.Text + textResultado.Text + "^2";
            textResultado.Text = Math.Pow(uno, 2).ToString();
        }

        private void btnRaiz_Click(object sender, EventArgs e)
        {
            uno = double.Parse(textResultado.Text);
            resp = uno;
            textVisualzar.Text = "√" + textVisualzar.Text + textResultado.Text;
            textResultado.Text = Math.Sqrt(uno).ToString();
        }

        private void btnCos_Click(object sender, EventArgs e)
        {
            uno = double.Parse(textResultado.Text);
            resp = uno;
            textVisualzar.Text = "cos (" + textVisualzar.Text + textResultado + ")";
            textResultado.Text = Math.Cos(uno).ToString();
        }

        private void btnSin_Click(object sender, EventArgs e)
        {
            uno = double.Parse(textResultado.Text);
            resp = uno;
            textVisualzar.Text = "sin (" + textVisualzar.Text + textResultado + ")";
            textResultado.Text = Math.Sin(uno).ToString();
        }

        private void btnTan_Click(object sender, EventArgs e)
        {
            uno = double.Parse(textResultado.Text);
            resp = uno;
            textVisualzar.Text = "tan (" + textVisualzar.Text + textResultado + ")";
            textResultado.Text = Math.Tan(uno).ToString();
        }

        private void btnCsc_Click(object sender, EventArgs e)
        {
            uno = double.Parse(textResultado.Text);
            resp = uno;
            textVisualzar.Text = "csc (" + textVisualzar.Text + textResultado + ")";
            textResultado.Text = Math.Cosh(uno).ToString();
        }

        private void btnSec_Click(object sender, EventArgs e)
        {
            uno = double.Parse(textResultado.Text);
            resp = uno;
            textVisualzar.Text = "Sec (" + textVisualzar.Text + textResultado + ")";
            textResultado.Text = Math.Sinh(uno).ToString();
        }

        private void btnTanh_Click(object sender, EventArgs e)
        {
            uno = double.Parse(textResultado.Text);
            resp = uno;
            textVisualzar.Text = "cot (" + textVisualzar.Text + textResultado + ")";
            textResultado.Text = Math.Tanh(uno).ToString();
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            uno = double.Parse(textResultado.Text);
            resp = uno;
            textVisualzar.Text = "log (" + textVisualzar.Text + textResultado + ")";
            textResultado.Text = Math.Log(uno).ToString();
        }

        private void btnExp_Click(object sender, EventArgs e)
        {
            uno = double.Parse(textResultado.Text);
            resp = uno;
            textVisualzar.Text = "exp (" + textVisualzar.Text + textResultado + ")";
            textResultado.Text = Math.Exp(uno).ToString();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn7_Click_1(object sender, EventArgs e)
        {

        }
    }
}
