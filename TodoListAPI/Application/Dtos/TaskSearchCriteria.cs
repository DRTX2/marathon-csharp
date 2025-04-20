using TodoListAPI.Entities;

namespace TodoListAPI.Application.Dtos;

public class TaskSearchCriteria
{
    public string TitleContains { get; set; }
    public Priority? MinimumPriority { get; set; }
    public bool? IsCompleted { get; set; }
    public DateTime? DueBefore { get; set; }
    public int? ListId { get; set; }
    public int Page { get; set; } = 1;
    public int PageSize { get; set; } = 10;

}