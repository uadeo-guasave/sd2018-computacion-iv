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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rbMasculino.Checked)
            {
                // entonces es hombre
                MessageBox.Show("Genero Masculino");
            }
            else if (rbFemenino.Checked)
            {
                // entonces es mujer
                MessageBox.Show("Genero Femenino");
            }
            else
            {
                // entonces no ha seleccionado genero
                MessageBox.Show("No ha seleccionado genero");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSesion.Checked)
                MessageBox.Show("Mantener la sesión activa");
            else
                MessageBox.Show("No mantener la sesión activa");
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            string[] nombres = new string[]
            {
                "juan urias",
                "jose luis bojorquez",
                "maria guadalupe villegas",
                "julio manuel de jesus beltran meza",
                "manuel gaxiola",
                "adalberto sicairos"
            };

            cmbNombres.Items.AddRange(nombres);
            lbNombres.Items.AddRange(nombres);
        }
    }
}
