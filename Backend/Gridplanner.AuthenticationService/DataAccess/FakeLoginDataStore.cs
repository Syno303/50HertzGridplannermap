using GridPlanner.Library.Models.Export;

namespace Gridplanner.AuthenticationService.DataAccess;

public static class FakeLoginDataStore
{
    public static List<UserDto> _users = new ()
    {
        new()
        {
            UserName = "Gridplanner",
            Claims = new List<string>()
            {
                "user",
                "gridplanner"
            },
        }, new()
        {
            UserName = "User",
            Claims = new List<string>()
            {
                "user"
            },
        },
    };
}