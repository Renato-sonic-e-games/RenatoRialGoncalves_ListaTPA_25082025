using System;
using System.Diagnostics;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int salario, horas, salarioEx;
            string perg, inv, code;
                do
                {
                Console.WriteLine("digite o código do operário");
                code = Console.ReadLine();
                Console.WriteLine("digite o número de horas trabalhadas do operário");
                horas = int.Parse(Console.ReadLine());
                salario = horas * 10;
                if (horas > 50) { salarioEx = (horas - 50) * 20;
                    salario = 500;
                    salario = salario + salarioEx;
                }
                else salarioEx = 0;
                    Console.WriteLine("Código do operário: " + code);
                Console.WriteLine("Salário total: "+salario);
                Console.WriteLine("salário excedente: " + salarioEx);
                do
                {
                    Console.WriteLine("Deseja encerrar o programa? (digite 'S' para sim e 'N' para não)");
                    perg = Console.ReadLine();
                    if (perg == "N") { inv = "P"; }
                    else if (perg == "S") inv = "S";
                    else inv = "N";
                    if (inv == "N") Console.WriteLine("inválido, digite novamente");
                }
                while (inv == "N");
                }
                while (inv == "P");

        }
    }
}