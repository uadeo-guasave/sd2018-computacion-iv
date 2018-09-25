using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HolaUADEO
{
    public partial class Form4 : Form
    {
        double num1, num2;
        //const string SUMA = "suma";
        //const string RESTA = "resta";
        //const string MULTIPLICACION = "multiplicacion";
        //const string DIVISION = "division";
        //enum Operacion
        //{
        //    Suma, Resta, Multiplicacion, Division
        //}


        public Form4()
        {
            InitializeComponent();
        }

        private bool textBoxIsNotEmpty()
        {
            if (!string.IsNullOrEmpty(txtUno.Text) && !string.IsNullOrEmpty(txtDos.Text))
                return true;
            else
                return false;
        }

        private bool valuesCanParseToDouble()
        {
            try
            {
                num1 = double.Parse(txtUno.Text);
                num2 = double.Parse(txtDos.Text);

                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            CalcularOperacion(TipoOperacion.Suma);
        }

        private void CalcularOperacion(TipoOperacion op)
        {
            if (textBoxIsNotEmpty() && valuesCanParseToDouble())
            {
                double resultado = 0;
                if (op == TipoOperacion.Suma)
                {
                    resultado = num1 + num2;
                }
                else if (op == TipoOperacion.Resta)
                {
                    resultado = num1 - num2;
                }
                else if (op == TipoOperacion.Multiplicacion)
                {
                    resultado = num1 * num2;
                }
                else if (op == TipoOperacion.Division)
                {
                    if (num2 > 0)
                        resultado = num1 / num2;
                    else
                        resultado = 0;
                }

                lblResultado.Text = resultado.ToString();
            }
            else
            {
                lblResultado.Text = "Los datos son obligatorios y deben ser numericos";
            }
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            CalcularOperacion(TipoOperacion.Resta);
        }

        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            CalcularOperacion(TipoOperacion.Multiplicacion);
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            CalcularOperacion(TipoOperacion.Division);
        }
    }
}
