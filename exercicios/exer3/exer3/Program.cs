using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("escreva um número para ver sua tabuada");
            int tabu = 0;
            tabu = int.Parse(Console.ReadLine());
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(tabu + "x" + i + " = " + tabu * i);
            }
        }
    }
}