using GridPlanner.Library.Models.Export;
using MediatR;

namespace GridPlanner.Library.Queries.Read;

public record GetGridstationByIdQuery(int id) : IRequest<GridStationExportDto>
{
    
}