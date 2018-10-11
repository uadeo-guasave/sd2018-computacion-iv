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
    public partial class frmMdiPadre : Form
    {
        public frmMdiPadre()
        {
            InitializeComponent();
        }

        private void inicioDeSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLogin.Instancia.MdiParent = this;
            FormLogin.Instancia.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            new FormGrid().Show();
        }

        private void frmMdiPadre_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Aplicación cargada correctamente.";
        }
    }
}
