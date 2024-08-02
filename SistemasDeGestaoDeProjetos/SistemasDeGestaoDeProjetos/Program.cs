namespace SistemasDeGestaoDeProjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            Project project = new Project("novo site");

            project.AdicionarTarefa("fazer o front end", "montar a primeira pagina");
            project.AdicionarTarefa("fazer o beck end", "trabalhar bastante");

            project.Imprimir();
        }
    }
}