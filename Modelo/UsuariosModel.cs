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
        private int Id { get; }
        private string Usuario { get; }
        private string Password { get; }
        private string Email { get; }
        private string Rol { get; }

        public UsuariosModel(int id, string usuario, string password, string email, string rol)
        {
            Id = id;
            Usuario = usuario;
            Password = password;
            Email = email;
            Rol = rol;
        }

        public int ObtenerId()
        {
            return Id;
        }

        public string ObtenerUsuario()
        {
            return Usuario;
        }

        public string ObtenerPassword()
        {
            return Password;
        }

        public string ObtenerEmail()
        {
            return Email;
        }

        public string ObtenerRol()
        {
            return Rol;
        }
    }
}
