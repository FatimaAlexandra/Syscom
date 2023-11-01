using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using Syscom.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syscom.Controlador
{
    internal class UsuarioController
    {
        private ConexionBD conexionBD;

        public UsuarioController()
        {
            conexionBD = new ConexionBD();
        }

        public void InsertarUsuario(UsuariosModel usuarios)
        {
            MySqlConnection conexion = conexionBD.ObtenerConexion();
            using (MySqlCommand comando = new MySqlCommand())
            {
                comando.Connection = conexion;
                comando.CommandText = "INSERT INTO Usuarios (usuario, pass, email, rol) VALUES (@usuario, @pass, @email, @rol)";
                comando.Parameters.AddWithValue("@usuario", usuarios.Usuario);
                comando.Parameters.AddWithValue("@pass", usuarios.Pass);
                comando.Parameters.AddWithValue("@email", usuarios.Email);
                comando.Parameters.AddWithValue("@rol", usuarios.Rol);
                comando.ExecuteNonQuery();
            }
            conexionBD.CerrarConexion();
        }

        public List<UsuariosModel> ObtenerUsuarios()
        {
            List<UsuariosModel> listaUsuarios = new List<UsuariosModel>();

            MySqlConnection conexion = conexionBD.ObtenerConexion();
            using (MySqlCommand comando = new MySqlCommand())
            {
                comando.Connection = conexion;
                comando.CommandText = "SELECT id, usuario, pass, email, rol FROM Usuarios";

                using (MySqlDataReader reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        UsuariosModel usuarios = new UsuariosModel
                        {
                            Id = reader.GetInt32("id"),
                            Usuario = reader.GetString("usuario"),
                            Pass = reader.GetString("pass"),
                            Email = reader.GetString("email"),
                            Rol = reader.GetString("rol")
                        };
                        listaUsuarios.Add(usuarios);
                    }
                }
            }
            conexionBD.CerrarConexion();

            return listaUsuarios;
        }

        //Editar usuario
        public void ActualizarUsuarios(UsuariosModel usuarios)
        {
            MySqlConnection conexion = conexionBD.ObtenerConexion();
            using (MySqlCommand comando = new MySqlCommand())
            {
                comando.Connection = conexion;
                comando.CommandText = "UPDATE Usuarios SET usuario = @usuario, pass = @pass, email = @email, rol = @rol WHERE id = @id";
                comando.Parameters.AddWithValue("@usuario", usuarios.Usuario);
                comando.Parameters.AddWithValue("@pass", usuarios.Pass);
                comando.Parameters.AddWithValue("@email", usuarios.Email);
                comando.Parameters.AddWithValue("@rol", usuarios.Rol);
                comando.Parameters.AddWithValue("@id", usuarios.Id);
                comando.ExecuteNonQuery();
            }
            conexionBD.CerrarConexion();
        }

        //Eliminar Usuario
        public void EliminarUsuario(int usuarioId)
        {
            MySqlConnection conexion = conexionBD.ObtenerConexion();
            using (MySqlCommand comando = new MySqlCommand())
            {
                comando.Connection = conexion;
                comando.CommandText = "DELETE FROM Usuarios WHERE id = @id";
                comando.Parameters.AddWithValue("@id", usuarioId);
                comando.ExecuteNonQuery();
            }
            conexionBD.CerrarConexion();
        }



        public int ObtenerIdClientePorNombreUsuario(string nombreUsuario)
        {
            int idCliente = -1; // Valor predeterminado en caso de que no se encuentre un cliente

            using (ConexionBD conexionBD = new ConexionBD())
            {
                MySqlConnection conexion = conexionBD.ObtenerConexion();

                try
                {
                    using (MySqlCommand comando = new MySqlCommand())
                    {
                        comando.Connection = conexion;
                        comando.CommandText = "SELECT id FROM Clientes WHERE id_usuario = (SELECT id FROM Usuarios WHERE usuario = @nombreUsuario)";
                        comando.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);

                        using (MySqlDataReader reader = comando.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                idCliente = reader.GetInt32("id");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Manejo de excepciones, muestra un mensaje de error o registra la excepción
                    Console.WriteLine("Error al obtener el ID de cliente: " + ex.Message);
                    MessageBox.Show("Error al obtener el ID de cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return idCliente;
        }



    }
}
