using MySql.Data.MySqlClient;
using Syscom.Controlador;
using Syscom.Modelo;
using Syscom.View;

namespace Syscom
{
    public partial class Login : Form
    {
        private ConexionBD conexionBD = new ConexionBD();
        private MySqlConnection conexion; // Asegúrate de que esta variable esté configurada con tu conexión a la base de datos.
        private LoginController loginController;
        public Login()
        {
            InitializeComponent();
            loginController = new LoginController(conexion);
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
            string contrasena = txtPass.Text;

            // Llama al método de inicio de sesión del controlador
            UsuariosModel usuarioModel = loginController.IniciarSesion(usuario, contrasena);

            if (usuarioModel != null)
            {
                // Inicio de sesión exitoso
                MessageBox.Show("Inicio de sesión exitoso", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Muestra el rol del usuario en el label
                lblRol.Text = "Usted ha iniciado sesión como: " + usuarioModel.Rol;

                // Aquí puedes redirigir al Dashboard o realizar otras acciones según el rol
            }
            else
            {
                // Inicio de sesión fallido
                MessageBox.Show("Inicio de sesión fallido. Compruebe su usuario y contraseña.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            Dashboard frmMenu = new Dashboard();

            frmMenu.ShowDialog();
        }
    }


}