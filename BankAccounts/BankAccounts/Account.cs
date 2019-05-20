namespace BankAccounts
{
    public abstract class Account
    {
        private Customer customer;
        private double balance;
        private double interestRate;

        public Account(Customer customer, double balance, double interestRate)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.InterestRate = interestRate;
        }

        public Customer Customer
        {
            get { return this.customer; }
            set { this.customer = value; }
        }
        public double Balance {
            get { return this.balance; }
            set { this.balance = value; }
        }
        public double InterestRate {
            get { return this.interestRate; }
            set { this.interestRate = value; }
        }

        public virtual double InterestAmount(int numberOfMonths)
        {
            double result = numberOfMonths * this.interestRate;

            return result;
        }

        
    }
}
