using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_Review
{
    internal interface IMovieAdder
    {
        void addMovie(ref List<Movie> movies);

        bool doesMovieExists(string moviename, ref List<Movie> movies);
    }

    internal class MovieAdder:IMovieAdder
    {
        public void addMovie(ref List<Movie> movies)
        {
            Console.WriteLine("Enter Movie Name: ");
            string moviename = Console.ReadLine();
            Console.WriteLine("Enter Year Of Release : ");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Total Number Of Geners: ");
            int numofGenres = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Genres: ");
            List<string> genres = new List<string>();
            while (numofGenres > 0)
            {
                string genresString = Console.ReadLine();
                genres.Add(genresString);
                numofGenres--;
            }
            
            if(!doesMovieExists(moviename,ref movies))
            {
                Movie m = new Movie(moviename, year, genres);
                movies.Add(m);

                Console.WriteLine();
                Console.WriteLine("Movie Added Successfully");

                Console.WriteLine();
                Console.WriteLine("Press Any Key To Continue");
                
            }
            else
            {
                throw new Exception("Movie Already Exists");
            }
        }

        public bool doesMovieExists(string moviename,ref List<Movie> movies)
        {
            foreach (Movie movie in movies) 
            {
                if(movie.movieName == moviename) return true;
            }
            return false;
        }
    }
}
