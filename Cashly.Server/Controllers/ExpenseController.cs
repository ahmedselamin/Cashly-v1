using Microsoft.AspNetCore.Mvc;

namespace Cashly.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExpenseController : ControllerBase
    {
        private readonly IExpenseService _expenseService;

        public ExpenseController(IExpenseService expenseService)
        {
            _expenseService = expenseService;
        }

        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<Expense>>>> GetExpenses()
        {
            var result = await _expenseService.GetExpenses();

            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ServiceResponse<Expense>>> GetExpense(int id)
        {
            var result = await _expenseService.GetExpense(id);

            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<ServiceResponse<Expense>>> CreateExpense(Expense expense)
        {
            var result = await _expenseService.CreateExpense(expense);

            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<ServiceResponse<Expense>>> UpdateExpense(int id, Expense Updatedexpense)
        {
            var result = await _expenseService.UpdateExpense(id, Updatedexpense);

            if (!result.Success)
            {
                return NotFound(result.Message);
            }

            return Ok(result);
        }

        [HttpDelete]
        public async Task<ActionResult<ServiceResponse<bool>>> DeleteExpense(int id)
        {
            var result = await _expenseService.DeleteExpense(id);

            if (!result.Success)
            {
                return NotFound(result.Message);
            }

            return Ok(result);
        }

    }
}
