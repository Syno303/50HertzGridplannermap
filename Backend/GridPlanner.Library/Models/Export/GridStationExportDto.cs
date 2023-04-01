namespace GridPlanner.Library.Models.Export;

public class GridStationExportDto
{
    public int Id { get; set; }
    public string StationName { get; set; }
    public CoordinateExportDto Coordinate { get; set; } = new CoordinateExportDto();
    public ContactExportDto Contact { get; set; } = new ContactExportDto();
    public bool Status { get; set; }
    public string Kilovoltage { get; set; }
}