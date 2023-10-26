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
    internal class ClientesController
    {
        private ConexionBD conexionBD;

        public ClientesController()
        {
            conexionBD = new ConexionBD();
        }

        public void InsertarCliente(ClientesModel cliente)
        {
            using (ConexionBD conexionBD = new ConexionBD())
            {
                MySqlConnection conexion = conexionBD.ObtenerConexion();
                try
                {
                    // No es necesario abrir la conexión manualmente, ya que se hace automáticamente dentro del using

                    using (MySqlCommand comando = new MySqlCommand())
                    {
                        comando.Connection = conexion;
                        comando.CommandText = "INSERT INTO Clientes (nombre, email, telefono, empresa, id_usuario) VALUES (@nombre, @email, @telefono, @empresa, @idUsuario)";
                        comando.Parameters.AddWithValue("@nombre", cliente.Nombre);
                        comando.Parameters.AddWithValue("@email", cliente.Email);
                        comando.Parameters.AddWithValue("@telefono", cliente.Telefono);
                        comando.Parameters.AddWithValue("@empresa", cliente.Empresa);
                        comando.Parameters.AddWithValue("@idUsuario", cliente.IdUsuario);
                        comando.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    // Manejo de excepciones, muestra un mensaje de error o registra la excepción
                    MessageBox.Show("Error al insertar el cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                // La conexión se cerrará automáticamente al salir del bloque 'using'
            }
        }

        public List<ClientesModel> ObtenerClientes()
        {
            List<ClientesModel> listaClientes = new List<ClientesModel>();

            using (ConexionBD conexionBD = new ConexionBD())
            {
                MySqlConnection conexion = conexionBD.ObtenerConexion();
                try
                {
                    // No es necesario abrir la conexión manualmente, ya que se hace automáticamente dentro del using

                    using (MySqlCommand comando = new MySqlCommand())
                    {
                        comando.Connection = conexion;
                        comando.CommandText = "SELECT id, nombre, email, telefono, empresa, id_usuario FROM Clientes";

                        using (MySqlDataReader reader = comando.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                ClientesModel cliente = new ClientesModel
                                {
                                    Id = reader.GetInt32("id"),
                                    Nombre = reader.GetString("nombre"),
                                    Email = reader.GetString("email"),
                                    Telefono = reader.GetString("telefono"),
                                    Empresa = reader.GetString("empresa"),
                                    IdUsuario = reader.GetInt32("id_usuario")
                                };
                                listaClientes.Add(cliente);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Manejo de excepciones, muestra un mensaje de error o registra la excepción
                    MessageBox.Show("Error al obtener los clientes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                // La conexión se cerrará automáticamente al salir del bloque 'using'
            }

            return listaClientes;
        }



        //Llenar ComboBox con usuarios de la base de datos
        public List<UsuariosModel> ObtenerUsuarios()
        {
            List<UsuariosModel> listaUsuarios = new List<UsuariosModel>();

            MySqlConnection conexion = conexionBD.ObtenerConexion();
            using (MySqlCommand comando = new MySqlCommand())
            {
                comando.Connection = conexion;
                comando.CommandText = "SELECT id, usuario FROM Usuarios"; // Ajusta la consulta según tu estructura de base de datos

                using (MySqlDataReader reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        UsuariosModel usuario = new UsuariosModel
                        {
                            Id = reader.GetInt32("id"),
                            Usuario = reader.GetString("usuario")
                        };
                        listaUsuarios.Add(usuario);
                    }
                }
            }
            conexionBD.CerrarConexion();

            return listaUsuarios;
        }


        //método para modificar la información de los clientes
        public void ActualizarCliente(ClientesModel cliente)
        {
            MySqlConnection conexion = conexionBD.ObtenerConexion();
            using (MySqlCommand comando = new MySqlCommand())
            {
                comando.Connection = conexion;
                comando.CommandText = "UPDATE Clientes SET nombre = @nombre, email = @email, telefono = @telefono, empresa = @empresa WHERE id = @id";
                comando.Parameters.AddWithValue("@nombre", cliente.Nombre);
                comando.Parameters.AddWithValue("@email", cliente.Email);
                comando.Parameters.AddWithValue("@telefono", cliente.Telefono);
                comando.Parameters.AddWithValue("@empresa", cliente.Empresa);
                comando.Parameters.AddWithValue("@id", cliente.Id);
                comando.ExecuteNonQuery();
            }
            conexionBD.CerrarConexion();
        }


        //método para eliminar clientes 

        public void EliminarCliente(int clienteId)
        {
            MySqlConnection conexion = conexionBD.ObtenerConexion();
            using (MySqlCommand comando = new MySqlCommand())
            {
                comando.Connection = conexion;
                comando.CommandText = "DELETE FROM Clientes WHERE id = @id";
                comando.Parameters.AddWithValue("@id", clienteId);
                comando.ExecuteNonQuery();
            }
            conexionBD.CerrarConexion();
        }

        public List<ClientesModel> ObtenerClientesConNombres()
        {
            MySqlConnection conexion = conexionBD.ObtenerConexion();
            List<ClientesModel> listaClientes = new List<ClientesModel>();

            using (MySqlCommand comando = new MySqlCommand("SELECT id, empresa FROM Clientes", conexion))
            {
                using (MySqlDataReader reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = reader.GetInt32("id");
                        string empresa = reader.GetString("empresa");
                        listaClientes.Add(new ClientesModel { Id = id, Empresa = empresa });
                    }
                }
            }

            return listaClientes;
        }

    }
}
