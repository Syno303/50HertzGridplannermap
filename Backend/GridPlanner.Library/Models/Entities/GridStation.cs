using System.ComponentModel.DataAnnotations;

namespace GridPlanner.Library.Models.Entities;

public class GridStation
{
    [Key] public int Id { get; set; }
    [Required] public string StationName { get; set; }
    public Coordinate Coordinate { get; set; } = new Coordinate();
    public Contact Contact { get; set; } = new Contact();

    public bool Status { get; set; }

    public int Kilovoltage { get; set; }
}