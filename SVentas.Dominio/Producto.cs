using System;
using System.Collections.Generic;
using System.Text;

namespace SVentas.Dominio
{
    public class Producto
    {
        public int IdProducto { get; set; }
        public string ListaProductos { get; set; }
        public string Marca { get; set; }
        public decimal Precio { get; set; }
        public int Cantidad { get; set; }
        public string Observacion { get; set; }
    }
}
