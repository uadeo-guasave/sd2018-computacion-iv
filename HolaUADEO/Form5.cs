using HolaUADEO.Entidades;
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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var usuario = new Usuario
            {
                Nombres = txtNombre.Text,
                Apellidos = txtApellidos.Text,
                CorreoElectronico = txtCorreoElectronico.Text,
                Telefono = txtTelefono.Text
            };

            // validar nombre de usuario
            try
            {
                usuario.Nombre = ValidarNombre(txtNombreDeUsuario.Text);
                txtNombreDeUsuario.BackColor = Color.LightGreen;
            }
            catch (FormatException ex)
            {
                txtNombreDeUsuario.BackColor = Color.FromName("Info");
                MessageBox.Show(ex.Message);
            }

            // validar contraseña
            try
            {
                usuario.Contraseña = ValidarContraseña(txtContraseña.Text, txtContraseña2.Text);
                txtContraseña.BackColor = Color.LightGreen;
                txtContraseña2.BackColor = Color.LightGreen;
            }
            catch (Exception ex)
            {
                txtContraseña.BackColor = Color.FromName("Info");
                txtContraseña2.BackColor = Color.FromName("Info");
                MessageBox.Show(ex.Message);
            }

        }

        private string ValidarContraseña(string contraseña, string contraseña2)
        {
            int longitud = contraseña.Length;
            if (longitud >= 8 && longitud <= 15)
            {
                if (contraseña == contraseña2)
                {
                    return contraseña;
                }
                else
                {
                    throw new Exception("Las contraseñas deben ser iguales");
                }
            }
            else
            {
                throw new FormatException("La longitud de la contraseña debe ser >=8 y <=15");
            }
        }

        private string ValidarNombre(string username)
        {
            /* validacion de nombre de usuario
             * 2.- que inicie con una letra
             * 3.- debe tener solo letras, numeros y/o _
             * 1.- longitud: entre 6 y 12
             */

            int longitud = username.Length;
            if (longitud >= 6 && longitud <= 12)
            {
                // TODO: agregar codigo para cuando pase la validacion de longitud
                if (Char.IsLetter(username[0]))
                {
                    for (int i = 1; i < longitud; i++)
                    {
                        if (!char.IsLetterOrDigit(username[i]) && username[i] != '_')
                        {
                            throw new FormatException("La cadena debe contener solo letra, numeros y _");
                        }
                    }
                    return username;
                }
                else
                {
                    throw new FormatException("El primer caracter debe ser letra [a-z][A-Z]");
                }
            }
            else
            {
                // TODO: informar del error de longitud
                throw new FormatException("La longitud del nombre debe ser >=6 <=12");
            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // toolTip1.SetToolTip(label2, "prueba");
        }

        private void txtNombreDeUsuario_Validating(object sender, CancelEventArgs e)
        {

        }
    }
}
