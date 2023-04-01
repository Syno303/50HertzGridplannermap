using GridPlanner.Library.Models.Entities;

namespace GridPlanner.Library.Extensions;

public static class CoordinateExtensions
{
    public static List<GridStation> GetAllGridstationsInProximityOfCoordinate(this Coordinate coordinate, int rangeInKm, List<GridStation> gridStations)
    {
        const double earthRadius = 6371; // Earth's radius in kilometers
        var results = new List<GridStation>();

        foreach (var gridStation in gridStations)
        {
            // Convert latitude and longitude values to radians
            var lat1 = coordinate.Latitude * Math.PI / 180;
            var lon1 = coordinate.Longitude * Math.PI / 180;
            var lat2 = gridStation.Coordinate.Latitude * Math.PI / 180;
            var lon2 = gridStation.Coordinate.Longitude * Math.PI / 180;

            // Calculate the distance between the two points using the Haversine formula
            var deltaLat = lat2 - lat1;
            var deltaLon = lon2 - lon1;
            var a = Math.Sin(deltaLat / 2) * Math.Sin(deltaLat / 2) + Math.Cos(lat1) * Math.Cos(lat2) * Math.Sin(deltaLon / 2) * Math.Sin(deltaLon / 2);
            var c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));
            var distance = earthRadius * c;

            // If the distance is within the specified range, add the point to the results
            if (distance <= rangeInKm)
            {
                results.Add(gridStation);
            }
        }

        return results;
    }
}