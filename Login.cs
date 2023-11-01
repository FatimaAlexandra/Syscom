using MySql.Data.MySqlClient;
using Syscom.Controlador;
using Syscom.Modelo;
using Syscom.View;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


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
            loginController = new LoginController();
            lblEstadoConexion.Visible = false;
        }

        private void lblEstadoConexion_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtPass.PasswordChar = '*';
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
            string pass = txtPass.Text;

            if (loginController.AutenticarUsuario(usuario, pass, out string rol))
            {
                Dashboard frmMenu = new Dashboard(usuario, rol);
                frmMenu.ShowDialog();
                Limpiar();

            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos. Por favor, inténtelo de nuevo.");
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

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            // Si el PasswordChar actual es '*', cambia a '\0'(sin censura).// De lo contrario, cambia de vuelta a '*' para ocultar la contraseña.
            if (txtPass.PasswordChar == '*')
            {
                txtPass.PasswordChar = '\0'; // Mostrar la contraseña sin censura
            }
            else
            {
                txtPass.PasswordChar = '*'; // Ocultar la contraseña con asteriscos
            }

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel4_Click(object sender, EventArgs e)
        {

        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }


}