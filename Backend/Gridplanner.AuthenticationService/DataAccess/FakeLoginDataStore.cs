using GridPlanner.Library.Models.Export;

namespace Gridplanner.AuthenticationService.DataAccess;

public static class FakeLoginDataStore
{
    public static List<UserDto> _users = new ()
    {
        new()
        {
            UserName = "Koen",
            Claims = new List<string>()
            {
                "user",
                "gridplanner"
            },
        }, new()
        {
            UserName = "Oz",
            Claims = new List<string>()
            {
                "user"
            },
        },
    };
}