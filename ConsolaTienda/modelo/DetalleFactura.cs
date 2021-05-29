using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolaTienda.modelo
{
    // Por lo general, el modelo deberia estar en singular.

    class DetalleFactura
    {

        public string Descripcion {set; get;}
        public int Cantidad {set; get;} // 0..255 (-2mm hasta 2mm)
        public int PrecioUntario {set; get;}

        public DetalleFactura(string descripcion, int cantidad, int precioUntario)
        {
            Descripcion = descripcion;
            Cantidad = cantidad;
            PrecioUntario = precioUntario;
        }

        public DetalleFactura()
        {
        }
    }
}
