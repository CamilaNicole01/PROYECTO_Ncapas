using SVentas.Dominio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace SVentas.Data
{
    public class UsuarioData
    {
        string cadenaConexion = "server=localhost; database=Ventas; Integrated Security = true ";
        public List<Usuario> Listar()
        {
            var listado = new List<Usuario>();
            using (var conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();
                using (var comando = new SqlCommand("Select * from Usuario", conexion))
                {
                    using (var lector = comando.ExecuteReader())
                    {
                        if (lector != null && lector.HasRows)
                        {
                            Usuario usuario;
                            while (lector.Read())
                            {
                                usuario = new Usuario();
                                usuario.IdUsuario = int.Parse(lector[0].ToString());
                                usuario.Identificacion = lector[1].ToString();
                                usuario.NameUser = lector[2].ToString();
                                usuario.Clave = lector[3].ToString();
                                listado.Add(usuario);
                            }
                        }
                    }
                }
            }
            return listado;
        }
        public Usuario BuscarPorId(int Id)
        {
            Usuario usuario = new Usuario();
            using (var conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();
                using (var comando = new SqlCommand("SELECT * FROM Usuario WHERE IdUsuario = @Id", conexion))
                {
                    comando.Parameters.AddWithValue("@Id", Id);
                    using (var lector = comando.ExecuteReader())
                    {
                        if (lector != null && lector.HasRows)
                        {
                            lector.Read();
                            usuario = new Usuario();
                            usuario.IdUsuario = int.Parse(lector[0].ToString());
                            usuario.Identificacion = lector[1].ToString();
                            usuario.NameUser = lector[2].ToString();
                            usuario.Clave = lector[3].ToString();
                        }
                    }
                }
            }
            return usuario;
         }
        public bool Insertar(Usuario usuario)
        {
            int filasInsertadas = 0;
            using (var conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();
                var Insertsql = "INSERT INTO Usuario (Identificacion, NameUser, Clave) VALUES(@Identificacion, @Nameuser, @Clave )";
                using (var comando = new SqlCommand(Insertsql, conexion))
                {
                    comando.Parameters.AddWithValue("@Identificacion", usuario.Identificacion);
                    comando.Parameters.AddWithValue("@Nameuser", usuario.NameUser);
                    comando.Parameters.AddWithValue("@Clave", usuario.Clave);
                    filasInsertadas = comando.ExecuteNonQuery();
                }
            }
            return filasInsertadas > 0;
        }
        public bool Actualizar(Usuario usuario)
        {
            int filasActualizadas = 0;
            using (var conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();
                var updatesql = "UPDATE Usuario (Identificacion, NameUser, Clave) VALUES(@Identificacion, @Nameuser, @Clave )";
                using (var comando = new SqlCommand(updatesql, conexion))
                {
                    comando.Parameters.AddWithValue("@Identificacion", usuario.Identificacion);
                    comando.Parameters.AddWithValue("@Nameuser", usuario.NameUser);
                    comando.Parameters.AddWithValue("@Clave", usuario.Clave);
                    filasActualizadas = comando.ExecuteNonQuery();
                }
            }
            return filasActualizadas > 0;
        }
        public bool Eliminar(int Id)
        {
            int filasEiminadas = 0;
            using (var conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();
                var deletesql = "DELETE FROM Usuario WHERE IdUsuario = @Id";
                using (var comando = new SqlCommand(deletesql, conexion))
                {
                    comando.Parameters.AddWithValue("@Id", Id);
                    filasEiminadas = comando.ExecuteNonQuery();
                }
            }
            return filasEiminadas > 0;
        }
        
    }
}
        