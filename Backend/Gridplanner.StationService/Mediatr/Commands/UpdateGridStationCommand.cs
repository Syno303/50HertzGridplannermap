using GridPlanner.Library.Models.Export;
using GridPlanner.Library.Models.Import;
using MediatR;

namespace Gridplanner.StationService.Mediatr.Commands;

public record UpdateGridStationCommand(int id, GridStationImportDto gridstation):IRequest<GridStationExportDto>
{
    
}