using GridPlanner.Library.Models.Export;
using GridPlanner.Library.Models.Import;
using MediatR;

namespace Gridplanner.AuthenticationService.Queries;

public record GetUserByLoginQuery(LoginDto login) : IRequest<UserDto?>
{
    
}