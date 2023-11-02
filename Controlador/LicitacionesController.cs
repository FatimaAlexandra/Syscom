using MySql.Data.MySqlClient;
using Syscom.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Syscom.Controlador
{
    internal class LicitacionesController
    {

        public bool AgregarLicitacion(string titulo, string descripcion, DateTime fechaInicio, DateTime fechaFin, int idCliente)
        {
            using (ConexionBD conexionBD = new ConexionBD())
            {
                MySqlConnection conexion = conexionBD.ObtenerConexion();

                try
                {
                    using (MySqlCommand comando = new MySqlCommand())
                    {
                        comando.Connection = conexion;
                        comando.CommandText = "INSERT INTO Licitaciones (titulo, descripcion, fecha_inicio, fecha_fin, estado, id_cliente) " +
                                            "VALUES (@titulo, @descripcion, @fechaInicio, @fechaFin, @estado, @idCliente)";
                        comando.Parameters.AddWithValue("@titulo", titulo);
                        comando.Parameters.AddWithValue("@descripcion", descripcion);
                        comando.Parameters.AddWithValue("@fechaInicio", fechaInicio);
                        comando.Parameters.AddWithValue("@fechaFin", fechaFin);
                        comando.Parameters.AddWithValue("@estado", "0");  // Supongo que el estado debe ser una cadena
                        comando.Parameters.AddWithValue("@idCliente", idCliente);
                        comando.ExecuteNonQuery();
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    // Manejo de excepciones
                    Console.WriteLine("Error al insertar la licitación: " + ex.Message);
                    return false;
                }
            }
        }


        public LicitacionesModel ObtenerLicitacionPorID(int idLicitacion)
        {
            LicitacionesModel licitacion = null;

            using (ConexionBD conexionBD = new ConexionBD())
            {
                MySqlConnection conexion = conexionBD.ObtenerConexion();

                try
                {
                    using (MySqlCommand comando = new MySqlCommand())
                    {
                        comando.Connection = conexion;
                        comando.CommandText = "SELECT * FROM Licitaciones WHERE id = @idLicitacion";
                        comando.Parameters.AddWithValue("@idLicitacion", idLicitacion);

                        using (MySqlDataReader reader = comando.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                licitacion = new LicitacionesModel
                                {
                                    Id = reader.GetInt32("id"),
                                    Titulo = reader.GetString("titulo"),
                                    Descripcion = reader.GetString("descripcion"),
                                    FechaInicio = reader.GetDateTime("fecha_inicio"),
                                    FechaFin = reader.GetDateTime("fecha_fin"),
                                    Estado = reader.IsDBNull("estado") ? null : reader.GetString("estado"),
                                    IdCliente = reader.GetInt32("id_cliente")
                                };
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Manejo de excepciones
                    Console.WriteLine("Error al obtener los detalles de la licitación: " + ex.Message);
                }
            }

            return licitacion;
        }

        private int ObtenerIdDeLaLicitacionRecienAgregada()
        {
            int idLicitacionAgregada = -1;  // Valor predeterminado en caso de error

            // Supongamos que estás utilizando MySQL
            using (ConexionBD conexionBD = new ConexionBD())
            {
                MySqlConnection conexion = conexionBD.ObtenerConexion();

                try
                {
                    using (MySqlCommand comando = new MySqlCommand("SELECT LAST_INSERT_ID()", conexion))
                    {
                        // Ejecuta la consulta y obtén el ID generado automáticamente
                        idLicitacionAgregada = Convert.ToInt32(comando.ExecuteScalar());
                    }
                }
                catch (Exception ex)
                {
                    // Manejo de excepciones
                    Console.WriteLine("Error al obtener el ID de la licitación recién agregada: " + ex.Message);
                }
            }

            return idLicitacionAgregada;
        }



        //public bool LanzarLicitacion(int idLicitacion)
        //{
        //    using (ConexionBD conexionBD = new ConexionBD())
        //    {
        //        MySqlConnection conexion = conexionBD.ObtenerConexion();

        //        try
        //        {
        //            using (MySqlCommand comando = new MySqlCommand())
        //            {
        //                comando.Connection = conexion;
        //                comando.CommandText = "UPDATE Licitaciones SET Estado = 1 WHERE Id = @idLicitacion";
        //                comando.Parameters.AddWithValue("@idLicitacion", idLicitacion);
        //                int filasAfectadas = comando.ExecuteNonQuery();

        //                return filasAfectadas > 0;
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            // Manejo de excepciones
        //            Console.WriteLine("Error al lanzar la licitación: " + ex.Message);
        //            return false;
        //        }
        //    }

        //}



        public bool LanzarLicitacion(int idLicitacion)
        {
            using (ConexionBD conexionBD = new ConexionBD())
            {
                MySqlConnection conexion = conexionBD.ObtenerConexion();

                try
                {
                    using (MySqlCommand comando = new MySqlCommand())
                    {
                        // Obtener el id_cliente asociado a la licitación
                        comando.Connection = conexion;
                        comando.CommandText = "SELECT id_cliente FROM Licitaciones WHERE Id = @idLicitacion";
                        comando.Parameters.AddWithValue("@idLicitacion", idLicitacion);
                        int idCliente = Convert.ToInt32(comando.ExecuteScalar());

                        if (idCliente > 0)
                        {
                            // Ahora que tienes el id del cliente, puedes obtener su email
                            comando.CommandText = "SELECT email FROM Clientes WHERE id = @idCliente";
                            comando.Parameters.AddWithValue("@idCliente", idCliente);
                            string email = comando.ExecuteScalar().ToString();

                            // Actualizar el estado de la licitación
                            comando.CommandText = "UPDATE Licitaciones SET Estado = 1 WHERE Id = @idLicitacion";
                            comando.Parameters.Clear();
                            comando.Parameters.AddWithValue("@idLicitacion", idLicitacion);
                            int filasAfectadas = comando.ExecuteNonQuery();

                            if (filasAfectadas > 0)
                            {
                                // Enviar un correo al cliente
                                EnviarCorreo(email);
                                EnviarCorreosAProveedores();

                                return true;
                            }
                        }
                    }

                    return false;
                }
                catch (Exception ex)
                {
                    // Manejo de excepciones
                    Console.WriteLine("Error al lanzar la licitación: " + ex.Message);
                    return false;
                }
            }
        }
        private void EnviarCorreo(string destinatario)
        {
            using (SmtpClient smtpClient = new SmtpClient("smtp.gmail.com"))
            {
                smtpClient.Port = 587;
                smtpClient.Credentials = new NetworkCredential("diegocas2222@gmail.com", "ujvfkinedbpvqbmg");
                smtpClient.EnableSsl = true;

                using (MailMessage mensaje = new MailMessage())
                {
                    mensaje.From = new MailAddress("diegocas2222@gmail.com");
                    mensaje.To.Add(destinatario);
                    mensaje.Subject = "Licitaciones";
                    mensaje.Body = "Se han lanzado las licitaciones";

                    smtpClient.Send(mensaje);
                }
            }
        }

        private void EnviarCorreoProve(string destinatario, string asunto, string cuerpo)
        {
            using (SmtpClient smtpClient = new SmtpClient("smtp.gmail.com"))
            {
                smtpClient.Port = 587;
                smtpClient.Credentials = new NetworkCredential("diegocas2222@gmail.com", "ujvfkinedbpvqbmg");
                smtpClient.EnableSsl = true;

                using (MailMessage mensaje = new MailMessage())
                {
                    mensaje.From = new MailAddress("diegocas2222@gmail.com");
                    mensaje.To.Add(destinatario);
                    mensaje.Subject = asunto;
                    mensaje.Body = cuerpo;

                    smtpClient.Send(mensaje);
                }
            }
        }

        private void EnviarCorreosAProveedores()
        {
            using (ConexionBD conexionBD = new ConexionBD())
            {
                MySqlConnection conexion = conexionBD.ObtenerConexion();

                try
                {
                    using (MySqlCommand comando = new MySqlCommand())
                    {
                        comando.Connection = conexion;
                        comando.CommandText = "SELECT email FROM Proveedores";

                        using (MySqlDataReader reader = comando.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string emailProveedor = reader["email"].ToString();
                                EnviarCorreoProve(emailProveedor, "NUEVAS LICITACIONES", "Envie su oferta economica lo antes posible");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Manejo de excepciones
                    Console.WriteLine("Error al enviar correos a proveedores: " + ex.Message);
                }
            }
        }







        public List<LicitacionesModel> ObtenerLicitacionesConEstado1()
        {
            List<LicitacionesModel> licitaciones = new List<LicitacionesModel>();

            using (ConexionBD conexionBD = new ConexionBD())
            {
                MySqlConnection conexion = conexionBD.ObtenerConexion();

                try
                {
                    using (MySqlCommand comando = new MySqlCommand())
                    {
                        comando.Connection = conexion;
                        comando.CommandText = "SELECT * FROM Licitaciones WHERE estado = '1'";
                        using (MySqlDataReader reader = comando.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                LicitacionesModel licitacion = new LicitacionesModel
                                {
                                    Id = reader.GetInt32("id"),
                                    Titulo = reader.GetString("titulo"),
                                    Descripcion = reader.GetString("descripcion"),
                                    FechaInicio = reader.GetDateTime("fecha_inicio"),
                                    FechaFin = reader.GetDateTime("fecha_fin"),
                                    IdCliente = reader.GetInt32("id_cliente"),
                                    Estado = reader.GetString("estado")
                                };
                                licitaciones.Add(licitacion);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Manejo de excepciones
                    Console.WriteLine("Error al obtener las licitaciones: " + ex.Message);
                }
            }

            return licitaciones;
        }







    }
}
