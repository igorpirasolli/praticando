using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasDeGestaoDeProjetos
{
    internal class Task
    {
        public string Title { get; set; }
        public string Descripition { get; set; }

        public Task(string title, string descripition)
        {
            Title = title;
            Descripition = descripition;
        }
    }
}
