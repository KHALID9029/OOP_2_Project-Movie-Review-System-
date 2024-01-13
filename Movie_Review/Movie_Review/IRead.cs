using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_Review
{
    internal interface IRead<T> 
    {
        void Read(ref List<T>items);
    }

    internal class ReadUsers:IRead<User>
    {
        public void Read(ref List<User> users)
        {
            string user_file = @"C:\OOP2_Project\User.txt";

            if (File.Exists(user_file))
            {
                StreamReader sr = new StreamReader(user_file);
                string line;

                while ((line = sr.ReadLine()) != null)
                {
                    string[] s = null;
                    s = line.Split(',');

                    string userName = s[0];
                    string status = s[1];
                    int totalReviews =Convert.ToInt32 (s[2]);
                    
                    User tempUser = new User(userName, status, totalReviews);
                    users.Add(tempUser);
                }

                sr.Close();
            }
        }
    }

    internal class ReadMovies:IRead<Movie>
    {
        public void Read( ref List<Movie> movies) 
        {
            string movieFile = @"C:\OOP2_Project\Movies.txt";

            if (File.Exists(movieFile))
            {
                StreamReader sr = new StreamReader(movieFile);
                string line;

                while ((line = sr.ReadLine()) != null)
                {
                    string[] s = null;
                    s = line.Split(',');

                    string movieName = s[0];
                    
                    int year = Convert.ToInt32(s[1]);
                    string genre = s[2];

                    MovieFactory factory = new MovieFactory();
                    Movie tempMovie=factory.CreateMovie(movieName,year,genre);

                    movies.Add(tempMovie);
                }

                sr.Close();
            }
        }
    }

    internal class ReadReviews:IRead<Reviews>
    {
        public void Read(ref List<Reviews> reviews) 
        {
            string reviewFile = @"C:\OOP2_Project\Reviews.txt";
            if (File.Exists(reviewFile)) 
            {
                StreamReader sr = new StreamReader(reviewFile);
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] s = null;
                    s = line.Split(',');

                    string userName = s[0];
                    string movieName = s[1];
                    int rating = Convert.ToInt32(s[2]);

                    Reviews review = new Reviews(userName,movieName,rating);
                    reviews.Add(review);
                }
                sr.Close();
            }
            
        }
    }
}
