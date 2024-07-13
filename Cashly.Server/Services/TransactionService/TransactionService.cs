
namespace Cashly.Server.Services.TransactionService;

public class TransactionService : ITransactionService
{
    private readonly DataContext _context;

    public TransactionService(DataContext context)
    {
        _context = context;
    }

    public async Task<ServiceResponse<List<Transaction>>> GetTransactions()
    {
        var response = new ServiceResponse<List<Transaction>>();
        try
        {
            response.Data = await _context.Transactions.ToListAsync();
        }

        catch (Exception ex)
        {
            response.Success = false;
            response.Message = ex.Message;
        }

        return response;
    }
    public async Task<ServiceResponse<Transaction>> GetTransactionById(int id)
    {
        var response = new ServiceResponse<Transaction>();
        try
        {
            var transaction = await _context.Transactions.FindAsync(id);

            if (transaction == null)
            {
                response.Success = false;
                response.Message = "Not Found";
            }

            response.Data = transaction;
        }

        catch (Exception ex)
        {
            response.Success = false;
            response.Message = ex.Message;
        }

        return response;
    }
    public async Task<ServiceResponse<Transaction>> CreateTransaction(Transaction transaction)
    {
        var response = new ServiceResponse<Transaction>();
        try
        {
            _context.Transactions.Add(transaction);

            await _context.SaveChangesAsync();
            response.Data = transaction;
        }

        catch (Exception ex)
        {
            response.Success = false;
            response.Message = ex.Message;
        }

        return response;
    }

    public async Task<ServiceResponse<Transaction>> UpdatedTransaction(int id, Transaction UpdatedTransaction)
    {
        var response = new ServiceResponse<Transaction>();
        try
        {
            var transaction = await _context.Transactions.FindAsync(id);

            if (transaction == null)
            {
                response.Success = false;
                response.Message = "Not Found";
            }

            transaction.Category = UpdatedTransaction.Category;
            transaction.Title = UpdatedTransaction.Title;
            transaction.Amount = UpdatedTransaction.Amount;
        }

        catch (Exception ex)
        {
            response.Success = false;
            response.Message = ex.Message;
        }

        return response;
    }

    public async Task<ServiceResponse<bool>> DeleteTransaction(int id)
    {
        var response = new ServiceResponse<bool>();
        try
        {
            var transaction = await _context.Transactions.FindAsync(id);

            if (transaction == null)
            {
                response.Success = false;
                response.Message = "Not Found";
            }

            _context.Transactions.Remove(transaction);
            await _context.SaveChangesAsync();

            response.Data = true;
        }

        catch (Exception ex)
        {
            response.Success = false;
            response.Message = ex.Message;
        }

        return response;
    }

}
