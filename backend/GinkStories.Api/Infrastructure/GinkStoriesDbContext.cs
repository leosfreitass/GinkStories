using GinkStories.Api.Entities;
using Microsoft.EntityFrameworkCore;

namespace GinkStories.Api.Infrastructure;

public class GinkStoriesDbContext : DbContext
{
    public DbSet<User> users { get; set; } = default!;
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Host=localhost;Database=ginkstoriesdb;Username=admin;Password=user");
    }
}