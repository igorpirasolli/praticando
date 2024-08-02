using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace agregacao
{
    internal class Livro
    {
        public string Titulo  { get; set; }
        public string  Autor { get; set; }

        public int Isbm { get; set; }

        public Livro() { }

        public Livro(string titulo, string autor, int isbm)
        {
            Titulo = titulo;
            Autor = autor;
            Isbm = isbm;
        }
    }
}
