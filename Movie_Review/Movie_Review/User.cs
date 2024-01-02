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

        public User(string username)
        {
            this.username = username;
            this.status = "viewer";
            this.totalReviews = 0;
        }
    }
}
