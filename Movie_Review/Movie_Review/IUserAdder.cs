using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_Review
{
    internal interface IUserAdder
    {
        void AddUser(string Username);
    }

    public class UserAdder:IUserAdder
    {
        public void AddUser(string Username) 
        {
            
        }
    }
}
