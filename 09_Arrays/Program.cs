using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] randomNumbers = {1, 323, 67, 55544, 110};
            Console.WriteLine(randomNumbers[2]); //67
            Console.WriteLine(randomNumbers[randomNumbers.Length - 1]); //Last item (110)

            //Update an array
            randomNumbers[randomNumbers.Length - 1] = 700;
            Console.WriteLine(randomNumbers[randomNumbers.Length - 1]); //Last item 'changed' (700)

            //Another way to create an array
            string[] dearFamily = new string[3];
            dearFamily[0] = "Necla";
            dearFamily[1] = "Burhan";
            dearFamily[2] = "Burak";
            Console.WriteLine(dearFamily[2]); //Bu aralar konumuz Burak çünkü

            Console.ReadKey();
        }
    }
}
