using System;
namespace Strings
{
    class Program
    {
        static void Main()
        {
            string xx = ("String XX: "), yy = ("String YY: "), zz = ("String ZZ: ");
            Console.WriteLine(xx);
            xx = Convert.ToString(Console.ReadLine());
            Console.WriteLine(yy);
            yy = Convert.ToString(Console.ReadLine());
            Console.WriteLine(zz);
            zz = Convert.ToString(Console.ReadLine());
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