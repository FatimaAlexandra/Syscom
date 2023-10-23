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
            // Crear un objeto ClientesModel y asignar valores desde los controles del formulario.
            ClientesModel nuevoCliente = new ClientesModel();
            nuevoCliente.Nombre = txtNombre.Text;
            nuevoCliente.Email = txtEmail.Text;
            nuevoCliente.Telefono = txtTelefono.Text;
            nuevoCliente.Empresa = txtEmpresa.Text;

            // Llamar al método del controlador para insertar el cliente.
            clientesController.InsertarCliente(nuevoCliente);

            // Limpiar los controles después de la inserción.
            Limpiar();
            // Mostrar un mensaje de "Agregado exitosamente".
            MessageBox.Show("Cliente agregado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // Llamar al método para cargar y mostrar los clientes en el DataGridView.
            CargarClientesEnDataGridView();
        }
        private void Limpiar()
        {
            txtNombre.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            txtEmpresa.Text = string.Empty;
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
            // Ocultar la columna "ID"
            dgvClientes.Columns["Id"].Visible = false;

            foreach (ClientesModel cliente in listaClientes)
            {
                dgvClientes.Rows.Add(cliente.Id, cliente.Nombre, cliente.Email, cliente.Telefono, cliente.Empresa);
            }
        }
        private void FormularioClientes_Load(object sender, EventArgs e)
        {

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
            // Verificar si se ha seleccionado una fila en el DataGridView.
            if (dgvClientes.SelectedRows.Count > 0)
            {
                // Obtener el cliente seleccionado.
                DataGridViewRow filaSeleccionada = dgvClientes.SelectedRows[0];

                // Obtener los datos del cliente desde las celdas del DataGridView.
                int clienteId = Convert.ToInt32(filaSeleccionada.Cells["Id"].Value);
                string nombre = filaSeleccionada.Cells["Nombre"].Value.ToString();
                string email = filaSeleccionada.Cells["Email"].Value.ToString();
                string telefono = filaSeleccionada.Cells["Telefono"].Value.ToString();
                string empresa = filaSeleccionada.Cells["Empresa"].Value.ToString();

                // Cargar los datos del cliente en los TextBox para edición.
                txtNombre.Text = nombre;
                txtEmail.Text = email;
                txtTelefono.Text = telefono;
                txtEmpresa.Text = empresa;

                // Habilitar los TextBox para edición.
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
                    Empresa = txtEmpresa.Text
                };

                // Llamar al método del controlador para actualizar el cliente.
                clientesController.ActualizarCliente(clienteModificado);

                // Deshabilitar los TextBox después de guardar los cambios.
                txtNombre.Enabled = false;
                txtEmail.Enabled = false;
                txtTelefono.Enabled = false;
                txtEmpresa.Enabled = false;

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
            // Verificar si se ha seleccionado una fila en el DataGridView.
            if (dgvClientes.SelectedRows.Count > 0)
            {
                // Obtener el cliente seleccionado.
                DataGridViewRow filaSeleccionada = dgvClientes.SelectedRows[0];

                // Obtener los datos del cliente desde las celdas del DataGridView.
                int clienteId = Convert.ToInt32(filaSeleccionada.Cells["Id"].Value);
                string nombre = filaSeleccionada.Cells["Nombre"].Value.ToString();
                string email = filaSeleccionada.Cells["Email"].Value.ToString();
                string telefono = filaSeleccionada.Cells["Telefono"].Value.ToString();
                string empresa = filaSeleccionada.Cells["Empresa"].Value.ToString();

                // Cargar los datos del cliente en los TextBox para edición.
                txtNombre.Text = nombre;
                txtEmail.Text = email;
                txtTelefono.Text = telefono;
                txtEmpresa.Text = empresa;

                // Habilitar los TextBox para edición.
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
    }
}
