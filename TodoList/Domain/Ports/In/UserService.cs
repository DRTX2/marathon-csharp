using TodoList.Models;
using Task = System.Threading.Tasks.Task;

namespace TodoList.Domain.Ports.In;

public interface UserService
{
    User fetchOne(int id);
    void Create(User user);
    void Update(int id, User user);
    
    void Delete(int id);   
}