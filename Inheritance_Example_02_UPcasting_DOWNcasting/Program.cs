using Inheritance_Example_02.Entities;
using System;

namespace Inheritance_Example_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account(1001, "Alex", 0.0);
            BussinessAccount bacc = new BussinessAccount(1002, "Maria", 0.0, 500.0);

            //UPCASTING

            Account acc1 = bacc; // essa conversão é perfeitamente legal, o complilador aceita.
            Account acc2 = new BussinessAccount(1003, "Bob", 0.0, 200.0); // posso fazer isso aqui também
            Account acc3 = new SavingsAccount(104, "Anna", 0.0, 0.01); // outra forma possível

            //DOWNCASTING

            BussinessAccount acc4 = (BussinessAccount)acc2; // fez a conversão Casting
            acc4.Loan(100.0); // agora conseguimos ter acesso a operacao LOAN

            // BussinessAccount acc5 = (BussinessAccount)acc3; // os dois tipos são incompativeis mesmo o compilador nao ter dado o erro.
            // são subclasses

            //Test
            if (acc3 is BussinessAccount)
            {
                //BussinessAccount acc5 = (BussinessAccount)acc3; //modo1
                BussinessAccount acc5 = acc3 as BussinessAccount; // modo2
                acc5.Loan(200.0);
                Console.WriteLine("loan!");
            }

            if (acc3 is SavingsAccount)
            {
                //SavingsAccount acc5 = (SavingsAccount)acc3; //modo 1
                SavingsAccount acc5 = acc3 as SavingsAccount; //modo 2
                acc5.UpdateBalance();
                Console.WriteLine("Update!");
            }


        }
    }
}
