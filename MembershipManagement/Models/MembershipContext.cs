using Microsoft.EntityFrameworkCore;

namespace MembershipApi.Models;

public class MembershipContext : DbContext
{
    public MembershipContext(DbContextOptions<MembershipContext> options)
        : base(options)
    {
    }

    public DbSet<Membership> Memberships { get; set; } = null!;
}