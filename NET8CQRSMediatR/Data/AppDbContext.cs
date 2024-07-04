using Microsoft.EntityFrameworkCore;
using NET8CQRSMediatR.Models;

namespace NET8CQRSMediatR.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<Actor> Actors { get; set; }

}
