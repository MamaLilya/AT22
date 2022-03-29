using System;
namespace Calculator
{ 
    class Program
{
        static double Plus (double a, double b)
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
        static double Grade(double a, double b)
        {
            return Math.Pow(a, b);
        }
        static void Main()
        {
            double a = 0, b = 0;
            Console.WriteLine("Hello! This is a calculator! Here you can sum, deduct, increase, divide or exponentiate two numbers!");
            Console.WriteLine("Choose an arithmetic action: " +
                "Plus - 1,  " +
                "Minus - 2, " +
                "Product - 3, " +
                "Divide - 4, " +
                "Grade - 5. ");
            string c = Console.ReadLine();
            Console.WriteLine($"Enter first number: ");
            a = byte.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            b = byte.Parse(Console.ReadLine());
            if (c == "1")
            {
                Console.WriteLine($"Your result is {Plus(a, b)}");
            }
            else if (c == "2")
            {
                Console.WriteLine($"Your result is {Minus(a, b)}");
            }
            else if (c == "3")
            {
                Console.WriteLine($"Your result is {Product(a, b)}");
            }
            else if (c == "4")
            {
                Console.WriteLine($"Your result is {Divide(a, b)}" );
            }
            else if (c == "5")
            {
                Console.WriteLine($"Your result is {Grade(a, b)}");
            }
                    
                Console.ReadKey();
            }
        }
}