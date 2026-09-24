namespace HabitTrackerServer.Models;

public class Habit
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public List<Completion> Completions { get; set; } = [];
}
