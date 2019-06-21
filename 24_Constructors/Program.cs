using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Song song01 = new Song("House of the Rising Sun", "The Animals", 123456);

            string artist = song01.artist;
            Console.WriteLine("Artist: " + artist);

            Console.ReadKey();
        }
    }
}
