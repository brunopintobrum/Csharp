using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_Example_02.Entities
{
    class SavingsAccount : Account
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
    }
}
