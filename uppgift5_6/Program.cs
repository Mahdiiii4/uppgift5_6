using System;
namespace Uppgift5_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tal = new int[5];
            Console.WriteLine("Skriva in tal som ska multiplaceras. (5 stycken)");
            for (int i = 0; i < 5; i++)
            {
                tal[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("*");
            }
            int summa = tal[0] * tal[1] * tal[2] * tal[3] * tal[4];
            Console.WriteLine("den summa är: " +summa+".");
        }
    }
}