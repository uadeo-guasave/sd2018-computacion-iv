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
        public FormBuscarClienteConGrid()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormBuscarClienteConGrid_Load(object sender, EventArgs e)
        {
            //BuscarCliente(); pero ustedes borrenlo, bueno si quieren dejenlo, pero entre comentario, si ya lo borraron den ctrl+z
        }

        private void BuscarCliente(string NombreABuscar)
        {
            NombreABuscar = NombreABuscar.ToLower();
            // resource (open() close())
            using (var db = new AppDbContext())
            {
                Clientes = new List<Cliente>();
                // select * from clientes where lower(nombre) LIKE '%gax%' or lower(apellidos) LIKE '%gax%';
                Clientes = db.Clientes
                             .Where(c => c.Nombre.ToLower().Contains(NombreABuscar) || c.Apellidos.ToLower().Contains(NombreABuscar))
                             .ToList();
                var lista = new BindingList<Cliente>(Clientes);
                gridDeClientes.DataSource = lista;
            }
        }

        private List<Cliente> Clientes { get; set; }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            BuscarCliente(txtABuscar.Text);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (gridDeClientes.RowCount > 0)
            {
                Cliente cliente = (Cliente)gridDeClientes.CurrentRow.DataBoundItem;
                MaestroDetalleVentas.Instancia.Cliente = cliente;
                this.Close();
            }
            else
            {
                MessageBox.Show("No se ha seleccionado cliente.");
            }
            
        }
    }
}
