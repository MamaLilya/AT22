using System;
namespace Arithmetic
{
    class Program
    {
        static double AskUserInput(string var)
        {
            Console.WriteLine($"Enter {var}:");
            return Convert.ToDouble(Console.ReadLine());
        }

        static void Main()
        {
            double x = AskUserInput("x");
            double y = AskUserInput("y");
            double z = AskUserInput("z");
            if (x <= 0)
            {
                Console.WriteLine("The value cannot be less or equal to 0");
            }
            else if (y <= 0)
            {
                Console.WriteLine("The value cannot be less or equal to 0");
            }
            else if (z <= 0)
            {
                Console.WriteLine("The value cannot be less or equal to 0");
            }
            else
            {

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
}