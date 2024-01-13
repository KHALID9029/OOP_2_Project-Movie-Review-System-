using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Movie_Review
{
    internal interface IWrite<T>
    {
        void Write(T item);
    }

    internal class WriteUser:IWrite<User>
    {
        public void Write(User user) 
        {
            string user_file = @"C:\OOP2_Project\User.txt";
            string info = $"{user.username},{user.status},{user.totalReviews}\n";
            File.AppendAllText(user_file, info);
        }
    }

    internal class WriteMovie:IWrite<Movie>
    {
        public void Write(Movie movie)
        {
            string movieFile = @"C:\OOP2_Project\Movies.txt";
            string info = $"{movie.movieName},{movie.yearOfRelease},{movie.genre}\n";
            File.AppendAllText(movieFile, info);
        }
    }

    internal class WriteReview:IWrite<Reviews>
    {
        public void Write(Reviews review) 
        {
            string reviewFile = @"C:\OOP2_Project\Reviews.txt";
            string info = $"{review.username},{review.moviename},{review.rating}\n";
            File.AppendAllText(reviewFile, info);
        }
    }
}
