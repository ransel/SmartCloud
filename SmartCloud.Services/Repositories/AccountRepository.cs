using System.Collections.Generic;
using System.Linq;
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
            var users = Context.User.Include(u => u.UserType).Take(50);
            var results = await users.ToListAsync();

            return results
                .OrderBy(user => user.FirstName)
                .ThenBy(user => user.LastName)
                .ToList();
        }

        public async Task CreateUser(User user)
        {
            Context.Add(user);
            await Context.SaveChangesAsync();
        }
    }
}