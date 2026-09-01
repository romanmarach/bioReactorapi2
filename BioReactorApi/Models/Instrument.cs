namespace BioReactorApi.Models;

public class Instrument
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string SerialNumber { get; set; } = string.Empty;
    public string Status { get; set; } = "Idle";
    public DateTimeOffset CreatedAt { get; set; } = DateTimeOffset.UtcNow;

    public List<Sensor> Sensors { get; set; } = [];
    public List<Run> Runs { get; set; } = [];
}
