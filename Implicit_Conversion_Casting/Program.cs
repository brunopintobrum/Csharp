using System;

namespace ConversaoImplicitaCasting
{
    class Program
    {
        static void Main(string[] args)
        {
            // conversão implicita de tipos
            float x = 4.5f;
            double y = x;

            Console.WriteLine(y);

            //Conversão explicita de tipos

            double a;
            float b;

            a = 5.1;
            b = (float)a;

            Console.WriteLine(b);

            //conversão explicita de tipos 2 com numero inteiros.O valor depois da virgula vao ser truncados.
            double c;
            int d;

            c = 5.1;
            d = (int)c;

            Console.WriteLine(d);

            //conversão explicita de tipos 3
            int e = 5;
            int f = 2;

            double resultado = (double) e / f;

            Console.WriteLine(resultado);
        }
    }
}
