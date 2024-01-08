using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_Review
{
    internal interface IUserAdder
    {
        void addUser(ref List<User>Users);

        bool doesUserExists(string username, ref List<User> users);
    }

    internal class UserAdder:IUserAdder
    {
        public void addUser(ref List<User>users) 
        {
            Console.WriteLine("Enter UserName: ");
            string username = Console.ReadLine();

            if (!doesUserExists(username,ref users))
            {
                User U = new User(username);
                users.Add(U);

                Console.WriteLine();
                Console.WriteLine("User added successfully");

                Console.WriteLine();
                Console.WriteLine("Press Any Key To Continue");
                
            }
            else
            {
                throw new Exception("User With this name already exists! Please Try another Name!");
            }           
        }

        public bool doesUserExists(string username,ref List<User>users) 
        {
            foreach (User user in users)
            {
                if (user.username == username) return true;
            }
            return false;
        }
    }
}
