using Microsoft.EntityFrameworkCore;
using Nightrain.BookStore.Domain.Entities;

namespace Nightrain.BookStore.Data.Context
{
    public interface IApplicationDbContext  
    {
        DbSet<TEntity> Set<TEntity>() where TEntity : class;
    }
}
