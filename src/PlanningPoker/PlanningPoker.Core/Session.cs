namespace PlanningPoker.Core;

public class Session
{
    public Guid Id { get; set; } = Guid.NewGuid();

    public List<Participant> Participants { get; set; } = new();
    
    public List<Story> Stories { get; set; } = new();
    
    public event EventHandler? SessionUpdated;
}