using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Carrito
    {
        //        IdCarrito Int Primary key identity,
        //IdCliente Int References Clientes(IdCliente),
        //IdProducto Int References Producto(IdProducto),
        //Cantidad int
        public int IdCarrito { get; set; }
        public Cliente oCliente { get; set; }
        public Productos oProducto { get; set; }
        public int Cantidad { get; set; }
        
    }
}
