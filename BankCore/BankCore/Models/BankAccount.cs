using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BankCore.Models
{
    public class BankAccount
    {
        [Key]
        public Guid BankAccountId { get; set; }
        // public Decimal AccountBalance { get; set; }
        public string UserId { get; set; }
        //public List<Transaction> TransactionHistory { get; set; }
        //public BankAccount()
        //{
        //    BankAccountId = new Guid();
        //    AccountBalance = 0.00m;
        //}

    }
    public class Transaction
    {
        [Key]
        public Guid TransactionId { get; set; }
        public string AccountId { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public Decimal Amount { get; set; }
        public Transaction_Type TransactionType {get; set;}
    }
    public enum Transaction_Type
    {
        Deposit = 1,
        Withdrawal = -1
    }
}
