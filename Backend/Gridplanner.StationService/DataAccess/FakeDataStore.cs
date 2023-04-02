using GridPlanner.Library.Models.Entities;

namespace Gridplanner.StationService.DataAccess;

public static class FakeDataStore
{
    public static List<GridStation> _gridStations = new ()
    {
        new()
        {
            StationName = "Station Diest",
            Coordinate = new Coordinate()
            {
                Latitude = 50.9688012,
                Longitude = 5.0743388
            },
            Contact = new Contact()
            {
                Name = "Diest"
            },
            Id = 1,
            Kilovoltage = 380
        },
        new()
        {
            StationName = "Station Lummen",
            Coordinate = new Coordinate()
            {

                Latitude = 50.9877,
                Longitude = 5.1951
            },
            Contact = new Contact()
            {
                Name = "Lummen"
            },
            Id = 2,
            Kilovoltage = 380
        },
        new()
        {
            StationName = "Station Diksmuide",
            Coordinate = new Coordinate()
            {
                Latitude = 51.0317,
                Longitude = 2.8639
            },
            Contact = new Contact()
            {
                Name = "Diksmuide"
            },
            Id = 3,
            Kilovoltage = 380
        }
    };
}