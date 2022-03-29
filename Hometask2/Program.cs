using System;
namespace Rectangular_parallelepiped
{
    class Program
    {
        static void Valid(double var)
        {
            if (var <= 0)
            {
                do
                {
                    Console.WriteLine("The value cannot be less or equal to 0");
                }
                while (var > 0);
            }
        }
        static int AskUser(string var)
        {
            Console.Write($"Enter the length of the edge {var}: ");
            return Convert.ToInt32(Console.ReadLine());
        }
            static void Main()
        {
            int x = AskUser("x");
            Valid(x);
            int y = AskUser("y"); 
            Valid(y);
            int z = AskUser("z");
            Valid(z);
                byte x_pow = 2;
                double d = Math.Sqrt(Math.Pow(x, x_pow) + Math.Pow(y, x_pow) + Math.Pow(z, x_pow));
                Console.Write("The diagonal length of a rectangular parallelepiped is: ");
                Console.WriteLine(d);
                Console.ReadKey();
        }
    }
}