using BioReactorApi.Models;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

var readings = new List<ReactorReading>();
var nextId = 1;

app.MapGet("/api/readings", () =>
{
    return Results.Ok(readings);
});

app.MapGet("/api/readings/{id}", (int id) =>
{
   var reading = readings.FirstOrDefault(reading => reading.Id == id);

      if (reading is null)
      {
          return Results.NotFound();
      }

      return Results.Ok(reading);
});

app.MapPost("/api/readings", (ReactorReading reading) =>
{
     reading.Id = nextId++;
      reading.RecordedAt = reading.RecordedAt == default
          ? DateTime.UtcNow
          : reading.RecordedAt;

      readings.Add(reading);
      Console.WriteLine($"Added reading: Id={reading.Id}, ReactorId={reading.ReactorId}, Temp={reading.Temperature}");
      return Results.Created($"/api/readings/{reading.Id}", reading);
});

  app.MapDelete("/api/readings/{id}", (int id) =>
  {
      var reading = readings.FirstOrDefault(reading => reading.Id == id);

      if (reading is null)
      {
          return Results.NotFound();
      }

      readings.Remove(reading);

      return Results.NoContent();
  });

app.Run();

