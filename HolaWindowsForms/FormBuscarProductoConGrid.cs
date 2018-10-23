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
    public partial class FormBuscarProductoConGrid : Form
    {
        public FormBuscarProductoConGrid()
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

        private void BuscarProducto(string NombreABuscar)
        {
            NombreABuscar = NombreABuscar.ToLower();
            using (var db = new AppDbContext())
            {
                Productos = new List<Producto>();
                Productos = db.Productos
                             .Where(c => c.Nombre.ToLower().Contains(NombreABuscar))
                             .ToList();
                var lista = new BindingList<Producto>(Productos);
                gridDeProductos.DataSource = lista;
            }
        }

        private List<Producto> Productos { get; set; }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            // deben validar que haya escrito algo en el cuadro, ustedes lo harán YO NO xD
            BuscarProducto(txtABuscar.Text);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (gridDeProductos.RowCount > 0)
            {
                Cliente cliente = (Cliente)gridDeProductos.CurrentRow.DataBoundItem;
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
