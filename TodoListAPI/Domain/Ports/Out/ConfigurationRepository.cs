namespace TodoListAPI.Domain.Ports.Out;

public interface ConfigurationRepository
{
    Task<String> GetSettingAsync(String key);
    Task UpdateSettingAsync(String key, string value);
}