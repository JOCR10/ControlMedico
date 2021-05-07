using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlMedico.Api.Modelos
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string CodUsuario { get; set; }
        public string Contrasena { get; set; }
        public string Rol { get; set; }
    }
}
