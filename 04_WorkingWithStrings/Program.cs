using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_WorkingWithStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string nick = "Nihil" + "Nia";
            Console.WriteLine("String nick's lenght = " + nick.Length);
            Console.WriteLine("Upper to nick: " + nick.ToUpper());

            Console.WriteLine("Nihil \"Nia\"\n");
            Console.WriteLine("Like\nPython\n\n");

            // Some Methods of Strings

            // ToUpper()
            // ToLower()

            // Contains()
            string artist = "Hayko Cepkin";
            Console.WriteLine(artist.Contains("Hayko")); //True
            Console.WriteLine(artist.Contains("Gorillaz")); //False
            Console.WriteLine(artist.Contains("i")); //True

            // IndexOf()
            string os = "Operating System";
            Console.WriteLine(os.IndexOf('m')); //15
            Console.WriteLine(os.IndexOf("rating")); //3
            Console.WriteLine(os.IndexOf("z")); //-1 ('z' is not in the string)

            // Substring()
            string info = "Visual Studio";
            Console.WriteLine(info.Substring(7, 3)); //Stu
            //Another Example
            string player = "Player One";
            int cutThePlayer = player.IndexOf("Player") + 7;
            Console.WriteLine(player.Substring(cutThePlayer));
            string player2 = "Player Two";
            Console.WriteLine(player2.Substring(cutThePlayer));


            Console.ReadKey();
        }
    }
}
