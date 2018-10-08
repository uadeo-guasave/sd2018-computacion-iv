using HolaUADEO.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HolaUADEO
{
    public partial class Form5 : Form
    {
        Usuario NuevoUsuario { get; set; } = new Usuario();
        ErrorProvider Error { get; set; } = new ErrorProvider();

        public Form5()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // TODO: pendiente
        }

        private bool ValidarLongitudContraseña(string contraseña)
        {
            int longitud = contraseña.Length;
            if (longitud >= 8 && longitud <= 15)
            {
                return true;
            }
            else
            {
                throw new FormatException("La longitud de la contraseña debe ser >=8 y <=15");
            }
        }

        private bool ValidarNombre(string username)
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
                    return true;
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

        private void txtNombreDeUsuario_Validating(object sender, CancelEventArgs e)
        {
            // TODO: crear codigo para validar por compomente
            try
            {
                if (ValidarNombre(txtNombreDeUsuario.Text))
                {
                    NuevoUsuario.Nombre = txtNombreDeUsuario.Text;
                    Error.Clear();
                }
            }
            catch (FormatException ex)
            {
                e.Cancel = true;
                txtNombreDeUsuario.SelectAll();
                Error.SetError(txtNombreDeUsuario, ex.Message);
                NuevoUsuario.Nombre = "";
            }
        }

        private void txtContraseña_Validating(object sender, CancelEventArgs e)
        {
            //// validar contraseña
            try
            {
                if(ValidarLongitudContraseña(txtContraseña.Text))
                {
                    txtContraseña2.Focus();
                    Error.Clear();
                }
            }
            catch (Exception ex)
            {
                e.Cancel = true;
                txtContraseña.SelectAll();
                Error.SetError(txtContraseña, ex.Message);
            }
        }

        private void txtContraseña2_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (ValidarContraseñasIguales(txtContraseña.Text, txtContraseña2.Text))
                {
                    Error.Clear();
                    NuevoUsuario.Contraseña = txtContraseña.Text;
                }
            }
            catch (Exception ex)
            {
                e.Cancel = true;
                txtContraseña2.SelectAll();
                Error.SetError(txtContraseña2, ex.Message);
            }
        }

        private bool ValidarContraseñasIguales(string con1, string con2)
        {
            if (con1 == con2)
            {
                return true;
            }
            else
            {
                throw new FormatException("Las contraseñas deben ser iguales");
            }
        }

        private void txtNombre_Validating(object sender, CancelEventArgs e)
        {
            if (txtNombre.Text != "")
            {
                Error.Clear();
                NuevoUsuario.Nombre = txtNombre.Text;
            }
            else
            {
                e.Cancel = true;
                txtNombre.SelectAll();
                Error.SetError(txtNombre, "El nombre es obligatorio");
            }
        }

        private void txtApellidos_Validating(object sender, CancelEventArgs e)
        {
            if (txtApellidos.Text != "")
            {
                Error.Clear();
                NuevoUsuario.Apellidos = txtApellidos.Text;
            }
            else
            {
                e.Cancel = true;
                txtApellidos.SelectAll();
                Error.SetError(txtApellidos, "Los apellidos son obligatorios");
            }
        }

        private void txtCorreoElectronico_Validating(object sender, CancelEventArgs e)
        {
            //string patron = "[a-z,A-Z,.,_]+@[a-z,A-Z,.,_]+";
            //var emailRegex = new Regex(patron);
            //if (emailRegex.IsMatch(txtCorreoElectronico.Text))
            //    MessageBox.Show("correo electronico correcto");
            //else
            //    MessageBox.Show("correo incorrecto");
            try
            {
                var correo = new System.Net.Mail.MailAddress(txtCorreoElectronico.Text);
                NuevoUsuario.CorreoElectronico = txtCorreoElectronico.Text;
                Error.Clear();
            }
            catch (ArgumentException)
            {
                // llega aqui cuando el correo esta vacio
                e.Cancel = true;
                Error.SetError(txtCorreoElectronico, "Campo obligatorio");
            }
            catch (FormatException)
            {
                // llega aqui cuando el correo tiene formato incorrecto
                e.Cancel = true;
                Error.SetError(txtCorreoElectronico, "direccion de correo incorrecta");
            }
        }
    }
}
