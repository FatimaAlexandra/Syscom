using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syscom.Modelo
{
    internal class ProductosModel
    {
        private int id;
        private string nombreProducto;
        private string descripcion;
        private decimal precioUnitario;
        private int cantidad;
        private int idLicitacion;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string NombreProducto
        {
            get { return nombreProducto; }
            set { nombreProducto = value; }
        }

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public decimal PrecioUnitario
        {
            get { return precioUnitario; }
            set { precioUnitario = value; }
        }

        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }

        public int IdLicitacion
        {
            get { return idLicitacion; }
            set { idLicitacion = value; }
        }
    }
}
