using System;
using System.Globalization;

namespace POORaio
{
    class Program
    {
        static void Main(string[] args)
        {
            //Calculadora calc = new Calculadora();

            Console.Write("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = Circunferencia(raio);
            double volume = Volume(raio);

            Console.WriteLine("Circunferência: " + circ.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("O valor de PI: " + Pi.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
