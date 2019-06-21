using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_GettersAndSetters
{
    class Movie
    {
        public string name, director;
        private int rating;

        public Movie(string pName, string pDirector, int pRating)
        {
            name = pName;
            director = pDirector;
            Rating = pRating;
        }

        public void showInfos()
        {
            Console.WriteLine("#### All Informations of Movie\n" +
                "Name: {0}\n" +
                "Director: {1}\n" +
                "Rating: {2}\n\n", name, director, rating);
        }

        public int Rating
        {
            get { return rating; }
            set {
                if (value == 1 || value == 2 || value == 3)
                {
                    rating = value;
                }
                else
                {
                    rating = 0;
                }
            }
        }
    }
}
