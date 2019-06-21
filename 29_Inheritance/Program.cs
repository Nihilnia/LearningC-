using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Song song01 = new Song("Song", "Eminem", "06.21.2019");
            song01.ShowInfos();

            song01.writeSomethings();

            Console.ReadKey();
        }
    }
}
