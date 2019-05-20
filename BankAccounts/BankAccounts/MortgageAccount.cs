namespace BankAccounts
{
    public class MortgageAccount : Account, IDepositable
    {

        public MortgageAccount(Customer customer, double balance, double interestRate)
            : base(customer, balance, interestRate)
        {

        }


        public void MakeDeposit(double addSum)
        {
            if (addSum <= 0)
            {
                this.Balance += addSum;
            }
        }

        public override double InterestAmount(int numberOfMonths)
        {
            if (Customer.CustomerType == CustomerType.Companies && numberOfMonths <= 12)
            {

                return (double)(base.InterestRate / 2) * numberOfMonths;
            }



            if (Customer.CustomerType == CustomerType.Individuals && numberOfMonths <= 6)


            {
                return 0;
            }

            return base.InterestRate * numberOfMonths;

        }
    }
}








