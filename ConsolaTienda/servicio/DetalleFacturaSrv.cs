using ConsolaTienda.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolaTienda.servicio
{
    class DetalleFacturaSrv
    {
        public static List<DetalleFactura> CrearListado()
        {
            List<DetalleFactura> lista=new List<DetalleFactura>();

            DetalleFactura det=new DetalleFactura("Tarifa servicio",1,200);
            lista.Add(det);
            lista.Add( new DetalleFactura("Mano de obra",5,75) );
            lista.Add( new DetalleFactura("descuento cliente nuevo",0,0) );
            return lista;
        }
        public static int Sumar(List<DetalleFactura> lista)
        {
            var total=0;
            foreach(var df in lista)
            {
                total=total+ (df.Cantidad*df.PrecioUntario);
            }
            return total;
        }
        public static int ObtenerMontoNeto(List<DetalleFactura> lista)
        {
            // round redondeo.
            // round para arriba.
            // round para abajo.


            // convertir el valor.   double->int
            // cast (especificar el tipo)

            int total=Convert.ToInt32(  Math.Round(  Sumar(lista) * 1.19) );
            // total=Int32.Parse(  "222" );   // string->int
            
            // es un cast:
            total=(int)Math.Round(  Sumar(lista) * 1.19);


            return total;
        }


    }
}
