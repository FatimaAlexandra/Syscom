using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syscom.Modelo
{
    internal class ClientesModel
    {
        private int id;
        private string nombre;
        private string email;
        private string telefono;
        private string empresa;

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

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        public string Empresa
        {
            get { return empresa; }
            set { empresa = value; }
        }
    }
}
