using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPClassInheritance
{
    internal class account
    {
        public string username;
        public string password;

        public account()
        {
            
        }
        public account(string AccUsername, string AccPassword)
        {
            username = AccUsername;
            password = AccPassword;
        }
        public void checkLogin(string username, string password)
        {
            string correctUsername = "AdminEA18yr@";
            string correctPassword = "AdminEA18yr@";

            if (string.IsNullOrEmpty(username) && string.IsNullOrEmpty(password))
                Console.WriteLine("Incorrect Username or Password.");
            else
            {
                if (username == correctUsername && password == correctPassword)
                    Console.WriteLine("Successful login!");
                else
                    Console.WriteLine("Incorrect Username or Password");
            }

        }
    }
}
