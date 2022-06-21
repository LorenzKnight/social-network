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

            PostVideo video1 = new PostVideo("Look the video of my new dog", "https://video.com/dog", 30, "Laura Garay", true);
            Console.WriteLine(video1.ToString());
            video1.Play();
            Console.WriteLine("Press any key to stop");
            Console.ReadKey();
            video1.Stop();
            Console.Read();
        }
    }

    // Crear clase PostVideo
    // Propiedades urlVideo y Duracion
    // Crear los constructores
    // Ajustar el estado ToString()
    // Crear una instancia de publicacionvideo
}
