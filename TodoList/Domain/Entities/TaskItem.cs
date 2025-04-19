namespace TodoList.Entities;

public class TaskItem
{
    public int Id { get; }
    public String Title { get; private set; }
    public String Description { get; private set; }
    public Priority Priority { get; private set; }
    public bool IsComplete { get; private set; }
    public DateTime CreatedAt { get; private set; }
    public DateTime UpdatedAt { get; private set; }
    public DateTime? DueDate { get; private set; }

    public TaskItem(String title, String description, Priority priority)
    {
        Id = 0;
        Title = title;
        Description = description;
        Priority = priority;
    }

    public void ChangeCompleteStatus() => IsComplete = !IsComplete;

    public void UpdateDetails(String title, String description, Priority priority)
    {
        Title = title;
        Description = description;
        Priority = priority;
    }

    public void setDueDate(DateTime? dueDate) => DueDate = dueDate;

}