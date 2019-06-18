using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_WhileLoops
{
    class Program
    {
        static void Main(string[] args)
        {

            int numb = 1;

            while (numb <= 5)
            {
                Console.WriteLine(numb);
                numb++;
            }


            //do while Loop

            int numb2 = 8;

            do
            {
                Console.WriteLine("\n" + numb2);
                numb2++;
            } while (numb2 <= 10);

            Console.ReadKey();
        }
    }
}
