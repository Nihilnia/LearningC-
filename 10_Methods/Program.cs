using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            SayHello("Nihil", 12);
            SayHello("Nihil", 13);
            SayHello("Nihil", 14);

            Welcome();

            Console.ReadKey();
        }

        static void SayHello(string userName, int age)
        {
            Console.WriteLine("Hello " + userName + " you are: "  + age);
        }

        static void Welcome()
        {
            string userName;
            Console.Write("What is your name: ");
            userName = Console.ReadLine();
            Console.WriteLine("Welcome dear " + userName);

        }

    }
}
