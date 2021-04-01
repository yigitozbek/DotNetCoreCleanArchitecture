using Nightrain.Base.Core.Helpers.Results;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Nightrain.Base.Core.DataAccessLayers.Abstract
{
    public interface IRepository<T>
    {
        Task<IResult> AddAsync(T entity);
        Task<IResult> UpdateAsync(T entity);
        Task<IResult> DeleteAsync(T entity);
        Task<T> GetAsync(Expression<Func<T, bool>> expression);
        Task<IEnumerable<T>> GetListAsync(Expression<Func<T, bool>> expression = null);
    }
}
