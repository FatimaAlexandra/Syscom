using MySql.Data.MySqlClient;
using Syscom.Controlador;
using Syscom.Modelo;
using Syscom.View;

namespace Syscom
{
    public partial class Login : Form
    {
        private ConexionBD conexionBD = new ConexionBD();
        private MySqlConnection conexion; // Aseg�rate de que esta variable est� configurada con tu conexi�n a la base de datos.
        private LoginController loginController;
        public Login()
        {
            InitializeComponent();
            loginController = new LoginController();
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
                    lblEstadoConexion.Text = "Conexi�n exitosa";
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

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario de proveedores
            FormularioProveedores formProveedores = new FormularioProveedores();

            // Mostrar el formulario de proveedores
            formProveedores.ShowDialog();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string pass = txtPass.Text;

            if (loginController.AutenticarUsuario(usuario, pass, out string rol))
            {
                Dashboard frmMenu = new Dashboard(usuario, rol);    
                frmMenu.ShowDialog();
                Limpiar();

            }
            else
            {
                MessageBox.Show("Usuario o contrase�a incorrectos. Por favor, int�ntelo de nuevo.");
                Limpiar();
            }
        }
        private void Limpiar()
        {
            txtUsuario.Text = string.Empty;
            txtPass.Text = string.Empty;
        }


        private void btnMenu_Click(object sender, EventArgs e)
        {
            
        }
    }


}