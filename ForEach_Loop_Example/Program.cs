using System;

namespace LaçoForEach {
    class Program {
        static void Main(string[] args) {

            //=================================================================================
            //                              USANDO O FOREACH
            //=================================================================================

            string[] vect = new string[] { "Maria", "Bob", "Alex" };

            foreach(string obj in vect) { // para cada objeto 'obj' contido em vect, faça!
                Console.WriteLine(obj);
            }

            //=================================================================================
            //                              USANDO O FOR
            //=================================================================================

            string[] vect2 = new string[] { "Bruno", "Fernanda" };

            for(int i = 0; i < vect2.Length; i++) {
                Console.WriteLine(vect2[i]);
            }

        }
    }
}
