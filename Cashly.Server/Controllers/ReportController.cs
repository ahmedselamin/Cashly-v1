using Cashly.Server.Services.ReportService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Cashly.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReportController : ControllerBase
    {
        private readonly IReportService _reportService;

        public ReportController(IReportService reportService)
        {
            _reportService = reportService;
        }

        [HttpGet("total-income"), Authorize]
        public async Task<ActionResult<ServiceResponse<decimal>>> GetTotalIncome(DateOnly startDate, DateOnly endDate)
        {
            var result = await _reportService.GetTotalIncome(startDate, endDate);

            return Ok(result);
        }
    }
}
