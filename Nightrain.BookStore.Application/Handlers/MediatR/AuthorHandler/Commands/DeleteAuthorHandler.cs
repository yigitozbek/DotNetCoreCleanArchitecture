using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Nightrain.Base.Core.Helpers.Results;
using Nightrain.BookStore.Application.Commands.AuthorCommand;
using Nightrain.BookStore.Domain.Entities;
using Nightrain.BookStore.Domain.Interfaces;

namespace Nightrain.BookStore.Application.Handlers.MediatR.AuthorHandler.Commands
{
    public class DeleteAuthorHandler : IRequestHandler<DeleteAuthorCommand, IResult>
    {
        private readonly IAuthorRepository _authorRepository;
        private readonly IMapper _mapper;
        public DeleteAuthorHandler(IAuthorRepository authorRepository, IMapper mapper)
        {
            _authorRepository = authorRepository;
            _mapper = mapper;
        }

        public async Task<IResult> Handle(DeleteAuthorCommand request, CancellationToken cancellationToken)
        {
            var author = _mapper.Map<Author>(request);
            var result = await _authorRepository.DeleteAsync(author);
            if (!result.Success) return new ErrorResult(result.Message);
            return new SuccessResult(result.Message);
        }
    }
}