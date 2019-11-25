using revolut.domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace revolut.domain
{
    public class Transaction
    {
        public Transaction()
        {
            Id = Guid.NewGuid();
        } 
        public Guid Id { get; set; }
        public TransactionMode Mode { get; set; }
        public double TransactionAmount { get; set; }
        // public Account FromAccount { get; set; }
        // public Account ToAccount { get; set; }
    }
}


// entity framework core 
// creatomg a data ,pde; amd database wotj ef cpre

// pluralsight julie lerman