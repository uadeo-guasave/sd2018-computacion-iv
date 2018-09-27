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
                Nombre = ValidarNombre(txtNombreDeUsuario.Text),
                Contraseña = txtContraseña.Text,
                Nombres = txtNombre.Text,
                Apellidos = txtApellidos.Text,
                CorreoElectronico = txtCorreoElectronico.Text,
                Telefono = txtTelefono.Text
            };

            MessageBox.Show(usuario.Nombre);

        }

        private string ValidarNombre(string username)
        {
            /* validacion de nombre de usuario
             * 3.- que inicie con una letra
             * 2.- debe tener solo letras, numeros y/o _
             * 1.- longitud: entre 6 y 12
             */

            int longitud = username.Length;
            if (longitud >= 6 && longitud <= 12)
            {
                // TODO: agregar codigo para cuando pase la validacion de longitud
                bool esLetraNumero_ = true;
                for (int i = 0; i < longitud; i++)
                {
                    if (!Char.IsLetterOrDigit(username[i]) || username[i] != '_')
                    {
                        esLetraNumero_ = false;
                        break;
                    }
                }
                if (esLetraNumero_)
                {
                    if (Char.IsLetter(username[0]))
                    {
                        return username;
                    }
                    else
                    {
                        throw new FormatException();
                    }
                }
                else
                {
                    throw new FormatException();
                }
            }
            else
            {
                // TODO: informar del error de longitud
                throw new FormatException();
            }
        }
    }
}
