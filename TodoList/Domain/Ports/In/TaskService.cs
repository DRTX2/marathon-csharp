using TodoList.Entities;

namespace TodoList.Domain.Ports.In;

public interface TaskService
{
    Task<TaskItem> CreateTaskAsync(T)
}