namespace Cashly.Server.Services.ReportService;

public interface IReportService
{
    Task<ServiceResponse<decimal>> GetTotalIncome(DateTime startDate, DateTime endDate);
    Task<ServiceResponse<decimal>> GetTotalExpenditure(DateTime startDate, DateTime endDate);
    Task<ServiceResponse<decimal>> GetTotalExpenses(DateTime startDate, DateTime endDate);
}
