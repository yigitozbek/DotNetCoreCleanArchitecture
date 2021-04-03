using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Nightrain.Base.Core.DataAccessLayers.Abstract;

namespace Nightrain.Base.Core.DataAccessLayers.Concrete.Dapper
{
    public class DapperRepository : IDapper
    {
        private readonly IDbConnection _dbConnection;


        public DapperRepository()
        {

            var builder = new ConfigurationBuilder();
            builder.AddJsonFile("appsettings.Development.json", optional: false);
            var configuration = builder.Build();
            var connectionString = configuration.GetConnectionString("SQLConnection");

            _dbConnection = new SqlConnection(connectionString);
        }

        public T ExecuteStoredProcedure<T>(string query, DynamicParameters spParams, CommandType commandType = CommandType.StoredProcedure)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<T>> GetListAsync<T>(string query, DynamicParameters spParams, CommandType commandType = CommandType.StoredProcedure)
        {
            var list = await _dbConnection.QueryAsync<T>(query, spParams, commandType: commandType);
            return list;
        }

        public List<T> Get<T>(string query, DynamicParameters spParams, CommandType commandType = CommandType.StoredProcedure)
        {
            throw new NotImplementedException();
        }

    }
}
