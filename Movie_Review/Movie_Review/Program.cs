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
            MovieManager manager = new MovieManager();
            while (true) 
            {
                string[] options = {"Add New User","Add New Movie","Add New Review"
                        , "Print Movies", "Print Users", "Print Reviews", "Avarage Score"
                        };

                Menu menu = new Menu(options);
                int inp = menu.Run();

                switch(inp)
                {
                    case 0:
                        Console.WriteLine("Enter UserName: ");
                        string username=Console.ReadLine();

                        if(manager.checkUniqueUser(username))
                        {
                            manager.addUser(username);
                        }
                        else
                        {
                            throw new Exception("User With this name already exists! Please Try another Name!");
                        }
                        break;

                    case 1:
                        Console.WriteLine("Enter Movie Name: ");
                        string moviename=Console.ReadLine();
                        Console.WriteLine("Enter Year Of Release : ");
                        int year=Convert.ToInt32 (Console.ReadLine());
                        Console.WriteLine("Enter Total Number Of Geners: ");
                        int numofGenres=Convert.ToInt32 (Console.ReadLine());
                        Console.WriteLine("Enter Genres: ");
                        List<string> genres = new List<string>();
                        while(numofGenres>0)
                        {
                            string genresString = Console.ReadLine();
                            genres.Add(genresString);
                            numofGenres--;
                        }
                        manager.addMovie(moviename,year,genres);
                        break;

                    case 2:
                        Console.WriteLine("Enter User Name : ");
                        username= Console.ReadLine();
                        Console.WriteLine("Enter Movie Name: ");
                        moviename=Console.ReadLine();
                        Console.WriteLine("Enter Rating: ");
                        int rating=Convert.ToInt32 (Console.ReadLine());

                        if(manager.findMovieByName(moviename))
                        {
                            if(manager.reviewsLength()==0)
                            {
                                manager.updateUser(username);
                                manager.addReviews(username,moviename,rating);
                            }
                            else
                            {
                                if(!manager.findSameReview(username,moviename,rating))
                                {
                                    manager.updateUser(username);
                                    manager.addReviews(username, moviename, rating);
                                }
                                else
                                {
                                    throw new Exception("Multiple Reviews Not Allowed");
                                }
                            }
                        }
                        else
                        {
                            throw new Exception("Movie Not Yet Released");
                        }
                        break;

                    case 3:
                        manager.printMovies();
                        break; 
                    case 4:
                        manager.printUsers();
                        break;
                    case 5:
                        manager.printReviews();
                        break;
                    case 6:
                        Console.WriteLine("Enter Movie Name : ");
                        moviename = Console.ReadLine();
                        manager.AvgRating(moviename); 
                        break;
                    default:
                        Console.WriteLine("Invalid Entry");
                        break;
                }
            }
        }
    }
}
