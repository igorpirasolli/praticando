namespace SistemaDeGestao
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Project project = new Project("new website");
            project.AddTask("Develop Backend", "Implement the server-side logic");
            project.AddTask("Design Homepage", "Create a modern homepage design");

            project.MostrarTask();

        }
    }
}