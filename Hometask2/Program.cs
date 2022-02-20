using System;
namespace Rectangular_parallelepiped
{
    class Program
    {
        static void Main()
        {
            byte x = 0, y = 0, z = 0;
            Console.Write("Enter the length of the edge x: ");
            x = Convert.ToByte(Console.ReadLine());
            Console.Write("Enter the length of the edge y: ");
            y = Convert.ToByte(Console.ReadLine());
            Console.Write("Enter the length of the edge y: ");
            z = Convert.ToByte(Console.ReadLine());
            byte x_pow = 2;
            double d = Math.Sqrt(Math.Pow(x, x_pow) + Math.Pow(y, x_pow) + Math.Pow(z, x_pow));
            Console.Write("The diagonal length of a rectangular parallelepiped is: ");
            Console.WriteLine(d);
            Console.ReadKey();

        }
    }
}