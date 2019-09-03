using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("**********This program give the result of Base^Exponent**********");
            Console.WriteLine("*****************************************************************");
            Console.Write("\nEnter the value of base: ");
            Double bNum = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nEnter the value of Exponent: ");
            int pwr = Convert.ToInt32(Console.ReadLine());
            result=CalcuOfPower(bnum, pwr);


            Console.Write("\nThe value of {0} to the power of {1} is : {2} \n\n}
     

        }
    }
}
