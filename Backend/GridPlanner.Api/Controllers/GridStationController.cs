// using GridPlanner.Backend.Models;
// using GridPlanner.Library.Commands;
// using GridPlanner.Library.Models.Entities;
// using GridPlanner.Library.Models.Export;
// using GridPlanner.Library.Models.Import;
// using GridPlanner.Library.Queries.Read;
// using MediatR;
// using Microsoft.AspNetCore.Mvc;
//
// namespace GridPlanner.Backend.Controllers;
//
// [ApiController]
// [Route("api/[controller]")]
// public class GridStationController : AbstractMediatrControllerBase
// {
//     private readonly ILogger<GridStationController> _logger;
//
//     public GridStationController(ILogger<GridStationController> logger, IMediator mediator) : base(mediator)
//     {
//         _logger = logger;
//     }
//
//     [HttpGet]
//     [ProducesResponseType(typeof(IEnumerable<GridStationExportDto>), StatusCodes.Status200OK)]
//     public async Task<IEnumerable<GridStationExportDto>> GetAll()
//     {
//         return await Mediator.Send(new GetGridstationListQuery());
//     }
//
//     [HttpGet]
//     [Route("{id}")]
//     [ProducesResponseType(typeof(GridStationExportDto), StatusCodes.Status200OK)]
//     public async Task<GridStationExportDto> GetById(int id)
//     {
//         return await Mediator.Send(new GetGridstationByIdQuery(id));
//     }
//
//     [HttpPut]
//     [Route("{id}")]
//     [ProducesResponseType(typeof(GridStationExportDto), StatusCodes.Status200OK)]
//     public async Task<GridStationExportDto> UpdateGridStation(int id, GridStationImportDto gridstation)
//     {
//         return await Mediator.Send(new UpdateGridStationCommand(id, gridstation));
//     }
//
//     [HttpPost]
//     [ProducesResponseType(typeof(IEnumerable<GridStationExportDto>), StatusCodes.Status200OK)]
//     [Route("proximity/{radiusInKm}")]
//     public async Task<List<GridStationExportDto>> GetGridstationsInProximityOfCoordinate(Coordinate coordinate,
//         int radiusInKm)
//     {
//         return await Mediator.Send(new GetGridstationsInProximityOfCoordinateQuery(coordinate, radiusInKm));
//     }
//
//     [HttpPost]
//     [ProducesResponseType(typeof(GridStationExportDto), StatusCodes.Status200OK)]
//     public async Task<GridStationExportDto> AddGridStation(GridStationImportDto gridStation)
//     {
//         return await Mediator.Send(new AddGridStationCommand(gridStation));
//     }
// }