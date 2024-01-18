using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_Review
{
    public interface IMovieAdder
    {
        void addMovie(ref List<Movie> movies);

        bool doesMovieExists(string moviename, ref List<Movie> movies);
    }

    public class AdventureMovieAdder:IMovieAdder
    {
        public void addMovie(ref List<Movie> movies)
        {
            Console.WriteLine("Enter Movie Name: ");
            string moviename = Console.ReadLine();
            Console.WriteLine("Enter Year Of Release : ");
            int year = Convert.ToInt32(Console.ReadLine());
           
            
            if(!doesMovieExists(moviename,ref movies))
            {
                Movie m = new AdventureMovie(moviename, year);
                movies.Add(m);

                //Console.WriteLine($"{m.genre}");
                //Console.ReadLine();

                Console.WriteLine();
                Console.WriteLine("Movie Added Successfully");

                IWrite<Movie> writeMovie = new WriteMovie();
                writeMovie.Write(m);

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

    public class ThrillerMovieAdder:IMovieAdder
    {
        public void addMovie(ref List<Movie> movies)
        {
            Console.WriteLine("Enter Movie Name: ");
            string moviename = Console.ReadLine();
            Console.WriteLine("Enter Year Of Release : ");
            int year = Convert.ToInt32(Console.ReadLine());


            if (!doesMovieExists(moviename, ref movies))
            {
                Movie m = new ThrillerMovie(moviename, year);
                movies.Add(m);

                Console.WriteLine();
                Console.WriteLine("Movie Added Successfully");

                IWrite<Movie> writeMovie = new WriteMovie();
                writeMovie.Write(m);

                Console.WriteLine();
                Console.WriteLine("Press Any Key To Continue");

            }
            else
            {
                throw new Exception("Movie Already Exists");
            }
        }

        public bool doesMovieExists(string moviename, ref List<Movie> movies)
        {
            foreach (Movie movie in movies)
            {
                if (movie.movieName == moviename) return true;
            }
            return false;
        }
    }

    public class ActionMovieAdder:IMovieAdder
    {
        public void addMovie(ref List<Movie> movies)
        {
            Console.WriteLine("Enter Movie Name: ");
            string moviename = Console.ReadLine();
            Console.WriteLine("Enter Year Of Release : ");
            int year = Convert.ToInt32(Console.ReadLine());


            if (!doesMovieExists(moviename, ref movies))
            {
                Movie m = new ActionMovie(moviename, year);
                movies.Add(m);

                Console.WriteLine();
                Console.WriteLine("Movie Added Successfully");

                IWrite<Movie> writeMovie = new WriteMovie();
                writeMovie.Write(m);

                Console.WriteLine();
                Console.WriteLine("Press Any Key To Continue");

            }
            else
            {
                throw new Exception("Movie Already Exists");
            }
        }

        public bool doesMovieExists(string moviename, ref List<Movie> movies)
        {
            foreach (Movie movie in movies)
            {
                if (movie.movieName == moviename) return true;
            }
            return false;
        }
    }
}
