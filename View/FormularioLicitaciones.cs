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
        public FormularioLicitaciones()
        {
            InitializeComponent();
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
            if (cmbIdCliente.SelectedItem != null)
            {
                string clienteNombre = cmbIdCliente.SelectedItem.ToString();
                int clienteId = Convert.ToInt32(cmbIdCliente.SelectedValue);

            }
        }
        private void CargarClientesEnComboBox()
        {
            ClientesController clientesController = new ClientesController(); // Crear una instancia del controlador
            // Llama al método del controlador para obtener la lista de clientes con nombres.
            List<ClientesModel> listaClientes = clientesController.ObtenerClientesConNombres();


            // Limpia el ComboBox si ya tenía elementos.
            cmbIdCliente.Items.Clear();

            // Agrega los clientes al ComboBox y configura el valor como el ID.
            foreach (ClientesModel cliente in listaClientes)
            {
                cmbIdCliente.Items.Add(cliente.Empresa);
                cmbIdCliente.ValueMember = cliente.Id.ToString();
            }
        }

    }
}
