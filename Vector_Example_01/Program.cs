using System;
using System.Globalization;

namespace Vetores01
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = int.Parse(Console.ReadLine());

            double[] vect = new double[numero];

            for(int i = 0; i < numero; i++)
            {
                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            double sum = 0.0;
            for(int i = 0; i < numero; i++)
            {
                sum += vect[i];
            }

            double avg = sum / numero;

            Console.WriteLine("Average Height = " + avg.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
