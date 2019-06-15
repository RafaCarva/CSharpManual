namespace Course.Entities
{
    class SavingsAccount : Account
    {
        public double InterestRate { get; set; }

        public SavingsAccount()
        {
        }
        
        //First we call base Account construct (send 3 attributes) follow by SavingsAccount logic
        public SavingsAccount(int number, string holder, double balance, double interestRate)
            : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }

        //Override Account.Withdraw() 
        public override void Withdraw(double amount)
        {
            //First, execute the method from base class Account, follow by new logic method
            base.Withdraw(amount);
            Balance -= 2.0;
        }
    }
}
