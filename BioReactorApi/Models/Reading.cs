namespace BioReactorApi.Models;

public class Reading
{
    public int Id { get; set; }
    public int RunId { get; set; }
    public int SensorId { get; set; }
    public double Value { get; set; }
    public string Quality { get; set; } = "Good";
    public DateTimeOffset RecordedAt { get; set; } = DateTimeOffset.UtcNow;

    public Run? Run { get; set; }
    public Sensor? Sensor { get; set; }
}
