using Microsoft.EntityFrameworkCore;

namespace Nightrain.BookStore.Data.Context
{
    public interface IApplicationDbContext  
    {
        DbSet<TEntity> Set<TEntity>() where TEntity : class;
    }
}
