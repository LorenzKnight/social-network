using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork
{
    class Program
    {
        static void Main(string[] args)
        {
            Publication post1 = new Publication("Thanks for the birthday wishes", true, "Laura Garay");
            Console.WriteLine(post1.ToString());

            PostImage image1 = new PostImage("Look my new dog", "Laura Garay", "https://imagen.com/dog", true);
            Console.WriteLine(image1.ToString());
            Console.Read();
        }
    }
}
