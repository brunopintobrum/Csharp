using System;
using System.Collections.Generic;
using System.Text;

namespace POOConversaoDolar
{
    class ConversorDeMoeda
    {

        public static double iof = 6.38;

        public static double DolarParaReal(double quantia, double cotacao)
        {
            double total = quantia * cotacao;
            return total + total * iof / 100.0;
        }


    }
}
