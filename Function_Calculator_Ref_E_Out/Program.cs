using System;

namespace FunctionCalculatorRefEOut {
    class Program {
        static void Main(string[] args) {

            // ambos são considerados "CODE SMELLS"

            //=============================================================================
            //                            IMPLEMENTANDO REF
            //=============================================================================

            // A variavel passada como parâmetro ref DEVE ter sido iniciada
            
            int a = 10; // usando Ref é obrigado a iniciar uma variavel com um valor.
            Calculator.TripleRef(ref a);  // ref é o modificador de parametro. Se não usar
                                          // o Ref não traz o valor do calculo.
            Console.WriteLine(a);

            //=============================================================================
            //                            IMPLEMENTANDO OUT
            //=============================================================================

            //A variável passada como parêmetro out não precisa ter sido iniciada.

            a = 10;
            int triple;
            Calculator.TripleOut(a, out triple);  //triple vai ser uma variavel de saida para
                                                  //não perder o valor quando voltar da função.
            Console.WriteLine(triple);


        }
    }
}
