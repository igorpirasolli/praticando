using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasDeGestaoDeProjetos
{
    internal class Project
    {
        public string Name { get; set; }
        public List<Task> Tasks { get; set; }

        public Project(string name)
        {
            Name = name;
            Tasks = new List<Task>();
        }

        public void AdicionarTarefa(string title, string descripition)
        {
            Tasks.Add(new Task(title, descripition));
        }

        public void Imprimir()
        {
            Console.WriteLine($"Nome do projeto: {Name}");
            foreach (var task in Tasks)
            {
                Console.WriteLine($"titulo da tarefa: {task.Title}\ndescriçao da tarefa: {task.Descripition}");
                Console.WriteLine();
            }
            
        }
    }
}
