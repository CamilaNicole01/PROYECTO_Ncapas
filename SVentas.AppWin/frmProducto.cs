using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SVentas.Dominio;
using SVentas.Logic;

namespace SVentas.AppWin
{
    public partial class frmProducto : Form
    {
        //Producto producto;
        public frmProducto()
        {
            InitializeComponent();
        }

        private void frmProducto_Load(object sender, EventArgs e)
        {
            cargarDatos();
        }
        private void cargarDatos()
        {
            var listado = ProductoBL.Listar();
            dgvListado.Rows.Clear();
            foreach (var producto in listado)
            {
                dgvListado.Rows.Add(producto.IdProducto, producto.Marca, producto.Precio, producto.Stock, producto.Observacion, producto.IdNombreProducto, producto.Estado);
            }
        }

        private void nuevoRegistro(object sender, EventArgs e)
        {
            var nuevoProducto = new Producto();
            var frm = new frmProductoEdit(nuevoProducto);
            if (frm.ShowDialog() == DialogResult.OK)
            {
              var exito = ProductoBL.Insertar(nuevoProducto);
                if (exito)
                {
                    MessageBox.Show("El Producto ha sido registrado Correctamente", "Ventas",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargarDatos();
                }
                else
                {
                    MessageBox.Show("No se ha podido registrar al nuevo Producto", "Ventas",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void editarRegistro(object sender, EventArgs e)
        {
            if (dgvListado.Rows.Count > 0)
            {
              int filaActual = dgvListado.CurrentRow.Index;
                var IdProducto = int.Parse(dgvListado.Rows[filaActual].Cells[0].Value.ToString());
                var productoEditar = ProductoBL.BuscarPorId(IdProducto);
                var frm = new frmProductoEdit(productoEditar);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    var exito = ProductoBL.Actualizar(productoEditar);
                    if (exito)
                    {
                        MessageBox.Show("El Producto ha sido actualizado Correctamente", "Ventas",
                         MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cargarDatos();
                    }
                    else
                    {
                        MessageBox.Show("No se ha podido completar la operación de actualización",
                           "Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void eliminarRegistro(object sender, EventArgs e)
        {
            if (dgvListado.Rows.Count > 0)
            {
                int filaActual = dgvListado.CurrentRow.Index;
                var IdProducto = int.Parse(dgvListado.Rows[filaActual].Cells[0].Value.ToString());
                var nombreProducto = dgvListado.Rows[filaActual].Cells[1].Value.ToString();
                var rpta = MessageBox.Show("¿Desea Eliminar este producto?"  + nombreProducto + " ?",
                    "Ventas", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rpta == DialogResult.Yes)
                {
                  var exito = ProductoBL.EliminarProducto(IdProducto);
                    if (exito)
                    {
                        MessageBox.Show("El Producto ha sido eliminado.", "Ventas",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cargarDatos();
                    }
                    else
                    {
                        MessageBox.Show("No se ha podido completar la eliminación del Producto",
                            "Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        
    }
}





