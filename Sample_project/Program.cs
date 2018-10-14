 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_project
{

    public class Program
    {

//        private byte menuOptionFromUser;

        static void Main(string[] args)
        {
            Library lib1 = new Library();
            lib1.addExistingBooks();
            lib1.printListOfBooks();
            lib1.displayMenu();
            lib1.printListOfBooks();
            Console.ReadLine();
        }
    }
}

