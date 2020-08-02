using System;

namespace EstruturaCondicionalExercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número inteiro:");

            int numero = int.Parse(Console.ReadLine());

            if (numero<0)
            {
                Console.WriteLine("NEGATIVO");
            }
            else
            {
                Console.WriteLine("NÃO NEGATIVO");
            }
        }
    }
}
