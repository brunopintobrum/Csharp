using System;

namespace FuncoesParaString {
    class Program {
        static void Main(string[] args) {

            string original = "abcde FGHIJ ABC abc DEFG    ";

            //Converte tudo pra maiusculo
            string s1 = original.ToUpper();
            Console.WriteLine("Original: -" + original + "-");
            Console.WriteLine("ToUpper: -" + s1 + "-");
            Console.WriteLine("==========================================================================");
           
            //Converte tudo pra minusculo
            string s2 = original.ToLower();
            Console.WriteLine("Original: -" + original + "-");
            Console.WriteLine("ToLower: -" + s2 + "-");
            Console.WriteLine("==========================================================================");
            
            //apaga os espaços em branco no inicio e fim
            string s3 = original.Trim();
            Console.WriteLine("Original: -" + original + "-");
            Console.WriteLine("Trim: -" + s3 + "-");
            Console.WriteLine("==========================================================================");
           
            //Usando o indexOf, retornando a posição.
            int n1 = original.IndexOf("bc");
            Console.WriteLine("Original: -" + original + "-");
            Console.WriteLine("IndexOf('bc'): " + n1);
            Console.WriteLine("==========================================================================");

            //Usando o LastindexOf, retornando a ultima posição.
            int n2 = original.LastIndexOf("bc");
            Console.WriteLine("Original: -" + original + "-");
            Console.WriteLine("LastIndexOf('bc'): " + n2);
            Console.WriteLine("==========================================================================");

            //Recortar uma string a partir de uma posição determinada
            string s4 = original.Substring(3);
            Console.WriteLine("Original: -" + original + "-");
            Console.WriteLine("Substring(3): -" + s4 + "-");
            Console.WriteLine("==========================================================================");

            //Recortar uma string a partir de uma posição determinada e com apenas 5 caracteres
            string s5 = original.Substring(3, 5);
            Console.WriteLine("Original: -" + original + "-");
            Console.WriteLine("Substring(3, 5): -" + s5 + "-");
            Console.WriteLine("==========================================================================");

            //Subistitui toda ocorrenca de a para x.
            string s6 = original.Replace('a', 'x');
            Console.WriteLine("Original: -" + original + "-");
            Console.WriteLine("Replace('a', 'x)': -" + s6 + "-");
            Console.WriteLine("==========================================================================");

            //Subistitui toda string de abc para xy.
            string s7 = original.Replace("abc", "xy");
            Console.WriteLine("Original: -" + original + "-");
            Console.WriteLine("Replace:('abc', 'xy') -" + s7 + "-");
            Console.WriteLine("==========================================================================");

            //verificar se é nulo ou vazio
            bool b1 = String.IsNullOrEmpty(original);
            Console.WriteLine("Original: -" + original + "-");
            Console.WriteLine("IsNullOrEmpty: " + b1);
            Console.WriteLine("==========================================================================");

            //verificar se é nulo ou espaço em branco, bom para formulario
            bool b2 = String.IsNullOrWhiteSpace(original);
            Console.WriteLine("Original: -" + original + "-");
            Console.WriteLine("IsNullOrWhiteSpace: " + b2);
            Console.WriteLine("==========================================================================");




        }
    }
}
