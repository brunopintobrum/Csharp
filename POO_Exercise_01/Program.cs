using System;

namespace POOExercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoas pessoa1 = new Pessoas();
            Pessoas pessoa2 = new Pessoas();

            Console.WriteLine("Dados da primeira pessoa:");
            Console.Write("Nome: ");
            pessoa1.nome = Console.ReadLine();
            Console.Write("Idade: ");
            pessoa1.idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da Segunda pessoa:");
            Console.Write("Nome: ");
            pessoa2.nome = Console.ReadLine();
            Console.Write("Idade: ");
            pessoa2.idade = int.Parse(Console.ReadLine());

            if (pessoa1.idade > pessoa2.idade)
            {
                Console.WriteLine($"Pessoa mais velha: {pessoa1.nome}");
            }
            else
            {
                Console.WriteLine($"Pessoa mais velha: {pessoa2.nome}");
            }
        }
    }
}
