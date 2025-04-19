using TodoList.Entities;

namespace TodoList.Domain.Ports.Out;

public interface TaskListRepository
{
    Task<TaskList?> GetByIdAsync(int id);
    Task<IEnumerable<TaskList>> GetAllAsync();
    Task<int> CreateAsync(TaskList taskList);
    Task UpdateAsync(TaskList taskList);
    Task DeleteAsync(int id);
}