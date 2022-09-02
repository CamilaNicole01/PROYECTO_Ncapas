using SVentas.Dominio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace SVentas.Data
{
    public class ProductoData
    {
        string cadenaConexion = "server=localhost; Database=Ventas; Integrated Security = true";
        public List<Producto> Listar()
        {
            var listado = new List<Producto>();
            using (var conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();
                using (var comando = new SqlCommand("Select * from Producto", conexion))
                {

                    using (var lector = comando.ExecuteReader())
                    {

                        if (lector != null && lector.HasRows)
                        {
                            Producto producto;
                            while (lector.Read())
                            {
                                producto = new Producto();
                                producto.IdProducto = int.Parse(lector[0].ToString());
                                producto.ListaProductos= (lector[1].ToString());
                                producto.Marca = (lector[2].ToString());
                                producto.Precio = decimal.Parse(lector[3].ToString());
                                producto.Cantidad= int.Parse(lector[4].ToString());
                                producto.Observacion = (lector[5].ToString());
                                listado.Add(producto);
                             }
                        }
                    }
                 }
            }

            return listado;

        }

        public Producto BuscarPorId(int Id)
        {
            var producto = new Producto();
            using (var conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();
                using (var comando = new SqlCommand("SELECT * FROM Producto WHERE IdProducto = @Id ", conexion))
                {
                    comando.Parameters.AddWithValue("@Id", Id);
                    using (var lector = comando.ExecuteReader())
                    {
                        if (lector != null && lector.HasRows)
                        {
                            lector.Read();
                            producto = new Producto();
                            producto.IdProducto = int.Parse(lector[0].ToString());
                            producto.ListaProductos = (lector[1].ToString());
                            producto.Marca = (lector[2].ToString());
                            producto.Precio = decimal.Parse(lector[3].ToString());
                            producto.Cantidad = int.Parse(lector[4].ToString());
                            producto.Observacion = (lector[5].ToString());
                }
                    }

                }

            }
            return producto;
        }

        public bool Insertar(Producto producto)
        {
            int filasInsertadas = 0;
            using (var conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();
                var Insertsql = "INSERT INTO Producto (ListaProductos, Marca, Precio, Cantidad, Observacion) VALUES (@ListaProductos, @Marca, @Precio, @Cantidad, @Observacion)";
                using (var comando = new SqlCommand(Insertsql, conexion))
                {
                    comando.Parameters.AddWithValue("@ListaProductos", producto.ListaProductos);
                    comando.Parameters.AddWithValue("@Marca", producto.Marca);
                    comando.Parameters.AddWithValue("@Precio", producto.Precio);
                    comando.Parameters.AddWithValue("@Cantidad", producto.Cantidad);
                    comando.Parameters.AddWithValue("@Observacion", producto.Observacion);
                    filasInsertadas = comando.ExecuteNonQuery();
                }
            }
            return filasInsertadas > 0;
            }
            public bool Actualizar(Producto producto)
            {
            int filasActualizadas = 0;
            using (var conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();
                var updatesql = "UPDATE Producto (ListaProductos, Marca, Precio, Cantidad, Observacion) VALUES(@ListaProductos, @Marca, @Precio, @Cantidad, @Observacion) WHERE (IdProducto = @Id))";
                using (var comando = new SqlCommand(updatesql, conexion))
                {
                    comando.Parameters.AddWithValue("@ListaProductos", producto.ListaProductos);
                    comando.Parameters.AddWithValue("@Marca", producto.Marca);
                    comando.Parameters.AddWithValue("@Precio", producto.Precio);
                    comando.Parameters.AddWithValue("@Cantidad", producto.Cantidad);
                    comando.Parameters.AddWithValue("@Observacion", producto.Observacion);
                    comando.Parameters.AddWithValue("@Id", producto.IdProducto);
                    filasActualizadas = comando.ExecuteNonQuery();
                  }
              }
            return filasActualizadas > 0;

        }

        public bool Eliminar(int Id)
        {
            int filasEliminadas = 0;
            using (var conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();
                using (var comando = new SqlCommand("DELETE  From Producto WHERE IdProducto = @Id", conexion))
                {
                    comando.Parameters.AddWithValue("@Id", Id);
                    filasEliminadas = comando.ExecuteNonQuery();
                }
            }
           return filasEliminadas > 0;
         }
     }
}
