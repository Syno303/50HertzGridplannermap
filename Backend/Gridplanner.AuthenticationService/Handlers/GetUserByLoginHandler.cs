using Gridplanner.AuthenticationService.DataAccess;
using Gridplanner.AuthenticationService.Queries;
using GridPlanner.Library.Models.Export;
using MediatR;

namespace Gridplanner.AuthenticationService.Handlers;

public class GetUserByLoginHandler:IRequestHandler<GetUserByLoginQuery, UserDto?>
{
    private readonly ILoginDataAccess _dataAccess;

    public GetUserByLoginHandler(ILoginDataAccess dataAccess)
    {
        _dataAccess = dataAccess;
    }
    public async Task<UserDto?> Handle(GetUserByLoginQuery request, CancellationToken cancellationToken)
    {
        return await _dataAccess.GetUserByLogin(request.login);
    }
}