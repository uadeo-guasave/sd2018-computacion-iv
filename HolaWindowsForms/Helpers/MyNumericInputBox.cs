using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HolaWindowsForms.Helpers
{
    public class MyNumericInputBox
    {
        public MyNumericInputBox(string title = "Dato numérico", string caption = "Ingresa el número")
        {
            Title = title;
            Caption = caption;
            InitializeComponent();
        }

        public Form MyForm { get; private set; }
        public string Title { get; set; }
        public string Caption { get; set; }
        public int Valor { get; set; }
        public Label Etiqueta { get; private set; }
        public NumericUpDown Entrada { get; private set; }
        public Button Boton { get; private set; }

        private void InitializeComponent()
        {
            Etiqueta = new Label
            {
                Text = Caption,
                Location = new Point(10, 10)
            };


            Entrada = new NumericUpDown
            {
                Location = new Point(10, 50),
                Width = 80
            };

            Boton = new Button
            {
                Text = "Aceptar",
                Location = new Point(100, 50)
            };
            Boton.Click += boton_Click;
            

            MyForm = new Form
            {
                Text = Title,
                Width = 400,
                Height = 200,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                MinimizeBox = false,
                MaximizeBox = false
            };

            MyForm.Controls.Add(Etiqueta);
            MyForm.Controls.Add(Entrada);
            MyForm.Controls.Add(Boton);
        }

        private void boton_Click(object sender, EventArgs e)
        {
            this.Valor = (int)Entrada.Value;
            MyForm.Close();
        }

        public int Show()
        {
            MyForm.ShowDialog();
            return Valor;
        }
    }
}
