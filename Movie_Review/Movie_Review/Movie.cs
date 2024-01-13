using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_Review
{
    public class Movie
    {
        public string movieName { get; set; }
        public int yearOfRelease { get; set; }
        public string genre { get; set; }

        public void printInfo()
        {
            Console.WriteLine($"{this.movieName} is released in Year {this.yearOfRelease} and it's a {this.genre} Movie");
        }
    }

    public class ActionMovie: Movie
    {
        public ActionMovie(string movieName, int yearOfRelease)
        {
            this.movieName = movieName;
            this.yearOfRelease = yearOfRelease;
            this.genre = "Action";
        }
    }


    public class ThrillerMovie:Movie
    {
     
        public ThrillerMovie(string movieName, int yearOfRelease)
        {
            this.movieName = movieName;
            this.yearOfRelease = yearOfRelease;
            this.genre = "Thriller";
        }
    }

    public class AdventureMovie : Movie
    {
        public AdventureMovie(string movieName, int yearOfRelease)
        {
            this.movieName = movieName;
            this.yearOfRelease = yearOfRelease;
            this.genre = "Adventure";
        }
    }
}
