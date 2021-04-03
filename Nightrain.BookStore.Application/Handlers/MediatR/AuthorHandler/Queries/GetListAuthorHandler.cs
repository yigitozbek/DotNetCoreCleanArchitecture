using System.Collections.Generic;
using System.Data;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using Dapper;
using MediatR;
using Nightrain.Base.Core.DataAccessLayers.Abstract;
using Nightrain.BookStore.Application.DataTransferObjects.Author;
using Nightrain.BookStore.Application.Queries.AuthorQuery;
using Nightrain.BookStore.Domain.Entities;

namespace Nightrain.BookStore.Application.Handlers.MediatR.AuthorHandler.Queries
{
    public class GetListAuthorHandler : IRequestHandler<GetListAuthorQuery, List<AuthorDto>>
    {
        private readonly IMapper _mapper;
        private readonly IDapper _dapper;
        public GetListAuthorHandler(IMapper mapper, IDapper dapper)
        {
            _mapper = mapper;
            _dapper = dapper;
        }

        public async Task<List<AuthorDto>> Handle(GetListAuthorQuery request, CancellationToken cancellationToken)
        {
            var query = "SELECT * FROM Authors AS a WHERE ";
            query += "(ISNULL(@Id,0) = 0 OR a.Id = @ID) ";
            query += "AND (ISNULL(@Name,'') = '' OR a.Name LIKE '%' + @Name + '%') ";
            query += "AND (ISNULL(@Surname,'') = '' OR a.Surname LIKE '%' + @Surname + '%') ";

            var dpParams = new DynamicParameters();
            dpParams.Add("Id", request.Id, DbType.Int32);
            dpParams.Add("Name", request.Name, DbType.String);
            dpParams.Add("Surname", request.Surname, DbType.String);

            var authors = await _dapper.GetListAsync<Author>(query, dpParams, CommandType.Text);
            var map = _mapper.Map<List<AuthorDto>>(authors);

            return map;
        }
    }
}
