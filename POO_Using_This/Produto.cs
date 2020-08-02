using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace POOUsandoThis
{
    class Produto
    {

        public string Nome;
        public double Preco;
        public int Quantidade;

        //Construtor Padrão
        public Produto()
        {
            Quantidade = 0;
        }
        //Construtor com 3 atributos
        public Produto(string nome, double preco) : this()
        {
            Nome = nome;
            Preco = preco;
        }
        //Construtor com 2 atributos
        public Produto(string nome, double preco, int quantidade) : this(nome, preco)
        {
            Quantidade = quantidade;
        }


        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }
        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }
        public override string ToString()
        {
            return Nome
            + ", $ "
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
