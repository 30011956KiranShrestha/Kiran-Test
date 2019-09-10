using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*********************************************************************");
            Console.WriteLine("************This Program  give the sum of total of price*************");
            Console.WriteLine("*********************************************************************");
            Console.WriteLine("\nHello");
            Double total = 0;
            for (int i = 1; i <=5; i++)

            {
                Console.Write($"\nEnter the price of item {i}: ");
                total += double.Parse(Console.ReadLine());


            }
            Console.WriteLine($"\nTotal of all items is: ${total} ");
            Console.ReadLine();




            




        }
    }
}
