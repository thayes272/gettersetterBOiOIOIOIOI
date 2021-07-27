using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace getterSetterSHIT
{
    class Movie
    {
        public string Title;
        private string rating;
        public int seconds;
        public Movie(string aTitle, string aRating, int secondsTotal)
        {
            Title = aTitle;
            Rating = aRating;
            seconds = secondsTotal;
        }

        public string Rating
        {
            get { return rating; }
            set
            {
                if (value == "R" || value == "PG-13" || value == "PG" || value == "NR")
                {
                    rating = value;
                }
                else
                {
                    rating = "NR";
                }
            }
        }


    }

}
