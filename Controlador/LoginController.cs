using MySql.Data.MySqlClient;
using Syscom.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syscom.Controlador
{
    internal class LoginController
    {
        private ConexionBD conexionBD;

        public LoginController(MySqlConnection conexion)
        {
            conexionBD = new ConexionBD();
        }

        public UsuariosModel IniciarSesion(string usuario, string contrasena)
        {
            MySqlConnection conexion = conexionBD.ObtenerConexion();

            try
            {
                conexion.Open();

                // Consulta para verificar si el usuario y la contraseña son válidos.
                string consulta = "SELECT * FROM Usuarios WHERE usuario = @usuario AND pass = @contrasena";
                MySqlCommand comando = new MySqlCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@usuario", usuario);
                comando.Parameters.AddWithValue("@contrasena", contrasena);

                using (MySqlDataReader reader = comando.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        UsuariosModel usuarioModel = new UsuariosModel
                        {
                            Id = reader.GetInt32("id"),
                            Usuario = reader.GetString("usuario"),
                            Pass = reader.GetString("pass"),
                            Email = reader.GetString("email"),
                            Rol = reader.GetString("rol")
                        };

                        return usuarioModel;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en el inicio de sesión: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }

            return null; // En caso de no encontrar un usuario válido.
        }
    }
}
