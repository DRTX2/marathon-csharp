using TodoList.Application.Dtos;
using TodoList.Entities;

namespace TodoList.Domain.Ports.In;

public interface TaskService
{
    Task<TaskItem> CreateTaskAsync(string title, string description, Priority priority, DateTime? dueTime=null);
    Task<TaskItem> GetByIdAsync(int id);
    Task<IEnumerable<TaskItem>> GetAllAsync();
    Task UpdateAsync(int id, string? title, string? description, Priority? priority, DateTime? dueTime=null);
    Task DeleteAsync(int id);
}