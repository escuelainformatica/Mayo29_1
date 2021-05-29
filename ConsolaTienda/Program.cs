using ConsolaTienda.servicio;
using System;

namespace ConsolaTienda
{
    class Program
    {
        static void Main(string[] args)
        {
            var listado=DetalleFacturaSrv.CrearListado();

            var total=DetalleFacturaSrv.Sumar(listado);
            var total2=DetalleFacturaSrv.ObtenerMontoNeto(listado);

            Console.WriteLine("el total es :"+total);

            Console.WriteLine("el total neto es :"+total2);

        }
    }
}
