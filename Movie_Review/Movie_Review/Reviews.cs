using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_Review
{
    internal class Reviews
    {
        public string username;
        public string moviename;
        public int rating;

        public Reviews(string username, string moviename, int rating)
        {
            this.username = username;
            this.moviename = moviename;
            this.rating = rating;
        }
    }
}
