using System.Linq;
using teste.entidade;

namespace teste
{
    class Program
    {

        static void Main(string[] args)
        {
            Post post1 = new Post(DateTime.Now, "traveling to new zealand", "i´m going to visit this wonderful country", 12);
            Comment comment1 = new Comment("have a nice trip");
            Comment comment2 = new Comment("wow that´s awesome!");

            post1.adicionarComment(comment1);
            post1.adicionarComment(comment2);

            post1.imprimir();

            Post post2 = new Post(new DateTime(2018, 07, 28, 23, 14, 19), "good night guys", "see you tomorrow", 5);
            Comment comment3 = new Comment("good night");
            Comment comment4 = new Comment("may the force be with you");

            post2.adicionarComment(comment3);
            post2.adicionarComment(comment4);

            post2.imprimir();


        }





    }
}