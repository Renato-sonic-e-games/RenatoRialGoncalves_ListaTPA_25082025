using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int resu = 0;
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(i);
                resu = i % 10;
                if (resu == 0) { Console.WriteLine("MÚLTIPLO DE 10"); }
            }
        }
    }
}