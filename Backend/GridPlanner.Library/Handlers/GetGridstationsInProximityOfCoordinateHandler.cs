using AutoMapper;
using GridPlanner.Library.DataAccess;
using GridPlanner.Library.Extensions;
using GridPlanner.Library.Models.Entities;
using GridPlanner.Library.Models.Export;
using GridPlanner.Library.Queries.Read;
using MediatR;

namespace GridPlanner.Library.Handlers;

public class GetGridstationsInProximityOfCoordinateHandler : IRequestHandler<GetGridstationsInProximityOfCoordinateQuery, List<GridStationExportDto>>
{
    private readonly IDataAccess _dataAccess;
    private readonly IMapper _mapper;

    public GetGridstationsInProximityOfCoordinateHandler(IDataAccess dataAccess, IMapper mapper)
    {
        _dataAccess = dataAccess;
        _mapper = mapper;
    }
    public async Task<List<GridStationExportDto>> Handle(GetGridstationsInProximityOfCoordinateQuery request, CancellationToken cancellationToken)
    {
        var gridStations =
            await _dataAccess.GetAllGridstations();

        var gridstationsInProximity = request.coordinate.GetAllGridstationsInProximityOfCoordinate(request.radiusInKm,gridStations);
        var result = _mapper.Map<List<GridStationExportDto>>(gridstationsInProximity);

        return result;
        
    }

    

}