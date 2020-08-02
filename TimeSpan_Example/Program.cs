using System;

namespace TimeSpan01 {
    class Program {
        static void Main(string[] args) {

            TimeSpan t1 = new TimeSpan(0, 1, 30);
            Console.WriteLine(t1);
            Console.WriteLine(t1.Ticks);

            Console.WriteLine();
            Console.WriteLine("================================");

            TimeSpan t2 = new TimeSpan(); //construtor padrão.
            Console.WriteLine(t2);

            Console.WriteLine();
            Console.WriteLine("================================");

            TimeSpan t3 = new TimeSpan(900000000L); // passa o ticks
            Console.WriteLine(t3);

            Console.WriteLine();
            Console.WriteLine("================================");

            TimeSpan t4 = new TimeSpan(2, 11, 21);
            Console.WriteLine(t4);

            Console.WriteLine();
            Console.WriteLine("================================");

            TimeSpan t5 = new TimeSpan(1, 2, 11, 21);
            Console.WriteLine(t5);

            Console.WriteLine();
            Console.WriteLine("================================");

            TimeSpan t6 = new TimeSpan(1, 2, 11, 21, 321);
            Console.WriteLine(t6);

            Console.WriteLine();
            Console.WriteLine("================================");

            TimeSpan t7 = TimeSpan.FromDays(1.5);
            Console.WriteLine(t7);
            TimeSpan t8 = TimeSpan.FromHours(1.5);
            Console.WriteLine(t8);
            TimeSpan t9 = TimeSpan.FromMinutes(1.5);
            Console.WriteLine(t9);
            TimeSpan t10 = TimeSpan.FromSeconds(1.5);
            Console.WriteLine(t10);
            TimeSpan t11 = TimeSpan.FromMilliseconds(1.5);
            Console.WriteLine(t11);




        }
    }
}
