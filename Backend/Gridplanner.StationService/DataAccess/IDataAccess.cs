﻿using GridPlanner.Library.Models.Entities;

namespace Gridplanner.StationService.DataAccess;

public interface IDataAccess
{
    Task<List<GridStation>> GetAllGridstations();
    Task<GridStation?> GetGridstationById(int id);
    Task<GridStation> AddGridStation(GridStation gridstation);
    Task SaveChangesAsync();
    Task<GridStation?> UpdateGridstation(GridStation gridstation);
}