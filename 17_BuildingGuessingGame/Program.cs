using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_BuildingGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {

            string animal = "Rat";
            string userGuess = "";
            int guessRight = 5;

            while (userGuess != animal && guessRight != 0)
            {
                Console.WriteLine("What is your predict?: ");
                userGuess = Console.ReadLine();

                if (userGuess == animal)
                {
                    Console.WriteLine("You won!");
                }
                else
                {
                    Console.WriteLine("Not {0}, try again..", userGuess);
                    guessRight--;
                    Console.WriteLine("{0} guess remaining...\n", guessRight);

                    if (guessRight == 0)
                    {
                        Console.WriteLine("Sorry, but you used all your guess rights..");
                    }
                }
                
            }
            
            

            Console.ReadKey();
        }
    }
}
