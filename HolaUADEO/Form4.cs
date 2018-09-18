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
        private double num1, num2;

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
            // TODO: validar que existan valores en los cuadros de textos
            if (textBoxIsNotEmpty() && valuesCanParseToDouble())
            {
                // TODO: validar que los valores existentes sean numericos
                lblResultado.Text = (num1 + num2).ToString();
                // TODO: realizar la sumatoria y mostrar el resultado en la etiqueta lblResultado
            }
            else
            {
                lblResultado.Text = "Los datos son obligatorios y deben ser numericos";
            }
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            // TODO: validar que existan valores en los cuadros de textos
            if (textBoxIsNotEmpty() && valuesCanParseToDouble())
            {
                // TODO: validar que los valores existentes sean numericos
                lblResultado.Text = (num1 - num2).ToString();
                // TODO: realizar la sumatoria y mostrar el resultado en la etiqueta lblResultado
            }
            else
            {
                lblResultado.Text = "Los datos son obligatorios y deben ser numericos";
            }
        }

        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            // TODO: validar que existan valores en los cuadros de textos
            if (textBoxIsNotEmpty() && valuesCanParseToDouble())
            {
                // TODO: validar que los valores existentes sean numericos
                lblResultado.Text = (num1 * num2).ToString();
                // TODO: realizar la sumatoria y mostrar el resultado en la etiqueta lblResultado
            }
            else
            {
                lblResultado.Text = "Los datos son obligatorios y deben ser numericos";
            }
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            // TODO: validar que existan valores en los cuadros de textos
            if (textBoxIsNotEmpty() && valuesCanParseToDouble())
            {
                // TODO: validar que los valores existentes sean numericos
                lblResultado.Text = (num1 / num2).ToString();
                // TODO: realizar la sumatoria y mostrar el resultado en la etiqueta lblResultado
            }
            else
            {
                lblResultado.Text = "Los datos son obligatorios y deben ser numericos";
            }
        }
    }
}
