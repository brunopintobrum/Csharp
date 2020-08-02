using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaiorElementoDaTabela
{
    class Maximum
    {
        static int TAILLE_ASCII = 256;

        static char getMaxOccuringChar(String str)
        {
            int[] count = new int[TAILLE_ASCII];
            int len = str.Length;
            for (int i = 0; i < len; i++)
                count[str[i]]++;
            int max = -1;
            char resultat = ' ';
            for (int i = 0; i < len; i++)
            {
                if (max < count[str[i]])
                {
                    max = count[str[i]];
                    resultat = str[i];
                }
            }
            return resultat;
        }

        public static void Main()
        {
            String str = "KaayuTest";
            Console.Write("Max caractère se produisant est " +
                                getMaxOccuringChar(str));
            Console.ReadLine();
        }
    }
}

