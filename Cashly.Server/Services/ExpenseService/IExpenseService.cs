namespace Cashly.Server.Services.ExpenseService;

public interface IExpenseService
{
    Task<ServiceResponse<List<Expense>>> GetExpenses();
    Task<ServiceResponse<Expense>> GetExpense(int id);
    Task<ServiceResponse<Expense>> CreateExpense(Expense expense);
    Task<ServiceResponse<Expense>> UpdateExpense(int id, Expense UpdatedExpense);
    Task<ServiceResponse<bool>> DeleteExpense(int id);
}
