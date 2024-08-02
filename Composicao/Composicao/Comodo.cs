using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composicao
{
    internal class Comodo
    {
        public string Tipo { get; set; }
        public double Area { get; set; }

        public Comodo(string tipo, double area)
        {
            Tipo = tipo;
            Area = area;
        }
    }
}
