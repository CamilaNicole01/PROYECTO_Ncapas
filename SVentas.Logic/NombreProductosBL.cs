using System;
using System.Collections.Generic;
using System.Text;
using SVentas.Data;
using SVentas.Dominio;

namespace SVentas.Logic
{
    public static class NombreProductosBL
    {
        public static List<NombreProductos> Listar()
        {
            var nombreproductosData = new NombreProductosData();
            return nombreproductosData.Listar();
        }
    }
}
