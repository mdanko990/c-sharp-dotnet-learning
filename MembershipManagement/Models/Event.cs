namespace EventApi.Models;

public class Event
{
    public long Id { get; set; }
    public required string Title { get; set; }
    public string? Description { get; set; }
    public DateTime? EventDate { get; set; }
    public int? Capacity { get; set; }
}