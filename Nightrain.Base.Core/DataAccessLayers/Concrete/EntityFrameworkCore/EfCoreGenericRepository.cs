using Microsoft.EntityFrameworkCore;
using Nightrain.Base.Core.Constants;
using Nightrain.Base.Core.DataAccessLayers.Abstract;
using Nightrain.Base.Core.Helpers.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Nightrain.Base.Core.DataAccessLayers.Concrete.EntityFrameworkCore
{
    public class EfCoreGenericRepository<TEntity, TContext> : IRepository<TEntity>
        where TEntity : class
        where TContext : DbContext
    {
        private readonly TContext _context;

        public EfCoreGenericRepository(TContext context)
        {
            _context = context;
        }

        public async Task<IResult> AddAsync(TEntity entity)
        {
            await _context.Set<TEntity>().AddAsync(entity);
            await _context.SaveChangesAsync();

            return new SuccessResult(Messages.Added);
        }

        public async Task<IResult> DeleteAsync(TEntity entity)
        {
            _context.Set<TEntity>().Remove(entity);
            await _context.SaveChangesAsync();
            return new SuccessResult(Messages.Removed);
        }

        public async Task<IResult> UpdateAsync(TEntity entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return new SuccessResult(Messages.Updated);
        }

        public async Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> expression)
        {
            return await _context.FindAsync<TEntity>(expression);
        }

        public async Task<IEnumerable<TEntity>> GetListAsync(Expression<Func<TEntity, bool>> expression = null)
        {
            return expression != null
                ? await _context.Set<TEntity>().Where(expression).ToListAsync()
                : await _context.Set<TEntity>().ToListAsync();
        }
    }
}
