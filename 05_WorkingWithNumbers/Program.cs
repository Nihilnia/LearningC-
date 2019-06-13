using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_WorkingWithNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(2 * (8 + 3) * 3);

            Console.WriteLine("Integer / Integer = Integer");
            Console.WriteLine("5 / 2 = " + 5 / 2);
            Console.WriteLine("\nBut..\nInteger / Double = Double");
            Console.WriteLine("5.0 / 2 = " + 5.0 / 2);

            int num = 6;
            num += 1;
            Console.WriteLine("\n\nnum += 1 --->" + num);
            // or
            num++;
            Console.WriteLine("Or\nnum++ --->" + num);

            // Some methods of numbers (Math)

            // Abs() - Absolute value of number
            Console.WriteLine("\nAbs: " + Math.Abs(-40)); //40

            // Pow() - Power of number
            Console.WriteLine("Pow: " + Math.Pow(2, 3)); //8

            // Sqrt() - Square Root
            Console.WriteLine("Sqrt: " + Math.Sqrt(36)); //6

            // Max() - Which number is bigger
            Console.WriteLine("Max: " + Math.Max(12, 88)); //88

            // Min() - Which number is smaller
            Console.WriteLine("Min: " + Math.Min(12, 88)); //12

            // Round() - Round the number 'if decimal is bigger than 5: round it to up'
            Console.WriteLine("Round up: " + Math.Round(2.6)); //3
            Console.WriteLine("Round down: " + Math.Round(2.5)); //2

            Console.ReadKey();
        }
    }
}
