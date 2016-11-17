using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //single line comment
            Console.WriteLine("Hello Sajid. Welcome to C#");
            Console.WriteLine("Hi Again");
            /*
             * multi
             * line 
             * comment
             */
            int age = 39;
            Console.WriteLine("My age is " + age );
            age++;
            Console.WriteLine(age);
            int a;
            int b;

            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            int c = a * b;
            Console.WriteLine("Multiplication result of "+ a + " with " + b + " is " + c);
            int test = int.Parse(Console.ReadLine());
            test += 5;
            Console.WriteLine("Result of test +" + test);
            test *= 5;
            Console.WriteLine("Result of test *" + test);
            test /= 5;
            Console.WriteLine("Result of test *" + test);
            Console.ReadLine();


        }
    }
}
