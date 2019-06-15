 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_IfStatements
{
    class Program
    {
        static void Main(string[] args)
        {

            bool isMale = true;
            bool isTall = true;

            if (isMale && isTall)
            {
                Console.WriteLine("You are a tall male.");
            }
            else if (isMale && !isTall)
            {
                Console.WriteLine("You are a male but not tall.");
            }
            else if (!isMale && isTall)
            {
                Console.WriteLine("You are not a male but you're tall");
            }
            else
            {
                Console.WriteLine("Either you're not a mal and not tall");
            }

            while (true)
            {       

                int userNumber;
                Console.Write("Give me a number: ");
                userNumber = Convert.ToInt32(Console.ReadLine());

                if (userNumber % 2 == 0)
                {
                    Console.WriteLine("Your number is an even number.");
                }
                else
                {
                    Console.WriteLine("Your number is an odd number.");

                }
            }
            
        }
    }
}
