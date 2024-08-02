using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace associacao_simples.entidades
{
    internal class Curso
    {
        public string Nome  { get; set; }
        public int  Codigo { get; set; }

        public Curso()
        {
        }

        public Curso(string nome, int codigo)
        {
            Nome = nome;
            Codigo = codigo;
        }


    }
}
