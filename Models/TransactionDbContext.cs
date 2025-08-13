using Microsoft.EntityFrameworkCore;

namespace MyPassbook.Models
{
    public class TransactionDbContext:DbContext
    {
        public TransactionDbContext(DbContextOptions<TransactionDbContext> option) : base(options)
        { }

        public DbSet<Transaction> Transactions { get; set; }
    }
}
