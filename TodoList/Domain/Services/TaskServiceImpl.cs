using TodoList.Domain.Ports.In;
using TodoList.Domain.Ports.Out;

namespace TodoList.Domain.Services;

public class TaskServiceImpl:TaskService
{
    private readonly TaskRepository _taskRepository;

    public TaskServiceImpl(TaskRepository taskRepository)
    {
        _taskRepository = taskRepository;
    }

    public Task fetchOne(int id)
    {
        return _taskRepository.GetByIdAsync(id);
    }

    public void Create(int taskList, Task task)
    {
        throw new NotImplementedException();
    }

    public void Update(int id, Task task)
    {
        throw new NotImplementedException();
    }

    public void Delete(int id)
    {
        throw new NotImplementedException();
    }
}