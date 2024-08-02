using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace associacao_simples.entidades
{
    internal class Aluno
    {
        public string Nome { get; set; }
        public int Matricula { get; set; }

        public Curso Curso { get; set; }

        public Aluno()
        {
        }

        public Aluno(string nome, int matricula, Curso curso)
        {
            Nome = nome;
            Matricula = matricula;
            Curso = curso;
        }

        public override string ToString()
        {
            return $"nome do aluno: {Nome}, numero da matricula: {Matricula}" +
                $"curso: {Curso.Nome}, codigo do curso: {Curso.Codigo}";
        }
    }
}
