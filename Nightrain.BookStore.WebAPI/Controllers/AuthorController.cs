using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Nightrain.BookStore.Application.Commands.AuthorCommand;
using Nightrain.BookStore.Application.Queries.AuthorQuery;


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

        [HttpGet]
        public IActionResult Get()
        {
            return Ok();
        }

        [HttpGet("List")]
        public async Task<IActionResult> List([FromQuery] GetListAuthorQuery getListAuthorQuery)
        {
            var result = await _mediator.Send(getListAuthorQuery);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateAuthorCommand createAuthorCommand)
        {
            var result = await _mediator.Send(createAuthorCommand);
            if (!result.Success) return BadRequest(result.Message);
            return Ok(result.Message);
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] UpdateAuthorCommand updateAuthorCommand)
        {
            var result = await _mediator.Send(updateAuthorCommand);
            if (!result.Success) return BadRequest(result.Message);
            return Ok(result.Message);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete([FromBody] DeleteAuthorCommand deleteAuthorCommand)
        {
            var result = await _mediator.Send(deleteAuthorCommand);
            if (!result.Success) return BadRequest(result.Message);
            return Ok(result.Message);
        }
    }
}