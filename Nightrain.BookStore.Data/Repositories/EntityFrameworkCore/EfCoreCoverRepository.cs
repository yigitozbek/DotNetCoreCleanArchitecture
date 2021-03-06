using Nightrain.Base.Core.DataAccessLayers.Concrete.EntityFrameworkCore;
using Nightrain.BookStore.Data.Context;
using Nightrain.BookStore.Domain.Entities;
using Nightrain.BookStore.Domain.Interfaces;

namespace Nightrain.BookStore.Data.Repositories.EntityFrameworkCore
{
    public class EfCoreCoverRepository : EfCoreGenericRepository<Cover, ApplicationDbContext>, ICoverRepository
    {
        public EfCoreCoverRepository(ApplicationDbContext context) : base(context)
        {

        }

    }
}