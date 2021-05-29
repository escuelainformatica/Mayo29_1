using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mayo29.modelo
{
    class Libro
    {
        public string Titulo  {set; get;}
        public string Autor {set; get;}
        public int CantPaginas {set; get;}

        public Libro(string titulo, string autor, int cantPaginas)
        {
            Titulo = titulo;
            Autor = autor;
            CantPaginas = cantPaginas;
        }

        public Libro()
        {
        }
    }
}
