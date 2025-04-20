using TodoListAPI.Entities;

namespace TodoListAPI.Domain.Ports.In;

public interface TaskListService
{
    TaskList FetchOne(int id);
    List<TaskList> FetchAll();
    void Create(TaskList taskList);
    void Update(int id, TaskList taskList);
    void Delete(int id);
}