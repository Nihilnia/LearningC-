using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29_Inheritance
{
    class Song : Art //inheritance
    {
        public Song(string pVarious, string pArtist, string pDate)
        {
            various = pVarious;
            artist = pArtist;
            date = pDate;
        }

        public override void writeSomethings() //override
        {
            Console.WriteLine("Fatboy Slim");
        }

    }
}
