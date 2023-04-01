using GridPlanner.Backend.Models;
using GridPlanner.Library.Models.Export;
using GridPlanner.Library.Models.Import;
using GridPlanner.Library.Queries.Read;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace GridPlanner.Backend.Controllers;

[ApiController]
[Route("api/[controller]")]
public class LoginController : AbstractMediatrControllerBase
{
    public LoginController(IMediator mediator) : base(mediator)
    {
    }
    
    [HttpPost]
    [ProducesResponseType(typeof(UserDto), StatusCodes.Status200OK)]
    public async Task<UserDto?> Login(LoginDto login)
    {
        return await Mediator.Send(new GetUserByLoginQuery(login));
    }
}