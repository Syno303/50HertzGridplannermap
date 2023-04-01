using AutoMapper;
using GridPlanner.Library.DataAccess;
using GridPlanner.Library.Models.Export;
using GridPlanner.Library.Queries;
using GridPlanner.Library.Queries.Read;
using MediatR;

namespace GridPlanner.Library.Handlers;

public class GetGridstationByIdHandler : IRequestHandler<GetGridstationByIdQuery, GridStationExportDto>
{
    private readonly IDataAccess _dataAccess;
    private readonly IMapper _mapper;

    public GetGridstationByIdHandler(IDataAccess dataAccess, IMapper mapper)
    {
        _dataAccess = dataAccess;
        _mapper = mapper;
    }
    public async Task<GridStationExportDto> Handle(GetGridstationByIdQuery request, CancellationToken cancellationToken)
    {
        var gridStation = await _dataAccess.GetGridstationById(request.id);
        return _mapper.Map<GridStationExportDto>(gridStation);
    }
}