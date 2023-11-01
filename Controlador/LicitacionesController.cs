using MySql.Data.MySqlClient;
using Syscom.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
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
                        comando.CommandText = "INSERT INTO Licitaciones (titulo, descripcion, fecha_inicio, fecha_fin, ganador, estado, id_cliente) " +
                                            "VALUES (@titulo, @descripcion, @fechaInicio, @fechaFin, @ganador, @estado, @idCliente)";
                        comando.Parameters.AddWithValue("@titulo", titulo);
                        comando.Parameters.AddWithValue("@descripcion", descripcion);
                        comando.Parameters.AddWithValue("@fechaInicio", fechaInicio);
                        comando.Parameters.AddWithValue("@fechaFin", fechaFin);
                        comando.Parameters.AddWithValue("@ganador", DBNull.Value);  // Valor nulo
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


    }
}
