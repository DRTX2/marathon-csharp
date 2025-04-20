using TodoListAPI.Entities;
using Task = System.Threading.Tasks.Task;

namespace TodoListAPI.Domain.Ports.In;

public interface UserService
{
    User fetchOne(int id);
    void Create(User user);
    void Update(int id, User user);
    
    void Delete(int id);   
}