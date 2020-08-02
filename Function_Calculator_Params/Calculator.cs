using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionCalculator {
    class Calculator {
        // ========================================================
        //               FORMA ERRADA DE SER FEITO
        // ========================================================
        //public static int sum(int n1, int n2) {
        //    return n1 + n2;
        //}
        //public static int sum(int n1, int n2, int n3) {
        //    return n1 + n2 + n3;
        //}
        //public static int sum(int n1, int n2, int n3, int n4) {
        //    return n1 + n2 + n3 + n4;
        //}

        // ========================================================
        //        FORMA CORRETA DE SER FEITO - COM VETOR
        // ========================================================
        public static int sum(params int[] numbers) {

            int sum = 0;
            for (int i = 0; i < numbers.Length; i++) {
                sum += numbers[i];
            }
            return sum;
        }

        // ========================================================
    }
}
