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
    public partial class frmClienteEdit : Form
    {
        Cliente cliente;

        public frmClienteEdit(Cliente cliente)
        {
            InitializeComponent();
            this.cliente = cliente;
        }
        private void grabarDatos(object sender, EventArgs e)
        {
            asignarObjetos();
            this.DialogResult = DialogResult.OK;
        }

        private void asignarObjetos()
        {
            cliente.Nombres = txtNombre.Text;
            cliente.Apellidos = txtApellido.Text;
            cliente.Correo = txtCorreo.Text;
            cliente.Observacion = txtObservacion.Text;
            cliente.Ciudad = txtCiudad.Text;

        }
        private void asignarControles()
        {
            txtNombre.Text = cliente.Nombres;
            txtApellido.Text = cliente.Apellidos;
            txtCorreo.Text = cliente.Correo;
            txtObservacion.Text = cliente.Observacion;
            txtCiudad.Text = cliente.Ciudad;
        
        }

        
    }
}
 


