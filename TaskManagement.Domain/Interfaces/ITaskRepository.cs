namespace TaskManagement.Domain.Interfaces;

public interface ITaskRepository
{
    Task<IEnumerable<TaskEntity>> GetAllAsync();
    
    Task<TaskEntity?> GetByIdAsync(Guid id);
    
    Task<TaskEntity> AddAsync(TaskEntity task);
    
    Task UpdateAsync(TaskEntity task);
    
    Task DeleteAsync(Guid id);
}