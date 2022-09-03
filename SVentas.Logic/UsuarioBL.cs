using SVentas.Dominio;
using System;
using System.Collections.Generic;
using System.Text;
using SVentas.Data;

namespace SVentas.Logic
{
    public static class UsuarioBL
    {
        public static List<Usuario> Listar()
        {
            var usuarioData = new UsuarioData();
            return usuarioData.Listar();
        }
        public static Usuario BuscarPorId(int Id)
        {
            var usuarioData = new UsuarioData();
            return usuarioData.BuscarPorId(Id);
        }

        public static bool Insertar(Usuario usuario)
        {
            var usuarioData = new UsuarioData();
            return usuarioData.Insertar(usuario);
        }

        public static bool Actualizar(Usuario usuario)
        {
            var usuarioData = new UsuarioData();
            return usuarioData.Actualizar(usuario);
        }

        public static bool Eliminar(int Id)
        {
            var usuarioData = new UsuarioData();
            return usuarioData.Eliminar(Id);
        }
    }
}
