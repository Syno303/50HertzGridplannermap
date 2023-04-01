using GridPlanner.Library.Models.Export;
using GridPlanner.Library.Models.Import;
using MediatR;

namespace GridPlanner.Library.Queries.Read;

public record GetUserByLoginQuery(LoginDto login) : IRequest<UserDto?>
{
    
}