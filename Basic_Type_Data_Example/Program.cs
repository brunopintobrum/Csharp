using System;
using System.Globalization;

namespace ExempleTiposBasicosDeDados
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte x1 = 100;
            byte x2 = 255; //numero maximo
            int x3 = 2147483647;
            long x4 = 2147483648L;
            bool completo = false;
            char genero = 'F';
            char letra = '\u0041';
            float x5 = 4.5f;
            double x6 = 4.5;
            string nome = "Bruno Brum";
            object obj1 = "Alex Brow";
            object obj2 = 4.5f;
            
            Console.WriteLine(x1);            
            Console.WriteLine(x2);            
            Console.WriteLine(x3);            
            Console.WriteLine(x4);
            Console.WriteLine(completo);
            Console.WriteLine(genero);
            Console.WriteLine(letra);
            Console.WriteLine(x5);
            Console.WriteLine(x6);
            Console.WriteLine(nome);
            Console.WriteLine(obj1);
            Console.WriteLine(obj2);

            //=================================

            int n1 = int.MinValue;
            int n2 = int.MaxValue;
            sbyte n3 = sbyte.MinValue;
            sbyte n4 = sbyte.MaxValue;

            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
        }
    }
}
