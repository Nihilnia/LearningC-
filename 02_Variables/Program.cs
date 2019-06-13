using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            string characterName = "Nihil";
            int characterAge;
            characterAge = 70;

            Console.WriteLine("There once was a man named " + characterName);
            Console.WriteLine("He was " + characterAge + " years old.");

            characterName = "Nia";
            Console.WriteLine("He reall liked the name " + characterName);
            Console.WriteLine("But didn't like the being " + characterAge);

            Console.ReadKey();

        }
    }
}
