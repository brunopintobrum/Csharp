using System;
namespace CalculoTrianguloProgramacaoOrientadaObjetos
{
    class Triangulo
    {
        //atributos da classe
        public double A;
        public double B;
        public double C;

        //metodos da classe
        public double AreaTringulo()
        {
            double p = (A + B + C) / 2.0;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
    }
}
