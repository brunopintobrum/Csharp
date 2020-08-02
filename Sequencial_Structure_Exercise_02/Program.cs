using System;
using System.Globalization;

namespace EstruturaSequencialExercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            double pi = 3.14159;
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double resultado = pi * (Math.Pow(raio, 2.0));

            Console.WriteLine("A = " + resultado.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}
