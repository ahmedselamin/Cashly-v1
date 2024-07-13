namespace Cashly.Server.Data;

public class DataContext(DbContextOptions<DataContext> options) : DbContext(options)
{
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

    }
    public DbSet<Transaction> Transactions { get; set; }
    public DbSet<User> Users { get; set; }
}
