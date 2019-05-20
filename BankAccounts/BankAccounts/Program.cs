using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts
{
    class Program
    {
        static void Main(string[] args)
        {

            Bank bank = new Bank("FirstBank");

            Customer P = new Customer("Diana", CustomerType.Individuals);
            DepositAccount deposit1 = new DepositAccount(P, 15000, 3.45);
            bank.AddAccount(deposit1);

            Customer Z = new Customer("Gosho", CustomerType.Companies);
            MortgageAccount mortg1 = new MortgageAccount(Z, 50000, 5);
            bank.AddAccount(mortg1);

            Console.WriteLine(bank);

            for (int i = 0; i < bank.AllAccounts.Count; i++)
            {
                Console.WriteLine();
                Console.WriteLine("Account {0}: ", i + 1);
                Console.WriteLine(bank.AllAccounts[i]);


            }

            Console.WriteLine("---------- Mitko deposit accounts ----------");
            DepositAccount a = new DepositAccount(new Customer ("Maria Daea", CustomerType.Individuals), 5000, 12);
            a.MakeDeposit(111000);
          a.Withdraw(5);
            Console.WriteLine("Totz balance: " + a.Balance);
            Console.WriteLine(); 

            Console.WriteLine("---------- AHA loan accounts ----------");
            LoanAccount asusLoanAccount = new LoanAccount(new Customer("Adria", CustomerType.Companies), 34567, 12);
            asusLoanAccount.MakeDeposit(10000);
            Console.WriteLine("AHA balance: " + asusLoanAccount.Balance);
            Console.WriteLine();

            Console.WriteLine("---------- B mortgage accounts ----------");
            MortgageAccount b = new MortgageAccount(new Customer("B", CustomerType.Companies),345565, 50);
            b.MakeDeposit(1000);
            Console.WriteLine("B balance: " + b.Balance);
            Console.WriteLine();


        }
    }
}










