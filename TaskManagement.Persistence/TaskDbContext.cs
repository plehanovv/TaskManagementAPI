using Microsoft.EntityFrameworkCore;
using TaskManagement.Domain;

namespace TaskManagement.Persistence;

public class TaskDbContext : DbContext
{
    public TaskDbContext(DbContextOptions<TaskDbContext> options) : base(options) { }

    public DbSet<TaskEntity> Tasks { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlite("Data Source=taskdb.sqlite", 
                options => options.MigrationsAssembly("TaskManagement.Infrastructure"));
        }
    }
}
