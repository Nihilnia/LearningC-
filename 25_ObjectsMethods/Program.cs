using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_ObjectsMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student01 = new Student("Nihil", "Nia", 3.6);
            Student student02 = new Student("Simulation", "Simulacra", 3.4);

            student01.showInfos();


            if (student01.honorReward())
            {
                Console.WriteLine("Student {0} deserve to get honor reward.", student01.name);
            }
            else
            {
                Console.WriteLine("Student {0} NOT deserve to get honor reward.", student01.name);
            }


            Console.ReadKey();
        }
    }
}
