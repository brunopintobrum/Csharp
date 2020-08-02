using System;

namespace FunctionCalculator {
    class Program {
        static void Main(string[] args) {
            // ========================================================
            //               FORMA ERRADA DE SER FEITO
            // ========================================================

            //int s1 = Calculator.sum(2, 3);
            //int s2 = Calculator.sum(2, 4, 3);

            //Console.WriteLine(s1);
            //Console.WriteLine(s2);

            // ========================================================
            //        FORMA CORRETA DE SER FEITO - COM VETOR
            // ========================================================

            int s1 = Calculator.sum(2, 3);
            int s2 = Calculator.sum(2, 3, 4);
            int s3 = Calculator.sum(10, 10, 10, 10, 10);

            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);


        }
    }
}
