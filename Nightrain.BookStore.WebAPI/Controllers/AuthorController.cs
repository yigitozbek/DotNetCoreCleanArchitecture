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

        public async Task<IActionResult> List()
        {
            await _mediator.Send(new CreateAuthorCommand() {Name = ""}); 
            return Ok();
        }

    }
}