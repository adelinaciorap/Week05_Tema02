namespace BankAccounts
{
    public class LoanAccount: Account, IDepositable
    {
        public LoanAccount(Customer customer, double balance, double interestRate): base(customer, balance, interestRate)
        {

        }

        public void MakeDeposit(double addSum)
        {
            this.Balance += addSum;
        }

        public override double InterestAmount(int numberOfMonths)
        {
            if (Customer.CustomerType == CustomerType.Individuals && numberOfMonths<3)
            {
                return 0;
                
            }
            if (Customer.CustomerType == CustomerType.Companies && numberOfMonths < 2)
            {
                return 0;
            }
            return base.InterestRate * numberOfMonths;




        }

    }

}








