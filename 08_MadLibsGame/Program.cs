using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_MadLibGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string color, pluralNoun, celebrity;

            Console.Write("Give me a color: ");
            color = Console.ReadLine();

            Console.Write("Give me a plural noun: ");
            pluralNoun = Console.ReadLine();

            Console.Write("Give me a celebrity name: ");
            celebrity = Console.ReadLine();

            Console.WriteLine("\nRoses are {0}\n" +
                "{1} are blue\n" +
                "and I love {2}!", color, pluralNoun, celebrity);

            Console.ReadKey();
        }
    }
}
