using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace HolaUADEO
{
    class Form1 : Form
    {
        public Button btnSaludar;
        public Form1()
        {
            btnSaludar = new Button();
            btnSaludar.Size = new Size(50, 40);
            btnSaludar.Location = new Point(30, 30);
            btnSaludar.Text = "Saluda me";
            this.Controls.Add(btnSaludar);
            btnSaludar.Click += new EventHandler(btnSaludar_Click);
        }

        public void btnSaludar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hola Formulario desde línea de comandos");
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Name = "Form1";
            this.ResumeLayout(false);

        }
    }
}
