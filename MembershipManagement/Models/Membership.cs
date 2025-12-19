namespace MembershipApi.Models;

public enum MembershipType { Basic=1, Pro=2 };
public enum MembershipStatus { Ective=1, Expired=2 };

public class Membership
{
    public long Id { get; set; }
    public long UserId { get; set; }
    public required MembershipType Type { get; set; }
    public required DateTime StartDate { get; set; }
    public required DateTime EndDate { get; set; }
    public required MembershipStatus Status { get; set; }
}