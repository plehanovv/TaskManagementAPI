using Microsoft.AspNetCore.Mvc;
using TaskManagement.Domain.Interfaces;

namespace TaskManagementAPI.Controllers;

[ApiController]
[Route("api/tasks")]
public class TaskController : ControllerBase
{
    private readonly ITaskRepository _repository;

    public TaskController(ITaskRepository repository)
    {
        _repository = repository;
    }

    [HttpGet]
    public async Task<IActionResult> GetAllAsync()
    {
        return Ok(await _repository.GetAllAsync());
    }
}