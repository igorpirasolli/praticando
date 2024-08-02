using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computador_e_componentes
{
    internal class Computer
    {
        public List<Componet> Components { get; set; } = new List<Componet>
        {
            new Componet ("gpu"),
            new Componet ("cpu"),
            new Componet ("placa de video")
        };

        public void MostrarComponentes()
        {
            int cont = 1;
            Console.WriteLine($"componentes do pc: ");
            foreach (var component in Components)
            {
                Console.WriteLine ($"componentes #{cont}: {component.Name} ");
                cont++;
            }
        }
    }
}
