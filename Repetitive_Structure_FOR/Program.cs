using System;

namespace EstruturaRepetitivaFOR
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos números inteiro você irá digitar? ");
            int n = int.Parse(Console.ReadLine());

            int soma = 0;

            for (int i = 1; i <= n; i++)
            {
                Console.Write("Valor #{0}: ", i);
                int valor = int.Parse(Console.ReadLine());
                soma += valor;

            }
            Console.WriteLine("Soma = " + soma);
        }
    }
}
