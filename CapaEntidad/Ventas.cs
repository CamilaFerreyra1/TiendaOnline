using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
   public class Ventas
    {
        //       IdVenta Int Primary key identity,
        //IdCliente Int References Clientes(IdCliente),
        //TotalCarrito Int,
        //MontoTotal decimal (10,2),
        //Contacto Varchar(50),
        //IdDistrito Varchar(10),
        //Telefono Varchar(100),
        //Direccion Varchar(200),
        //IdTransaccion Varchar(100),

        public int IdVenta { get; set; }
        public int IdCliente { get; set; }
        public int TotalCarrito { get; set; }
        public decimal MontoTotal { get; set; }
        public string Contacto { get; set; }
        public int IdDistrito { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public int IdTransaccion { get; set; }
    }
}
