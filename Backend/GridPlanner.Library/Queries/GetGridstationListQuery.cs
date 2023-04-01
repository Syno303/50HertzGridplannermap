using GridPlanner.Library.Models.Entities;
using GridPlanner.Library.Models.Export;
using MediatR;

namespace GridPlanner.Library.Queries.Read;

public record GetGridstationListQuery : IRequest<List<GridStationExportDto>>
{
    
}