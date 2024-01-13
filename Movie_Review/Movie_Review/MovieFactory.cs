using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_Review
{
    internal class MovieFactory
    {
        public Movie CreateMovie(string moviename,int year,string genre)
        {
            if (genre == "Action") return new ActionMovie(moviename, year);
            else if(genre =="Adventure") return new AdventureMovie(moviename,year);
            else  return new ThrillerMovie(moviename,year);
        }
    }
}
