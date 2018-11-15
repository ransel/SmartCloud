using System.Collections.Generic;
using System.Threading.Tasks;
using SmartCloud.Domain.Commands.Account;
using SmartCloud.Domain.Entities;

namespace SmartCloud.Services.Interfaces
{
    public interface IAccountService
    {
        bool IsValidSessionId(string sessionId);
        Task<List<User>> GetAllUsers();
        Task<User> CreateUser(CreateUserCommand command);
    }
}