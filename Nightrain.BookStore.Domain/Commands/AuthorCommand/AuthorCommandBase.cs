using Nightrain.Base.Core.Commands;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nightrain.BookStore.Domain.Commands.AuthorCommand
{
    public class AuthorCommandBase : CommandBase
    {
        public int Id { get; set; }
    }
}
