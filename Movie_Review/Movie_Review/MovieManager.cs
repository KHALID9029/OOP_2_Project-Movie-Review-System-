using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_Review
{
    internal class MovieManager
    {
        private List<User> users=new List<User>();
        private List<Movie> movies=new List<Movie>();
        private List<Reviews> reviewList=new List<Reviews>();

        public void addUser(string username)
        {
            User U = new User(username);
            users.Add(U);
        }

        public void addMovie(string moviename, int yearOfRelease, List<string> genre)
        {
            Movie m = new Movie(moviename, yearOfRelease, genre);
            movies.Add(m);
        }

        public void addReviews(string name, string moviename, int rating)
        {
            bool youCanAddReview=false;

            try
            {
                foreach (User u in users)
                {
                    if (u.username == name)
                    {
                        if (u.status == "Critic")
                        {
                            rating *= 2;
                            youCanAddReview = true;
                        }
                        else
                        {
                            youCanAddReview = true;
                        }
                    }
                }
                if (youCanAddReview)
                {
                    Reviews reviews = new Reviews(name, moviename, rating);
                    reviewList.Add(reviews);
                    foreach (User user in users)
                    {
                        if (user.username == name) { user.totalReviews++; break; }
                    }
                }
            }
            catch (Exception e) { Console.WriteLine(e.Message); }
        }

        public bool findMovieByName(string mName)
        {
            foreach(Movie movie in movies) 
            {
                if(movie.movieName==mName && movie.yearOfRelease<2025)
                {
                    return true;
                }
            }
            return false;
        }

        public bool findSameReview(string username, string moviename,int rating)
        {
            foreach(Reviews r in reviewList)
            {
                if(r.moviename==moviename && r.username==username)
                {
                    return true;
                }
            }
            return false;
        }

        public void updateUser(string username)
        {
            foreach(User user in users)  
            {
                if(user.username==username && user.totalReviews>3)
                {
                    user.status = "Critic";
                }
            }
        }

        public void printMovies()
        {
            foreach (Movie movie in movies)
            {
                Console.WriteLine($"{movie.movieName} is released in Year {movie.yearOfRelease}");
            }
        }

        public void printUsers()
        {
            foreach(User u in users)
            {
                Console.WriteLine($"{u.username} has rated {u.totalReviews} and has status {u.status}");
            }
        }
    }
}
