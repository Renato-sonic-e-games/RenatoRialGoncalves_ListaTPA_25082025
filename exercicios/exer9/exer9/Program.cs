using System;
using System.Diagnostics;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int digito, par = 0, impar = 0, negativo = 0, positivo = 0, resu = 0;
            string perg, inv;
            do
            {
                Console.WriteLine("digite algum número");
                digito = int.Parse(Console.ReadLine());
                resu = digito % 2;
                if (resu == 0) par++;
                else if (resu == 1 || resu == -1) impar++;
                if (0 < digito) positivo++;
                else if (0 > digito) negativo++;
                do
                {
                    Console.WriteLine("Deseja encerrar o programa? (digite 'S' para sim e 'N' para não)");
                    perg = Console.ReadLine();
                    if (perg == "N") { inv = "S"; }
                    else if (perg == "S") inv = "S";
                    else inv = "N";
                    if (inv == "N") Console.WriteLine("inválido, digite novamente");
                }
                while (inv == "N");
            }
            while (perg == "N"); ;
                Console.WriteLine("Você digitou:");
                Console.WriteLine("Números pares:" + par);
                Console.WriteLine("Números impares:" + impar);
                Console.WriteLine("Números positivo:" + positivo);
                Console.WriteLine("Números negativo:" + negativo);

            
    }
    }
}