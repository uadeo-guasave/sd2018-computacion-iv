using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HolaWindowsForms.Helpers
{
    public partial class MyInputBox : Form
    {
        public MyInputBox(string title, string caption, out string valor)
        {
            InitializeComponent();
            this.Text = title;
            lblCaption.Text = caption;
            valor = txtValor.Text;
        }
    }
}
