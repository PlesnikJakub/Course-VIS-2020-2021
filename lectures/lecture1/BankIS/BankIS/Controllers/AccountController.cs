using Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace BankIS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        [HttpGet("{id}")]
        public int Get(int id)
        {
            var accountService = new AccountService();
            return accountService.GetAccountBalance(id);
        }
    }
}
