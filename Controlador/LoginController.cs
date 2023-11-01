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
        private ConexionBD conexion;

        public LoginController()
        {
            conexion = new ConexionBD();
        }

        public bool AutenticarUsuario( string usuario, string pass, out string rol)
        {
            rol = null;
            try
            {
                using (MySqlConnection conn = conexion.ObtenerConexion())
                {
                    string query = "SELECT rol FROM Usuarios WHERE usuario = @usuario AND pass = @pass";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@usuario", usuario);
                        cmd.Parameters.AddWithValue("@pass", pass);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                rol = reader.GetString("rol");
                                return true;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al autenticar el usuario: " + ex.Message);
            }

            return false;
        }


    }
}
