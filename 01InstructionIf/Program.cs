using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01InstructionIf
{
    class Program
    {
        static void Main(string[] args)
        {
            String user = "Sajid Hanif";
            String gender = "Masculin";

            decimal bankAccount = 0.5M;
            // M is used to precise decimal otherwise it is taken as double and by default the compiler is unable to do the conversion.
            decimal amount;
            String operationType;

            amount = 300;
            bankAccount += amount;

            Console.WriteLine("Amount Added to your bank Account: " + amount);

            amount = -20;
            bankAccount += amount;

            Console.WriteLine("Amount Deducted from your bank Account: " + amount);

            operationType = "Credit";
            amount = 50;

            if ((operationType == "Credit") && (amount >= 0)){
                Console.WriteLine("Credit operation took place ");
                
            }
            Console.ReadLine();

        }
    }
}
