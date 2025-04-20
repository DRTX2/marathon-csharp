namespace TodoListAPI.Entities;

public class User
{

    public int Id { get; private set; }
    public String Name { get; private set; }
    public String LastName { get; private set; }
    public TaskList Tasks {get; private set; }
    
    public User(int id, String name, String lastname, TaskList tasks)
    {
        Id = id;
        Name = name;
        LastName = lastname;
        Tasks = tasks;
    }
    
}