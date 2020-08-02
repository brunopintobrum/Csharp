using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_Example_02.Entities
{
    class BussinessAccount : Account
    {
        public double loanLimit { get; set; }

        public BussinessAccount()
        {

        }

        public BussinessAccount(int number, string holder, double balance, double loanLimit): base(number, holder, balance)
        {
            this.loanLimit = loanLimit;
        }

        public void Loan(double amount)
        {
            if (amount <= loanLimit)
            {
                Balance += amount;
            }
        }
    }
}
