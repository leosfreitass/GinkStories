using GinkStories.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace GinkStories.Infrastructure.DataAccess;

public class GinkStoriesDbContext : DbContext
{
    public DbSet<User> users { get; set; } = default!;
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Host=db;Database=ginkstoriesdb;Username=admin;Password=user");
    }
}