using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using SVentas.Dominio;

namespace SVentas.Data
{
    public class NombreProductosData
    { 

    string cadenaConexion = "server=localhost; database=Ventas; Integrated Security=true";
    public List<NombreProductos> Listar()
    {
        var listado = new List<NombreProductos>();
        using (var conexion = new SqlConnection(cadenaConexion))
        {
            conexion.Open();
            using (var comando = new SqlCommand("SELECT * FROM NombreProductos", conexion))
            {
                using (var lector = comando.ExecuteReader())
                {
                    if (lector != null && lector.HasRows)
                    {
                        NombreProductos nombres;
                        while (lector.Read())
                        {
                            nombres = new NombreProductos();
                            nombres.ID = int.Parse(lector[0].ToString());
                            nombres.Nombre = lector[1].ToString();
                            listado.Add(nombres);
                        }
                    }
                }
            }
        }
        return listado;
    }

    public NombreProductos BuscarPorId(int id)
    {
        var nombreProducto = new NombreProductos();
        return nombreProducto;
    }

    public bool Insertar()
    {
        return true;
    }


}
}
