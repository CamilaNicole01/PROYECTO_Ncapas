using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SVentas.AppWin
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void MantUsuario(object sender, EventArgs e)
        {
            var Usuario = new frmUsuario();
            Usuario.Show();
         }

        private void MantCliente(object sender, EventArgs e)
        {
            var Cliente = new frmCliente();
            Cliente.Show();
        }

        private void MantProducto(object sender, EventArgs e)
        {
            var Producto = new frmProducto();
            Producto.Show();
        }
    }
}
