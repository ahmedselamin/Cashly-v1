
namespace Cashly.Server.Services.ReportService;

public class ReportService : IReportService
{
    private readonly DataContext _context;

    public ReportService(DataContext context)
    {
        _context = context;
    }
    public async Task<ServiceResponse<decimal>> GetTotalIncome(DateTime startDate, DateTime endDate)
    {
        var response = new ServiceResponse<decimal>();
        try
        {
            response.Data = await _context.Expenses
                  .Where(e => e.CategoryId == 1 && e.Date >= startDate && e.Date <= endDate)
                  .SumAsync(e => e.Amount);

            response.Success = true;
        }

        catch (Exception ex)
        {
            response.Success = false;
            response.Message = ex.Message;
        }

        return response;

    }

    public async Task<ServiceResponse<decimal>> GetTotalExpenditure(DateTime startDate, DateTime endDate)
    {
        var response = new ServiceResponse<decimal>();
        try
        {
            response.Data = await _context.Expenses
                .Where(e => e.CategoryId == 2 && e.Date >= startDate && e.Date <= endDate)
                .SumAsync(e => e.Amount);
            response.Success = true;
        }

        catch (Exception ex)
        {
            response.Success = false;
            response.Message = ex.Message;
        }

        return response;
    }

    public async Task<ServiceResponse<decimal>> GetTotalExpenses(DateTime startDate, DateTime endDate)
    {
        var response = new ServiceResponse<decimal>();
        try
        {
            response.Data = await _context.Expenses
                .Where(e => e.CategoryId == 1 && e.Date >= startDate && e.Date <= endDate)
                .SumAsync(e => e.Amount);
            response.Success = true;
        }

        catch (Exception ex)
        {
            response.Success = false;
            response.Message = ex.Message;
        }

        return response;
    }
}
