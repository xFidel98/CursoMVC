using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    /*
     * 
     * IdVenta int primary key identity,
IdCliente int references CLIENTE(IdCliente),
TotalProducto int,
MontoTotal decimal(10,2),
Contacto varchar(50),
IdDepto varchar(10),
Telefono varchar(50),
Direccion varchar(500),
IdTransaccion varchar(50),
    */

    public class Venta
    {
        public int IdVenta { get; set; }
        public int IdCliente { get; set; }
        public int TotalProducto { get; set; }
        public decimal MontoTotal { get; set; }
        public string Contacto { get; set; }
        public string IdDepto { get; set; } // IdDistrito
        public string Telefono { get; set; }
        public string Direccion { get; set; } //FechaText
        public string IdTransaccion { get; set; }
    }
}
