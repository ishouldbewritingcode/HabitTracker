namespace HabitTrackerServer.Models;

public class Completion
{
    public Guid Id { get; set; }
    public DateOnly Date { get; set; }

    public Guid HabitId { get; set; }
    public Habit Habit { get; set; } = null!;
}
