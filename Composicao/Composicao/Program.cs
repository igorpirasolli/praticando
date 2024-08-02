namespace Composicao
{
    class Program {
        static void Main(string[] args)
        {
            Comodo comodo1 = new Comodo("quarto", 20.5);
            Comodo comodo2 = new Comodo("sala", 15.0);

            Casa casa = new Casa();

            casa.AdicionarComodo(comodo1);
            casa.AdicionarComodo(comodo2);

            casa.ExibirComodos();
        }
    }
}