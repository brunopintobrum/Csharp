using System;
using System.Collections.Generic;

namespace ConjuntosExercicios01 {
    class Program {
        static void Main(string[] args) {

            //Declaração e instanciação de Conjuntos
            HashSet<int> A = new HashSet<int>();
            HashSet<int> B = new HashSet<int>();

            // adiciona itens no conjunto
            A.Add(3);
            A.Add(5);
            A.Add(8);
            A.Add(9);

            B.Add(3);
            B.Add(4);
            B.Add(5);


            Console.WriteLine("Conjunto A:");

            //percorre o conjunto, não podemos fazer com o FOR normal.
            foreach (int x in A) { //para cada inteiro x dentro do conjunto A
                Console.WriteLine(x);
            }

            Console.WriteLine();

            Console.WriteLine("Conjunto B:");
            foreach (int x in B) {
                Console.WriteLine(x);
            }

            Console.WriteLine("Digite um valor inteiro: ");
            int N = int.Parse(Console.ReadLine());

            if (B.Contains(N)) {
                Console.WriteLine(N + " pertence ao conjunto B");
            }
            else {
                Console.WriteLine(N + " não pertence ao conjunto B");
            }

            Console.WriteLine("=====================");
            // diferença entre conjuntos
            A.ExceptWith(B);
            foreach (int x in A) {
                Console.WriteLine(x);
            }

            Console.WriteLine("=====================");
            // faz uma uniao entre conjuntos
            A.UnionWith(B);
            foreach (int x in A) {
                Console.WriteLine(x);
            }

            Console.WriteLine("=====================");
            // faz uma interseção entre conjuntos
            A.IntersectWith(B);
            foreach (int x in A) {
                Console.WriteLine(x);
            }





        }
    }
}
