using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class DetalleVenta
    {
        //   IdDetalleVenta Int Primary key identity,
        //IdProducto Int References Producto(IdProducto),
        //Canidad Int,
        //Total decimal

        public int IdDetalleVenta { get; set; }
        public Productos oProducto { get; set; }
        public int Cantidad { get; set; }
        public decimal Total { get; set; }

        public string IdTransaccion { get; set; }

    }
}
