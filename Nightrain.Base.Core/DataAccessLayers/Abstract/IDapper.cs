using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace Nightrain.Base.Core.DataAccessLayers.Abstract
{
    public interface IDapper
    {
        T ExecuteStoredProcedure<T>(string query, DynamicParameters spParams, CommandType commandType = CommandType.StoredProcedure);

        Task<IEnumerable<T>> GetListAsync<T>(string query, DynamicParameters spParams,
            CommandType commandType = CommandType.StoredProcedure);
        List<T> Get<T>(string query, DynamicParameters spParams, CommandType commandType = CommandType.StoredProcedure);
    }
}
