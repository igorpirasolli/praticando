using escola_estudantes.entidades;

namespace escola_estudantes
{
    class Program
    {
        static void Main(string[] args)
        {
            Students student1 = new Students("igor felipe", 10);
            Students student2 = new Students("isabelle caroline", 12);

            School school = new School();

            school.AdicionarEstudantes(student1);
            school.AdicionarEstudantes(student2);

            school.Mostraralunos();


        }
    }
}