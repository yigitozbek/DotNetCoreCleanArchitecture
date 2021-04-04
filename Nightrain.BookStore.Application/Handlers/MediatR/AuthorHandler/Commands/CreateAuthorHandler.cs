using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Nightrain.Base.Core.Aspects.PostSharp.Validation;
using Nightrain.Base.Core.Helpers.Results;
using Nightrain.BookStore.Application.Commands.AuthorCommand;
using Nightrain.BookStore.Application.Validations.FluentValidation.AuthorValidator;
using Nightrain.BookStore.Domain.Entities;
using Nightrain.BookStore.Domain.Interfaces;

namespace Nightrain.BookStore.Application.Handlers.MediatR.AuthorHandler.Commands
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

        [ValidationAspect(Validator = typeof(CreateAuthorValidator))]
        public async Task<IResult> Handle(CreateAuthorCommand request, CancellationToken cancellationToken)
        {
            var author = _mapper.Map<Author>(request);
            var result = await _authorRepository.AddAsync(author);
            if (!result.Success) return new ErrorResult(result.Message);
            return new SuccessResult(result.Message);
        }
    }
}
