 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_project
{
   class Program
    {                  

        public static void Main(string[] args)
        {
            
            string[] AuthorName = new string[5];
            AuthorName[0] = "SidneySheldon";
            AuthorName[1] = "Jeffrey Archer";
            AuthorName[2] = "Dan Brown";
            AuthorName[3] = "R.K.Narayan";
            AuthorName[4] = "John Grisham";

            for (int i = 0; i<AuthorName.Length; i++)
            {
                if (AuthorName[i].Equals("Dan Brown"))
                {
                    Console.WriteLine("Author found");
                }
               Console.WriteLine(AuthorName[i]);

                Console.ReadLine();

                //Console.WriteLine(AuthorName[1]);

            }
            






    }

    }
}
