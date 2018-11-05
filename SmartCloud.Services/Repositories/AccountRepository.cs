using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SmartCloud.Domain.Entities;
using SmartCloud.Services.Interfaces;

namespace SmartCloud.Services.Repositories
{
    public class AccountRepository : BaseRepository, IAccountRepository
    {
        public AccountRepository(MVP_DBContext context) : base(context)
        {
        }

        public async Task<List<User>> GetAllUsers()
        {
            var users = Context.User.Include(u => u.UserType);
            return await users.ToListAsync();
        }
    }
}