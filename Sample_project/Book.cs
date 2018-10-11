using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_project
{
    public  class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public genreEnum Genre { get; set; }
        public int Pub_Year { get; set; }
        public Book(string title, string author, genreEnum genre, int pub_year)
        {
            Title = title;
            Author = author;
            Genre = genre;
            Pub_Year = pub_year;
        }
        public Book() { }

    }
    
}
