namespace Cashly.Server.Data;

public class DataContext(DbContextOptions<DataContext> options) : DbContext(options)
{
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

    }
    public DbSet<Expense> Expenses { get; set; }
    public DbSet<User> Users { get; set; }
}
