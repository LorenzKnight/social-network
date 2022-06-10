using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork
{
    class Publication
    {
        private static int PublicationID;

        //Properties
        protected int ID { get; set; }
        protected string Title { get; set; }
        protected string Autor { get; set; }
        protected bool IsPublic { get; set; }

        //Default Constructor
        public Publication()
        {
            ID = CreateID();
            Title = "My first publication";
            IsPublic = true;
            Autor = "Juan Perez";
        }

        //Parameterized Constructor
        public Publication(string title, bool isPublic, string autor)
        {
            this.ID = CreateID();
            this.Title = title;
            this.IsPublic = isPublic;
            this.Autor = autor;
        }

        //Method to create ID
        protected int CreateID()
        {
            return ++PublicationID;
        }

        //Method to edit post
        public void Edit(string title, bool isPublic)
        {
            this.Title = title;
            this.IsPublic = isPublic;
        }

        public override string ToString()
        {
            return String.Format(" {0} - {1} - Created by {2}", this.ID, this.Title, this.Autor);
        }
    }
}
