using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syscom.Modelo
{
    internal class PropuestasEconomicasModel
    {
        private int id;
        private int idLicitacion;
        private int idProveedor;
        private decimal precio;

        // Constructor
        public PropuestasEconomicasModel(int id, int idLicitacion, int idProveedor, decimal precio)
        {
            this.id = id;
            this.idLicitacion = idLicitacion;
            this.idProveedor = idProveedor;
            this.precio = precio;
        }

        // Propiedades (getters y setters)
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public int IdLicitacion
        {
            get { return idLicitacion; }
            set { idLicitacion = value; }
        }

        public int IdProveedor
        {
            get { return idProveedor; }
            set { idProveedor = value; }
        }

        public decimal Precio
        {
            get { return precio; }
            set { precio = value; }
        }
    }
}
