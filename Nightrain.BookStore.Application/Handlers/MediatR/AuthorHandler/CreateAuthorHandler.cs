using MediatR;
using Nightrain.Base.Core.Helpers.Results;
using Nightrain.BookStore.Domain.Commands.AuthorCommand;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Nightrain.BookStore.Data.Context;

namespace Nightrain.BookStore.Application.Handlers.MediatR.AuthorHandler
{
    public class CreateAuthorHandler : IRequestHandler<CreateAuthorCommand, IResult>
    {

        private IApplicationDbContext _applicationDbContext;

        public CreateAuthorHandler(IApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public Task<IResult> Handle(CreateAuthorCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
