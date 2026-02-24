using Microsoft.AspNetCore.Mvc;
using BankingAPI.Models;

namespace BankingAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AccountsController : ControllerBase
    {
        [HttpPost("balance")]
        public IActionResult GetBalance([FromBody] BalanceRequest request)
        {
            if (request == null)
            {
                return BadRequest("Request cannot be empty");
            }

            var response = new BalanceResponse
            {
                transaction_reference = request.transaction_reference,
                transaction_code = request.transaction_code,
                amount = request.amount,
                // narration = request.narration,
                phone_number = request.phone_number,
                account_name = "John Doe",
                actual_balance = 500,
                available_balance = 500
            };

            return Ok(response);
        }
    }
}