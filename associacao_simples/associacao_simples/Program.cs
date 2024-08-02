using associacao_simples.entidades;

namespace associacao_simples
{
    class Program
    {
        static void Main(string[] args)
        {
            Curso curso = new Curso("engenharia de sofware", 1997);
            Aluno aluno = new Aluno("igor", 06111197, curso);

            Console.WriteLine(aluno);

        }
    }
}