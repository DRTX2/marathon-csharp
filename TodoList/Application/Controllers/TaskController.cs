using System.Runtime.InteropServices.JavaScript;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TodoList.Application.Dtos;
using TodoList.Domain.Ports.In;
using TodoList.Entities;

namespace TodoList.Application.Controllers;

[ApiController]
[Route("api/[controller]")] // esto hace que la ruta sea /api/tasks, es el nombre del controlador menos el sufijo controller
[Produces("application/json")]
public class TasksController : ControllerBase
{
    private readonly TaskService _taskService;
    private readonly ILogger<TasksController> _logger;

    public TasksController(TaskService taskService, ILogger<TasksController> logger)
    {
        _taskService = taskService ?? throw new ArgumentNullException(nameof(taskService));
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] TaskCreationRequest request)
    // metodo asincrono que devuelve una accion http(status+body). 
    {
        try
        {
            var createdTask = _taskService.CreateTaskAsync(
                request.Title,
                request.Description,
                request.Priority,
                request.DueDate
            );
            // CreatedAtAction(...)
            // Es un método de ASP.NET Core que genera una respuesta 201 Created apuntando a un endpoint existente.
            return CreatedAtAction(
                // Esto se convierte en "GetById" en tiempo de compilación. Es una manera segura de referenciar el método del controlador llamado GetById (para evitar errores por escribir strings manualmente).
                    nameof(GetById), 
                // Es un objeto anónimo con los parámetros que se necesitan para resolver la ruta del método GetById, en este caso el id.
                    new {id=createdTask.Id},
                // Este es el cuerpo de la respuesta.
                    createdTask
                );
        }
        catch (Exception ex)
        {
                _logger.LogError(ex,"Error creating task");
                return BadRequest(new { Error = ex.Message });
        }
    }

    [HttpGet]
    public async Task<IActionResult> GetById(int id)
    {
        try
        {

            var task = await _taskService.GetByIdAsync(id);
            if (task == null)
                return NotFound();
            return Ok(task);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex,$"Error getting task with ID {id}");
            return StatusCode(500, new { Error = ex.Message });
        }

    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<TaskItem>>> GetAll()
    {
        try
        {

            var tasks = await _taskService.GetAllAsync();
            return Ok(tasks);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, $"Error getting all tasks" );
            return StatusCode(500, new { Error = "Internal Server Error"});
        }
    }

    [HttpPut("{id}")]
    public async Task<ActionResult> Update(int id, [FromBody] TaskUpdateRequest request)
    {
        try
        {

            await _taskService.UpdateAsync(
                id,
                request.Title,
                request.Description,
                request.Priority,
                request.DueDate
            );
            return NoContent();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex,$"Error updating task with id {id}");
            return StatusCode(500, new { Error = ex.Message });
        }
        
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> delete(int id)
    {
        try
        {

            await _taskService.DeleteAsync(id);
            return NoContent();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, $"Error trying to delete task with ID {id}");
            return StatusCode(500, new {Error="Internal Server Error"});
        }
    }

}