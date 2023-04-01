using GridPlanner.Library.Models.Entities;

namespace GridPlanner.Library.DataAccess;

public interface IDataAccess
{
    Task<List<GridStation>> GetAllGridstations();
    Task<GridStation?> GetGridstationById(int id);
    Task<GridStation> AddGridStation(GridStation gridstation);
    Task SaveChangesAsync();
    Task<GridStation?> UpdateGridstation(GridStation gridstation);
}