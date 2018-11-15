using System.Collections.Generic;
using System.Threading.Tasks;
using SmartCloud.Domain.Entities;

namespace SmartCloud.Services.Interfaces
{
    public interface IAccountRepository
    {
        Task<List<User>> GetAllUsers();
        Task CreateUser(User user);
    }
}