using System.ComponentModel.DataAnnotations;
using TodoListAPI.Entities;


namespace TodoListAPI.Application.Dtos;

public class TaskCreationRequest
{
    [Required] 
    [StringLength(50)] 
    public string Title { get; set; }
    
    [StringLength(100)]
    public String Description { get; set; }

    public Entities.Priority Priority { get; set; } = Priority.MEDIUM;
    
    [FutureDate(ErrorMessage = "Due date must be in the future")]
    public DateTime? DueDate { get; set; } 
    // public int? ListId { get; set; }
}