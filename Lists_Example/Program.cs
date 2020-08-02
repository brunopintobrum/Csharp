using System;
using System.Collections.Generic;

namespace List01 {
    class Program {
        static void Main(string[] args) {

            //List<string> list = new List<string>(); //criação de uma lista sem instanciar.

            //List<string> list2 = new List<string> { "Maria", "Alex" }; //Criaçõ de uma lista com instanciamento.

            List<string> list = new List<string>();

            // o ADD sempre adiciona o elemento na ultima posição
            list.Add("Bruno");
            list.Add("Fernanda");
            list.Add("Erica");
            list.Add("Edi");

            //o INSERT adiciona o elemento no lugar que escolhermos.
            list.Insert(4, "Marco");

            foreach (string obj in list) {
                Console.WriteLine(obj);
            }
            Console.WriteLine("------------------------------------------------------");

            // o COUNT é para ele contar quantos elementos a lista possui. valor total.
            Console.WriteLine("O Count da lista é: " + list.Count);

            string s1 = list.Find(x => x[0] == 'E'); // expressao lambda para pegar o primeiro
            Console.WriteLine("A primeira pessoa com a letra 'E' = " + s1);

            string s2 = list.FindLast(x => x[0] == 'E');// expressao lambda para pegar o ultimo
            Console.WriteLine("A ultima pessoa com a letra 'E' = " + s2);

            int pos1 = list.FindIndex(x => x[0] == 'E');
            Console.WriteLine("O Indice da primeira posição = " + pos1);

            int pos2 = list.FindLastIndex(x => x[0] == 'E');
            Console.WriteLine("O Indice da Ultima posição = " + pos2);


            List<string> list2 = list.FindAll(x => x.Length == 5);// vai trazer somente os nomes com 5 caract.
            Console.WriteLine("------------------------------------------------------");

            foreach (string obj in list2) {
                Console.WriteLine(obj);// imprime os nomes com 5 caract.
            }

            list.Remove("Marco");
            Console.WriteLine("------------------------------------------------------");
            foreach (string obj in list) {
                Console.WriteLine(obj);
            }

            list.RemoveAll(x => x[0] == 'E');
            Console.WriteLine("------------------------------------------------------");
            foreach (string obj in list) {
                Console.WriteLine(obj);
            }

            list.RemoveAt(1);
            Console.WriteLine("------------------------------------------------------");
            foreach (string obj in list) {
                Console.WriteLine(obj);
            }
            Console.WriteLine("------------------------------------------------------");
            list.Add("Fernanda");
            list.Add("Erica");
            list.Add("Edi");
            foreach (string obj in list) {
                Console.WriteLine(obj);
            }

            Console.WriteLine("------------------------------------------------------");
            list.RemoveRange(1, 2);
            foreach (string obj in list) {
                Console.WriteLine(obj);
            }









        }
    }
}
