using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_StaticClassAttributes
{
    class Song
    {
        public string name, artist;
        public double duration;
        public static int songCount = 0;

        public Song(string pName, string pArtist, double pDuration)
        {
            artist = pArtist;
            name = pName;
            duration = pDuration;
            songCount += 1;
        }

        public void ShowInfos()
        {
            Console.WriteLine("----- ALL INFORMATIONS OF SONG -----\n" +
                "Name: {0}\n" +
                "Artist: {1}\n" +
                "Duration: {2}\n", name, artist, duration);
        }

        public int getSongCount()
        {
            return songCount;
        }
    }

}
