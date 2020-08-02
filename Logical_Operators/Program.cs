using System;

namespace OperadoresLogicos
{
    class Program
    {
        static void Main(string[] args)
        {
            bool c1 = 2 > 3 && 4 != 5;

            Console.WriteLine(c1);

            bool c2 = 2 > 3 || 4 != 5;

            Console.WriteLine(c2);

            bool c3 = !(2 > 3) && 4 != 5;

            Console.WriteLine(c3);
            Console.WriteLine("-------------------");

        }
    }
}
