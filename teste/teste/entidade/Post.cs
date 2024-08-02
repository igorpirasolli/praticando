using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste.entidade
{
    internal class Post
    {
        public DateTime Moment{ get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }

        public List<Comment> Comment { get; set; } 

        public Post()
        {
        }

        public Post(DateTime moment, string title, string content, int likes)
        {
            Moment = moment;
            Title = title;
            Content = content;
            Likes = likes;
            Comment = new List<Comment>();
        }

        public void adicionarComment(Comment comment)
        {
            Comment.Add(comment);
        }

        public void imprimir()
        {
            Console.WriteLine($"{Title}\n" +
                $"{Likes} - {Moment}\n" +
                $"{Content}\n" +
                $"comments:");
            foreach (Comment comment in Comment)
            {
                Console.WriteLine($"{comment.Text}");
            }
            Console.WriteLine();
        }
    }
}
