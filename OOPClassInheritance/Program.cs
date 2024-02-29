using System.Globalization;
using System.Reflection.Metadata.Ecma335;

namespace OOPClassInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task1
            //Console.WriteLine("WELCOME!");
            //account acc1 = new account();
            //Console.WriteLine("PLEASE ENTER YOUR USERNAME");
            //acc1.username = Console.ReadLine();
            //Console.WriteLine("===========================");
            //Console.WriteLine("PLEASE ENTER YOUR PASSWORD");
            //acc1.password = Console.ReadLine();
            //acc1.checkLogin(acc1.username, acc1.password);
            #endregion

            #region Task2

            Console.WriteLine("REGISTER");
            register firstAcc=new register();
            Console.WriteLine("==============");
            Console.WriteLine("PLEASE ENTER YOUR FIRST NAME");
            firstAcc.firstName = Console.ReadLine();
            Console.WriteLine("PLEASE ENTER YOUR LAST NAME");
            firstAcc.lastName = Console.ReadLine();
            Console.WriteLine("PLEASE ENTER YOUR MAIL ADDRESS OR PHONE NUMBER");
            firstAcc.numOrEmail = Console.ReadLine();
            Console.WriteLine("PLEASE CREATE A PASSWORD");
            firstAcc.password = Console.ReadLine();
        dobInput:
            Console.WriteLine("PLEASE ENTER YOUR DATE OF BIRTH IN DD/MM/YYYY FORMAT");
            bool isCorrectFormat = DateTime.TryParseExact(Console.ReadLine(), "dd/MM/yyyy", new CultureInfo("az-Latn-AZ"), DateTimeStyles.AssumeLocal, out firstAcc.birthday);
            if (!isCorrectFormat)
                goto dobInput;
            else
            {
                genderChoose:
                Console.WriteLine("PLEASE CHOOSE CORRESPONDING NUMBER THAT INDICATES YOUR GENDER:");
                Console.WriteLine("1. MALE");
                Console.WriteLine("2. FEMALE");
                bool isGenderType=int.TryParse(Console.ReadLine(), out int genderType);
                if (!isGenderType)
                {
                    Console.WriteLine("Incorrect input.");
                    goto genderChoose;
                }
                else
                {
                    if (genderType == 1)
                        firstAcc.gender = "MALE";
                    if (genderType == 2)
                        firstAcc.gender = "FEMALE";
                    else if (genderType>2||genderType<1)
                    {
                        Console.WriteLine("Incorrect input");
                        goto genderChoose;
                    }
                }
                
            }
            Console.WriteLine("REGISTRATION COMPLETED");
            infoDetails:
            Console.WriteLine("PLEASE PRESS 1 ON YOUR KEYBOARD TO ACCESS YOUR INFORMATION DETAILS");
            Console.WriteLine("OR PRESS ANY KEY TO EXIT");
            bool isNumber=int.TryParse(Console.ReadLine(),out int number);
            if(!isNumber)
            {
                Console.WriteLine("INCORRECT INPUT. PLEASE TRY AGAIN");
                goto infoDetails;
            }
            else if (number == 1)
            {
                firstAcc.informationDetails();
            }


            #endregion
        }

    }
    
}
