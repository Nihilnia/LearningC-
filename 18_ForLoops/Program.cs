using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_ForLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] luckNumbers = {2, 4, 18, 12, 24};

            for (int i = 0; i < luckNumbers.Length; i++)
            {
                Console.WriteLine(luckNumbers[i]);
            }

            Console.ReadLine();

        }
    }
}
