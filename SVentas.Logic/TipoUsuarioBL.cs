using System;
using System.Collections.Generic;
using System.Text;
using SVentas.Data;
using SVentas.Dominio;

namespace SVentas.Logic
{
    public static class TipoUsuarioBL
    {
        public static List<TipoUsuario> Listar()
        {
            var tipoUsuarioData = new TipoUsuarioData();
            return tipoUsuarioData.Listar();
        }
    }
}