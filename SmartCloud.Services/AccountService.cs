using System.Collections.Generic;
using System.Threading.Tasks;
using SmartCloud.Domain.Entities;
using SmartCloud.Services.Interfaces;

namespace SmartCloud.Services
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository _accountRepository;

        public AccountService(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }

        public bool IsValidSessionId(string sessionId)
        {
            return true;
        }

        public async Task<List<User>> GetAllUsers()
        {
            return await _accountRepository.GetAllUsers();
        }
    }
}