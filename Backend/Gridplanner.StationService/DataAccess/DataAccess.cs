using GridPlanner.Library.Models.Entities;

namespace Gridplanner.StationService.DataAccess;

public class DataAccess : IDataAccess
{

    private List<GridStation> _gridStations;
    public DataAccess()
    {
        _gridStations = FakeDataStore._gridStations;
    }

    public Task<List<GridStation>> GetAllGridstations()
    {
        return Task.FromResult(_gridStations);
    }
    

    public Task<GridStation?> GetGridstationById(int id)
    {
        return Task.FromResult(_gridStations.FirstOrDefault(g=>g.Id == id));
    }

    public Task<GridStation> AddGridStation(GridStation gridstation)
    {
        _gridStations.Add(gridstation);
        gridstation.Id = _gridStations
                                .Select(x => x.Id)
                                .DefaultIfEmpty(0)
                                .Max() + 1;
        
        return Task.FromResult(gridstation);
    }

    public Task SaveChangesAsync()
    {
        FakeDataStore._gridStations = _gridStations;
        return Task.CompletedTask;
    }

    public Task<GridStation> UpdateGridstation(GridStation gridstation)
    {
        var existingGridstation = _gridStations
            .FirstOrDefault(x => x.Id == gridstation.Id);
        if (existingGridstation != null)
        {
            existingGridstation.Contact.Name = gridstation.Contact.Name;
            existingGridstation.Status = gridstation.Status;
            return Task.FromResult(existingGridstation);
        }

        return Task.FromResult(gridstation);


    }
}
