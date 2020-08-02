using System;
using System.Globalization;


namespace ExpressãoTernaria01 {
    class Program {
        static void Main(string[] args) {

            //usando a expressão ternária
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double desconto = (preco < 20.00) ? preco * 0.1 : preco * 0.05;

            Console.WriteLine(desconto);


            //==========================================================

            //Modo normal sem usar a expressão ternária
            //double desconto;
            //if (preco < 20.00) {
            //    desconto = preco * 0.1;
            //}
            //else {
            //    desconto = preco * 0.05;
            //}


        }
    }
}
