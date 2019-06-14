using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_GettingUserInput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Who is there? ");
            string thePerson = Console.ReadLine();
            Console.Write("Okay.. But what are you doing? ");
            string doing = Console.ReadLine();
            Console.Write("I hope things are going well /w " + doing + " " + thePerson);

            Console.ReadKey();
        }
    }
}
