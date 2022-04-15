using Microsoft.EntityFrameworkCore;
using PaystactIntegrationWithDotNet.Model;

namespace PaystactIntegrationWithDotNet.Repository
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Transaction> Transactions { get; set; }
    }
}
