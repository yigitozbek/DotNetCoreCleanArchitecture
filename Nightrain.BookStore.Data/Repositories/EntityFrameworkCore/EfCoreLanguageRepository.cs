using Nightrain.Base.Core.DataAccessLayers.Concrete.EntityFrameworkCore;
using Nightrain.BookStore.Data.Context;
using Nightrain.BookStore.Domain.Entities;
using Nightrain.BookStore.Domain.Interfaces;

namespace Nightrain.BookStore.Data.Repositories.EntityFrameworkCore
{
    public class EfCoreLanguageRepository : EfCoreGenericRepository<Language, ApplicationDbContext>, ILanguageRepository
    {
        public EfCoreLanguageRepository(ApplicationDbContext context) : base(context)
        {

        }

    }
}