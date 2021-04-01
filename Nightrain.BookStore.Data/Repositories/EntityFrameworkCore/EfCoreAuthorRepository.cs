using Nightrain.Base.Core.DataAccessLayers.Concrete.EntityFrameworkCore;
using Nightrain.BookStore.Data.Context;
using Nightrain.BookStore.Domain.Entities;
using Nightrain.BookStore.Domain.Interfaces;

namespace Nightrain.BookStore.Data.Repositories.EntityFrameworkCore
{
    public class EfCoreAuthorRepository : EfCoreGenericRepository<Author, ApplicationDbContext>, IAuthorRepository
    {
        public EfCoreAuthorRepository(ApplicationDbContext context) : base(context)
        {

        }

    }
}
