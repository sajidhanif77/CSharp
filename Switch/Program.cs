using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            string result = ReadAndWrite("Enter Month: ");
            Console.WriteLine(result);

            switch (result)
            {
                case "January":
                case "February":
                    {   Console.WriteLine ("Winter");
                        Console.ReadLine();
                        break;
                    }
                case "March":
                case "April":
                    {
                        Console.WriteLine("Spring");
                        Console.ReadLine();
                        break;
                    }

            }
        }

        private static string ReadAndWrite(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();
        }
    }
}
