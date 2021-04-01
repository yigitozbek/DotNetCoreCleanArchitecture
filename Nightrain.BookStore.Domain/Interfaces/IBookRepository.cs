using Nightrain.Base.Core.DataAccessLayers.Abstract;
using Nightrain.BookStore.Domain.Entities;

namespace Nightrain.BookStore.Domain.Interfaces
{
    public interface IBookRepository : IRepository<Book>
    {

    }
}