using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_Review
{
    public class Movie
    {
        public string movieName;
        public int yearOfRelease;
        public List<string> genre;

        public Movie(string movieName, int yearOfRelease, List<string> genre)
        {
            this.movieName = movieName;
            this.yearOfRelease = yearOfRelease;
            this.genre = genre;
        }

        public void printInfo()
        {
            Console.WriteLine($"{this.movieName} is released in Year {this.yearOfRelease}");
        }
    }
}
