using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StremoCloud.Application.Features.Command.Create;

namespace StremoCloud.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        readonly IMediator _mediator;

        public UserController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> SignUpAsync(SignUpCommand command)
        {
            var response = await _mediator.Send(command);
            return Ok(response);
        }
    }
}
