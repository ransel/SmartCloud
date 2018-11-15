using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SmartCloud.Domain.Commands.Account;
using SmartCloud.Domain.Context;
using SmartCloud.Services.Interfaces;

namespace SmartCloud.Controllers.api
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccountService _accountService;
        private readonly IContextService _contextService;
        private readonly INotificationService _notificationService;

        public AccountController(IAccountService accountService, IContextService contextService, INotificationService notificationService)
        {
            _accountService = accountService;
            _contextService = contextService;
            _notificationService = notificationService;
        }

        [HttpPost("createuser")]
        public async Task<IActionResult> CreateUser([FromBody]CreateUserCommand command)
        {
            var principal = new SmartCloudPrincipal
            {
                FirstName = "Ransel",
                LastName = "Lopez"
            };
            _contextService.User = principal; 

            var user = await _accountService.CreateUser(command);
            return Ok(user);
        }
    }
}