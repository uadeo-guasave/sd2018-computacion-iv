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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            lblResultado.Text = "";
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtUsuario.Text) || String.IsNullOrEmpty(txtContraseña.Text))
                lblResultado.Text = "Debes escribir usuario y contraseña\n";
            else
                //lblResultado.Text = "Usuario: " + txtUsuario.Text + ", Contraseña: " + txtContraseña.Text + "\n";
                lblResultado.Text = $"Usuario: {txtUsuario.Text}, Contraseña: {txtContraseña.Text}\n";

            if (chkSesion.Checked == true)
                lblResultado.Text += "Se mantiene la sesión iniciada";
            else
                lblResultado.Text += "No se mantiene la sesión iniciada";
        }
    }
}
