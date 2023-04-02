using AutoMapper;
using GridPlanner.Library.Extensions;
using GridPlanner.Library.Models.Export;
using Gridplanner.StationService.DataAccess;
using Gridplanner.StationService.Mediatr.Queries;
using MediatR;

namespace Gridplanner.StationService.Mediatr.Handlers;

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