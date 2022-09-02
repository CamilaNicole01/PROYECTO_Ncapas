using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SVentas.Logic;
using SVentas.Dominio;
using SVentas.Data;

namespace SVentas.AppWin
{
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            cargarDatos();
        }
        private void cargarDatos()
        {
            var listado = ClienteBL.Listar();
            dgvListado.Rows.Clear();
            foreach (var cliente in listado)
            {
                dgvListado.Rows.Add(cliente.IdCliente, cliente.NombreCompleto, cliente.Correo, cliente.Observacion, cliente.Ciudad);
            }
        }

        private void nuevoRegistro(object sender, EventArgs e)
        {
            var nuevoCliente = new Cliente();
            var frm = new frmClienteEdit(nuevoCliente);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                var exito = ClienteBL.Insertar(nuevoCliente);
                if (exito)
                {
                    MessageBox.Show("El Cliente ha sido registrado Correctamente", "Ventas",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargarDatos();
                }
                else
                {
                    MessageBox.Show("No se ha podido registrar al nuevo Cliente", "Ventas",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void editarRegistro(object sender, EventArgs e)
        {
            if (dgvListado.Rows.Count > 0)
            {
                int filaActual = dgvListado.CurrentRow.Index;
                var IdCliente = int.Parse(dgvListado.Rows[filaActual].Cells[0].Value.ToString());
                var clienteEditar = ClienteBL.BuscarPorId(IdCliente);
                var frm = new frmClienteEdit(clienteEditar);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    var exito = ClienteBL.Actualizar(clienteEditar);
                    if (exito)
                    {
                        MessageBox.Show("El Cliente ha sido actualizado Correctamente", "Ventas",
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
                var IdCliente = int.Parse(dgvListado.Rows[filaActual].Cells[0].Value.ToString());
                var nombreCliente = dgvListado.Rows[filaActual].Cells[1].Value.ToString();
                var rpta = MessageBox.Show("¿Realmente desea eliminar al Cliente " + nombreCliente + " ?",
                    "Ventas", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rpta == DialogResult.Yes)
                {
                    var exito = ClienteBL.Eliminar(IdCliente);
                    if (exito)
                    {
                        MessageBox.Show("El Cliente ha sido eliminado.", "Ventas",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cargarDatos();
                    }
                    else
                    {
                        MessageBox.Show("No se ha podido completar la eliminación del Cliente",
                            "Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}