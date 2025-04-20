using TodoListAPI.Domain.Ports.In;
using TodoListAPI.Domain.Ports.Out;
using TodoListAPI.Entities;

namespace TodoListAPI.Domain.Services;

public class TaskServiceImpl:TaskService
{
    private readonly TaskRepository _taskRepository;

    public TaskServiceImpl(TaskRepository taskRepository)
    {
        _taskRepository = taskRepository;
    }

    public async Task<TaskItem> CreateTaskAsync(string title, string description, Priority priority, DateTime? dueTime=null)
    {
        var newTask = new TaskItem(title, description, priority, DateTime.Now, DateTime.Now);
        if(dueTime!=null)
            newTask.setDueDate(dueTime);
        await _taskRepository.CreateAsync(newTask);
        return newTask;
    }

    public async Task<TaskItem> GetByIdAsync(int id)
    {
        return await _taskRepository.GetByIdAsync(id);
    }

    public Task<IEnumerable<TaskItem>> GetAllAsync()
    {
        return _taskRepository.GetAllAsync();
    }

    public async Task UpdateAsync(int id, string? title, string? description, Priority? priority, DateTime? updatedAt=null)
    {
        var task = await _taskRepository.GetByIdAsync(id);
        if (task == null)
            throw new Exception("Task not found");
        task.UpdateDetails(
            title?? task.Title,
            description?? task.Description,
            priority?? task.Priority,
            updatedAt
        );
        
        await _taskRepository.UpdateAsync(task);
    }

    public async Task DeleteAsync(int id)
    {
        await _taskRepository.DeleteAsync(id);
    }
}