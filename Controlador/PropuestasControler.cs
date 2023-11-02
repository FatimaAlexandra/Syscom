using MySql.Data.MySqlClient;
using Syscom.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syscom.Controlador
{
    internal class PropuestasControler
    {
        private ConexionBD connection;

        public PropuestasControler() 
        {
            connection = new ConexionBD();
        }

        public void AgregarPropuestaEconomica(PropuestasModelo propuestas)
        {
            try
            {
                MySqlConnection conexion = connection.ObtenerConexion();

                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = conexion;
                    cmd.CommandText = "INSERT INTO PropuestasEconomicas (id_licitacion, id_proveedor, precio) " +
                                      "VALUES (@idLicitacion, @idProveedor, @precio)";
                    cmd.Parameters.AddWithValue("@idLicitacion", propuestas.ID_licitacion);
                    cmd.Parameters.AddWithValue("@idProveedor", propuestas.ID_proveedor);
                    cmd.Parameters.AddWithValue("@precio", propuestas.Precio);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (MySqlException ex)
            {
                // Manejar excepciones de MySQL, si es necesario
                Console.WriteLine("Error MySQL: " + ex.Message);
            }
            finally
            {
                connection.CerrarConexion();
            }
        }

        public void EliminarPropuestaEconomica(int id)
        {
            try
            {
                MySqlConnection conexion = connection.ObtenerConexion();


                string query = "DELETE FROM PropuestasEconomicas WHERE id = @id";

                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = conexion;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (MySqlException ex)
            {
                // Manejar excepciones de MySQL, si es necesario
                Console.WriteLine("Error MySQL: " + ex.Message);
            }
            finally
            {
                connection.CerrarConexion();
            }
        }

        public List<PropuestasModelo> ObtenerPropuestas()
        {

                List<PropuestasModelo> listaPropuestas = new List<PropuestasModelo>();
                MySqlConnection conexion = connection.ObtenerConexion();
                string query = "SELECT id, id_licitacion, id_proveedor, precio FROM PropuestasEconomicas";

                using (MySqlCommand comando = new MySqlCommand())
                {
                    comando.Connection = conexion;
                    comando.CommandText = query;
                    using (MySqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            PropuestasModelo propuesta = new PropuestasModelo
                            {
                                Id = reader.GetInt32("id"),
                                ID_licitacion = reader.GetInt32("id_licitacion"),
                                ID_proveedor = reader.GetInt32("id_proveedor"),
                                Precio = reader.GetDouble("precio")
                            };
                            listaPropuestas.Add(propuesta);
                        }
                    }
                }
                connection.CerrarConexion();
                return listaPropuestas;           
        }
    }
}
