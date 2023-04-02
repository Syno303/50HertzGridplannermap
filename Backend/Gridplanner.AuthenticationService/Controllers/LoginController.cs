using Gridplanner.AuthenticationService.Queries;
using GridPlanner.Library.Models.Export;
using GridPlanner.Library.Models.Import;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Gridplanner.AuthenticationService.Controllers;

[ApiController]
[Route("api/[controller]")]
public class LoginController : ControllerBase
{
    private readonly IMediator _mediator;

    public LoginController(IMediator mediator)
    {
        _mediator = mediator;
    }
    [HttpPost]
    [ProducesResponseType(typeof(UserDto), StatusCodes.Status200OK)]
    public async Task<UserDto?> Login(LoginDto login)
    {
        return await _mediator.Send(new GetUserByLoginQuery(login));
    }
}