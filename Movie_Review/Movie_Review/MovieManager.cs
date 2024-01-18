using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_Review
{
    internal class MovieManager
    {
        public void addUser(ref List<User>users)
        {
            IUserAdder userAdder = new UserAdder();
            userAdder.addUser(ref users);
        }

        

        public void addAdventureMovie(ref List<Movie> movies)
        {
            IMovieAdder movieAdder = new AdventureMovieAdder();
            movieAdder.addMovie(ref movies);
        }

        public void addActionMovie(ref List<Movie> movies)
        {
            IMovieAdder movieAdder = new ActionMovieAdder();
            movieAdder.addMovie(ref movies);
        }

        public void addThrillerMovie(ref List<Movie> movies)
        {
            IMovieAdder movieAdder = new ThrillerMovieAdder();
            movieAdder.addMovie(ref movies);
        }

        public void addReviews(ref List<User> users, ref List<Reviews> reviews, ref List<Movie> movies)
        {
            IReviewAdder reviewAdder = new ReviewAdder();
            reviewAdder.addReview(ref users,ref reviews,ref movies);
        }

        //Avarage Rating of a Movie
        public void AvgRating(ref List<Reviews>reviewList)
        {
            Console.WriteLine("Enter Movie Name : ");
            string mName=Console.ReadLine();

            double rating = 0;
            double count = 0;
            foreach(Reviews r in reviewList)
            {
                if(r.moviename==mName)
                {
                    rating += r.rating;
                    count++;
                }
            }
            if(count==0)
            {
                Console.WriteLine("Movie not rated yet");
            }
            else
            {
                double ans=rating/count;
                string formattedAns = $"{ans:F2}";
                Console.WriteLine();
                Console.WriteLine($"Avarage Rating of {mName} is {formattedAns}");

                Console.WriteLine();
                Console.WriteLine("Press Any Key To Continue");
            }
        }
    }
}
