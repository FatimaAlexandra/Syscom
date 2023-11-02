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
    public partial class FormularioProveedores : Form
    {
        private ProveedoresController proveedoresController = new ProveedoresController();
        public FormularioProveedores()
        {
            InitializeComponent();
            // En el constructor del formulario de proveedores, carga automáticamente los proveedores en el DataGridView.
            CargarProveedoresEnDataGridView();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Crear un objeto ProveedorModel y asignar valores desde los controles del formulario.
            ProveedoresModel nuevoProveedor = new ProveedoresModel();

            // Verificar si algún campo está vacío
            if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtTelefono.Text) || string.IsNullOrEmpty(txtEmpresa.Text))
            {
                MessageBox.Show("Todos los campos deben estar completos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Detener la operación si hay campos vacíos
            }

            nuevoProveedor.Nombre = txtNombre.Text;
            nuevoProveedor.Email = txtEmail.Text;
            nuevoProveedor.Telefono = txtTelefono.Text;
            nuevoProveedor.Empresa = txtEmpresa.Text;

            // Llamar al método del controlador para insertar el proveedor.
            proveedoresController.InsertarProveedor(nuevoProveedor);

            // Limpiar los controles después de la inserción.
            Limpiar();

            // Mostrar un mensaje de "Proveedor agregado exitosamente".
            MessageBox.Show("Proveedor agregado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Llamar al método para cargar y mostrar los proveedores en el DataGridView.
            CargarProveedoresEnDataGridView();
        }
        private void Limpiar()
        {
            txtNombre.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            txtEmpresa.Text = string.Empty;
        }
        private void CargarProveedoresEnDataGridView()
        {
            dgvProveedores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Limpia el DataGridView antes de cargar los datos.
            dgvProveedores.Rows.Clear();
            dgvProveedores.Columns.Clear(); // Limpia las columnas también

            // Evitar que se agregue automáticamente una fila en blanco al final
            dgvProveedores.AllowUserToAddRows = false;

            List<ProveedoresModel> listaProveedores = proveedoresController.ObtenerProveedores();

            // Agrega las columnas al DataGridView
            dgvProveedores.Columns.Add("Id", "ID");
            dgvProveedores.Columns.Add("Nombre", "Nombre");
            dgvProveedores.Columns.Add("Email", "Email");
            dgvProveedores.Columns.Add("Telefono", "Teléfono");
            dgvProveedores.Columns.Add("Empresa", "Empresa");
            // Ocultar la columna "ID"
            dgvProveedores.Columns["Id"].Visible = false;

            foreach (ProveedoresModel proveedor in listaProveedores)
            {
                dgvProveedores.Rows.Add(proveedor.Id, proveedor.Nombre, proveedor.Email, proveedor.Telefono, proveedor.Empresa);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void dgvProveedores_SelectionChanged(object sender, EventArgs e)
        {
            // Verificar si se ha seleccionado una fila en el DataGridView.
            if (dgvProveedores.SelectedRows.Count > 0)
            {
                // Obtener el proveedor seleccionado.
                DataGridViewRow filaSeleccionada = dgvProveedores.SelectedRows[0];

                // Obtener los datos del proveedor desde las celdas del DataGridView.
                int proveedorId = Convert.ToInt32(filaSeleccionada.Cells["Id"].Value);
                string nombre = filaSeleccionada.Cells["Nombre"].Value.ToString();
                string email = filaSeleccionada.Cells["Email"].Value.ToString();
                string telefono = filaSeleccionada.Cells["Telefono"].Value.ToString();
                string empresa = filaSeleccionada.Cells["Empresa"].Value.ToString();

                // Cargar los datos del proveedor en los TextBox para edición.
                txtNombre.Text = nombre;
                txtEmail.Text = email;
                txtTelefono.Text = telefono;
                txtEmpresa.Text = empresa;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvProveedores.SelectedRows.Count > 0)
            {
                // Obtener el ID del proveedor seleccionado.
                int proveedorId = Convert.ToInt32(dgvProveedores.SelectedRows[0].Cells["Id"].Value);

                // Validar campos vacíos
                if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtTelefono.Text) || string.IsNullOrEmpty(txtEmpresa.Text))
                {
                    MessageBox.Show("Por favor, complete todos los campos antes de guardar cambios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    // Crear un objeto ProveedorModel con los datos modificados.
                    ProveedoresModel proveedorModificado = new ProveedoresModel
                    {
                        Id = proveedorId,
                        Nombre = txtNombre.Text,
                        Email = txtEmail.Text,
                        Telefono = txtTelefono.Text,
                        Empresa = txtEmpresa.Text
                    };

                    // Llamar al método del controlador para actualizar el proveedor.
                    proveedoresController.ActualizarProveedor(proveedorModificado);

                    // Limpiar los TextBox.
                    Limpiar();

                    // Mostrar un mensaje de "Cambios guardados exitosamente".
                    MessageBox.Show("Cambios guardados exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Recargar la lista de proveedores en el DataGridView después de la edición.
                    CargarProveedoresEnDataGridView();
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un proveedor para editar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Verificar si se ha seleccionado una fila en el DataGridView.
            if (dgvProveedores.SelectedRows.Count > 0)
            {
                // Obtener el ID del proveedor seleccionado.
                int proveedorId = Convert.ToInt32(dgvProveedores.SelectedRows[0].Cells["Id"].Value);

                // Mostrar un cuadro de diálogo de confirmación antes de eliminar el proveedor.
                DialogResult resultado = MessageBox.Show("¿Seguro que deseas eliminar este proveedor?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (resultado == DialogResult.Yes)
                {
                    // Llamar al método del controlador para eliminar el proveedor.
                    proveedoresController.EliminarProveedor(proveedorId);

                    // Mostrar un mensaje de "Proveedor eliminado exitosamente".
                    MessageBox.Show("Proveedor eliminado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Recargar la lista de proveedores en el DataGridView después de la eliminación.
                    CargarProveedoresEnDataGridView();
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtEmpresa_TextChanged(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void dgvProveedores_SelectionChanged_1(object sender, EventArgs e)
        {
            // Verificar si se ha seleccionado una fila en el DataGridView.
            if (dgvProveedores.SelectedRows.Count > 0)
            {
                // Obtener el proveedor seleccionado.
                DataGridViewRow filaSeleccionada = dgvProveedores.SelectedRows[0];

                // Obtener los datos del proveedor desde las celdas del DataGridView.
                int proveedorId = Convert.ToInt32(filaSeleccionada.Cells["Id"].Value);
                string nombre = filaSeleccionada.Cells["Nombre"].Value.ToString();
                string email = filaSeleccionada.Cells["Email"].Value.ToString();
                string telefono = filaSeleccionada.Cells["Telefono"].Value.ToString();
                string empresa = filaSeleccionada.Cells["Empresa"].Value.ToString();

                // Cargar los datos del proveedor en los TextBox para edición.
                txtNombre.Text = nombre;
                txtEmail.Text = email;
                txtTelefono.Text = telefono;
                txtEmpresa.Text = empresa;
            }
        }
    }
}
