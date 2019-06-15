using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_BuildingBetterCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double userNum1, userNum2;
            Console.Write("Give me the first number: ");
            userNum1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Give me the operator (+ , - , / , x): ");
            char userOp = Convert.ToChar(Console.ReadLine());

            Console.Write("Give the second number: ");
            userNum2 = Convert.ToDouble(Console.ReadLine());

            

            if (userOp == '+')
            {
                Console.WriteLine("{0} + {1} = {2}", userNum1, userNum2, userNum1 + userNum2);
            }else if (userOp == '-')
            {
                Console.WriteLine("{0} - {1} = {2}", userNum1, userNum2, userNum1 - userNum2);
            }
            else if (userOp == '/')
            {
                Console.WriteLine("{0} / {1} = {2}", userNum1, userNum2, userNum1 / userNum2);
            }
            else if(userOp == 'x'){
                Console.WriteLine("{0} x {1} = {2}", userNum1, userNum2, userNum1 * userNum2);
            }
            else
            {
                Console.WriteLine("Invalid Operator given.");
            }

            Console.ReadKey();

        }
    }
}
