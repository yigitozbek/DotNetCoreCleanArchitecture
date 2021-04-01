﻿using Nightrain.Base.Core.DataAccessLayers.Concrete.EntityFrameworkCore;
using Nightrain.BookStore.Data.Context;
using Nightrain.BookStore.Domain.Entities;
using Nightrain.BookStore.Domain.Interfaces;

namespace Nightrain.BookStore.Data.Repositories.EntityFrameworkCore
{
    public class EfCoreBookFormatRepository : EfCoreGenericRepository<BookFormat, ApplicationDbContext>, IBookFormatRepository
    {
        public EfCoreBookFormatRepository(ApplicationDbContext context) : base(context)
        {

        }

    }
}