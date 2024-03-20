using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Usuario
    {
        //  [IdUsuario]
        //,[Nombre]
        //,[Apellidos]
        //,[Correo]
        //,[Clave]
        //,[Restablcer]
        //,[Activo]
        //,[FechaDeIngreso]

        public int IdUsuario { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Correo { get; set; }
        public string Clave { get; set; }
        public bool Restablecer { get; set; }
        public bool Activo { get; set; }
    }


}
