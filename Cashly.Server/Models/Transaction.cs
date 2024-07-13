using System.ComponentModel.DataAnnotations.Schema;

namespace Cashly.Server.Models;

public class Transaction
{
    public int Id { get; set; }
    [Required]
    public string Category { get; set; } = string.Empty;
    [Required]
    public string Title { get; set; } = string.Empty;
    [Required]
    [Column(TypeName = "decimal(18,2)")]
    public decimal Amount { get; set; }
    public DateTime Date { get; set; } = DateTime.Now;
    [Required]
    public string UserId { get; set; } = string.Empty;

}
