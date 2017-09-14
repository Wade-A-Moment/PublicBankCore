using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankCore.Interfaces;
using BankCore.Data;

namespace BankCore.Models
{
    public class BankRepository : IBankRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public BankRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<BankAccount> ListAccountsByUserId(string userId)
        {
            return _dbContext.BankAccounts.Where(x=>x.UserId == userId).AsEnumerable();
        }

        public void AddAccount(BankAccount bankAccount)
        {
            _dbContext.BankAccounts.Add(bankAccount);
            _dbContext.SaveChanges();
        }

        public IEnumerable<Transaction> ListTransactionsByAcountId(string accountId)
        {
            return _dbContext.Transactions.Where(x => x.AccountId == accountId);
        }

        public void AddTransaction(Transaction transaction)
        {
            _dbContext.Transactions.Add(transaction);
            _dbContext.SaveChanges();
        }

        public decimal GetBalanceByAccountId(string accountId)
        {
            var transactions = _dbContext.Transactions.Where(x => x.AccountId == accountId);
            var withdrawals = transactions.Where(x => x.TransactionType == Transaction_Type.Withdrawal).Sum(x => x.Amount);
            var deposits = transactions.Where(x => x.TransactionType == Transaction_Type.Deposit).Sum(x => x.Amount);
            var balance = deposits - withdrawals;
            balance = Math.Round(balance, 2, MidpointRounding.ToEven); // Bankers rounding, better for positive ranges
            return balance;
        }

    }
}
