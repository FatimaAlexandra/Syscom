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
    public partial class FormularioProductos : Form
    {
        private int idLicitacion; // Campo para almacenar el idLicitacion
        // Define un evento para notificar la adición exitosa de un producto
        public event EventHandler ProductoAgregado;
        public FormularioProductos(int idLicitacion)
        {
            InitializeComponent();
            this.idLicitacion = idLicitacion; // Asigna el idLicitacion recibido al campo de la clase
            txtPrecio.Visible = false;
            lblPrecio.Visible = false;
            CargarProductosEnDataGridView();
        }
        private void FormularioProductos_Load(object sender, EventArgs e)
        {

        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Obtén los valores de los controles en el formulario
            string nombre = txtNombre.Text;
            string descripcion = txtDescripcion.Text;
            txtPrecio.Text = "0";

            if (decimal.TryParse(txtPrecio.Text, out decimal precioUnitario) &&
                int.TryParse(txtCantidad.Text, out int cantidad))
            {
                // Crea una instancia de ProductosController
                ProductosController productosController = new ProductosController();

                // Intenta agregar el producto usando la instancia de productosController
                if (productosController.AgregarProducto(nombre, descripcion, precioUnitario, cantidad, idLicitacion))
                {
                    // Inserción exitosa, muestra un mensaje de confirmación
                    MessageBox.Show("Producto agregado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Notifica a los suscriptores que se ha agregado un producto
                    OnProductoAgregado(EventArgs.Empty);

                    // Limpia los campos después de la inserción exitosa
                    LimpiarCampos();
                    // Carga los productos en el DataGridView
                    CargarProductosEnDataGridView();
                }
                else
                {
                    // Error durante la inserción, muestra un mensaje de error
                    MessageBox.Show("Error al agregar el producto. Por favor, inténtelo de nuevo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Los valores ingresados para precio y cantidad no son válidos
                MessageBox.Show("Los valores ingresados para precio y cantidad no son válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        protected virtual void OnProductoAgregado(EventArgs e)
        {
            ProductoAgregado?.Invoke(this, e);
        }

        private void LimpiarCampos()
        {
            txtNombre.Text = string.Empty;
            txtDescripcion.Text = string.Empty;
            txtPrecio.Text = string.Empty;
            txtCantidad.Text = string.Empty;
        }

        private void CargarProductosEnDataGridView()
        {
            dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Limpia el DataGridView antes de cargar los datos.
            dgvProductos.Rows.Clear();
            dgvProductos.Columns.Clear(); // Limpia las columnas también

            // Evitar que se agregue automáticamente una fila en blanco al final
            dgvProductos.AllowUserToAddRows = false;

            ProductosController productosController = new ProductosController(); // Crear una instancia de ProductosController
            List<ProductosModel> listaProductos = productosController.ObtenerProductosPorLicitacion(idLicitacion); // Llama al método a través de la instancia


            // Agrega las columnas al DataGridView
            dgvProductos.Columns.Add("Id", "ID");
            dgvProductos.Columns.Add("NombreProducto", "Nombre del Producto");
            dgvProductos.Columns.Add("Descripcion", "Descripción");
            dgvProductos.Columns.Add("PrecioUnitario", "Precio Unitario");
            dgvProductos.Columns.Add("Cantidad", "Cantidad");
            // Puedes ocultar la columna "ID" si lo prefieres
            dgvProductos.Columns["Id"].Visible = false;

            foreach (ProductosModel producto in listaProductos)
            {
                dgvProductos.Rows.Add(producto.Id, producto.NombreProducto, producto.Descripcion, producto.PrecioUnitario, producto.Cantidad);
            }
        }


    }
}
