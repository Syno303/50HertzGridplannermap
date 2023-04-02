using GridPlanner.Library;
using GridPlanner.Library.Models.Export;
using GridPlanner.Library.Models.Import;

namespace Gridplanner.AuthenticationService.DataAccess;

public class LoginDataAccess:ILoginDataAccess
{
    private List<UserDto> _users;
    public LoginDataAccess()
    {
        _users = FakeLoginDataStore._users;
    }


    public async Task<UserDto?> GetUserByLogin(LoginDto login)
    {
        return await Task.FromResult(_users.FirstOrDefault(x => x.UserName == login.Username));
    }
}