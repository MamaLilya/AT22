using System;
namespace Arithmetic
{
    class Program
    {
        static void Main()
        {
            byte x = 0, y = 0;
            double z = 0;
            Console.Write("Enter x: ");
            x = Convert.ToByte (Console.ReadLine());
            Console.Write("Enter y: ");
            y = Convert.ToByte(Console.ReadLine());
            Console.Write("Enter z: ");
            z = Convert.ToDouble(Console.ReadLine());
            short sum = 0;
            sum = (short)(x + y);
            double z_pow = 2;
            double result = Math.Pow(z, z_pow);
            double factor1 = sum, factor2 = Math.Pow(z, z_pow);
            double product = 0; 
            product = factor1 * (++factor2);
            Console.Write("Answer 1 is ");
            Console.WriteLine(product);
            double dividend = x, divisor = z;
            double remainder = 0;
            remainder = dividend % divisor;
            double result2 = Math.Sqrt(y);
            double factor3 = (--remainder), factor4 = Math.Sqrt(y);
            double product2 = 0;
            product2 = factor3 * factor4;
            Console.Write("Answer 2 is ");
            Console.WriteLine(product2);
            double factor5 = x, factor6 = y;
            double product3 = 0;
            product3 = factor5 * factor6;
            double factor7 = y, factor8 = z;
            double product4 = 0;
            product4 = factor7 * factor8;
            double summand1 = product3, summand2 = product4;
            double sum2 = 0;
            sum2 = summand1 + summand2;
            double z_pow_pow = 3;
            double result3 = Math.Pow(z, z_pow_pow);
            double dividend2 = sum2, divisor2 = result3;
            double quotient2 = 0;
            quotient2 = dividend2 / divisor2;
            Console.Write("Answer 3 is ");
            Console.WriteLine(quotient2);
            Console.ReadKey();


            ///В конце я поняла, что написать этот коды можно было гораздо короче, но решила оставить так, чтобы был виден ход мысли :)
        }
    }
}