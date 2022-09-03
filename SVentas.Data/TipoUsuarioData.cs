using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using SVentas.Dominio;

namespace SVentas.Data
{
    public class TipoUsuarioData
    {
        string cadenaConexion = "server=localhost; database=Ventas; Integrated Security=true";
        public List<TipoUsuario> Listar()
        {
            var listado = new List<TipoUsuario>();
            using (var conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();
                using (var comando = new SqlCommand("SELECT * FROM TipoUsuario", conexion))
                {
                    using (var lector = comando.ExecuteReader())
                    {
                        if (lector != null && lector.HasRows)
                        {
                            TipoUsuario tipo;
                            while (lector.Read())
                            {
                                tipo = new TipoUsuario();
                                tipo.ID = int.Parse(lector[0].ToString());
                                tipo.Nombre = lector[1].ToString();
                                listado.Add(tipo);
                            }
                        }
                    }
                }
            }
            return listado;
        }

        public TipoUsuario BuscarPorId(int id)
        {
            var tipoUsuario= new TipoUsuario();
            return tipoUsuario;
        }

        public bool Insertar()
        {
            return true;
        }


    }
}
