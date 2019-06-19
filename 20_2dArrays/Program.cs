using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_2dArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //I know what is 2d arrays already.
            //Let's build a "2d array reader"
            // btw , int[,] nameIt = new int[2, 3]

            int[,] randomArrays = {
                {1, 2},
                {2, 3},
                {3, 4},
                {3, 4},
                {3, 4},
                {3, 4},
                {3, 4},
            };

            for (int start = 0; start < randomArrays.GetLength(0); start++)
            {
                Console.Write(randomArrays[start, 0]);
                Console.WriteLine(randomArrays[start, 1]);


            }

            Console.ReadKey();
        }
    }
}
