using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int resu = 0;
            for (int i = 11; i <= 251; i++)
            {
                resu = i % 2;
                if (resu == 0) { Console.WriteLine(i); }
            }
        }
    }
}