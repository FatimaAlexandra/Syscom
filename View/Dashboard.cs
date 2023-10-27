using Syscom.Controlador;
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

        private string rolUsuario;
        private string usuario;
        public Dashboard(string usuario, string rolUsuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            this.rolUsuario = rolUsuario;

            MostrarBotonesSegunRol();
            lblUsuario.Text = usuario + "\n";
            lblRol.Text = rolUsuario + "\n";

        }
        //ocultar botones 
        private void MostrarBotonesSegunRol()
        {
            if (rolUsuario == "cliente")
            {
                btnClientes.Visible = false;
                btnProveedor.Visible = false;
                btnUsuarios.Visible = false;

            }
            if (rolUsuario == "proveedor")
            {
                btnProveedor.Visible = false;
                btnClientes.Visible = false;
                btnLicitacion.Visible = false;
                btnUsuarios.Visible = false;
            }

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

        private void btnLicitacion_Click(object sender, EventArgs e)
        {
            FormularioLicitaciones licitaciones = new FormularioLicitaciones();

            licitaciones.ShowDialog();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {


        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            FormularioUsuarios frmUsuarios = new FormularioUsuarios();

            frmUsuarios.ShowDialog();
        }
    }
}
