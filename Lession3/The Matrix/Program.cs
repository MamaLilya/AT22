using System;
namespace Matrix
{
    class Program
    {
        static void Main()
        {
            int x = 0;
            int y = 0;
            int sum = 0;
            Console.WriteLine($"Enter a line ({x}) and a column ({y})");
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());
            int[,] array = new int[x, y];
            Random random = new Random();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = random.Next(100);
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    if (i == j)
                        sum += array[i, j];
                }
            }
            Console.WriteLine();
                Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}