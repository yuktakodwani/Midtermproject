 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_project
{
    enum genreEnum { fiction, nonfiction, management, biography }

    enum menuOptionEnum : byte
    {
        findBook = 1,
        findBookbyAuthor = 2,
        findBookbyGenre = 3,
        quit = 9,
    }

    class Program
    {
        private static string menuText =
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

        private static byte menuOptionFromUser;

        private static void readMenuInput()
        {
            switch (menuOptionFromUser)
            {
                case (byte)menuOptionEnum.findBook:
                    Console.WriteLine("This will find book by title");
                    displayMenu();
                    break;
                case (byte)menuOptionEnum.findBookbyAuthor:
                    Console.WriteLine("This will find book by author");
                    displayMenu();
                    break;
                case (byte)menuOptionEnum.findBookbyGenre:
                    Console.WriteLine("This will find book by genre");
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

        private static void displayMenu()
        {
            Console.WriteLine(menuText);
            menuOptionFromUser = Convert.ToByte(Console.ReadLine());
            readMenuInput();
        }

        static void Main(string[] args)
        {
            Book book1 = new Book();
            book1.Title = "Malgudi Days";
            book1.Author = "R. K. Narayan";
            book1.Genre = genreEnum.fiction;

            Book book2 = new Book("What happended", "Hillory Clinton", genreEnum.biography,2017);

            displayMenu();
            Console.ReadLine();
        }
    }
}

