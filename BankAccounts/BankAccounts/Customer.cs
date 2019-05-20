namespace BankAccounts
{
    public class Customer
     {
        private string fullName;
        private CustomerType customerType;

        public Customer(string fullName, CustomerType customertype)
        {
            this.FullName = fullName;
            this.CustomerType = customertype;
        }
        public string FullName
        {
            get { return this.fullName; }
            set { this.fullName = value; }
        }
        public CustomerType CustomerType
        {
            get { return this.customerType; }
                
            set { this.customerType = value; }
            
        }
        
    }
}
