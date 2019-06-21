using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_StaticClassAttributes
{
    class Program
    {
        static void Main(string[] args)
        {
            Song song01 = new Song("Broken Phone Blues", "Black Strobe", 4.34);
            song01.ShowInfos();

            Song song02 = new Song("A New World", "Zülfü Livaneli,", 4.32);
            song02.ShowInfos();

            // Show the count that how many song is there?

            Console.WriteLine("There is totally {0} song created!", Song.songCount);


            Console.ReadKey();
        }
    }
}
