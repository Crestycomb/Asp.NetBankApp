using Microsoft.EntityFrameworkCore;
using revolut.domain;

namespace Revolut.Data
{
    public class AccountsContext : DbContext
    {
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Transaction> Transactions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "user id=myuser1;password=labas;Data Source=.\\SQLEXPRESS;Database=Accounts");


        }
    }
}
