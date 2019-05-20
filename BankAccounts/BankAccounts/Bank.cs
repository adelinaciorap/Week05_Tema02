using System.Collections.Generic;

namespace BankAccounts
{
    public class Bank
    {
        
        private string name;
        private List<Account> allAccounts;

        //Constructors
        public Bank(string name)
        {
            this.Name = name;
            this.allAccounts = new List<Account>();
        }

        
            public string Name
            {
                get
                { 
                    return this.name;
                }
                set
                {
                    this.name = value;
                }
            }

            internal List<Account> AllAccounts
            {
                get
                {
                    return new List<Account>(this.allAccounts);
                }
            }

           
            public void AddAccount(Account newAccount)
            {
                this.allAccounts.Add(newAccount);
            }

            public override string ToString()
            {
                return string.Format("The Bank {0} has {1} accounts opened in it.", this.Name, this.AllAccounts.Count);
            }


    }
}











