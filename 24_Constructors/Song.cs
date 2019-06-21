using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_Constructors
{
    class Song
    {
        public string name, artist;
        public int id;

        public Song(string songName, string songArtist, int songID)
        {
            name = songName;
            artist = songArtist;
            id = songID;

            Console.WriteLine("New song created!\n" +
                "Name: {0}\n" +
                "Artist: {1}\n" +
                "ID: {2}", name, artist, id);
        }
    }
}
