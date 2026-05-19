using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parqueo.Models
{
    public class Usuarios
    {
        public int IdUsuario { get; set; }
        // Propiedades que se corresponden con los campos de tu formulario
        public string NombreUsuario { get; set; }
        public string Contrasena { get; set; } // Ojo: ¡Será el hash!
        public string Rol { get; set; }
    }
}
