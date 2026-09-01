namespace BioReactorApi.Models;

public class Run
{
    public int Id { get; set; }
    public int InstrumentId { get; set; }
    public string Name { get; set; } = string.Empty;
    public string State { get; set; } = "Created";
    public DateTimeOffset StartedAt { get; set; } = DateTimeOffset.UtcNow;
    public DateTimeOffset? EndedAt { get; set; }

    public Instrument? Instrument { get; set; }
    public List<Reading> Readings { get; set; } = [];
}
