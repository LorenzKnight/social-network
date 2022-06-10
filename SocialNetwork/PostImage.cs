using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork
{
    class PostImage:Publication
    {
        //new property
        public string urlImage { get; set; }

        //Default Constructor
        public PostImage() { }

        //Parameterized Constructor
        public PostImage(string title, string autor, string urlImage, bool isPublic)
        {
            this.ID = CreateID();
            this.Title = title;
            this.Autor = autor;
            this.IsPublic = isPublic;

            this.urlImage = urlImage;
        }

        public override string ToString()
        {
            return String.Format(" {0} - {1} - {2} - Created by {3}", this.ID, this.Title, this.urlImage, this.Autor);
        }
    }
}
