using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace agregacao
{
    internal class Biblioteca
    {
        public string Nome { get; set; }
        public string Endereco { get; set; }

        public List<Livro> Livro { get; set; } = new List<Livro>();

        public Biblioteca()
        {
        }

        public Biblioteca(string nome, string endereco, Livro livros)
        {
            Nome = nome;
            Endereco = endereco;
            
        }

        public void AdicionarLivros(Livro livro)
        {
            Livro.Add(livro);
        }

        public void ExibirLivros()
        {
            foreach (var livro in Livro)
            {
                Console.WriteLine($"Titulo: {livro.Titulo}, Autor: {livro.Autor}, ISBM: {livro.Isbm}");
            }
        }

    }
}
