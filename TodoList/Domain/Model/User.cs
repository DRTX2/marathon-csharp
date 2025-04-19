namespace TodoList.Models;

public class User(int id, String name, String lastname)
{
    public int Id { get; private set; }
    public String Name { get; private set; }
    public String LastName { get; private set; }
}