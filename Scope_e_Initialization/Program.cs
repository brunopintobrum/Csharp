using System;

namespace Escopo_E_Inicializacao
{
    class Program
    {
        static void Main(string[] args)
        {
            double preco = double.Parse(Console.ReadLine());
            double desconto = 0.0;//escopo: nao pode inicializar a variavel dentro do if
            if (preco > 100.0)
            {
                desconto = preco * 0.1;//nao poderia inicializar aqui a variavel
            }

            Console.WriteLine(desconto);//daria erro aqui!
        }
    }
}
