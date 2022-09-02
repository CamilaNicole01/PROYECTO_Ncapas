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
    public partial class frmUsuarioEdit : Form
    {
        Usuario usuario;

        public frmUsuarioEdit(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }

        private void grabarDatos(object sender, EventArgs e)
        {
            asignarObjetos();
            this.DialogResult = DialogResult.OK;
        }

        private void asignarObjetos()
        {
            usuario.Identificacion = txtIdent.Text;
            usuario.NameUser = txtUsuario.Text;
            usuario.Clave = txtClave.Text;

        }
        private void asignarControles()
        {
            txtIdent.Text = usuario.Identificacion;
            txtUsuario.Text = usuario.NameUser;
            decimal.Parse(txtClave.Text = usuario.Clave.ToString());
            
        }

    }
}
