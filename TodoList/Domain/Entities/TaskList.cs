namespace TodoList.Entities;

public class TaskList
{
    public int ListId { get; private set; }
    private static int CurId=1;
    public String Title { get; private set; }
    public List<TaskItem> Tasks { get; private set; }

    public Priority Priority { get; private set; }

    public TaskList(String title, List<TaskItem> tasks, Priority priority)
    {
        ListId = TaskList.CurId++;
        Title = title;
        Tasks = tasks;
        Priority = priority;
    }
}