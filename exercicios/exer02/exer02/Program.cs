using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite 2 números. O primeiro começa o loop de ordem decrescente e o segundo termina ele.");
            int inicio, final, resu = 0;
            inicio = int.Parse(Console.ReadLine());
            final = int.Parse(Console.ReadLine());
            if (inicio > final)
            {
                for (int i = inicio; i >= final; i--)
                {
                    resu = i % 2;
                    if (resu == 1) { Console.WriteLine(i); }
                }
            }
            else { Console.WriteLine("o primeiro número tem de ser maior que o segundo"); }
        }
    }
}