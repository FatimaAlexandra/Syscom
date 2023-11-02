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
    public partial class FormularioLicitaconesLanzadas : Form
    {
        // Declaración de la lista para las licitaciones
        List<LicitacionesModel> licitaciones;

        public FormularioLicitaconesLanzadas()
        {
            InitializeComponent();

            // Configurar el DataGridView
            ConfigurarDataGridView();

        }


        // Método para configurar el DataGridView
        private void ConfigurarDataGridView()
        {
            dgvLicitaciones.AutoGenerateColumns = false;
            dgvLicitaciones.Columns.Clear();

            // Configurar las columnas del DataGridView
            dgvLicitaciones.Columns.Add("Id", "ID");
            dgvLicitaciones.Columns.Add("Titulo", "Título");
            dgvLicitaciones.Columns.Add("Descripcion", "Descripción");
            dgvLicitaciones.Columns.Add("FechaInicio", "Fecha Inicio");
            dgvLicitaciones.Columns.Add("FechaFin", "Fecha Fin");
            dgvLicitaciones.Columns.Add("IdCliente", "ID Cliente");
            dgvLicitaciones.Columns.Add("Estado", "Estado"); // Agrega la columna Estado

            // Llama al método para cargar las licitaciones con estado 1
            CargarLicitacionesConEstado1();
        }

        private void CargarLicitacionesConEstado1()
        {
            // Llamar al método para obtener las licitaciones con estado 1 desde el controlador
            LicitacionesController controller = new LicitacionesController();
            licitaciones = controller.ObtenerLicitacionesConEstado1();

            // Limpiar el DataGridView
            dgvLicitaciones.Rows.Clear();

            // Recorrer la lista de licitaciones y agregar los datos al DataGridView
            foreach (LicitacionesModel licitacion in licitaciones)
            {
                dgvLicitaciones.Rows.Add(
                    licitacion.Id,
                    licitacion.Titulo,
                    licitacion.Descripcion,
                    licitacion.FechaInicio,
                    licitacion.FechaFin,
                    licitacion.IdCliente,
                    licitacion.Estado // Agregar el estado en la columna correspondiente
                );
            }
        }


        private void FormularioLicitaconesLanzadas_Load(object sender, EventArgs e)
        {

        }
    }
}
