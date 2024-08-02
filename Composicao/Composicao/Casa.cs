using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composicao
{
    internal class Casa
    {
        public string Endereco { get; set; }
        public List<Comodo> Comodos { get; set; } = new List<Comodo>();

        public Casa()
        {
        }

        public Casa(string endereco)
        {
            Endereco = endereco;
        }

        public void AdicionarComodo(Comodo comodo)
        {
            Comodos.Add(comodo);
        }

        public void ExibirComodos()
        {
            foreach (var comodo in Comodos)
            {
                Console.WriteLine($"Tipo: {comodo.Tipo}, Area: {comodo.Area} m2");
            }
        }
    }
}
