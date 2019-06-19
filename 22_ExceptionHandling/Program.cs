using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {

            int numberOne, numberTwo;
            double result;

            try
            {
                Console.Write("Give me the number: ");
                numberOne = Convert.ToInt32(Console.ReadLine());

                Console.Write("Give me the second number: ");
                numberTwo = Convert.ToInt32(Console.ReadLine());

                result = numberOne / numberTwo;
                Console.WriteLine(result);

            }
            catch (Exception x)
            {

                Console.WriteLine("Hey, somethings bad happened:\n" + "\"" + x.Message + "\"");
            }


            /*
             * And there is another way to catch spesific exceptions
             * 
             */


            try
            {
                Console.Write("Give me the number: ");
                numberOne = Convert.ToInt32(Console.ReadLine());

                Console.Write("Give me the second number: ");
                numberTwo = Convert.ToInt32(Console.ReadLine());

                result = numberOne / numberTwo;
                Console.WriteLine(result);

            }
            catch (DivideByZeroException) //You can define an exception also: DivideByZerException xx
            {

                Console.Write("Hey, you can't divide a number to zero");
            }
            catch (FormatException)
            {
                Console.WriteLine("You should give the number, not a character or word..");
            }
            finally
            {
                Console.WriteLine("This block always works!");
            }

            Console.ReadKey();
            
        }
    }
}
