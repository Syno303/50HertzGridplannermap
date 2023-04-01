using GridPlanner.Library.Models.Export;
using GridPlanner.Library.Models.Import;
using MediatR;

namespace GridPlanner.Library.Commands;

public record UpdateGridStationCommand(int id, GridStationImportDto gridstation):IRequest<GridStationExportDto>
{
    
}