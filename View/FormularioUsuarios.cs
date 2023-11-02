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
    public partial class FormularioUsuarios : Form
    {
        private UsuarioController usuarioController = new UsuarioController();

        public FormularioUsuarios()
        {
            InitializeComponent();
            CargarUsuariosEnDataGridView();
        }

        private void FormularioUsuarios_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            // Guardando los valores desde las txt
            UsuariosModel nuevoUsuario = new UsuariosModel();

            // Verificar si algún campo está vacío
            if (string.IsNullOrEmpty(txtUsuario.Text) || string.IsNullOrEmpty(txtPass.Text) || string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtRol.Text))
            {
                MessageBox.Show("Todos los campos deben estar completos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Detener la operación si hay campos vacíos
            }

            nuevoUsuario.Usuario = txtUsuario.Text;
            nuevoUsuario.Pass = txtPass.Text;
            nuevoUsuario.Email = txtEmail.Text;
            nuevoUsuario.Rol = txtRol.Text;

            // Insertando al usuario
            usuarioController.InsertarUsuario(nuevoUsuario);

            // Limpiar los controles después de la inserción.
            Limpiar();

            // Mostrar un mensaje de "Agregado exitosamente".
            MessageBox.Show("Usuario agregado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Llamar al método para cargar y mostrar los usuarios en el DataGridView.
            CargarUsuariosEnDataGridView();
        }

        private void Limpiar()
        {
            txtUsuario.Text = string.Empty;
            txtPass.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtRol.Text = string.Empty;
        }

        private void CargarUsuariosEnDataGridView()
        {
            dgvUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Limpia el DataGridView antes de cargar los datos.
            dgvUsuarios.Rows.Clear();
            dgvUsuarios.Columns.Clear(); // Limpia las columnas 

            // Evitar que se agregue automáticamente una fila en blanco al final
            dgvUsuarios.AllowUserToAddRows = false;

            List<UsuariosModel> listaUsuarios = usuarioController.ObtenerUsuarios();

            // Agrega las columnas al DataGridView
            dgvUsuarios.Columns.Add("Id", "ID");
            dgvUsuarios.Columns.Add("Usuario", "Usuario");
            dgvUsuarios.Columns.Add("Pass", "Pass");
            dgvUsuarios.Columns.Add("Email", "Email");
            dgvUsuarios.Columns.Add("Rol", "Rol");
            // Ocultar la columna "ID" y la columna de Pass para la contra
            dgvUsuarios.Columns["Id"].Visible = false;
            dgvUsuarios.Columns["Pass"].Visible = false;

            foreach (UsuariosModel usuario in listaUsuarios)
            {
                dgvUsuarios.Rows.Add(usuario.Id, usuario.Usuario, usuario.Pass, usuario.Email, usuario.Rol);
            }
        }

        private void dgvUsuarios_SelectionChanged(object sender, EventArgs e)
        {
            // Verificar si se ha seleccionado una fila en el DataGridView.
            if (dgvUsuarios.SelectedRows.Count > 0)
            {
                // Obtener el usuario seleccionado.
                DataGridViewRow filaSeleccionada = dgvUsuarios.SelectedRows[0];

                // Obtener los datos del usuario desde las celdas del DataGridView.
                int usuarioId = Convert.ToInt32(filaSeleccionada.Cells["Id"].Value);
                string usuario = filaSeleccionada.Cells["Usuario"].Value.ToString();
                string pass = filaSeleccionada.Cells["Pass"].Value.ToString();
                string email = filaSeleccionada.Cells["Email"].Value.ToString();
                string rol = filaSeleccionada.Cells["Rol"].Value.ToString();

                // Cargar los datos del usuario en los TextBox para edición.
                txtUsuario.Text = usuario;
                txtPass.Text = pass;
                txtEmail.Text = email;
                txtRol.Text = rol;

                // Habilitar los TextBox para edición.
                txtUsuario.Enabled = true;
                txtPass.Enabled = true;
                txtEmail.Enabled = true;
                txtRol.Enabled = true;
            }
        }

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnModificarUsuario_Click(object sender, EventArgs e)
        {
            // Verificar si se ha seleccionado una fila en el DataGridView.
            if (dgvUsuarios.SelectedRows.Count > 0)
            {
                // Obtener el ID del usuario seleccionado.
                int usuarioId = Convert.ToInt32(dgvUsuarios.SelectedRows[0].Cells["Id"].Value);

                // Crear un objeto usuarioModel con los datos modificados.
                UsuariosModel usuarioModificado = new UsuariosModel
                {
                    Id = usuarioId,
                    Usuario = txtUsuario.Text,
                    Pass = txtPass.Text,
                    Email = txtEmail.Text,
                    Rol = txtRol.Text
                };

                // Verificar si algún campo está vacío
                if (string.IsNullOrEmpty(usuarioModificado.Usuario) || string.IsNullOrEmpty(usuarioModificado.Pass) || string.IsNullOrEmpty(usuarioModificado.Email) || string.IsNullOrEmpty(usuarioModificado.Rol))
                {
                    MessageBox.Show("Todos los campos deben estar completos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Detener la operación si hay campos vacíos
                }

                // Llamar al método del controlador para actualizar el usuario.
                usuarioController.ActualizarUsuarios(usuarioModificado);

                Limpiar();

                // Mostrar un mensaje de "Cambios guardados exitosamente".
                MessageBox.Show("Cambios guardados exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Recargar la lista de usuarios en el DataGridView después de la edición.
                CargarUsuariosEnDataGridView();
            }
        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            // Verificar si se ha seleccionado una fila en el DataGridView.
            if (dgvUsuarios.SelectedRows.Count > 0)
            {
                // Obtener el ID del cliente seleccionado.
                int usuarioId = Convert.ToInt32(dgvUsuarios.SelectedRows[0].Cells["Id"].Value);

                // Mostrar un cuadro de diálogo de confirmación antes de eliminar el cliente.
                DialogResult resultado = MessageBox.Show("¿Seguro que deseas eliminar este usuario?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (resultado == DialogResult.Yes)
                {
                    // Llamar al método del controlador para eliminar el cliente.
                    usuarioController.EliminarUsuario(usuarioId);

                    // Mostrar un mensaje de "Cliente eliminado exitosamente".
                    MessageBox.Show("Usuario eliminado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Recargar la lista de clientes en el DataGridView después de la eliminación.
                    CargarUsuariosEnDataGridView();
                }
            }
        }

        private void dgvClientes_SelectionChanged_1(object sender, EventArgs e)
        {
            // Verificar si se ha seleccionado una fila en el DataGridView.
            if (dgvUsuarios.SelectedRows.Count > 0)
            {
                // Obtener el cliente seleccionado.
                DataGridViewRow filaSeleccionada = dgvUsuarios.SelectedRows[0];

                // Obtener los datos del usuario desde las celdas del DataGridView.
                int usuarioId = Convert.ToInt32(filaSeleccionada.Cells["Id"].Value);
                string usuario = filaSeleccionada.Cells["Usuario"].Value.ToString();
                string pass = filaSeleccionada.Cells["Pass"].Value.ToString();
                string email = filaSeleccionada.Cells["Email"].Value.ToString();
                string rol = filaSeleccionada.Cells["Rol"].Value.ToString();

                // Cargar los datos del cliente en los TextBox para edición.
                txtUsuario.Text = usuario;
                txtPass.Text = pass;
                txtEmail.Text = email;
                txtRol.Text = rol;

                // Habilitar los TextBox para edición.
                txtUsuario.Enabled = true;
                txtPass.Enabled = true;
                txtEmail.Enabled = true;
                txtRol.Enabled = true;
            }
        }
        private void dgvUsuarios_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvUsuarios.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
        }

    }
}
