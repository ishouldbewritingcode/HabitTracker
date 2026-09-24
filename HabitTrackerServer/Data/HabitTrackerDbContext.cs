using HabitTrackerServer.Models;
using Microsoft.EntityFrameworkCore;

namespace HabitTrackerServer.Data;

public class HabitTrackerDbContext(DbContextOptions<HabitTrackerDbContext> options) : DbContext(options)
{
    public DbSet<Habit> Habits => Set<Habit>();
    public DbSet<Completion> Completions => Set<Completion>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Habit>()
            .HasMany(h => h.Completions)
            .WithOne(c => c.Habit)
            .HasForeignKey(c => c.HabitId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
