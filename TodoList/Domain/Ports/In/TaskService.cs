namespace TodoList.Domain.Ports.In;

public interface TaskService
{
    Task fetchOne(int id);
    void Create(int taskList,Task task);
    void Update(int id, Task task);
    
    void Delete(int id);
}