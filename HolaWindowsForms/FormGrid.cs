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
    public partial class FormGrid : Form
    {
        public List<Empleado> Empleados { get; set; }
        public FormGrid()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormGrid_Load(object sender, EventArgs e)
        {
            Empleados = new List<Empleado>
            {
                new Empleado
                {
                    Nombre="Kevin",
                    Apellidos="Lopez",
                    Edad=18,
                    Departamento="Ciencias"
                },
                new Empleado
                {
                    Nombre="Juanita",
                    Apellidos="La Huerfanita",
                    Edad=89,
                    Departamento="Adultos mayores"
                },
                new Empleado
                {
                    Nombre="Carmen",
                    Apellidos="Se me perdio la cadenita",
                    Edad=50,
                    Departamento="Que tú me regalaste Carmen"
                }
            };
        }

        private void btnCargarGrid_Click(object sender, EventArgs e)
        {
            foreach (var empleado in Empleados)
            {
                object[] emp = { empleado.Nombre, empleado.Apellidos, empleado.Edad, empleado.Departamento };
                gridEmpleados.Rows.Add(emp);
            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            gridEmpleados.Rows.Clear();
        }
    }
}
