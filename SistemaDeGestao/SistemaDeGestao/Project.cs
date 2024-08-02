using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeGestao
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

        public void AddTask(string title, string descripition)
        {
            Tasks.Add(new Task(title,descripition));
        }

        public void MostrarTask()
        {
            Console.WriteLine($"tarefa: {Name}");
            foreach (var task in Tasks)
            {
                Console.WriteLine($"Title of task: {task.Title}\n descriçao da tarefa: {task.Description}");
            }
        }
    }
}
