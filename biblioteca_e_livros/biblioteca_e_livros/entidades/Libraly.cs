using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca_e_livros.entidades
{
    internal class Libraly
    {
        public string Book { get; set; }

        public List<Book> Livros { get; set; } = new List<Book>();

        public Libraly()
        {
        }

        public Libraly(string book)
        {
            Book = book;
        }

        public void AdicionarLivro(Book livros)
        {
            Livros.Add(livros);
        } 

        public void MostrarLivros()
        {
            Console.WriteLine($"name of library: {Book} ");
            foreach (Book livros in Livros)
            {
                Console.WriteLine ($"Title of Book: {livros.Title}, name of author: {livros.Author}");
            }
        }
    }
}
