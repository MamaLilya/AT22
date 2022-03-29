using System;
namespace Concatenation
{
    class Program
    {
        static string AskUser(string var)
        {
            Console.Write($"Enter the string {var}: ");
            return Convert.ToString(Console.ReadLine());
            Convert.ToChar(Console.ReadLine());
        }
        static void Main()
        {
            string x = AskUser("x"); 
            string y = AskUser("y");
            char z = (char)0;
            Console.WriteLine(x);
            Console.WriteLine("Symbol: ");
            z = Convert.ToChar(Console.ReadLine());
            string phrase = x + y;
            short LastIndexOf = (short)phrase.LastIndexOf(z);
            string result = $"Index of {z} in {phrase} = {LastIndexOf}";
            Console.WriteLine(phrase);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}