using System;
using System.Collections.Generic;
using System.Text;
using revolut.domain.Enums;

namespace revolut.domain
{
    public class Account
    {
        public Account()
        {
            Id = Guid.NewGuid();
            Transactions = new List<Transaction>();
        }
        public Account(double balance)
            :this()
        {
            Balance = balance;
            Transactions.Add(new Transaction()
            {
                Mode = Enums.TransactionMode.CashIn,
                TransactionAmount = balance,
            });
        }


        public Guid Id { get; set; }
        public double Balance { get; set; }

        public List<Transaction> Transactions { get; set; }
    }

}
