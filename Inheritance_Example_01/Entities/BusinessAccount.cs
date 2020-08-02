namespace Heritage_Example_01.Entities
{
    class BusinessAccount : Account
    {
        public double LoanLimit { get; set; }

        public BusinessAccount()
        {

        }
        public BusinessAccount(int number, string holder, double balance, double loanLimit) : base(number, holder, balance) // Como fazer o const. herdar da super classe
        {
            LoanLimit = loanLimit;

        }

        public void Loan(double amount)
        {
            if (amount <= LoanLimit)
            {
                Balance += amount;
            }
        }
    }
}
