using System.ComponentModel.DataAnnotations;
using TodoList.Models;

namespace TodoList.Application.Dtos;


public class TaskUpdateRequest
{
    [StringLength(50)] 
    public string Title { get; set; }
    
    [StringLength(100)]
    public String Description { get; set; }

    public Priority priority { get; set; }  
    
    [FutureDate(ErrorMessage = "Due date must be in the future")]
    public DateTime? DueDate { get; set; } 
    public bool? IsCompleted { get; set; }
}