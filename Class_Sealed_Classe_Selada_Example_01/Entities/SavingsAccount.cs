using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_Example_02.Entities
{
    sealed class SavingsAccount : Account
    {
        public double InterestRate { get; set; } //taxa de juros

        public SavingsAccount()
        {

        }

        public SavingsAccount(int number, string holder, double balance, double interestRate) : base(number, holder, balance)
        {
            this.InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }

        public sealed override void Withdraw(double amount) //nao pode ser sobreescrita em uma outra subclasse, está selado o metodo.
        {
            base.Withdraw(amount); //chamada da regra da classe mae
            Balance -= 2.0;
        }
    }
}
