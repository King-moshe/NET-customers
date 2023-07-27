// YourDbContext.cs
using Microsoft.EntityFrameworkCore;

public class YourDbContext : DbContext
{
    public YourDbContext(DbContextOptions options) : base(options)
    {
    }

    // DbSet property for your entities (ensure it's named 'Clients')
    public DbSet<Client> Clients { get; set; }
}
