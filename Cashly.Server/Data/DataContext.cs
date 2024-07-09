namespace Cashly.Server.Data;

public class DataContext(DbContextOptions<DataContext> options) : DbContext(options)
{
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Expense>().HasData(
            new Expense
            {
                Id = 1,
                Title = "Salary",
                Amount = 5600m,
                Date = DateTime.Now,
                CategoryId = 1,
            },
            new Expense
            {
                Id = 2,
                Title = "gift",
                Amount = 200m,
                Date = DateTime.Now,
                CategoryId = 1,
            },
            new Expense
            {
                Id = 3,
                Title = "Lunch",
                Amount = 50.76m,
                Date = DateTime.Now,
                CategoryId = 2,
            }, new Expense
            {
                Id = 4,
                Title = "rent",
                Amount = 1200m,
                Date = DateTime.Now,
                CategoryId = 2,
            }
        );

        modelBuilder.Entity<Category>().HasData(
            new Category
            {
                Id = 1,
                Name = "Income",
            },
            new Category
            {
                Id = 2,
                Name = "Expenditure",
            }
        );

    }
    public DbSet<Expense> Expenses { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<User> Users { get; set; }
}
