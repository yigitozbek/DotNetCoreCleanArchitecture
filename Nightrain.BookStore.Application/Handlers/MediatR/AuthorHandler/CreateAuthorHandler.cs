using MediatR;
using Nightrain.Base.Core.Helpers.Results;
using Nightrain.BookStore.Domain.Commands.AuthorCommand;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using Nightrain.BookStore.Data.Context;
using Nightrain.BookStore.Domain.Entities;
using Nightrain.BookStore.Domain.Interfaces;

namespace Nightrain.BookStore.Application.Handlers.MediatR.AuthorHandler
{
    public class CreateAuthorHandler : IRequestHandler<CreateAuthorCommand, IResult>
    {
        private readonly IAuthorRepository _authorRepository;
        private readonly IMapper _mapper;
        public CreateAuthorHandler(IAuthorRepository authorRepository, IMapper mapper)
        {
            _authorRepository = authorRepository;
            _mapper = mapper;
        }

        public async Task<IResult> Handle(CreateAuthorCommand request, CancellationToken cancellationToken)
        {
            var author = _mapper.Map<Author>(request);
            var result = await _authorRepository.AddAsync(author);
            if (!result.Success) return new ErrorResult(result.Message);
            return new SuccessResult(result.Message);
        }
    }
}
