using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Nightrain.BookStore.Domain.Commands.AuthorCommand;


namespace Nightrain.BookStore.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AuthorController(IMediator mediator)
        {
            _mediator = mediator;
        }

        public IActionResult List()
        {
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateAuthorCommand createAuthorCommand)
        {
            var result = await _mediator.Send(createAuthorCommand);
            if (!result.Success) return BadRequest(result.Message);
            return Ok(result.Message);
        }



    }
}