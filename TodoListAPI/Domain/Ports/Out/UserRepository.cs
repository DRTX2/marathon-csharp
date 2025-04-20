using TodoListAPI.Entities;

namespace TodoListAPI.Domain.Ports.Out;

public interface UserRepository
{
    Task<User?> GetByIdAsync(int id);
    Task<int> CreateAsync(User user);
    Task UpdateAsync(User user);
    Task DeleteAsync(int id);
}