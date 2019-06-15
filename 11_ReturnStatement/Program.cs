using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_ReturnStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNumber, secondNumber;

            Console.Write("Give me the first number: ");
            firstNumber = Convert.ToDouble(Console.ReadLine());
            Console.Write("Give me the second number: ");
            secondNumber = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("{0} / {1} = {2}", firstNumber, secondNumber, xyz(firstNumber, secondNumber));


            Console.Write("Give me a number between 1 - 4: ");
            int userNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You choose {0} and the family member is as your choice: {1}", userNumber, DearFamily()[userNumber - 1]);
            Console.ReadKey();


        }

        static double xyz(double number01, double number02)
        {
            double result = number01 / number02;
            return result;
        }

        static string[] DearFamily()
        {
            string[] myFamily = {"Necla", "Burhan", "Burak", "Okan"};
            return myFamily;
        }
    }
}
