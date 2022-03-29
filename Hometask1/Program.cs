using System;
namespace Arithmetic
{
    class Program
    {
        static void Valid(double var)
        {
            if (var <= 0)
            {
                Console.WriteLine("The value cannot be less or equal to 0");
            }
        }
        static double AskUserInput(string var)
        {
            Console.WriteLine($"Enter {var}:");
            return Convert.ToDouble(Console.ReadLine());
        }

        static void Main()
        {
            double x = AskUserInput("x");
            Valid(x);
            double y = AskUserInput("y");
            Valid(y);
            double z = AskUserInput("z");
            Valid(z);
            double z_pow = Math.Pow(z, 2);
            Console.WriteLine($"Answer 1 is {(x + y) * +z_pow}");
            double dividend = x % z;
            Console.WriteLine($"Answer 2 is {-dividend * Math.Sqrt(y)}");
            double z_pow_pow = 3;
            double result = Math.Pow(z, z_pow_pow);
            Console.WriteLine($"Answer 3 is {(x * y + y * z) / result} ");
            Console.ReadKey();
        }
    }
}