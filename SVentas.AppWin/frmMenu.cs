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
            var usuario = new frmUsuario();
            usuario.Show();
         }

        private void MantCliente(object sender, EventArgs e)
        {
            var cliente = new frmCliente();
            cliente.Show();
        }

        private void MantProducto(object sender, EventArgs e)
        {
            var producto= new frmProducto();
            producto.Show();
        }

        private void abrirCatalogo(object sender, EventArgs e)
        {
            var catalogo = new Catalogo();
            catalogo.Show();
        }

        private void abrirRegistro(object sender, EventArgs e)
        {
            var registro = new frmRegistro();
            registro.Show();
        }
    }
}
