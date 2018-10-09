using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_project
{
    class Library
    {

            List<Books> books = new List<Books>();

            public void Add(Books book)
            {
                books.Add(book);
            }

        
    }
}
