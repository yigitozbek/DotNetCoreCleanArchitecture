using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Nightrain.BookStore.Domain.Commands.AuthorCommand;
using Nightrain.BookStore.Domain.Entities;

namespace Nightrain.BookStore.Application.Mapper.AutoMapper.AuthorMapper
{
    public class AuthorMappingProfile : Profile
    {
        public AuthorMappingProfile()
        {
            CreateMap<Author, CreateAuthorCommand>();
            CreateMap<CreateAuthorCommand, Author>();
        }   

    }
}
