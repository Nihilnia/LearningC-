using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29_Inheritance
{
    class Art
    {
        public string various, artist, date;

        public void ShowInfos()
        {
            Console.WriteLine("# # # # ALL INFORMATIONS ABOUT THIS ART # # # #\n" +
                "Various:   {0}\n" +
                "Artist:    {1}\n" +
                "Date:      {2}\n\n", various, artist, date);
        }

        public virtual void writeSomethings() //virtual == okay for override.
        {
            Console.WriteLine("Right Here Right Now");
        }

    }
}
