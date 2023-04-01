using GridPlanner.Library.Models.Export;
using GridPlanner.Library.Models.Import;

namespace GridPlanner.Library.DataAccess;

public interface ILoginDataAccess
{
    Task<UserDto?> GetUserByLogin(LoginDto login);
}