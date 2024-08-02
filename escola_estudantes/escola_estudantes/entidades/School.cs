using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace escola_estudantes.entidades
{
    internal class School
    {
        public List<Students> Students { get; set; }

        public School()
        {
            Students = new List<Students>();
        }

        public void AdicionarEstudantes(Students students)
        {
            Students.Add(students);
        }

        public void Mostraralunos()
        {
            foreach (Students student in Students)
            {
                Console.WriteLine($"Nome do aluno: {student.Name}\nGrade: {student.Grade}");
            }
        }
    }
}
