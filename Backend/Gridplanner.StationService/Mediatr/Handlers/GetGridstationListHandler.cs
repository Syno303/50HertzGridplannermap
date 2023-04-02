using AutoMapper;
using GridPlanner.Library.Models.Export;
using Gridplanner.StationService.DataAccess;
using Gridplanner.StationService.Mediatr.Queries;
using MediatR;

namespace Gridplanner.StationService.Mediatr.Handlers;

public class GetGridstationListHandler : IRequestHandler<GetGridstationListQuery, List<GridStationExportDto>>
{
    private readonly IDataAccess _dataAccess;
    private readonly IMapper _mapper;

    public GetGridstationListHandler(IDataAccess dataAccess, IMapper mapper)
    {
        _dataAccess = dataAccess;
        _mapper = mapper;
    }
    public async Task<List<GridStationExportDto>> Handle(GetGridstationListQuery request, CancellationToken cancellationToken)
    {
        var gridstations = await _dataAccess.GetAllGridstations();
        return _mapper.Map<List<GridStationExportDto>>(gridstations);
    }
}