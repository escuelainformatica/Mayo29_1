using Mayo29.modelo;
using System;
using System.Collections.Generic;
// using System.Linq;

namespace Mayo29
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // ciclos, arreglos y los listados.

            // arreglo
            string[] arreglopaises=new string[3];
            arreglopaises[0]="Chile";
            arreglopaises[1]="Argentina";
            arreglopaises[2]="Peru";

            string[] arreglopaises2=new string[] {"Chile","Argentina","Peru"};

            // listas
            // clase llamada List < > = diamante.
            // Clase<tipo>  = generics.

            var objg=new ClaseGenerics<int>();
            int r= objg.RegresarElemento(5);

            // Queue, Stack, Dictionary, etc.
            var listaPaises=new List<string>();

            listaPaises.Add("Chile");
            listaPaises.Add("Argentina");
            listaPaises.Add("Peru");

            Console.WriteLine(listaPaises[0]); // Chile
            Console.WriteLine(listaPaises.Count); // contar (3)

            var libros=new List<Libro>();
            Libro libro=new Libro("harry potter","autor",300);
            libros.Add(libro);

            libro=new Libro("libro2","autor",300);
            libros.Add(libro);

            libro=new Libro("libro3","autor",300);
            libros.Add(libro);

            libro=new Libro("libro4","autor",500);
            libros.Add(libro);


            var libros2=new List<Libro>();

            Libro libro2=new Libro("harry potter","autor",300);
            libros2.Add(libro2);  // el primer elemento apunte al espacio de memoria libro2

            libro2.Titulo="libro2";
            libros2.Add(libro2); // el segundo elemento apunte al espacio de memoria libro2

            libro2.Titulo="libro3";
            libros2.Add(libro2); // el tercer elemento apunte al espacio de memoria libro2

            // libros2  libro3,libro3,libro3 ????

            // variable definida por una clase (objeto) y los objetos son punteros.

            Libro libro3=new Libro();
            libro3=new Libro();


            Libro libro4=libro3;  // crear una instancia.
            libro4.Titulo="libro4";

            Console.WriteLine("libro 3 es igual a "+libro3.Titulo);

            // variables primitivas
            string texto1="hola";
            string texto2=texto1; // no es una instancia, es una variable separada.


            // ciclo
            for(int i=0 ; i<libros.Count ; i++)
            {
                Console.WriteLine(i+ " "+libros[i].Titulo);
            }

            for(int i=0;i<5;i++)
            {
                Console.WriteLine("ciclo del 0 al 4 "+i);
            }
            for(int i=4;i>=0;i--)
            {
                Console.WriteLine("ciclo del 4 al 0 "+i);
            }
            for(int i=0 ; i<5 ; i=i+2)
            {
                Console.WriteLine("ciclo del 0 al 4 de dos en dos "+i);
            }

            // i=i+1   i++ (unitaria)
            // i=i-1   i-- (unitaria)
            // i=i+2   i+=2 

            string ingreso="";

            // el ciclo while me interesa usarlo cuando no se cuantos valores
            // debo iterar en el ciclo
            while(ingreso!="q") {
                Console.Write("ingrese un valor (escriba q para salir):");
                ingreso=Console.ReadLine();
            }

            int contador=0;
            while(contador<10)
            {
                Console.WriteLine("contador :"+contador);
                contador++;
            }

            ingreso="";
            // do-while por lo menos se va a ejecutar una vez.
            do {
                Console.Write("ingrese un valor (presione enter para salir):");
                ingreso=Console.ReadLine();
            } while(ingreso!="");

            // for-each.
            // trabajas con objetos que son "listables" (List, arreglos, etc.)
            // for-each, no tenemos la posicion.

            foreach(Libro lib in libros)
            {
                Console.WriteLine("foreach :"+lib.Titulo);
            }

            // contar las cantidad de paginas.
            
            int cantPagina=0;
            foreach(Libro fila in libros)
            {
                cantPagina=cantPagina+fila.CantPaginas;
            }

            Console.WriteLine("contar la cantidad de paginas :"+cantPagina);








        }
    }
}
