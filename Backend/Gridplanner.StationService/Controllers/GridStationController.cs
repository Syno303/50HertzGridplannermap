using GridPlanner.Library.Models.Entities;
using GridPlanner.Library.Models.Export;
using GridPlanner.Library.Models.Import;
using Gridplanner.StationService.Mediatr.Commands;
using Gridplanner.StationService.Mediatr.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Gridplanner.StationService.Controllers;

[ApiController]
[Route("api/[controller]")]
public class GridStationController : ControllerBase
{
    private readonly IMediator _mediator;

    public GridStationController( IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    [ProducesResponseType(typeof(IEnumerable<GridStationExportDto>), StatusCodes.Status200OK)]
    public async Task<IEnumerable<GridStationExportDto>> GetAll()
    {
        return await _mediator.Send(new GetGridstationListQuery());
    }

    [HttpGet]
    [Route("{id}")]
    [ProducesResponseType(typeof(GridStationExportDto), StatusCodes.Status200OK)]
    public async Task<GridStationExportDto> GetById(int id)
    {
        return await _mediator.Send(new GetGridstationByIdQuery(id));
    }

    [HttpPut]
    [Route("{id}")]
    [ProducesResponseType(typeof(GridStationExportDto), StatusCodes.Status200OK)]
    public async Task<GridStationExportDto> UpdateGridStation(int id, GridStationImportDto gridstation)
    {
        return await _mediator.Send(new UpdateGridStationCommand(id, gridstation));
    }

    [HttpPost]
    [ProducesResponseType(typeof(IEnumerable<GridStationExportDto>), StatusCodes.Status200OK)]
    [Route("proximity/{radiusInKm}")]
    public async Task<List<GridStationExportDto>> GetGridstationsInProximityOfCoordinate(Coordinate coordinate,
        int radiusInKm)
    {
        return await _mediator.Send(new GetGridstationsInProximityOfCoordinateQuery(coordinate, radiusInKm));
    }

    [HttpPost]
    [ProducesResponseType(typeof(GridStationExportDto), StatusCodes.Status200OK)]
    public async Task<GridStationExportDto> AddGridStation(GridStationImportDto gridStation)
    {
        return await _mediator.Send(new AddGridStationCommand(gridStation));
    }
}