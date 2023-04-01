using GridPlanner.Library.DataAccess;
using GridPlanner.Library.Models.Export;
using GridPlanner.Library.Queries.Read;
using MediatR;

namespace GridPlanner.Library.Handlers;

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