using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SocialNetwork
{
    class PostVideo:Publication
    {
        //Variabels
        protected bool onPlay = false;
        protected int currentDuration = 0;

        Timer clock;


        //new property
        protected string UrlVideo { get; set; }
        protected int Duration { get; set; }

        //Default Constructor
        public PostVideo() { }

        //Parameterized Constructor
        public PostVideo(string title, string urlVideo, int duration, string autor, bool isPublic) 
        { 
            this.ID = CreateID();
            this.Title = title;
            this.UrlVideo = urlVideo;
            this.Duration = duration;
            this.Autor = autor;
            this.IsPublic = isPublic;
        }

        public override string ToString()
        {
            return String.Format(" {0} - {1} - {2} - {3} min - Created by {4}", this.ID, this.Title, this.UrlVideo, this.Duration, this.Autor);
        }

        public void Play()
        {
            if (!onPlay)
            {
                onPlay = true;
                Console.WriteLine("Playing");
                clock = new Timer(Playback, null, 0, 1000);
            }
        }

        public void Stop()
        {
            if (onPlay)
            {
                onPlay = false;
                Console.WriteLine("\nStop on {0}s", currentDuration);
                currentDuration = 0;
                clock.Dispose();
            }
        }
        private void Playback(Object o)
        {
            if(currentDuration < Duration)
            {
                currentDuration++;
                Console.WriteLine("Video on {0}s", currentDuration);
                GC.Collect();
            }
            else 
            { 
                Stop();
            }
        }
    }
}
