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
        var response = new ServiceResponse<List<Expense>>();

        try
        {
            response.Data = await _context.Expenses.ToListAsync();
        }
        catch (Exception ex)
        {
            response.Success = false;
            response.Message = ex.Message;
        }

        return response;
    }
    public async Task<ServiceResponse<Expense>> GetExpense(int id)
    {
        var response = new ServiceResponse<Expense>();
        try
        {
            var expense = await _context.Expenses.FindAsync(id);

            if (expense == null)
            {
                response.Success = false;
                response.Message = "Not Found";
            }
            response.Data = expense;
        }
        catch (Exception ex)
        {
            response.Success = false;
            response.Message = ex.Message;
        }
        return response;
    }

    public async Task<ServiceResponse<Expense>> CreateExpense(Expense expense)
    {
        var response = new ServiceResponse<Expense>();

        try
        {
            _context.Expenses.Add(expense);

            await _context.SaveChangesAsync();
            response.Data = expense;
        }
        catch (Exception ex)
        {
            response.Success = false;
            response.Message = ex.Message;
        }

        return response;
    }

    public async Task<ServiceResponse<Expense>> UpdateExpense(int id, Expense UpdatedExpense)
    {
        var response = new ServiceResponse<Expense>();

        try
        {
            var expense = await _context.Expenses.FindAsync(id);

            if (expense == null)
            {
                response.Success = false;
                response.Message = "Not Found";
            }

            expense.Title = UpdatedExpense.Title;
            expense.Amount = UpdatedExpense.Amount;
            expense.Date = UpdatedExpense.Date;
            expense.CategoryId = UpdatedExpense.CategoryId;

            response.Data = expense;
        }
        catch (Exception ex)
        {
            response.Success = false;
            response.Message = ex.Message;
        }

        return response;
    }

    public async Task<ServiceResponse<bool>> DeleteExpense(int id)
    {
        var response = new ServiceResponse<bool>();
        try
        {
            var expense = await _context.Expenses.FindAsync(id);
            if (expense == null)
            {
                response.Success = false;
                response.Message = "Not Found!";
            }

            _context.Expenses.Remove(expense);
            await _context.SaveChangesAsync();

            response.Data = true;
        }
        catch (Exception ex)
        {
            response.Success = false;
            response.Message = ex.Message;
            response.Data = false;
        }

        return response;

    }

}
