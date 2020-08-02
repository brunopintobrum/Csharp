using System;
using System.Globalization;

namespace POOConversaoDolar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é a cotação do dólar Canadense? ");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantos dólares você vai comprar? ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double resultado = ConversorDeMoeda.DolarParaReal(quantia, cotacao);

            Console.WriteLine("O valor a ser pago em reais = " + resultado.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
