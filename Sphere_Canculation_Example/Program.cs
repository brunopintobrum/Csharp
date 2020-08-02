using System;
using System.Globalization;

namespace EsferaCalculo {
    class Program {
        static void Main(string[] args) {

            double volume, pi = 3.14159;

            int raio = int.Parse(Console.ReadLine());
            
            volume = (4 / 3.0) * pi * Math.Pow(raio,3);

            Console.WriteLine("VOLUME = " + volume.ToString("F3", CultureInfo.InvariantCulture));

        }
    }
}
