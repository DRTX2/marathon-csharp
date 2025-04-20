namespace TodoListAPI.Entities;

public class TaskItem
{
    public int Id { get; }
    public string Title { get; private set; }
    public string Description { get; private set; }
    public Priority Priority { get; private set; }
    public bool IsComplete { get; private set; }
    public DateTime CreatedAt { get; private set; }
    public DateTime UpdatedAt { get; private set; }
    public DateTime? DueDate { get; private set; }

    public TaskItem(string title, string description, Priority priority, DateTime createdAt, DateTime updatedAt)
    {
        Id = 0; // asumes que el repositorio lo asigna
        Title = title;
        Description = description;
        Priority = priority;
        CreatedAt = createdAt;
        UpdatedAt = updatedAt;
        IsComplete = false;
    }

    public void ChangeCompleteStatus() => IsComplete = !IsComplete;

    public void UpdateDetails(String title, String description, Priority priority, DateTime? dueTime,DateTime? updatedAt=null)
    {
        Title = title;
        Description = description;
        Priority = priority;
        UpdatedAt = updatedAt ?? DateTime.Now;
        DueDate = dueTime ?? DueDate;
    }

    public void setDueDate(DateTime? dueDate) => DueDate = dueDate;

}