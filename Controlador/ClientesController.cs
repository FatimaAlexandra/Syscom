using MySql.Data.MySqlClient;
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
            MySqlConnection conexion = conexionBD.ObtenerConexion();
            using (MySqlCommand comando = new MySqlCommand())
            {
                comando.Connection = conexion;
                comando.CommandText = "INSERT INTO Clientes (nombre, email, telefono, empresa) VALUES (@nombre, @email, @telefono, @empresa)";
                comando.Parameters.AddWithValue("@nombre", cliente.Nombre);
                comando.Parameters.AddWithValue("@email", cliente.Email);
                comando.Parameters.AddWithValue("@telefono", cliente.Telefono);
                comando.Parameters.AddWithValue("@empresa", cliente.Empresa);
                comando.ExecuteNonQuery();
            }
            conexionBD.CerrarConexion();
        }
        public List<ClientesModel> ObtenerClientes()
        {
            List<ClientesModel> listaClientes = new List<ClientesModel>();

            MySqlConnection conexion = conexionBD.ObtenerConexion();
            using (MySqlCommand comando = new MySqlCommand())
            {
                comando.Connection = conexion;
                comando.CommandText = "SELECT id, nombre, email, telefono, empresa FROM Clientes";

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
                            Empresa = reader.GetString("empresa")
                        };
                        listaClientes.Add(cliente);
                    }
                }
            }
            conexionBD.CerrarConexion();

            return listaClientes;
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
    }
}
