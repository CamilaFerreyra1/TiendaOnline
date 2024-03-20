using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
  //  [IdProducto]
  //    ,[Descripcion]
   //   ,[IdMarca]
   //   ,[IdCategoria]
  //    ,[Precio]
 //     ,[Stock]
  //    ,[RutaImagen]
  //    ,[NombreImagen]
   //   ,[Activo]
   //   ,[FechaRegistro]
    public class Productos
    {   public int IdProducto { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public Marca oMarca { get; set; }
        public Categoria oCategoria { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; }
        public string RutaImagen { get; set; }
        public string NombreImagen { get; set; }
        public bool Activo { get; set; }
     //   public string FechaRegistro { get; set; }
    }
}
