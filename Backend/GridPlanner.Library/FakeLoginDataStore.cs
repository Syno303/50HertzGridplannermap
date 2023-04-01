using GridPlanner.Library.Models.Export;

namespace GridPlanner.Library;

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