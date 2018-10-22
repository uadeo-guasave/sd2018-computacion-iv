﻿using HolaWindowsForms.Models;
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
            }
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
    }
}
