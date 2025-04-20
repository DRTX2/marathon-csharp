namespace TodoListAPI.Models;

public class TaskList
{
    public int ListId { get; private set; }
    private static int CurId=1;
    public String Title { get; private set; }
    public List<Task> Tasks { get; private set; }

    public Priority Priority { get; private set; }

    public TaskList(String title, List<Task> tasks, Priority priority)
    {
        ListId = TaskList.CurId++;
        Title = title;
        Tasks = tasks;
        Priority = priority;
    }
}