using System;
using System.Collections.Generic;
using System.Text;

namespace POORaio
{
    class Calculadora
    {
        public double Pi = 3.14;

        public double Volume(double r)
        {
            return 4.0 / 3.0 * Pi * r * r * r;
        }

        public double Circunferencia(double r)
        {
            return 2.0 * Pi * r;
        }
    }
}
