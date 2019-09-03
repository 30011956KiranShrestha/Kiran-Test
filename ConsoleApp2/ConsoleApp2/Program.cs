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
            // 2(x+3) + x = 12
            // 2x + 6 + x = 12
            // 3x = 12-6
            // 3x = 6
            // x = 2

            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("-------can you solve the following algebraic expression-----------");
            Console.WriteLine("------------------------------------------------------------------");

            Console.Write("\nEnter your guess at the value of X: ");
            int num1 = int.Parse(Console.ReadLine());

            if (num1 == 2)
                Console.Write("\nYour guess is correct");
            else
                Console.Write("\nSorry that guess is incorrect");
            Console.ReadLine();


        }
    }
}
