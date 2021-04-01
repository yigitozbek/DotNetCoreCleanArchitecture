using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nightrain.Base.Core.DataAccessLayers.Abstract;
using Nightrain.BookStore.Domain.Entities;

namespace Nightrain.BookStore.Domain.Interfaces
{
    public interface IAuthorRepository : IRepository<Author>
    {

    }
}
