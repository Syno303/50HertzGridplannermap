using AutoMapper;
using GridPlanner.Library.DataAccess;
using GridPlanner.Library.Models.Export;
using GridPlanner.Library.Queries;
using GridPlanner.Library.Queries.Read;
using MediatR;

namespace GridPlanner.Library.Handlers;

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