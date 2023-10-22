
using Microsoft.EntityFrameworkCore;
using ProjectLibrary.Entities;

namespace ProjectLibrary.Data
{
    public class ProjectLibraryDbContext : DbContext
    {
        public DbSet<Project> Projects => Set<Project>();
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring (optionsBuilder);
            optionsBuilder.UseInMemoryDatabase("ProjectLibraryDb");
        }
    }
    
}
