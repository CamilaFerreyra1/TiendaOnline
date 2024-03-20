using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Distrito
//        IdDistrito Varchar(6) not null,
//Descripcion Varchar(45) not null,
//IdProvincia Varchar(4) not null,
//IdDepartamento Varchar(2) not null
    {
        public int IdDistrito { get; set; }
        public string Descripcion { get; set; }
        public Provincia oProvincia { get; set; }
        public Departamento oDepartamento { get; set; }

    }
}
