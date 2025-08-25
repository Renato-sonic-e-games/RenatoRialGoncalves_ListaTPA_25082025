using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("digite 15 números");
            int num1, resu = 0;
                for (int i = 0; i < 15; i++)
                {
                    num1 = int.Parse(Console.ReadLine());
                    if(resu < num1) { resu = num1; }
                }
            Console.WriteLine("o maior número digitado foi: " + resu);
        }
    }
}