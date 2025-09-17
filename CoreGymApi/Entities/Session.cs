namespace CoreGymApi.Entities;

public class Session
{
    public Guid Id { get; set; }
    public DateTime StartTime { get; set; }
    public int Duration { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string Trainer { get; set; }
    public string Location { get; set; }
    public int Spots { get; set; }
}
