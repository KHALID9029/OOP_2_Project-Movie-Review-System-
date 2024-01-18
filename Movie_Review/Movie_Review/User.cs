using System;
using System.Collections.Generic;
using System.IO;
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
            Console.WriteLine($"* {this.username} has rated {this.totalReviews} movies and has status {this.status}");
        }

        public void updateUser(User user)
        {
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string user_file = Path.Combine(baseDirectory, @"C:\ClassResources Sem-03\SWE 4302 OOP LAB\Lab Final Project\Movie_Review\Movie_Review\bin\Database\User.txt");

            if (user.totalReviews>=minimumReviewToBeCritic)
            {
                user.status = "Critic";
            }

            string info=null;

            if(File.Exists(user_file)) 
            {
                StreamReader sr = new StreamReader(user_file);
                string line;

                while ((line = sr.ReadLine()) != null)
                {
                    string[] s = null;
                    s = line.Split(',');

                    string userName = s[0];
                    string status = s[1];
                    int totalReviews = Convert.ToInt32(s[2]);

                    if(userName==user.username)
                    {
                        info+= $"{user.username},{user.status},{user.totalReviews}\n";
                    }
                    else info += line;
                }

                sr.Close();
            }
            File.WriteAllText(user_file, info);
        }
    }
}
