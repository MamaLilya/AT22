using System;
namespace Strings
{
    class Program
    {
        static string AskUser(string var)
        {
            Console.Write($"Enter the string {var}: ");
            return Convert.ToString(Console.ReadLine());
        }
        static void Main()
        {
            string xx = AskUser("xx"); 
            string yy = AskUser("yy");
            string zz = AskUser("zz");
            bool answer = false;
            if (xx.StartsWith (yy))
                {
                answer = true;
            }
            else
            {
                answer = false;
            }
            Console.WriteLine(answer);
            if (xx.EndsWith (zz))
            {
                answer = true;
            }
            else
            {
                answer = false;
            }
            Console.WriteLine (answer);
            Console.ReadKey();

        }
    }
}