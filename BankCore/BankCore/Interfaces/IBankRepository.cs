using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankCore.Models;


namespace BankCore.Interfaces
{
    public interface IBankRepository
    {
        IEnumerable<BankAccount> ListAccountsByUserId(string userId);
        void AddAccount(BankAccount bankAccount);
        IEnumerable<Transaction> ListTransactionsByAcountId(string accountId);
        void AddTransaction(Transaction transaction);
        decimal GetBalanceByAccountId(string accountId);
    }
}
