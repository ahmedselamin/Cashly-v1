namespace Cashly.Server.Models;

public class ExpenseSummary
{
    public int Year { get; set; }
    public int Month { get; set; }
    public string Category { get; set; } = string.Empty;
    public decimal TotalAmount { get; set; }
}
