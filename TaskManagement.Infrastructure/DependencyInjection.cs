using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using TaskManagement.Domain.Interfaces;
using TaskManagement.Persistence;
using TaskManagement.Persistence.Repositories;

namespace TaskManagement.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, string connectionString)
    {
        services.AddDbContext<TaskDbContext>(options => options.UseSqlite(connectionString));
        services.AddScoped<ITaskRepository, TaskRepository>();
        
        return services;
    }
}   