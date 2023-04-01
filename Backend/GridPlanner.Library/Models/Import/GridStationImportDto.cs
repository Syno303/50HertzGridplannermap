namespace GridPlanner.Library.Models.Import;

public class GridStationImportDto
{
    public string StationName { get; set; }
    public int Id { get; set; }
    public CoordinateImportDto Coordinate { get; set; } = new CoordinateImportDto();
    public ContactImportDto Contact { get; set; } = new ContactImportDto();
    public bool Status { get; set; }
    public int Kilovoltage { get; set; }
}