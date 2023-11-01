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
        private string nombre;
        private string descripcion;
        private decimal precio;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public decimal Precio
        {
            get { return precio; }
            set { precio = value; }
        }
    }
}
