using MySql.Data.MySqlClient;
using Syscom.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syscom.Controlador
{
    internal class ProductosController
    {

        public bool AgregarProducto(string nombre, string descripcion, decimal precioUnitario, int cantidad, int idLicitacion)
        {
            using (ConexionBD conexionBD = new ConexionBD())
            {
                MySqlConnection conexion = conexionBD.ObtenerConexion();

                try
                {
                    using (MySqlCommand comando = new MySqlCommand())
                    {
                        comando.Connection = conexion;
                        comando.CommandText = "INSERT INTO Productos (nombre_producto, descripcion, precio_unitario, cantidad, id_licitacion) " +
                                            "VALUES (@nombre, @descripcion, @precioUnitario, @cantidad, @idLicitacion)";
                        comando.Parameters.AddWithValue("@nombre", nombre);
                        comando.Parameters.AddWithValue("@descripcion", descripcion);
                        comando.Parameters.AddWithValue("@precioUnitario", precioUnitario);
                        comando.Parameters.AddWithValue("@cantidad", cantidad);
                        comando.Parameters.AddWithValue("@idLicitacion", idLicitacion);
                        comando.ExecuteNonQuery();
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    // Manejo de excepciones
                    Console.WriteLine("Error al insertar el producto: " + ex.Message);
                    return false;
                }
            }
        }

        public List<ProductosModel> ObtenerProductosPorLicitacion(int idLicitacion)
        {
            List<ProductosModel> productos = new List<ProductosModel>();

            using (ConexionBD conexionBD = new ConexionBD())
            {
                MySqlConnection conexion = conexionBD.ObtenerConexion();

                try
                {
                    using (MySqlCommand comando = new MySqlCommand())
                    {
                        comando.Connection = conexion;
                        comando.CommandText = "SELECT * FROM Productos WHERE idLicitacion = @idLicitacion";
                        comando.Parameters.AddWithValue("@idLicitacion", idLicitacion);

                        using (MySqlDataReader reader = comando.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                ProductosModel producto = new ProductosModel
                                {
                                    Id = Convert.ToInt32(reader["id"]),
                                    NombreProducto = reader["nombre_producto"].ToString(),
                                    Descripcion = reader["descripcion"].ToString(),
                                    PrecioUnitario = Convert.ToDecimal(reader["precio_unitario"]),
                                    Cantidad = Convert.ToInt32(reader["cantidad"])
                                    // Agrega más propiedades según tu modelo
                                };

                                productos.Add(producto);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Manejo de excepciones
                    Console.WriteLine("Error al obtener productos por licitación: " + ex.Message);
                }
            }

            return productos;
        }





    }
}
