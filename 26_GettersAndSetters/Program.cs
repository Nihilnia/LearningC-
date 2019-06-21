using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_GettersAndSetters
{
    class Program
    {
        static void Main(string[] args)
        {
            Movie movie01 = new Movie("Shrek", "ASDASD", -1);

            movie01.showInfos();

            Console.ReadKey();
        }
    }
}
