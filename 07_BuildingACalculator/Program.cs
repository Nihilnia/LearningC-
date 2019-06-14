using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_BuildingACalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            double number01 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter another number: ");
            double number02 = Convert.ToDouble(Console.ReadLine());
            
            Console.Write(number01 + " + " + number02 + " = " + (number02 + number01));
                                                                //if you combine directly with strings, then the result will be wrong

            Console.ReadKey();

        }
    }
}
