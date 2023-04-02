using AutoMapper;
using GridPlanner.Library.Models.Entities;
using GridPlanner.Library.Models.Export;
using Gridplanner.StationService.DataAccess;
using Gridplanner.StationService.Mediatr.Commands;
using MediatR;

namespace Gridplanner.StationService.Mediatr.Handlers;

public class AddGridstationHandler:IRequestHandler<AddGridStationCommand, GridStationExportDto>
{
    private readonly IDataAccess _dataAccess;
    private readonly IMapper _mapper;

    public AddGridstationHandler(IDataAccess dataAccess, IMapper mapper)
    {
        _dataAccess = dataAccess;
        _mapper = mapper;
    }
    public async Task<GridStationExportDto> Handle(AddGridStationCommand request, CancellationToken cancellationToken)
    {
        var gridstation = _mapper.Map<GridStation>(request.gridstation);
        var result = await _dataAccess.AddGridStation(gridstation);
        await _dataAccess.SaveChangesAsync();
        return _mapper.Map<GridStationExportDto>(result);
    }
}