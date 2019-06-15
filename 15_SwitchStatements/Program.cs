using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_SwitchStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            int userChoice;
            Console.Write("Give me the number (1- 7) so I can tell you the day name!: ");
            userChoice = Convert.ToInt32(Console.ReadLine());
            Console.Write("You choice: " + GetDayName(userChoice));

            Console.ReadKey();

        }

        static string GetDayName(int numb)
        {
            string dayName;

            switch (numb)
            {
                case 1:
                    dayName = "Monday";
                    break;

                case 2:
                    dayName = "Tuesday";
                    break;

                case 3:
                    dayName = "Wednesday";
                    break;

                case 4:
                    dayName = "Thursday";
                    break;

                case 5:
                    dayName = "Friday";
                    break;

                case 6:
                    dayName = "Saturday";
                    break;

                case 7:
                    dayName = "Sunday";
                    break;

                default:
                    dayName = "There is no day!";
                    break;
            }

            return dayName;
        }
    }
}
