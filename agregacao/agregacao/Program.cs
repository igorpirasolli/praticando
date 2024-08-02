namespace agregacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Livro livro1 = new Livro("mitologia nordica", "neil gaiman", 25581);
            Livro livro2 = new Livro("mitologia grega", "igor felipe", 1997);

            Biblioteca biblioteca = new Biblioteca();
            biblioteca.AdicionarLivros(livro1);
            biblioteca.AdicionarLivros(livro2);

            biblioteca.ExibirLivros();

        }
    }
}