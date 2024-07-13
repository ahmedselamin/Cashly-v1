using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Cashly.Server.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TransactionController : ControllerBase
{
    private readonly ITransactionService _transactionService;

    public TransactionController(ITransactionService transactionService)
    {
        _transactionService = transactionService;
    }

    //[Authorize]
    [HttpGet]
    public async Task<ActionResult<ServiceResponse<List<Transaction>>>> GetTransactions()
    {
        var result = await _transactionService.GetTransactions();

        return Ok(result);
    }

    [Authorize]
    [HttpGet("{id}")]
    public async Task<ActionResult<ServiceResponse<Transaction>>> GetTransactionById(int id)
    {
        var result = await _transactionService.GetTransactionById(id);

        if (!result.Success)
        {
            return NotFound(result);
        }

        return Ok(result);
    }

    [Authorize]
    [HttpPost]
    public async Task<ActionResult<ServiceResponse<Transaction>>> CreateTrasnaction(Transaction transaction)
    {
        var result = await _transactionService.CreateTransaction(transaction);

        return Ok(result);
    }

    [Authorize]
    [HttpPut("{id}")]
    public async Task<ActionResult<ServiceResponse<Transaction>>> UpdateTransAction(int id, Transaction UpdatedTransaction)
    {
        var result = await _transactionService.UpdatedTransaction(id, UpdatedTransaction);

        if (!result.Success)
        {
            return NotFound(result);
        }

        return Ok(result);
    }

    [Authorize]
    [HttpDelete]
    public async Task<ActionResult<ServiceResponse<bool>>> DeleteTransaction(int id)
    {
        var result = await _transactionService.DeleteTransaction(id);

        if (!result.Success)
        {
            return BadRequest(result);
        }

        return Ok(result);
    }
}
