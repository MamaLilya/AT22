using System;
namespace Authenticator
{
    class Program
    {
        static string AskUser(string var)
        {
            Console.Write($"Enter {var}: ");
            return Console.ReadLine();
        }
        static void Main()
        {
            int counter = 0;
            while (counter < 3)
            {
                string username = AskUser("Username");
                string password = AskUser("Password");
                if (username == "admin" && password == "adminadmin")
                {
                    Console.WriteLine("Welcome!");
                    break;
                }

                else
                {
                    counter++;
                    Console.WriteLine($"Wrong Username or Password. You have 3 attempts and there are {3 - counter} attempts left.");
                }
            }

                Console.ReadKey();


            
            }
    }
}