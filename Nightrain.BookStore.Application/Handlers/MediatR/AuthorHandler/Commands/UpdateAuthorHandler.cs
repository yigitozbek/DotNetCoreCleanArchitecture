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
    public class UpdateAuthorHandler : IRequestHandler<UpdateAuthorCommand, IResult>
    {
        private readonly IAuthorRepository _authorRepository;
        private readonly IMapper _mapper;
        public UpdateAuthorHandler(IAuthorRepository authorRepository, IMapper mapper)
        {
            _authorRepository = authorRepository;
            _mapper = mapper;
        }

        public async Task<IResult> Handle(UpdateAuthorCommand request, CancellationToken cancellationToken)
        {
            var author = _mapper.Map<Author>(request);
            var result = await _authorRepository.UpdateAsync(author);
            if (!result.Success) return new ErrorResult(result.Message);
            return new SuccessResult(result.Message);
        }
    }
}