using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_ClassesAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Song song01 = new Song();

            song01.name = "Virulence";
            song01.artist = "Helion";
            song01.id = 123456;

            Console.WriteLine(song01.id);
            Console.WriteLine(song01.artist);
            Console.WriteLine(song01.name);

            Console.ReadKey();
        }
    }
}
