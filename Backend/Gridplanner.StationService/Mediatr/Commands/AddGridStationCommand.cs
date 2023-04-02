using GridPlanner.Library.Models.Export;
using GridPlanner.Library.Models.Import;
using MediatR;

namespace Gridplanner.StationService.Mediatr.Commands;

public record AddGridStationCommand(GridStationImportDto gridstation):IRequest<GridStationExportDto>
{
    
}