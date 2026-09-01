using BioReactorApi.Models;
using Microsoft.EntityFrameworkCore;

namespace BioReactorApi.Infrastructure.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<Instrument> Instruments => Set<Instrument>();
    public DbSet<Run> Runs => Set<Run>();
    public DbSet<Sensor> Sensors => Set<Sensor>();
    public DbSet<Reading> Readings => Set<Reading>();
}
