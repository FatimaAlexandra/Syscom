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
    public partial class FormularioPropuesta : Form
    {
        private PropuestasControler propuestaController = new PropuestasControler();
        public FormularioPropuesta()
        {
            InitializeComponent();
            CargarPropuestasEnDataGridView();
        }
        private void CargarPropuestasEnDataGridView()
        {
            dgvProveedores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Limpia el DataGridView antes de cargar los datos.
            dgvProveedores.Rows.Clear();
            dgvProveedores.Columns.Clear(); // Limpia las columnas también

            // Evitar que se agregue automáticamente una fila en blanco al final
            dgvProveedores.AllowUserToAddRows = false;

            List<PropuestasModelo> listapropuesta = propuestaController.ObtenerPropuestas();

            // Agrega las columnas al DataGridView
            dgvProveedores.Columns.Add("id", "id");
            dgvProveedores.Columns.Add("id_licitacion", "id_licitacion");
            dgvProveedores.Columns.Add("id_proveedor", "id_proveedor");
            dgvProveedores.Columns.Add("precio", "precio");
            // Ocultar la columna "ID"
            dgvProveedores.Columns["id"].Visible = false;

            foreach (PropuestasModelo propuesta in listapropuesta)
            {
                dgvProveedores.Rows.Add(propuesta.Id, propuesta.ID_licitacion, propuesta.ID_proveedor, propuesta.Precio);
            }
        }
        private void Limpiar()
        {
            txtIdli.Text = string.Empty;
            txtIdproveedores.Text = string.Empty;
            txtPrecop.Text = string.Empty;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Crear un objeto ProveedorModel y asignar valores desde los controles del formulario.
            PropuestasModelo nuevoPropuesta = new PropuestasModelo();
            nuevoPropuesta.ID_licitacion = Convert.ToInt32(txtIdli.Text);
            nuevoPropuesta.ID_proveedor = Convert.ToInt32(txtIdproveedores.Text);
            nuevoPropuesta.Precio = Convert.ToDouble(txtPrecop);

            // Llamar al método del controlador para insertar el proveedor.
            propuestaController.AgregarPropuestaEconomica(nuevoPropuesta);

            // Limpiar los controles después de la inserción.
            Limpiar();

            // Mostrar un mensaje de "Proveedor agregado exitosamente".
            MessageBox.Show("Propuesta agregado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Llamar al método para cargar y mostrar los proveedores en el DataGridView.
            CargarPropuestasEnDataGridView();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Verificar si se ha seleccionado una fila en el DataGridView.
            if (dgvProveedores.SelectedRows.Count > 0)
            {
                // Obtener el ID del proveedor seleccionado.
                int proveedorId = Convert.ToInt32(dgvProveedores.SelectedRows[0].Cells["id"].Value);

                // Mostrar un cuadro de diálogo de confirmación antes de eliminar el proveedor.
                DialogResult resultado = MessageBox.Show("¿Seguro que deseas eliminar este proveedor?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (resultado == DialogResult.Yes)
                {
                    // Llamar al método del controlador para eliminar el proveedor.
                    propuestaController.EliminarPropuestaEconomica(proveedorId);

                    // Mostrar un mensaje de "Proveedor eliminado exitosamente".
                    MessageBox.Show("Proveedor eliminado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Recargar la lista de proveedores en el DataGridView después de la eliminación.
                    CargarPropuestasEnDataGridView();
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
