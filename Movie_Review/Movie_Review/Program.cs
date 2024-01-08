using SPL_PROJECT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_Review
{
    internal class Program
    {
        static void Main(string[] args)
        {
             List<User> users = new List<User>();
             List<Movie> movies = new List<Movie>();
             List<Reviews> reviewList = new List<Reviews>();

            MovieManager manager = new MovieManager();

            while (true) 
            {
                string[] options = {"Add New User","Add New Movie","Add New Review"
                        , "Print Movies", "Print Users", "Print Reviews", "Avarage Rating"
                        };

                Menu menu = new Menu(options);
                int inp = menu.Run();

                switch(inp)
                {
                    case 0:
                        Console.Clear();
                        manager.addUser(ref users);
                        //Console.WriteLine(manager.users.Count);
                        break;

                    case 1:
                        Console.Clear();
                        manager.addMovie(ref movies);
                        break;

                    case 2:
                        Console.Clear();
                        manager.addReviews(ref users, ref reviewList, ref movies);
                        break;

                    case 3:
                        Console.Clear();
                        foreach (Movie movie in movies)
                        {
                            movie.printInfo();
                        }

                        Console.WriteLine();
                        Console.WriteLine("All the movies have been printed");
                        Console.WriteLine();
                        Console.WriteLine("Press Any Key To Continue");
                        
                        break; 
                    
                    case 4:
                        Console.Clear();
                        foreach(User user in users)
                        {
                            user.printInfo();
                        }

                        Console.WriteLine();
                        Console.WriteLine("All the users have been printed");
                        Console.WriteLine();
                        Console.WriteLine("Press Any Key To Continue");
                        
                        break;
                    
                    case 5:
                        Console.Clear();
                        foreach(Reviews reviews in reviewList)
                        {
                            reviews.printInfo();
                        }

                        Console.WriteLine();
                        Console.WriteLine("All the reviews have been printed");
                        Console.WriteLine();
                        Console.WriteLine("Press Any Key To Continue");
                        
                        break;
                    
                    case 6:
                        Console.Clear();
                      
                        manager.AvgRating(ref reviewList); 
                        break;
                    default:
                        Console.WriteLine("Invalid Entry");
                        break;
                }
                Console.ReadLine();
            }
        }
    }
}
