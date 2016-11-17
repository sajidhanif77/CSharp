using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            String firstName;
            String lastName;
            String username;
            String domain;
            String twitter;

            firstName = "Sajid";
            lastName = "Hanif";
            username = "sajid1312";
            domain = "yahoo.com";
            twitter = "msh_2010";

            Console.WriteLine("Bonjour, Je me presente :");
            Console.WriteLine(firstName + " " + lastName);
            Console.WriteLine("Voici mon twitter : http://twitter.com/" + twitter);
            Console.WriteLine("Et voici mon addresse mail :");
            Console.WriteLine(username + "@" + domain);
            Console.WriteLine("Appuyez sur une touche pour continuer :");
            Console.ReadLine();
            Console.WriteLine();


        }
    }
}
