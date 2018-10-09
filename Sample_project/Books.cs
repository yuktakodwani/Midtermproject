using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_project
{
   public  class Books
    {
        public string BookName { get; set; }
        public string AuthorName { get; set; }
        public string Genre { get; set; }
        public int Pub_Year { get; set; }

        public Books(string bookName, string authorName, string Genre, int Pub_Year)
        {
            this.BookName = bookName;
            this.AuthorName = authorName;
            this.Genre = Genre;
            this.Pub_Year = Pub_Year;

        }

    }
    
}
