using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("escreva um número para ver seu fatorial");
            int facto = 1, n;
            n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
                facto = facto * i;
            Console.WriteLine("o valor fatorial de"+n+"é de"+facto);
        }
    }
}