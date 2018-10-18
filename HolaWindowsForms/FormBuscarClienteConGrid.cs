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
    public partial class FormBuscarClienteConGrid : Form
    {
        //public FormBuscarClienteConGrid()
        //{
        //    InitializeComponent();
        //}

        public FormBuscarClienteConGrid(string nombreABuscar)
        {
            NombreABuscar = nombreABuscar.ToLower();

            InitializeComponent();
        }

        public string NombreABuscar { get; }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormBuscarClienteConGrid_Load(object sender, EventArgs e)
        {
            // resource (open() close())
            using (var db = new AppDbContext())
            {
                Clientes = new List<Cliente>();
                Clientes = db.Clientes
                             .Where(c => c.Nombre.ToLower() == NombreABuscar || c.Apellidos.ToLower() == NombreABuscar)
                             .ToList();
                var lista = new BindingList<Cliente>(Clientes);
                gridDeClientes.DataSource = lista;
            }
        }

        private List<Cliente> Clientes { get; set; }
    }
}
