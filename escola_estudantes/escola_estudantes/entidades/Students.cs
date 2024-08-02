using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace escola_estudantes.entidades
{
    internal class Students
    {
        public string Name { get; set; }
        public int  Grade { get; set; }

        public Students(string name, int grade)
        {
            Name = name;
            Grade = grade;
        }
    }
}
