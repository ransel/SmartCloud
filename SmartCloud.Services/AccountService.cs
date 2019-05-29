using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SmartCloud.Domain.Commands.Account;
using SmartCloud.Domain.Entities;
using SmartCloud.Services.Helpers;
using SmartCloud.Services.Interfaces;

namespace SmartCloud.Services
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository _accountRepository;
        private readonly IMapperService _mapperService;
        private readonly IContextService _contextService;

        public AccountService(IAccountRepository accountRepository, IMapperService mapperService, IContextService contextService)
        {
            _accountRepository = accountRepository;
            _mapperService = mapperService;
            _contextService = contextService;
        }

        public bool IsValidSessionId(string sessionId)
        {
            return true;
        }

        public async Task<List<User>> GetAllUsers()
        {
            return await _accountRepository.GetAllUsers();
        }

        public async Task<User> CreateUser(CreateUserCommand command)
        {
            var currentUser = _contextService.User?.Name;

            var user = _mapperService.Map<CreateUserCommand, User>(command);
            user.UserId = Guid.NewGuid();
            user.VerificationPin = PinGenerator.Generate();
            user.CreateUser = currentUser;
            user.LastModUser = currentUser;

            await _accountRepository.CreateUser(user);

            return await Task.FromResult(user);
        }
    }
}