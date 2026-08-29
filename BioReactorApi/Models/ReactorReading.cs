 namespace BioReactorApi.Models;
 
 public class ReactorReading
  {
      public int Id { get; set; }
      public string ReactorId { get; set; }
      public double Temperature { get; set; }
      public double Ph { get; set; }
      public double DissolvedOxygen { get; set; }
      public int Rpm { get; set; }
      public DateTime RecordedAt { get; set; }
  }