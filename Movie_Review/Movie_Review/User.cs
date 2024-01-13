using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_Review
{
    internal class User
    {
        public string username;
        public string status;
        public int totalReviews;

        public int minimumReviewToBeCritic = 10;

        public User(string username)
        {
            this.username = username;
            this.status = "viewer";
            this.totalReviews = 0;
        }

        public User(string username, string status , int totalReviews) 
        {
            this.username = username;
            this.status = status;
            this.totalReviews = totalReviews;
        }

        public void printInfo()
        {
            Console.WriteLine($"{this.username} has rated {this.totalReviews} movies and has status {this.status}");
        }

        public void updateUser()
        {
            if(this.totalReviews>=minimumReviewToBeCritic)
            {
                this.status = "Critic";
            }
        }
    }
}
