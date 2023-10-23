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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario de clientes
            FormularioClientes formClientes = new FormularioClientes();

            // Mostrar el formulario de clientes (modal) - Bloquea Form1 hasta que se cierre el formulario de clientes
            formClientes.ShowDialog();
        }

        private void btnProveedor_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario de proveedores
            FormularioProveedores formProveedores = new FormularioProveedores();

            // Mostrar el formulario de proveedores
            formProveedores.ShowDialog();
        }
    }
}
