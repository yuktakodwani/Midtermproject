using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_project
{
    public enum menuOptionEnum : byte
    {
        findBook = 1,
        findBookbyAuthor = 2,
        findBookbyGenre = 3,
        quit = 9,
    }

    public class Library
    {
        private List<Book> bookList = new List<Book>();

        private string menuText =
        "\n" +
        "******************************************** \n" +
        "Welcome to Library.\n" +
        "Choose the digit as per the action shown below\n" +
        "Find Book by Title  : 1\n" +
        "Find Book by Author : 2\n" +
        "Find Book by Genre  : 3\n" +
        "Quit                : 9\n" +
         "******************************************** \n" +
        "\n" +
        "Enter your Option (Digit)  :  ";

        private byte menuOptionFromUser;


        private void performMenuAction()
        {
            switch (menuOptionFromUser)
            {
                case (byte)menuOptionEnum.findBook:
                    findBook();
                    displayMenu();
                    break;
                case (byte)menuOptionEnum.findBookbyAuthor:
                    // Console.WriteLine("This will find book by author");
                    findBookByAuthor();
                    displayMenu();
                    break;
                case (byte)menuOptionEnum.findBookbyGenre:
                    //Console.WriteLine("This will find book by genre");
                    findBookByGenre();
                    displayMenu();
                    break;
                case (byte)menuOptionEnum.quit:
                    Console.WriteLine("Good Bye");
                    break;
                default:
                    Console.WriteLine("Wrong Option ....... Please select the right menu option");
                    displayMenu();
                    break;
            }
        }

        public void displayMenu()
        {
            Console.WriteLine(menuText);
            menuOptionFromUser = Convert.ToByte(Console.ReadLine());
            performMenuAction();
        }

        public void findBook()
        {
            Console.WriteLine("Viji is yet to write code for finding book by Title");//By Viji
            Console.WriteLine("Enter the Title to search :");
            string iTitle = Console.ReadLine();
            int foundBooks = 0;
            foreach (Book value in bookList)
            {
                if (value.Title.Equals(iTitle))
                {
                    foundBooks++;
                    Console.WriteLine("Book found " + foundBooks);
                    value.printBookInfo();
                }
            }
            if (foundBooks <= 0) {
                Console.WriteLine("Book not found");
            }
            Console.WriteLine();
        }

        public void findBookByAuthor()
        {
            Console.WriteLine("Enter the Author to search :");
            string iAuthor = Console.ReadLine();
            int foundBooks = 0;
            foreach (Book value in bookList)
            {
                if (value.Author.Equals(iAuthor))
                {
                    foundBooks++;
                    Console.WriteLine("Book found " + foundBooks);
                    value.printBookInfo();
                }
            }
            if (foundBooks <= 0)
            {
                Console.WriteLine("Book not found");
            }
            Console.WriteLine();
        }

        public void findBookByGenre()
        {
            Console.WriteLine("Enter the Genre to search :0 for fiction, 1 for nonfiction, 2 for management, 3 for biography");
            int iGenre = 0;
            try
            {
                 iGenre = Convert.ToInt32(Console.ReadLine());
                
            }
            catch(FormatException)
            {
                Console.WriteLine("Genre should be integer");
                findBookByGenre();
            }
            
            int foundBooks = 0;
            foreach (Book value in bookList)
            {
                if ((int) value.Genre == iGenre)
                {
                    foundBooks++;
                    Console.WriteLine("Book found " + foundBooks);
                    value.printBookInfo();
                }
            }
            if (foundBooks <= 0)
            {
                Console.WriteLine("Book not found");
            }
            Console.WriteLine();
        }
        public void QuitProgram()
        {
            Console.WriteLine("Quitting the program");
            Environment .Exit(0);


        }
        public void addBooks()
        {
            // Add the book details
            //method 1 to add book
            Book book1 = new Book();
            book1.Title = "Malgudi Days";
            book1.Author = "R. K. Narayan";
            book1.Genre = genreEnum.fiction;
            book1.Pub_Year = 1970;
            book1.Edition_Lang = "English";
            //method 2 to add book details
            Book book2 = new Book("What happened", "Hillary Clinton", genreEnum.biography, 2017, "English", 21);
            Book book3 = new Book("Hunger Games", "Suzanne Collins", genreEnum.fiction, 2008, "English", 13);
            Book book4 = new Book("Small Fry", "Lisa Brennan Jobs", genreEnum.nonfiction, 2018, "English", 15);
            Book book5 = new Book("Getting things done", "David allen", genreEnum.management, 2002, "English", 03);
            Book book6 = new Book("Steve Jobs", "Walter Isaacson", genreEnum.biography, 2011, "English", 61);
            Book book7 = new Book("Pride and prejudice", "Jane austin", genreEnum.fiction, 2000, "English", 22);

            //Add the book to book list
            bookList.Add(book1);
            bookList.Add(book2);
            bookList.Add(book3);
            bookList.Add(book4);
            bookList.Add(book5);
            bookList.Add(book6);
            bookList.Add(book7);

            //Remove books from list
           /* var results = new List<Book>//assign values to results
            {
               new Book (){ Title= "Getting Things done", Author = "David allen", Pub_Year = 2002},
                new Book(){ Title= "Pride and prejudice", Author = "Jane austin", Pub_Year = 2000}
           };
            var removeList = new List<string>() { "Getting things done", "Pride and prejudice" };*/

            // Print the book List
            Console.WriteLine("All the books");
            foreach (Book value in bookList)
            {
                value.printBookInfo();
            }
        }

    }
}

