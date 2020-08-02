using System;

namespace DateTime01 {
    class Program {
        static void Main(string[] args) {

            DateTime d1 = DateTime.Now;
            Console.WriteLine(d1);
            Console.WriteLine(d1.Ticks);// representa a data e hora, é armazenado assim, um numero inteiro.
            Console.WriteLine("============================================================");
            Console.WriteLine();

            DateTime d2 = new DateTime(2018, 11, 25);
            Console.WriteLine(d2);
            DateTime d3 = new DateTime(2018, 11, 25, 20, 45, 3);
            Console.WriteLine(d3);
            DateTime d4 = new DateTime(2018, 11, 25, 20, 45, 3, 500);
            Console.WriteLine(d4);

            Console.WriteLine("============================================================");
            Console.WriteLine();

            DateTime d5 = DateTime.Today;
            Console.WriteLine(d5);
            DateTime d6 = DateTime.UtcNow;
            Console.WriteLine(d6);
        }
    }
}
