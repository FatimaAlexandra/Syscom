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
        public FormularioLicitaciones(string usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            txtIdUsuario.Text = usuario + "\n";
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
    }
}
