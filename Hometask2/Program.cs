using System;
namespace Rectangular_parallelepiped
{
    class Program
    {
        static int AskUser(string var)
        {
            Console.Write($"Enter the length of the edge {var}: ");
            return Convert.ToInt32(Console.ReadLine());
        }
            static void Main()
        {
            int x = AskUser("x");
            int y = AskUser("y"); 
            int z = AskUser("z");
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
                byte x_pow = 2;
                double d = Math.Sqrt(Math.Pow(x, x_pow) + Math.Pow(y, x_pow) + Math.Pow(z, x_pow));
                Console.Write("The diagonal length of a rectangular parallelepiped is: ");
                Console.WriteLine(d);
                Console.ReadKey();

            }
        }
    }
}