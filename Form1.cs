using MySql.Data.MySqlClient;
using Syscom.Modelo;
using Syscom.View;

namespace Syscom
{
    public partial class Form1 : Form
    {
        private ConexionBD conexionBD = new ConexionBD();
        public Form1()
        {
            InitializeComponent();
        }

        private void lblEstadoConexion_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection conexion = conexionBD.ObtenerConexion();
                if (conexion.State == System.Data.ConnectionState.Open)
                {
                    lblEstadoConexion.Text = "Conexión exitosa";
                }
                else
                {
                    lblEstadoConexion.Text = "Error al conectar a la base de datos";
                }
            }
            catch (Exception ex)
            {
                lblEstadoConexion.Text = "Error al conectar a la base de datos: " + ex.Message;
            }
        }

        private void btnCrudClientes_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario de clientes
            FormularioClientes formClientes = new FormularioClientes();

            // Mostrar el formulario de clientes (modal) - Bloquea Form1 hasta que se cierre el formulario de clientes
            formClientes.ShowDialog();
        }
    }
}