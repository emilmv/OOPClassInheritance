using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPClassInheritance
{
    internal class register
    {
        public string firstName;
        public string lastName;
        public string numOrEmail;
        public string password;
        public DateTime birthday;
        public string gender;

        public register()
        {
            
        }
        public register(string accFirstName, string accLastName, string accNumOrEmail, string accPassword, DateTime accBirthday, string accGender)
        {
            firstName = accFirstName;
            lastName = accLastName;
            numOrEmail = accNumOrEmail;
            password = accPassword;
            birthday = accBirthday;
            gender = accGender;

        }

        public void informationDetails()
        {
            Console.WriteLine($"First Name: {firstName}");
            Console.WriteLine($"Last Name: {lastName}");
            Console.WriteLine($"Phone number or e-mail: {numOrEmail}");
            Console.WriteLine($"Password: {password[0]}*****{password[password.Length-1]}");
            Console.WriteLine($"Date of Birth: {birthday.ToString("dd/MM/yyyy")}");
            Console.WriteLine($"Gender: {gender}");
        }
    }
    
}
