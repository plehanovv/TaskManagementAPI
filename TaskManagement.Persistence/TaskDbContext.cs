using Microsoft.EntityFrameworkCore;
using TaskManagement.Domain;

namespace TaskManagement.Persistence;

public class TaskDbContext : DbContext
{
    public TaskDbContext(DbContextOptions<TaskDbContext> options) : base(options) { }
    
    public DbSet<TaskEntity> Tasks { get; set; }
}