namespace TodoList.Models;

public class Task
{
    public int ItemId { get; }
    private static int CurId=1;
    public String Title { get; private set; }
    public String Description { get; private set; }
    public Priority Priority { get; private set; }

    public Task(String title, String description, Priority priority)
    {
        ItemId = Task.CurId++;
        Title = title;
        Description = description;
        Priority = priority;
    }
    
    
}