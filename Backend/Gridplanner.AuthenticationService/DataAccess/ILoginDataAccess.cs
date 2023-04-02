using GridPlanner.Library.Models.Export;
using GridPlanner.Library.Models.Import;

namespace Gridplanner.AuthenticationService.DataAccess;

public interface ILoginDataAccess
{
    Task<UserDto?> GetUserByLogin(LoginDto login);
}