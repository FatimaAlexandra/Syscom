using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using Syscom.Controlador;
using Syscom.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Syscom.View
{
    public partial class FormularioLicitaciones : Form
    {
        private string usuario;
        private UsuarioController usuariosController;

        private UsuarioController usuarioController = new UsuarioController();
        private ClientesModel clienteSeleccionado;
        public FormularioLicitaciones(string usuario)
        {
            InitializeComponent();
            usuariosController = new UsuarioController();
            btnAgregarProductos.Enabled = false;
            btnGenerarLicitacion.Enabled = true;
            btnLanzarLicitacion.Enabled = false;



            // Obtén el ID del cliente actual
            int idClienteActual = usuarioController.ObtenerIdClientePorNombreUsuario(usuario);

            // Muestra el ID del cliente en el TextBox
            MostrarIdCliente(idClienteActual);

        }
        private void MostrarIdCliente(int idCliente)
        {
            // Asigna el ID del cliente al TextBox
            txtIdCliente.Text = idCliente.ToString();
        }


        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarProductos_Click(object sender, EventArgs e)
        {
            FormularioProductos frmProductos = new FormularioProductos();

            frmProductos.ShowDialog();
        }

        private void FormularioLicitaciones_Load(object sender, EventArgs e)
        {

        }

        private void cmbIdCliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void lblUsuario_Click(object sender, EventArgs e)
        {

        }

        private void cmbClientes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSleccionarCliente_Click(object sender, EventArgs e)
        {

        }

        private void btnGenerarLicitacion_Click(object sender, EventArgs e)
        {
            // Obtener los valores de los controles en el formulario
            string titulo = txtTitulo.Text;
            string descripcion = txtDescripcion.Text;
            DateTime fechaInicio = tpFechaInicio.Value;
            DateTime fechaFin = tpFechaFin.Value;

            // Obtener el id del cliente desde el cuadro de texto txtIdCliente
            int idCliente;
            if (int.TryParse(txtIdCliente.Text, out idCliente))
            {
                // Crear una instancia de LicitacionesController
                LicitacionesController licitacionesController = new LicitacionesController();

                // Intentar agregar la licitación usando la instancia de licitacionesController
                if (licitacionesController.AgregarLicitacion(titulo, descripcion, fechaInicio, fechaFin, idCliente))
                {
                    // Inserción exitosa, muestra un mensaje de confirmación
                    MessageBox.Show("Licitación agregada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Limpia los campos después de la inserción exitosa
                    LimpiarCampos();
                    btnAgregarProductos.Enabled = true;
                    btnGenerarLicitacion.Enabled = false;

                    // Obtener el ID de la licitación recién agregada
                    int idLicitacionAgregada = ObtenerIdDeLaLicitacionRecienAgregada();

                    // Usar idLicitacionAgregada para cargar los datos en los campos
                    CargarDatosDeLicitacion(idLicitacionAgregada);
                }
                else
                {
                    // Error durante la inserción, muestra un mensaje de error
                    MessageBox.Show("Error al agregar la licitación. Por favor, inténtelo de nuevo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnGenerarLicitacion.Enabled = true;
                }
            }
            else
            {
                // El valor en txtIdCliente no es un número válido
                MessageBox.Show("El ID del cliente debe ser un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private int ObtenerIdDeLaLicitacionRecienAgregada()
        {
            int idLicitacionAgregada = -1;  // Valor predeterminado en caso de error

            // Supongamos que estás utilizando MySQL
            using (ConexionBD conexionBD = new ConexionBD())
            {
                MySqlConnection conexion = conexionBD.ObtenerConexion();

                try
                {
                    using (MySqlCommand comando = new MySqlCommand("SELECT LAST_INSERT_ID()", conexion))
                    {
                        // Ejecuta la consulta y obtén el ID generado automáticamente
                        idLicitacionAgregada = Convert.ToInt32(comando.ExecuteScalar());
                    }
                }
                catch (Exception ex)
                {
                    // Manejo de excepciones
                    Console.WriteLine("Error al obtener el ID de la licitación recién agregada: " + ex.Message);
                }
            }

            return idLicitacionAgregada;
        }
        private void CargarDatosDeLicitacion(int idLicitacion)
        {
            using (ConexionBD conexionBD = new ConexionBD())
            {
                MySqlConnection conexion = conexionBD.ObtenerConexion();

                try
                {
                    using (MySqlCommand comando = new MySqlCommand())
                    {
                        comando.Connection = conexion;
                        comando.CommandText = "SELECT id, titulo, descripcion, fecha_inicio, fecha_fin, estado, id_cliente FROM Licitaciones WHERE id = @idLicitacion";
                        comando.Parameters.AddWithValue("@idLicitacion", idLicitacion);

                        using (MySqlDataReader reader = comando.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtId.Text = reader["id"].ToString();
                                txtTitulo.Text = reader["titulo"].ToString();
                                txtDescripcion.Text = reader["descripcion"].ToString();
                                tpFechaInicio.Value = Convert.ToDateTime(reader["fecha_inicio"]);
                                tpFechaFin.Value = Convert.ToDateTime(reader["fecha_fin"]);
                                txtEstado.Text = reader["estado"].ToString();
                                txtIdCliente.Text = reader["id_cliente"].ToString();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Manejo de excepciones
                    Console.WriteLine("Error al cargar los datos de la licitación: " + ex.Message);
                }
            }
        }




        // Método para limpiar los campos del formulario después de agregar una licitación
        private void LimpiarCampos()
        {
            txtId.Text = "";
            txtTitulo.Text = "";
            txtDescripcion.Text = "";
            tpFechaInicio.Value = DateTime.Now;
            tpFechaFin.Value = DateTime.Now;
        }
    }
}
