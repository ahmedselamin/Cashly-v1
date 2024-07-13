namespace Cashly.Server.Data;

public class DataContext(DbContextOptions<DataContext> options) : DbContext(options)
{
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

    }
    public DbSet<Transaction> Expenses { get; set; }
    public DbSet<User> Users { get; set; }
}
