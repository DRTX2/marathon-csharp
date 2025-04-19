using TodoList.Entities;

namespace TodoList.Domain.Ports.Out;

public interface TaskRepository
{
    // opearacion asincrona, que retorna un tipo T, si no retorna nada se puede dejar vacio el tipo T, en este caso se dice que puede o no retornar un tipo
    Task<TaskItem?> GetByIdAsync(int id);
    // IEnumerable<T> es una interfaz de colección que permite iterar (foreach) sobre objetos del tipo T.
    Task<IEnumerable<TaskItem> > GetAllAsync();
    Task<IEnumerable<TaskItem>> GetByTaskListAsync(int taskListId);
    Task<int> CreateAsync(TaskItem task);
    Task UpdateAsync(TaskItem item);
    Task DeleteAsync(int id);
}