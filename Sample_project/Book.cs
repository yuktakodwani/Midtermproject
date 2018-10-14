using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_project
{
    public enum genreEnum { fiction, nonfiction, management, biography }

    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public genreEnum Genre { get; set; }
        public int Pub_Year { get; set; }
        public string Edition_Lang { get; set; }
        public int ID_No { get; set; }
        public Book(string title, string author, genreEnum genre, int pub_year, 
                                        string Edition_Lang, int ID_No)

        {
           this.Title = title;
            this.Author = author;
           this.Genre = genre;
            this.Pub_Year = pub_year;
            this.Edition_Lang = Edition_Lang;
            this.ID_No = ID_No;

        }
        public Book() { }

        public void printBookInfo()
        {
            Console.WriteLine("Book Title : " + Title + " Author : " + Author + " Genre : " + Genre 
                + " Pub Year : " + Pub_Year + "Edition Lang : " + Edition_Lang + "ID_No :" +ID_No );
        }

    }

}
