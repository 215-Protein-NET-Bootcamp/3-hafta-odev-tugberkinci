using Microsoft.AspNetCore.Mvc;
using PatikaHomework3.Service.IServices;

namespace PatikaHomework3.Controllers
{
    [Route("[Controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccountService _accountService;

        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }

    }
}
