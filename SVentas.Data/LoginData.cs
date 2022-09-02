using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using SVentas.Dominio;

namespace SVentas.Data
{
    public class LoginData
    {
        string cadenaConexion = "server=localhost; database=Ventas; Integrated Security = true ";
        public List<Login> Listar()
        {
            var listado = new List<Producto>();
            using (var conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();
                using (var comando = new SqlCommand("Select * from Usuario", conexion))
                {
                }

            return listado;
        }

        }
    }
}
