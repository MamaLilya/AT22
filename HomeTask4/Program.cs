using System;
namespace Concatenation
{
    class Program
    {
        static void Main()
        {
            string x = ("String1: "), y = ("String2: ");
            char z = (char)0;
            Console.WriteLine(x);
            x = Convert.ToString(Console.ReadLine());
            Console.WriteLine(y);
            y = Convert.ToString(Console.ReadLine());
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