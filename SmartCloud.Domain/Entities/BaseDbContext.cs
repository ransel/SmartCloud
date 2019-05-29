using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace SmartCloud.Domain.Entities
{
    public class BaseDbContext : DbContext
    {
        public BaseDbContext() : base()
        {}

        public BaseDbContext(DbContextOptions<MVP_DBContext> options)
            : base(options)
        {
        }

        public override Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default(CancellationToken))
        {
            var addedEntities = ChangeTracker.Entries().Where(e => e.State == EntityState.Added).ToList();

            addedEntities.ForEach(e =>
            {
                if (PropertyExists("CreateDate", e))
                {
                    e.Property("CreateDate").CurrentValue = DateTime.Now;
                }
                if (PropertyExists("LastModDate", e))
                {
                    e.Property("LastModDate").CurrentValue = DateTime.Now;
                }
            });

            var editedEntities = ChangeTracker.Entries().Where(e => e.State == EntityState.Modified).ToList();

            editedEntities.ForEach(e =>
            {
                if (PropertyExists("LastModDate", e))
                {
                    e.Property("LastModDate").CurrentValue = DateTime.Now;
                }
            });

            return base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
        }

        private static bool PropertyExists(string propertyName, EntityEntry entity)
        {
            return entity.Metadata.FindProperty(propertyName) != null;
        }
    }
}