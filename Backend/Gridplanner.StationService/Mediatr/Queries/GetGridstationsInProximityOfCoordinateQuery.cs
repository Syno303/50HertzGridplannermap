using GridPlanner.Library.Models.Entities;
using GridPlanner.Library.Models.Export;
using MediatR;

namespace Gridplanner.StationService.Mediatr.Queries;

public record GetGridstationsInProximityOfCoordinateQuery(Coordinate coordinate, int radiusInKm) : IRequest<List<GridStationExportDto>>
{
    
}