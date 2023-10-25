using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Syscom.Modelo
{
    internal class UsuariosModel
    {
        private int id;
        private string usuario;
        private string pass;
        private string email;
        private string rol;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }

        public string Pass
        {
            get { return pass; }
            set { pass = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Rol
        {
            get { return rol; }
            set { rol = value; }
        }
    }
}
