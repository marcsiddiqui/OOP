using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class BankAccount
    {
        private string Title { get; set; }
        private string Type { get; set; }
        private string CustomerName { get; set; }
        private string CNIC { get; set; }
        private decimal Balance { get; set; }
        private decimal LastCredit { get; set; }
        private decimal LastDebit { get; set; }

        public string GetTitle()
        {
            return Title;
        }

        public void SetTitle(string title)
        {
            if (string.IsNullOrWhiteSpace(title))
            {
                Console.WriteLine("Invalid title");
            }
            else if (title.Length < 5)
            {
                Console.WriteLine("Invalid title");
            }
            else
            {
                Title = title;
            }
        }

        public string GetType()
        {
            return Type;
        }

        public void SetType(string type)
        {
            Type = type;
        }

        public string GetCustomerName()
        {
            return CustomerName;
        }

        public void SetCustomerName(string customerName)
        {
            CustomerName = customerName;
        }

        public string GetCNIC()
        {
            return CNIC;
        }

        public void SetCNIC(string cNIC)
        {
            CNIC = cNIC;
        }
        
        public decimal GetBalance()
        {
            return Balance;
        }

        public void SetBalance(decimal balance)
        {
            Balance = balance;
        }

        public decimal GetLastCredit()
        {
            return LastCredit;
        }

        public void SetLastCredit(decimal lastCredit)
        {
            LastCredit = lastCredit;
        }

        public decimal GetLastDebit()
        {
            return LastDebit;
        }

        public void SetLastDebit(decimal lastDebit)
        {
            LastDebit = lastDebit;
        }
    }
}
