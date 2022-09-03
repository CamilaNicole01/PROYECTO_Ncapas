using System;
using System.Collections.Generic;
using System.Text;
using SVentas.Dominio;
using SVentas.Data;

namespace SVentas.Logic
{
    public static class ProductoBL
    {
        public static List<Producto> Listar()
        {
             var ProductoData = new ProductoData();
            return ProductoData.Listar();
        }

        public static Producto BuscarPorId(int id)
        {

            var productoData = new ProductoData();
            return productoData.BuscarPorId(id);

        }

        public static bool Insertar(Producto producto)
        {

            var addProd = new ProductoData();
            return addProd.Insertar(producto);

        }

        public static bool Actualizar(Producto producto)
        {
            var productoData = new ProductoData();
            return productoData.Actualizar(producto);

        }

        public static bool EliminarProducto(int id)
        {

            var productoData = new ProductoData();
            return productoData.Eliminar(id);

        }

    }
}

