using CSharpConcepts.Classes.Exercises.Diary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcepts.Classes.Exercises.BankAccount
{
    public class BankAccount
    {
        public List<BankAccount> bankAccounts = new List<BankAccount>();
        public void AddAction(decimal balance, DateTime day, decimal overdraft)
        {
            var  bankaccount = new BankAccount(balance, day, overdraft);
            bankAccounts.Add(bankaccount);
        }
        // As you complete each task make sure you test your code carefully
        // Choose some combination of manual testing, Debug.Assert and unit tests

        // Task One        
        // The bank account should have a balance property        
        // It should have a constructor that sets the initial balance (default zero) and the opening date (default today)
        // It should have methods to deposit and withdraw/make payments from the account. 
        public decimal Balance { get; private set; }
        public DateTime Opendate { get; private set; }
        public decimal Overdraft { get; private set; }
        public BankAccount(decimal balance, DateTime opendate, decimal overdraft)
        {
            Balance = balance;
            Opendate = opendate;
            Overdraft = overdraft;
        }

        public BankAccount()
        {
            Balance = 0;
            Opendate= DateTime.Now;
            Overdraft = 0;
        }
        // Task Two
        // Give the option to set an overdraft limit
        // Do not allow a withdrawal/payment if the overdraft limit is exceeded. You could return false or throw an exception.
        
        // Task Three
        // Create a new class called AccountTransaction.
        // It could contain properties such as
        // date, amount, category, counterparty, transactionType, description (optional)
        // e.g 26/09/2022 16:45, -300, Groceries, Waitrose, Card, Weekly shop
        //     27/09/2022 17:40, 200, Gift, Bob Smith, Cheque, Birthday present
        // You might wish to use enums for category and transactionType
        // Amend your bank account to contain a list of transactions
        // The methods for  deposit and withdraw/make payments should be amended to add transactions

        // Task Four
        // Now add some new methods to your account
        // - See what the balance was at a previous date
        // - See how much money was spent in a given time period
        // - See how much money was spent in different categories

        // Extension
        // Work out how much interest is payable on your account
        // For the moment make up the interest rates, though later we could look at loading them from a website
        // The interest should be added as transactions to your account





    }
    public class Account_Transaction
    {
        public DateTime Date { get; private set; }
        public decimal Balance { get; private set; }
        public int Amount { get; private set;  }
        public string Category { get; private set; }
        public string Counterparty { get; private set; }
        public string TransactionType { get; private set; }
        public decimal Overdraft { get; private set; }


        public Account_Transaction(DateTime date, int amount, string category, string counterparty, string transactionType)
        {
            Date = date;
            Amount = amount;
            Category = category;
            Counterparty = counterparty;
            TransactionType = transactionType;
        }
        public bool CheckOverdaft
        {

            get
            {
                return Balance < Overdraft;
            }
        }
    }
}
