using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HolaWindowsForms
{
    public partial class FormLogin : Form
    {
        // singleton pattern
        private static FormLogin instancia = null;
        public static FormLogin Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new FormLogin();
                }
                return instancia;
            }
            set
            {
                instancia = value;
            }
        }

        private FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
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

        private void FormLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            instancia = null;
        }
    }
}
