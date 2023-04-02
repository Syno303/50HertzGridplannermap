using GridPlanner.Library.Models.Export;
using MediatR;

namespace Gridplanner.StationService.Mediatr.Queries;

public record GetGridstationByIdQuery(int id) : IRequest<GridStationExportDto>
{
    
}