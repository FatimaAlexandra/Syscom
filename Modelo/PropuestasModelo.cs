using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syscom.Modelo
{
    internal class PropuestasModelo
    {
        private int id;
        private int id_licitacion;
        private int id_proveedor;
        private double precio;

        public int Id {
            get { return id; }
            set { id = value; }
        }
        public int ID_licitacion { 
            get { return id_licitacion; }
            set { id_licitacion = value;}
        }
        public int ID_proveedor { 
            get { return id_proveedor; }
            set { id_proveedor = value;}
        }

        public double Precio { 
            get { return precio; }
            set { precio = value;}
        }
    }
}
