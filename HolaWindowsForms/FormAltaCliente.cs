using HolaWindowsForms.Models;
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
    public partial class FormAltaCliente : Form
    {
        public FormAltaCliente()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // aqui debe estar la validación, que ustedes harán, YO NO xD
            using (var db = new AppDbContext())
            {
                Cliente cliente = new Cliente
                {
                    Nombre = txtNombre.Text,
                    Apellidos = txtApellidos.Text,
                    Domicilio = txtDomicilio.Text
                };
                db.Clientes.Add(cliente);
                db.SaveChanges();
                MaestroDetalleVentas.Instancia.Cliente = cliente;
            }

            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
