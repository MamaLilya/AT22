using System;
namespace Calculator
{
    class Program
    {
        static double Plus(double a, double b)
        {
            return a + b;
        }
        static double Minus(double a, double b)
        {
            return a - b;
        }
        static double Product(double a, double b)
        {
            return a * b;
        }
        static double Divide(double a, double b)
        {
            return a / b;
        }
        static double Power(double a, double b)
        {
            return Math.Pow(a, b);
        }
        static string Validation(string c)
        {
            while (c != "+" & c != "-" & c != "*" & c != "/" & c != "^")
            {
                Console.WriteLine("Wrong!");
                Console.WriteLine("Choose an arithmetic action: ");
                c = Console.ReadLine();
                if (c == "+" || c == "-" || c == "*" || c == "/" || c == "^")
                {
                    break;
                }
                else
                {
                    continue;
                }
            }
            return c;
        }
        static void Main()
        {
            double a = 0, b = 0;
            Console.WriteLine("Hello! This is a calculator! Here you can sum, deduct, increase, divide or exponentiate two numbers!");
            Console.WriteLine($"Enter first number: ");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Choose an arithmetic action: ");
            string c = Console.ReadLine();
            c = Validation(c);
            Console.WriteLine("Enter second number: ");
            b = double.Parse(Console.ReadLine());
            if (c == "+")
            {
                Console.WriteLine($"Your result is {Plus(a, b)}");
            }
            else if (c == "-")
            {
                Console.WriteLine($"Your result is {Minus(a, b)}");
            }
            else if (c == "*")
            {
                Console.WriteLine($"Your result is {Product(a, b)}");
            }
            else if (c == "/")
            {
                Console.WriteLine($"Your result is {Divide(a, b)}");
            }
            else if (c == "^")
            {
                Console.WriteLine($"Your result is {Power(a, b)}");
            }

            Console.ReadKey();
        }
    }
}
