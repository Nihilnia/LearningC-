using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_ObjectsMethods
{
    class Student
    {
        public string name, surname;
        public double gpa;

        public Student(string aName, string aSurname, double aGpa)
        {
            name = aName;
            surname = aSurname;
            gpa = aGpa;
        }

        public void showInfos()
        {
            Console.WriteLine("- - - - Student's Informations - - - -\n" +
                "Name: {0}\n" +
                "Surname: {1}\n" +
                "GPA: {2}\n\n", name, surname, gpa);
        }

        public bool honorReward()
        {
            if (gpa >= 3.5)
            {
                return true;
            }
            return false;
        }


    }
}
