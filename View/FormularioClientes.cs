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
    public partial class FormularioClientes : Form
    {
        private ClientesController clientesController = new ClientesController();
        public FormularioClientes()
        {
            InitializeComponent();

            // En el constructor del formulario de clientes, carga automáticamente los clientes en el DataGridView.
            CargarClientesEnDataGridView();


        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            // Recopila los datos del cliente desde los controles en el formulario
            string nombre = txtNombre.Text;
            string email = txtEmail.Text;
            string telefono = txtTelefono.Text;
            string empresa = txtEmpresa.Text;

            // Obtiene el ID del usuario seleccionado en el ComboBox
            int idUsuario = Convert.ToInt32(cmbUsuarios.SelectedValue);


            // Crea una instancia de ClientesModel con los datos del cliente
            ClientesModel cliente = new ClientesModel
            {
                Nombre = nombre,
                Email = email,
                Telefono = telefono,
                Empresa = empresa,
                IdUsuario = idUsuario
            };

            // Llama al método para insertar el cliente
            try
            {
                clientesController.InsertarCliente(cliente);
                MessageBox.Show("Cliente insertado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpia los campos después de insertar el cliente
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar el cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            CargarClientesEnDataGridView();
        }
        private void Limpiar()
        {
            txtNombre.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            txtEmpresa.Text = string.Empty;
            cmbUsuarios.SelectedIndex = -1;
        }
        private void CargarClientesEnDataGridView()
        {
            dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Limpia el DataGridView antes de cargar los datos.
            dgvClientes.Rows.Clear();
            dgvClientes.Columns.Clear(); // Limpia las columnas también

            // Evitar que se agregue automáticamente una fila en blanco al final
            dgvClientes.AllowUserToAddRows = false;

            List<ClientesModel> listaClientes = clientesController.ObtenerClientes();

            // Agrega las columnas al DataGridView
            dgvClientes.Columns.Add("Id", "ID");
            dgvClientes.Columns.Add("Nombre", "Nombre");
            dgvClientes.Columns.Add("Email", "Email");
            dgvClientes.Columns.Add("Telefono", "Telefono");
            dgvClientes.Columns.Add("Empresa", "Empresa");
            dgvClientes.Columns.Add("IdUsuario", "IdUsuario");
            // Ocultar la columna "ID"
            dgvClientes.Columns["Id"].Visible = false;

            foreach (ClientesModel cliente in listaClientes)
            {
                dgvClientes.Rows.Add(cliente.Id, cliente.Nombre, cliente.Email, cliente.Telefono, cliente.Empresa, cliente.IdUsuario);
            }
        }
        private void FormularioClientes_Load(object sender, EventArgs e)
        {
            CargarClientesEnDataGridView();
            CargarUsuariosEnComboBox();
        }
        private void CargarUsuariosEnComboBox()
        {
            // Llama al método del controlador para obtener la lista de usuarios.
            List<UsuariosModel> listaUsuarios = clientesController.ObtenerUsuarios();

            // Limpia el ComboBox si ya tenía elementos.
            cmbUsuarios.Items.Clear();

            // Configura el ComboBox para mostrar el nombre y retener el id como el valor asociado.
            cmbUsuarios.DisplayMember = "Usuario"; // Nombre de la propiedad en UsuariosModel que contiene el nombre.
            cmbUsuarios.ValueMember = "Id"; // Nombre de la propiedad en UsuariosModel que contiene el id.

            // Agrega los usuarios al ComboBox.
            cmbUsuarios.DataSource = listaUsuarios;
        }



        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void dgvClientes_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count >= 0)
            {
                DataGridViewRow filaSeleccionada = dgvClientes.SelectedRows[0];
                int clienteId = Convert.ToInt32(filaSeleccionada.Cells["Id"].Value);
                string nombre = filaSeleccionada.Cells["Nombre"].Value.ToString();
                string email = filaSeleccionada.Cells["Email"].Value.ToString();
                string telefono = filaSeleccionada.Cells["Telefono"].Value.ToString();
                string empresa = filaSeleccionada.Cells["Empresa"].Value.ToString();
                int idUsuario = Convert.ToInt32(filaSeleccionada.Cells["IdUsuario"].Value);

                txtNombre.Text = nombre;
                txtEmail.Text = email;
                txtTelefono.Text = telefono;
                txtEmpresa.Text = empresa;

                // Establecer la selección en el ComboBox según el ID del usuario.
                cmbUsuarios.SelectedValue = idUsuario;

                txtNombre.Enabled = true;
                txtEmail.Enabled = true;
                txtTelefono.Enabled = true;
                txtEmpresa.Enabled = true;
            }
        }

        private void btnModificarCliente_Click(object sender, EventArgs e)
        {
            // Verificar si se ha seleccionado una fila en el DataGridView.
            if (dgvClientes.SelectedRows.Count > 0)
            {
                // Obtener el ID del cliente seleccionado.
                int clienteId = Convert.ToInt32(dgvClientes.SelectedRows[0].Cells["Id"].Value);

                // Crear un objeto ClientesModel con los datos modificados.
                ClientesModel clienteModificado = new ClientesModel
                {
                    Id = clienteId,
                    Nombre = txtNombre.Text,
                    Email = txtEmail.Text,
                    Telefono = txtTelefono.Text,
                    Empresa = txtEmpresa.Text,
                    IdUsuario = cmbUsuarios.SelectedIndex
                };

                // Llamar al método del controlador para actualizar el cliente.
                clientesController.ActualizarCliente(clienteModificado);

                // Deshabilitar los TextBox después de guardar los cambios.
                txtNombre.Enabled = false;
                txtEmail.Enabled = false;
                txtTelefono.Enabled = false;
                txtEmpresa.Enabled = false;
                cmbUsuarios.SelectedIndex = 0;

                // Limpiar los TextBox.
                Limpiar();

                // Mostrar un mensaje de "Cambios guardados exitosamente".
                MessageBox.Show("Cambios guardados exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Recargar la lista de clientes en el DataGridView después de la edición.
                CargarClientesEnDataGridView();
            }
        }

        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            // Verificar si se ha seleccionado una fila en el DataGridView.
            if (dgvClientes.SelectedRows.Count > 0)
            {
                // Obtener el ID del cliente seleccionado.
                int clienteId = Convert.ToInt32(dgvClientes.SelectedRows[0].Cells["Id"].Value);

                // Mostrar un cuadro de diálogo de confirmación antes de eliminar el cliente.
                DialogResult resultado = MessageBox.Show("¿Seguro que deseas eliminar este cliente?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (resultado == DialogResult.Yes)
                {
                    // Llamar al método del controlador para eliminar el cliente.
                    clientesController.EliminarCliente(clienteId);

                    // Mostrar un mensaje de "Cliente eliminado exitosamente".
                    MessageBox.Show("Cliente eliminado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Recargar la lista de clientes en el DataGridView después de la eliminación.
                    CargarClientesEnDataGridView();
                }
            }
        }

        private void dgvClientes_SelectionChanged_1(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = dgvClientes.SelectedRows[0];
                int clienteId = Convert.ToInt32(filaSeleccionada.Cells["Id"].Value);
                string nombre = filaSeleccionada.Cells["Nombre"].Value.ToString();
                string email = filaSeleccionada.Cells["Email"].Value.ToString();
                string telefono = filaSeleccionada.Cells["Telefono"].Value.ToString();
                string empresa = filaSeleccionada.Cells["Empresa"].Value.ToString();
                int idUsuario = Convert.ToInt32(filaSeleccionada.Cells["IdUsuario"].Value);

                txtNombre.Text = nombre;
                txtEmail.Text = email;
                txtTelefono.Text = telefono;
                txtEmpresa.Text = empresa;

                // Seleccionar el usuario correspondiente en el ComboBox por su ID
                cmbUsuarios.SelectedValue = idUsuario;

                txtNombre.Enabled = true;
                txtEmail.Enabled = true;
                txtTelefono.Enabled = true;
                txtEmpresa.Enabled = true;
            }
        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvClientes_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvClientes.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
        }

        private void cmbUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
