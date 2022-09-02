using SVentas.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SVentas.Dominio;
using SVentas.Data;

namespace SVentas.AppWin
{
    public partial class frmUsuario : Form
    {
        public frmUsuario()
        {
            InitializeComponent();
        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {
            cargarDatos();
        }
        private void cargarDatos()
        {
            var listado = UsuarioBL.Listar();
            dgvListado.Rows.Clear();
            foreach (var usuario in listado)
            {
                dgvListado.Rows.Add(usuario.IdUsuario, usuario.Identificacion, usuario.NameUser, usuario.Clave);
            }
        }

        private void nuevoRegistro(object sender, EventArgs e)
        {
            var nuevoUsuario = new Usuario();
            var frm = new frmUsuarioEdit(nuevoUsuario);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                var exito = UsuarioBL.Insertar(nuevoUsuario);
                if (exito)
                {
                    MessageBox.Show("El Usuario ha sido registrado Correctamente", "Ventas",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargarDatos();
                }
                else
                {
                    MessageBox.Show("No se ha podido registrar al nuevo Usuario", "Ventas",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void editarRegistro(object sender, EventArgs e)
        {
            if (dgvListado.Rows.Count > 0)
            {
                int filaActual = dgvListado.CurrentRow.Index;
                var IdUsuario = int.Parse(dgvListado.Rows[filaActual].Cells[0].Value.ToString());
                var usuarioEditar = UsuarioBL.BuscarPorId(IdUsuario);
                var frm = new frmUsuarioEdit(usuarioEditar);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    var exito = UsuarioBL.Actualizar(usuarioEditar);
                    if (exito)
                    {
                        MessageBox.Show("El Usuario ha sido actualizado Correctamente", "Ventas",
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
                var IdUsuario = int.Parse(dgvListado.Rows[filaActual].Cells[0].Value.ToString());
                var nombreUsuario = dgvListado.Rows[filaActual].Cells[1].Value.ToString();
                var rpta = MessageBox.Show("¿Realmente desea eliminar al Usuario " + nombreUsuario + " ?",
                    "Ventas", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rpta == DialogResult.Yes)
                {
                    var exito = UsuarioBL.Eliminar(IdUsuario);
                    if (exito)
                    {
                        MessageBox.Show("El Usuario ha sido eliminado.", "Ventas",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cargarDatos();
                    }
                    else
                    {
                        MessageBox.Show("No se ha podido completar la eliminación del Usuario",
                            "Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                }
            }
        }
    }


