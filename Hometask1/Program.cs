using System;
namespace Arithmetic
{
    class Program
    {
        static void Main()
        {
            double x = 0, y = 0, z = 0;
            Console.Write("Enter x: ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter y: ");
            y = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter z: ");
            z = Convert.ToDouble(Console.ReadLine());
            double z_pow = Math.Pow(z, 2);
            Console.WriteLine($"Answer 1 is {(x+y) * ++z_pow}");
            double dividend = x % z;
            Console.WriteLine($"Answer 2 is {-dividend * Math.Sqrt(y)}");
            double z_pow_pow = 3;
            double result = Math.Pow(z, z_pow_pow);
            Console.WriteLine($"Answer 3 is {(x * y + y * z) / result} ");
            Console.ReadKey();

        }
    }
} 