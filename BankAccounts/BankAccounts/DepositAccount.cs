using System;

namespace BankAccounts
{
    public class DepositAccount : Account, IDepositable, IWithDrawable
    {
        public DepositAccount(Customer customer, double balance, double interestRate) : base(customer, balance, interestRate)
        {

        }

        public void MakeDeposit(double addSum)
        {
            this.Balance += addSum;
        }

        public void Withdraw(double removeSum)
        {
            if (removeSum <= 0)
            {
                Console.WriteLine("Enter a sum greater than 0!");
            }
            
            else
            {
                this.Balance -= removeSum;
            }
        }


        public override double InterestAmount(int numberOfMonths)
        {
            if (this.Balance < 1000)
            {
                return 0;
            }

            return numberOfMonths * base.InterestRate;

        }



    }
}





