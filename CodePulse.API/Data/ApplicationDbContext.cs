using CodePulse.API.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace CodePulse.API.Data
{
  public class ApplicationDbContext: DbContext {
    // transfer dbconnection from DbContextOptions to DbContext
    public ApplicationDbContext(DbContextOptions options): base(options) { 
    }

    // Database tables
    public DbSet<BlogPost> BlogPosts { get; set; }
    public DbSet<Category> Categories { get; set; }
  }
}