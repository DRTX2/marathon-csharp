using System.ComponentModel.DataAnnotations;

namespace TodoListAPI.Application.Dtos;

public class FutureDateAttribute: ValidationAttribute
{
    public override bool IsValid(object value)
    {
        if (value is null) return true;
        return ((DateTime)value) > DateTime.Now;
    }
    
}