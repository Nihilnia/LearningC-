using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_BuildingAnExponentMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            int baseNumb, powNumb;
            Console.Write("Base number: ");
            baseNumb = Convert.ToInt32(Console.ReadLine());

            Console.Write("Power number: ");
            powNumb = Convert.ToInt32(Console.ReadLine());

            int result = 1;

            for (int i = 1; i <= powNumb; i++)
            {
                result *= baseNumb;
            }
            Console.WriteLine("Result: " + result);

            Console.ReadKey();

        }
    }
}
