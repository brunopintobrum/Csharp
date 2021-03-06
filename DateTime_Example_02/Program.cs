﻿using System;
using System.Globalization;

namespace DateTime02 {
    class Program {
        static void Main(string[] args) {

            //conversão de datas

            DateTime d1 = DateTime.Parse("2000-08-15");
            DateTime d2 = DateTime.Parse("2000-05-15 13:05:58");

            DateTime d3 = DateTime.Parse("15/08/2000");
            DateTime d4 = DateTime.Parse("15/08/2000 13:05:58");

            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d4);

            Console.WriteLine();
            Console.WriteLine("===============================================================");
            DateTime d5 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            DateTime d6 = DateTime.ParseExact("15/08/2000 13:05:58", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            Console.WriteLine(d5);
            Console.WriteLine(d6);


            



            
        }
    }
}
