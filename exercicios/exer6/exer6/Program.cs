using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite 10 notas (entre 0 a 10) para ver a média");
            int nota, resu = 0;
            for (int i = 0; i < 10; i++)
            {
                nota = int.Parse(Console.ReadLine());
                if (nota < 0)
                {
                    nota = 0;
                    i--;
                    Console.WriteLine("O valor não pode ser menor que 0. Escreva novamente!");
                }
                resu = resu + nota;
                if (nota > 10)
                {
                    resu = resu - nota;
                    i--;
                    Console.WriteLine("O valor não pode ser maior que 10. Escreva novamente!");
                }
            }
            resu = resu / 10;
            Console.WriteLine("a média é " + resu);
        }
    }
}