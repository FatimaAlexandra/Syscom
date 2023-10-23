using MySql.Data.MySqlClient;
using Syscom.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syscom.Controlador
{
    internal class ProveedoresController
    {
        private ConexionBD conexionBD;

        public ProveedoresController()
        {
            conexionBD = new ConexionBD();
        }

        public void InsertarProveedor(ProveedoresModel proveedor)
        {
            MySqlConnection conexion = conexionBD.ObtenerConexion();
            using (MySqlCommand comando = new MySqlCommand())
            {
                comando.Connection = conexion;
                comando.CommandText = "INSERT INTO Proveedores (nombre, email, telefono, empresa) VALUES (@nombre, @email, @telefono, @empresa)";
                comando.Parameters.AddWithValue("@nombre", proveedor.Nombre);
                comando.Parameters.AddWithValue("@email", proveedor.Email);
                comando.Parameters.AddWithValue("@telefono", proveedor.Telefono);
                comando.Parameters.AddWithValue("@empresa", proveedor.Empresa);
                comando.ExecuteNonQuery();
            }
            conexionBD.CerrarConexion();
        }

        public List<ProveedoresModel> ObtenerProveedores()
        {
            List<ProveedoresModel> listaProveedores = new List<ProveedoresModel>();

            MySqlConnection conexion = conexionBD.ObtenerConexion();
            using (MySqlCommand comando = new MySqlCommand())
            {
                comando.Connection = conexion;
                comando.CommandText = "SELECT id, nombre, email, telefono, empresa FROM Proveedores";

                using (MySqlDataReader reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ProveedoresModel proveedor = new ProveedoresModel
                        {
                            Id = reader.GetInt32("id"),
                            Nombre = reader.GetString("nombre"),
                            Email = reader.GetString("email"),
                            Telefono = reader.GetString("telefono"),
                            Empresa = reader.GetString("empresa")
                        };
                        listaProveedores.Add(proveedor);
                    }
                }
            }
            conexionBD.CerrarConexion();

            return listaProveedores;
        }

        public void ActualizarProveedor(ProveedoresModel proveedor)
        {
            MySqlConnection conexion = conexionBD.ObtenerConexion();
            using (MySqlCommand comando = new MySqlCommand())
            {
                comando.Connection = conexion;
                comando.CommandText = "UPDATE Proveedores SET nombre = @nombre, email = @email, telefono = @telefono, empresa = @empresa WHERE id = @id";
                comando.Parameters.AddWithValue("@nombre", proveedor.Nombre);
                comando.Parameters.AddWithValue("@email", proveedor.Email);
                comando.Parameters.AddWithValue("@telefono", proveedor.Telefono);
                comando.Parameters.AddWithValue("@empresa", proveedor.Empresa);
                comando.Parameters.AddWithValue("@id", proveedor.Id);
                comando.ExecuteNonQuery();
            }
            conexionBD.CerrarConexion();
        }

        public void EliminarProveedor(int proveedorId)
        {
            MySqlConnection conexion = conexionBD.ObtenerConexion();
            using (MySqlCommand comando = new MySqlCommand())
            {
                comando.Connection = conexion;
                comando.CommandText = "DELETE FROM Proveedores WHERE id = @id";
                comando.Parameters.AddWithValue("@id", proveedorId);
                comando.ExecuteNonQuery();
            }
            conexionBD.CerrarConexion();
        }
    }
}
