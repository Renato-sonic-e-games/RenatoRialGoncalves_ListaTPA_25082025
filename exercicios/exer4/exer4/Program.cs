using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite dois números para ver a quantidade de números impares entre seus intervalos(incluindo os digitados)");
            int resu, num1, num2, counter = 0;
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());
            if (num1 > num2) {
                for (int i = num1; i >= num2; i--)
                {
                    resu = i % 2;
                    if (resu == 1) { counter++; }
                }
            }
            else if (num2 > num1) {
                for (int b = num2; b >= num1; b--)
                {
                    resu = b % 2;
                    if (resu == 1) { counter = counter + 1; }
                }
            }
            Console.WriteLine("entre seus intervalos existem: "+counter+" números impares");
        }
    }
}