using SmartCloud.Domain.Entities;

namespace SmartCloud.Services.Repositories
{
    public abstract class BaseRepository
    {
        protected readonly MVP_DBContext Context;

        protected BaseRepository(MVP_DBContext context)
        {
            Context = context;
        }
    }
}