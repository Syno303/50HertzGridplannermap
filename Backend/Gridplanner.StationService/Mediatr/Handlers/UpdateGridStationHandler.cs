using AutoMapper;
using GridPlanner.Library.Models.Entities;
using GridPlanner.Library.Models.Export;
using Gridplanner.StationService.DataAccess;
using Gridplanner.StationService.Mediatr.Commands;
using MediatR;

namespace Gridplanner.StationService.Mediatr.Handlers;

public class UpdateGridStationHandler:IRequestHandler<UpdateGridStationCommand, GridStationExportDto>
{
    private readonly IDataAccess _dataAccess;
    private readonly IMapper _mapper;

    public UpdateGridStationHandler(IDataAccess dataAccess, IMapper mapper)
    {
        _dataAccess = dataAccess;
        _mapper = mapper;
    }
    public async Task<GridStationExportDto> Handle(UpdateGridStationCommand request, CancellationToken cancellationToken)
    {
        var gridstation = _mapper.Map<GridStation>(request.gridstation);
        var result = await _dataAccess.UpdateGridstation(gridstation);
        await _dataAccess.SaveChangesAsync();
        return _mapper.Map<GridStationExportDto>(result);
    }
}