using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
 //   IdCliente Int Primary key identity,
//Nombre Varchar(255),
//Apellidos Varchar(255),
//Correo Varchar(255),
//Clave Varchar(20),
// bit default 0,
   public class Cliente
    {
        public int IdCliente { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Correo { get; set; }
        public string Clave { get; set; }
        public bool Restablcer { get; set; }
    }
}
