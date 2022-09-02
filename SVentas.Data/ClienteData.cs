using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using SVentas.Dominio;

namespace SVentas.Data
{
    public class ClienteData
    {
        string cadenaConexion = "server=localhost; database=Ventas; Integrated Security = true ";
        public List<Cliente> Listar()
        {
            var listado = new List<Cliente>();
            using (var conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();
                using (var comando = new SqlCommand("Select * from Cliente", conexion))
                {
                    using (var lector = comando.ExecuteReader())
                    {
                        if (lector != null && lector.HasRows)
                        {
                            Cliente cliente;
                            while (lector.Read())
                            {
                                cliente = new Cliente();
                                cliente.IdCliente = int.Parse(lector[0].ToString());
                                cliente.Nombres = lector[1].ToString();
                                cliente.Apellidos = lector[2].ToString();
                                cliente.Correo = lector[3].ToString();
                                cliente.Observacion = lector[4].ToString();
                                cliente.Ciudad = lector[5].ToString();
                                listado.Add(cliente);
                            }
                        }
                    }
                }
            }
            return listado;
        }
        public Cliente BuscarPorId(int Id)
        {
            Cliente cliente = new Cliente();
            using (var conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();
                using (var comando = new SqlCommand("SELECT * FROM Cliente WHERE IdCliente = @Id", conexion))
                {
                    comando.Parameters.AddWithValue("@Id", Id);
                    using (var lector = comando.ExecuteReader())
                    {
                        if (lector != null && lector.HasRows)
                        {
                            lector.Read();
                            cliente = new Cliente();
                            cliente.IdCliente = int.Parse(lector[0].ToString());
                            cliente.Nombres = lector[1].ToString();
                            cliente.Apellidos = lector[2].ToString();
                            cliente.Correo = lector[3].ToString();
                            cliente.Observacion = lector[4].ToString();
                            cliente.Ciudad = lector[5].ToString();
                        }
                    }
                }
            }
            return cliente;
        }
        public bool Insertar(Cliente cliente)
        {
            int filasInsertadas = 0;
            using (var conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();
                var Insertsql = "INSERT INTO Cliente (Nombres, Apellidos, Correo, Observacion, Ciudad) VALUES(@Nombres,@Apellidos ,@Correo ,@Observacion ,@Ciudad)";
                using (var comando = new SqlCommand(Insertsql, conexion))
                {
                    comando.Parameters.AddWithValue("@Nombres", cliente.Nombres);
                    comando.Parameters.AddWithValue("@Apellidos", cliente.Apellidos);
                    comando.Parameters.AddWithValue("@Correo", cliente.Correo);
                    comando.Parameters.AddWithValue("@Observacion", cliente.Observacion);
                    comando.Parameters.AddWithValue("@Ciudad", cliente.Ciudad);
                    filasInsertadas = comando.ExecuteNonQuery();
                }
            }
            return filasInsertadas > 0;
        }
        public bool Actualizar(Cliente cliente)
        {
            int filasActualizadas = 0;
            using (var conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();
                var updatesql = "UPDATE Cliente (Nombres, Apellidos, Correo, Observacion, Ciudad) VALUES(@Nombres,@Apellidos ,@Correo ,@Observacion ,@Ciudad) WHERE (IdCliente = @Id)";
                using (var comando = new SqlCommand(updatesql, conexion))
                {
                    comando.Parameters.AddWithValue("@Nombres", cliente.Nombres);
                    comando.Parameters.AddWithValue("@Apellidos", cliente.Apellidos);
                    comando.Parameters.AddWithValue("@Correo", cliente.Correo);
                    comando.Parameters.AddWithValue("@Observacion", cliente.Observacion);
                    comando.Parameters.AddWithValue("@Ciudad", cliente.Ciudad);
                    comando.Parameters.AddWithValue("@Id", cliente.IdCliente);
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
                var deletesql = "DELETE FROM Cliente WHERE IdCliente = @Id";
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


