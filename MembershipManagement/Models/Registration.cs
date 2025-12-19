namespace RegistrationApi.Models;

public enum RegistrationStatus { Registered=1, Confirmed=2, Canceled=3 };

public class Registration
{
    public long Id { get; set; }
    public required string UserId { get; set; }
    public required DateTime RegisteredAt { get; set; }
    public required RegistrationStatus Status { get; set; }
}