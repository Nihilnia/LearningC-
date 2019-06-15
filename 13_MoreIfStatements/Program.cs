using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_MoreIfStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            int userNumber1, userNumber2, userNumber3;
            Console.Write("Give me a number: ");
            userNumber1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Give me the second number: ");
            userNumber2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Give me the another number: ");
            userNumber3 = Convert.ToInt32(Console.ReadLine());

            if (userNumber1 == userNumber2 && userNumber1 == userNumber3)
            {
                Console.Write("All of them equal.");
            }
            else
            {
                Console.Write("Bigger number is: " + GetMax(userNumber1, userNumber2, userNumber3));
            }
            

            Console.ReadKey();

        }

        static int GetMax(int num1, int num2, int num3)
        {
            if (num1 > num2 && num1 > num3)
            {
                return num1;
                
            }
            else if(num2 > num3 && num2 > num1)
            {
                return num2;
            }
            else
            {
                return num3;
            }
        }
    }
}
