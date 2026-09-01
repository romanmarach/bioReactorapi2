namespace BioReactorApi.Models;

public class Sensor
{
    public int Id { get; set; }
    public int InstrumentId { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Type { get; set; } = string.Empty;
    public string Unit { get; set; } = string.Empty;
    public double MinimumValue { get; set; }
    public double MaximumValue { get; set; }

    public Instrument? Instrument { get; set; }
    public List<Reading> Readings { get; set; } = [];
}
