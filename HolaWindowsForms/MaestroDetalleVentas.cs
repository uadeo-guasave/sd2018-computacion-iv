using HolaWindowsForms.Helpers;
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
    public partial class MaestroDetalleVentas : Form
    {
        public MaestroDetalleVentas()
        {
            InitializeComponent();
        }

        private void MaestroDetalleVentas_Load(object sender, EventArgs e)
        {
            using (var db = new AppDbContext())
            {
                db.Database.EnsureCreated();
                var productos = new BindingList<Producto>(db.Productos.ToList());
                comboProductos.ValueMember = "Id";
                comboProductos.DisplayMember = "Nombre";
                comboProductos.DataSource = productos;
            }

            //gridProductos.DataSource = new BindingList<ProductoAVender>(Productos);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Form formBuscarCliente = new FormBuscarClienteConGrid();
            formBuscarCliente.ShowDialog();
            if (Cliente != null)
                txtNombreCliente.Text = Cliente.NombreCompleto;
        }

        public Cliente Cliente { get; set; } = null;

        private static MaestroDetalleVentas instancia = null;
        public static MaestroDetalleVentas Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new MaestroDetalleVentas();
                }
                return instancia;
            }
            set
            {
                instancia = value;
            }
        }

        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            var nuevoCliente = new FormAltaCliente();
            nuevoCliente.ShowDialog();
            if (Cliente != null)
                txtNombreCliente.Text = Cliente.NombreCompleto;
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            var buscarProducto = new FormBuscarProductoConGrid();
            buscarProducto.ShowDialog();
            //gridProductos.DataSource = null;
            //gridProductos.DataSource = Productos;
        }

        public List<ProductoAVender> Productos { get; set; } = new List<ProductoAVender>();

        public void AgregarProductoAlGrid(ProductoAVender producto)
        {
            string[] p = {
                producto.Id.ToString(),
                producto.Nombre,
                producto.Precio.ToString(),
                producto.Cantidad.ToString(),
                producto.Total.ToString()
            };
            gridProductos.Rows.Add(p);
        }
    }
}
