using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Nightrain.BookStore.Domain.Interfaces;

namespace Nightrain.BookStore.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {

        private readonly IBookRepository _bookRepository;

        public BookController(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public async Task<IActionResult> List()
        {
            var test = await _bookRepository.GetListAsync();
            return Ok();
        }

    }
}
