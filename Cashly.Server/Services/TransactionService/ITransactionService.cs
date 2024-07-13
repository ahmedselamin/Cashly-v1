namespace Cashly.Server.Services.TransactionService
{
    public interface ITransactionService
    {
        Task<ServiceResponse<List<Transaction>>> GetTransactions();
        Task<ServiceResponse<Transaction>> GetTransactionById(int id);
        Task<ServiceResponse<Transaction>> CreateTransaction(Transaction transaction);
        Task<ServiceResponse<Transaction>> UpdatedTransaction(int id, Transaction UpdatedTransaction);
        Task<ServiceResponse<bool>> DeleteTransaction(int id);
    }
}
