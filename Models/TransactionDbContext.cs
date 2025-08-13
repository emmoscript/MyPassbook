using Microsoft.EntityFrameworkCore;

namespace MyPassbook.Models
{
    public class TransactionDbContext
    {
        public TransactionDbContext(DbContextOptions<TransactionDbContext> options) : base(options)
        { }

        public DbSet<Transaction> Transactions { get; set; }
    }
}
