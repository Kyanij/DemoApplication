using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApplication
{
    public class BankAccount
    {
        private string accountNumber;
        private double balance;

        public BankAccount(string accountNumber, double balance) //constructor
        {
            this.accountNumber = accountNumber;
            this.balance = balance;
        }

        public string GetAccountNumber()
        { return accountNumber; }

        public void GetBalance() 
        {
            Console.WriteLine($"Current balance is {balance}");
        }

        public void Deposit(double amount)
        {
            balance += amount;
            Console.WriteLine($"Successfully deposited {amount}");
        }
         
        public void Withdraw(double amount)
        {
            if (amount > balance)
            {
                Console.WriteLine("Insufficent funds");
            }
            else
            {
                balance -= amount;
                Console.WriteLine($"Successfully withdraw {amount}");
            }
        }
    }
}
