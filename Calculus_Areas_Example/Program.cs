using System;
using System.Globalization;

namespace AreasCalculos {
    class Program {
        static void Main(string[] args) {

            double A, B, C,TRIANGULO, CIRCULO, TRAPEZIO, QUADRADO, RETANGULO, pi = 3.14159;

            A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            TRIANGULO = A * C / 2;
            CIRCULO = pi * Math.Pow(C, 2);
            TRAPEZIO = (A + B) * C / 2;



            Console.WriteLine("TRIANGULO: " + TRIANGULO.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: " + CIRCULO.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: " + TRAPEZIO.ToString("F3", CultureInfo.InvariantCulture));



        }
    }
}
