
namespace Cashly.Server.Services.ExpenseService;

public class ExpenseService : IExpenseService
{
    private readonly DataContext _context;

    public ExpenseService(DataContext context)
    {
        _context = context;
    }
    public async Task<ServiceResponse<List<Expense>>> GetExpenses()
    {
        var response = new ServiceResponse<List<Expense>>()
        {
            Data = await _context.Expenses.ToListAsync()
        };

        return response;
    }
    public Task<ServiceResponse<Expense>> GetExpense(int id)
    {
        throw new NotImplementedException();
    }


    public Task<ServiceResponse<Expense>> CreateExpense(Expense expense)
    {
        throw new NotImplementedException();
    }

    public Task<ServiceResponse<bool>> DeleteExpense(int id)
    {
        throw new NotImplementedException();
    }



    public Task<ServiceResponse<Expense>> UpdateExpense(int id, Expense UpdatedExpense)
    {
        throw new NotImplementedException();
    }
}
