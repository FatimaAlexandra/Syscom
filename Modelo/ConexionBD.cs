using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syscom.Modelo
{
    internal class ConexionBD
    {

        private MySqlConnection conexion;
        private string servidor = "127.0.0.1";
        private string baseDeDatos = "Syscom";
        private string usuario = "root";
        private string contraseña = "12345";

        public ConexionBD()
        {
            string cadenaConexion = $"Server={servidor};Database={baseDeDatos};User ID={usuario};Password={contraseña};";

            try
            {
                conexion = new MySqlConnection(cadenaConexion);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al establecer la conexión a la base de datos: " + ex.Message);
            }
        }

        public MySqlConnection ObtenerConexion()
        {
            if (conexion.State != System.Data.ConnectionState.Open)
            {
                conexion.Open();
            }
            return conexion;
        }

        public void CerrarConexion()
        {
            if (conexion.State == System.Data.ConnectionState.Open)
            {
                conexion.Close();
            }
        }
    }
}
