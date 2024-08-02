using biblioteca_e_livros.entidades;

namespace biblioteca_e_livros
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("mitologia nordica", "neil gaiman");
            Book book2 = new Book("mitologia grega", "igor pirasoli");

            Libraly livraria = new Libraly("livraria do rio de janeiro");
            livraria.AdicionarLivro(book1);
            livraria.AdicionarLivro(book2);

            livraria.MostrarLivros();
        }
    }
}