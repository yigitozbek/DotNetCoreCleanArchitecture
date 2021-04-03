using AutoMapper;
using Nightrain.BookStore.Application.Commands.AuthorCommand;
using Nightrain.BookStore.Application.DataTransferObjects.Author;
using Nightrain.BookStore.Domain.Entities;

namespace Nightrain.BookStore.Application.Mapper.AutoMapper
{
    public class AuthorMappingProfile : Profile
    {
        public AuthorMappingProfile()
        {
            CreateMap<Author, CreateAuthorCommand>();
            CreateMap<CreateAuthorCommand, Author>();

            CreateMap<AuthorDto, Author>();
            CreateMap<Author, AuthorDto>();


        }   

    }
}
