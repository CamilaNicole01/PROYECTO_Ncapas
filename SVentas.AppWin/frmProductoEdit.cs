using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SVentas.Dominio;

namespace SVentas.AppWin
{
    public partial class frmProductoEdit : Form
    {
        Producto producto;
        public frmProductoEdit(Producto producto)
        {
            InitializeComponent();
            this.producto = producto;
        }

        private void iniciarFormulario(object sender, EventArgs e)
        {
            if (producto.IdProducto > 0)
            {
            asignarControles();
            }
        }

        private void grabarDatos(object sender, EventArgs e)
        {
            asignarObjetos();
            this.DialogResult = DialogResult.OK;
        }

        private void asignarObjetos()
        {
            this.producto.Marca = txtMarca.Text;
            this.producto.Precio = decimal.Parse(txtPrecio.Text);
            this.producto.Stock = int.Parse(txtCantidad.Text);
            this.producto.Observacion = txtObserva.Text;
            this.producto.IdNombreProducto = int.Parse(cboNombreProducto.SelectedValue.ToString());

        }
           private void asignarControles()
           {
           txtMarca.Text = producto.Marca;
            decimal.Parse(txtPrecio.Text = producto.Precio.ToString());
            int.Parse(txtCantidad.Text = producto.Stock.ToString());
            txtObserva.Text = producto.Observacion;
            cboNombreProducto.SelectedValue = producto.IdNombreProducto;

        }
           }
}
